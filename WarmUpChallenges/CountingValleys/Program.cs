using System;
using System.IO;

namespace CountingValleys
{
    class Program
    {
        static int CountingValleys(int n, string s)
        {

            int joreny = 0;
            int valleys = 0;
            char[] arr = s.ToCharArray();

            for (int i = 0; i < n; i++)
            {
                if (arr[i] == 'U')
                {
                    joreny++;
                    if (i != 0 && joreny == 0)
                    {
                        valleys++;
                    }
                }
                else
                {
                    joreny--;
                }
            }
            return valleys;
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            string s = Console.ReadLine();

            int result = CountingValleys(n, s);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
