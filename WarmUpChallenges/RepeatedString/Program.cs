using System;
using System.IO;

namespace RepeatedString
{
    class Program
    {
        static long RepeatedString(string s, long n)
        {
            int count = 0;
            int count1 = 0;
            if (n % s.Length == 0)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == 'a')
                    {
                        count++;
                    }
                }
                return n / s.Length * count;
            }
            else
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == 'a')
                    {
                        count++;
                        if (i < n % s.Length)
                        {
                            count1++;
                        }
                    }
                }
                return (n / s.Length * count) + count1;
            }

        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string s = Console.ReadLine();

            long n = Convert.ToInt64(Console.ReadLine());

            long result = RepeatedString(s, n);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
