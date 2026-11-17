using System;

class Program
{
    // Matricany ekranga shygaru
    static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    // Ar bagandagy en ulken elementti tabu
    static int[] FindMax(int[,] matrix)
    {
        int[] B = new int[5];

        for (int j = 0; j < 5; j++)
        {
            int max = matrix[0, j];

            for (int i = 1; i < 5; i++)
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

        // 5x5 matrica
        int[,] matrix =
        {
            { 8,  2,  10,  7,  9 },
            { 6,  2,  -1,  5,  0 },
            { 4, -7,   5,  2, -7 },
            { 6, -2,   5,  7,  3 },
            { 2, -4, -10, -8, -4 }
        };

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
