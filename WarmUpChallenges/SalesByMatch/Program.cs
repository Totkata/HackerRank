using System;
using System.Collections.Generic;
using System.IO;

namespace SalesByMatch
{
    class Program
    {
        static int SockMerchant(int n, int[] ar)
        {
            List<int> socks = new List<int>();

            int pairs = 0;

            for (int i = 0; i < ar.Length; i++)
            {
                int sock = ar[i];
                if (!socks.Contains(sock))
                {
                    socks.Add(sock);
                }
                else
                {
                    socks.Remove(sock);
                    pairs++;
                }
            }

            return (pairs);
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
            ;
            int result = SockMerchant(n, ar);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
