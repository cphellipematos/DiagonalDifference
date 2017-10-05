using System;

namespace DiagonalDifferenceChallenge
{
    class Program
    {
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[][] a = new int[n][];
            for (int a_i = 0; a_i < n; a_i++)
            {
                string[] a_temp = Console.ReadLine().Split(' ');
                a[a_i] = Array.ConvertAll(a_temp, Int32.Parse);
            }

            Console.Write(GetData(a, n));
            Console.ReadLine();
        }

        static int GetData(int[][] a, int n)
        {
            int sumA = 0;
            int sumB = 0;
            int dif = 0;

            int j = n - 1;
            for (int i = 0; i < n; i++)
            {
                sumA += a[i][i];
                sumB += a[i][j];
                j--;
            }

            if (sumA >= sumB)
            {
                dif = sumA - sumB;
                return dif;
            }

            dif = sumB - sumA;

            return dif;
        }
    }
}
