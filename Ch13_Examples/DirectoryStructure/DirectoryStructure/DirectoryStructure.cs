/* DirectoryStructure.cs
   Illustrates using File and Directory utilities.
*/
using System;
using System.IO;

class DirectoryStructure
{
     static void Main(string[] args)
     {


         /*Example 13-1 */
         //string fileName = "BirdOfParadise.jpg";
         //if (File.Exists(fileName))
         //{
         //    Console.WriteLine("FileName: {0}", fileName);
         //    Console.WriteLine("Attributes: {0}", File.GetAttributes(fileName));
         //    Console.WriteLine("Created: {0}", File.GetCreationTime(fileName));
         //    Console.WriteLine("Last Accessed: {0}", File.GetLastAccessTime(fileName));
         //}
         //else
         //{
         //    Console.WriteLine("{0} not found - using current directory:", fileName);
         //}

         /* Example 13-2 */
         DirectoryInfo dir = new DirectoryInfo(".");
         Console.WriteLine("Current Directory: \n{0}\n", Directory.GetCurrentDirectory());
         Console.WriteLine("File Name".PadRight(52) + "Size".PadRight(10) + "Creation Time");
         foreach (FileInfo fil in dir.GetFiles("*.*"))
         {
             string name = fil.Name;
             long size = fil.Length;
             DateTime creationTime = fil.CreationTime;
             Console.WriteLine("{0} {1,12:N0}{2,20:g}", name.PadRight(45), size,
                        creationTime);
         }
         Console.ReadKey();

     }
}
