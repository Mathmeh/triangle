using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var trianlgle = new List<int[]>();
            int n = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < n + 1; i++)
            {
                int[] array = new int[i + 1];
                string[] str = Console.ReadLine().Split(' ');
                for (i = 0; i < str.Length; i++)
                    array[i] = Convert.ToInt32(str[i]);

                trianlgle.Add(array);
            }

            trianlgle.Reverse();

            for (int i = 1; i < trianlgle.Count; i++)
            {
                for (int j = 0; j < trianlgle[i].Length; j++)

                    trianlgle[i][j] += Math.Max(trianlgle[i - 1][j], trianlgle[i - 1][j + 1]);
            }

            Console.WriteLine(trianlgle[trianlgle.Count - 1][0]);
        }
    }
}