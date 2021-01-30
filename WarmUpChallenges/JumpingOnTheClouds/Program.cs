using System;
using System.IO;

namespace JumpingOnTheClouds
{
    class Program
    {
        static int JumpingOnClouds(int[] c)
        {

            int jumps = 0;

            for (int i = 0; i < c.Length; i++)
            {
                if (i + 1 == c.Length)
                {
                    break;
                }
                if (i + 2 == c.Length)
                {
                    jumps++;
                    break;
                }
                if (c[i + 1] == 0 && c[i + 2] == 0 && i + 1 < c.Length)
                {
                    jumps++;
                    i++;
                }
                else if (c[i + 1] == 0)
                {
                    jumps++;
                }
                else
                {
                    jumps++;
                    i++;
                }
            }
            return jumps;
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
            ;
            int result = JumpingOnClouds(c);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
