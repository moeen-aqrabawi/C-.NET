// BinaryFileAccess.cs
// Illustrates retrieving data from a binary file
// Test file name - BinaryInputTestFile.bin (stored in bin\Debug directory)
using System;
using System.IO;    // Added for file access

namespace BinaryFileAccess
{
    class BinaryInput
    {
        static void Main(string[] args)
        {
            FileStream filStream;
            BinaryReader binReader;

            Console.Write("Enter name of the file: ");
            string fileName = Console.ReadLine();
            try
            {
                filStream = new FileStream(fileName, FileMode.Open,
                                            FileAccess.Read);
                binReader = new BinaryReader(filStream);

                RetrieveAndDisplayData(binReader);

                binReader.Close();
                filStream.Close();
            }
            catch (FileNotFoundException exc)
            {
                Console.WriteLine(exc.Message);
            }
            catch (InvalidDataException exc)
            {
                Console.WriteLine(exc.Message);
            }
            catch (EndOfStreamException exc)
            {
                Console.WriteLine(exc.Message);
            }
            catch (IOException exc)
            {
                Console.WriteLine(exc.Message);
            }
            Console.ReadKey();
        }

        public static void RetrieveAndDisplayData(BinaryReader binReader)
        {
            // Read string data from the file
            Console.WriteLine(binReader.ReadString());

            // Read integer data from the file
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine(binReader.ReadInt32());
            }

            // Read decimal data from the file
            Console.WriteLine(binReader.ReadDecimal());
        }
    }
}