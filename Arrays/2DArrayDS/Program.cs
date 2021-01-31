using System;
using System.IO;

namespace _2DArrayDS
{
    class Program
    {
        static int HourglassSum(int[][] arr)
        {

            int result = int.MinValue;

            for (int row = 0; row < 6; row++)
            {
                for (int col = 0; col < 6; col++)
                {
                    if (row + 2 > 5 || col + 2 > 5)
                    {
                        break;
                    }
                    int sum = arr[row][col] + arr[row][col + 1] + arr[row][col + 2] +
                        arr[row + 1][col + 1] +
                        arr[row + 2][col] + arr[row + 2][col + 1] + arr[row + 2][col + 2];
                    if (result < sum)
                    {
                        result = sum;
                    }
                }
            }

            return result;
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int[][] arr = new int[6][];

            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            int result = HourglassSum(arr);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
