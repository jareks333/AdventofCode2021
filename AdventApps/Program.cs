using System;
using System.IO;


namespace AdventApps
{
    class Program
    {
        static void Main(string[] args)
        {

            int iter = 0;

            // Example #2
            // Read each line of the file into a string array. Each element
            // of the array is one line of the file.
            string[] lines = File.ReadAllLines(@"E:\Pobrane\input.txt");

            // Display the file contents by using a foreach loop.
            System.Console.WriteLine("Contents of WriteLines2.txt = " + lines.Length);
            for (int i = 0; i < lines.Length-1; i++)
            {
                int m = Int32.Parse(lines[i]);
                int n = Int32.Parse(lines[i+1]);

                Console.WriteLine(m + "\t" + n);
                if (m<n)
                {
                    iter++;
                }

            }
            Console.WriteLine(iter);

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();

        }
    }
}

//-1


//
