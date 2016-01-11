﻿/*PlayerApp.cs     Author: Doyle
 * Application that instantiates
 * Player class. Creates an array
 * of player objects that can be
 * used to display individual 
 * records or do stats  
 * on the entire team.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerApp
{
    class PlayerApp
    {
        static void Main(string[] args)
        {
            string ln,
                      fn,
                      iden;
            string inValue;

            int playerCnt,
                loopCnt = 0,
                gameCnt;
            int[ ] points = new int[1000];

            Console.Write("How many players? ");
            inValue = Console.ReadLine();
            if (int.TryParse(inValue, out playerCnt) == false)
                Console.WriteLine("Invalid data entered - " +
                                    "0 recorded for number of players."); 
            Player[] teamMember = new Player[playerCnt];
            while (loopCnt < playerCnt)
            {
                GetIdInfo(out ln, out fn, out iden);
                gameCnt = 0;
                points = GetScores(ref gameCnt);
                teamMember[loopCnt] = new Player(ln, fn, iden, points, gameCnt);
                loopCnt++;
            }
            DisplayStats(teamMember);
            Console.ReadKey();
        }

        public static int[ ] GetScores(ref int gameCnt)
        {
            int[ ] points = new int[1000];
            string inValue;

            Console.Write("Game {0}: ((-99 to exit)) ", gameCnt + 1);
            inValue = Console.ReadLine();

            while (inValue != "-99")
            {
                if (int.TryParse(inValue, out points[gameCnt]) == false)
                    Console.WriteLine("Invalid data entered - " +
                                        "0 recorded for points array element");
                ++gameCnt;
                Console.Write("Game {0}: ((-99 to exit)) ", gameCnt + 1);
                inValue = Console.ReadLine();
            }
            return points;
        }

        public static void GetIdInfo(out string ln,
                             out string fn, out string iden)
        {
            Console.WriteLine();
            Console.Write("Player First Name: ");
            fn = Console.ReadLine();
            Console.Write("Player Last Name: ");
            ln = Console.ReadLine();
            Console.Write("Player ID Number: ");
            iden = Console.ReadLine();
        }

        public static void DisplayStats(Player[] teamMember)
        {
            Console.WriteLine();
            Console.WriteLine("{0,12} {1,25}","Player", "Avg Points");
            Console.WriteLine("--------------------------------------");
            foreach (Player pl in teamMember)
            {
                    Console.WriteLine("{0,-25} {1,7}", (pl.FName + " " + pl.LName),
                                      pl.ComputeAverage().ToString("F0"));
            }
        }
    }
}
