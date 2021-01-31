using System;
using System.Collections.Generic;

namespace LeftRotation
{
    class Program
    {
        static int[] RotLeft(int[] a, int d)
        {
            Queue<int> numbers = new Queue<int>();

            foreach (var num in a)
            {
                numbers.Enqueue(num);
            }

            for (int i = 0; i < d; i++)
            {
                int currNum = numbers.Peek();

                numbers.Dequeue();

                numbers.Enqueue(currNum);
            }

            int[] arr = numbers.ToArray();

            return arr;
        }

        static void Main(string[] args)
        {
            string[] nd = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nd[0]);

            int d = Convert.ToInt32(nd[1]);

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
            ;
            int[] result = RotLeft(a, d);

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
