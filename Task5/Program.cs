
using System;

class Program
{
    static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    static int[] FindMax(int[,] matrix)
    {
        int[] B = new int[matrix.GetLength(1)];

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int max = matrix[0, j];

            for (int i = 1; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, j] > max)
                {
                    max = matrix[i, j];
                }
            }

            B[j] = max;
        }

        return B;
    }

    static void Main()
    {
        int nomer = 6;
        int n = 5;

        int[,] matrix = new int[n, n];

        Random rnd = new Random(nomer);

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = rnd.Next(-10, 11);
            }
        }

        Console.WriteLine("Kod nomeri: " + nomer);

        Console.WriteLine("\nBastapky matrica:");
        PrintMatrix(matrix);

        int[] B = FindMax(matrix);

        Console.WriteLine("\nBagandardagy en ulken elementter:");

        for (int i = 0; i < B.Length; i++)
        {
            Console.Write(B[i] + "\t");
        }

        Console.WriteLine();
    }
}
