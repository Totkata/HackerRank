using System;

namespace MinSwaps
{
    class Program
    {
        static int minimumSwaps(int[] arr)
        {
            int swaps = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (i + 1 != arr[i])
                {
                    int t = i;
                    while (arr[t] != i + 1)
                    {
                        t++;
                    }
                    int temp = arr[t];
                    arr[t] = arr[i];
                    arr[i] = temp;
                    swaps++;
                }
            }

            return swaps;
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            int res = minimumSwaps(arr);

            Console.WriteLine(res);
        }
    }
}
