
using System;

class Program
{
    // Matindegi sozder sanyn esepteu
    static int CountWords(string text)
    {
        string[] words = text.Split(
            new char[] { ' ', '\t', '\n', '\r' },
            StringSplitOptions.RemoveEmptyEntries
        );

        return words.Length;
    }

    static void Main()
    {
        int nomer = 6;

        Console.WriteLine("6-tapsyrma, 1-nusqa");
        Console.WriteLine("Kod nomeri: " + nomer);

        Console.Write("\nMatindi engiziniz: ");

        string text = Console.ReadLine() ?? "";

        int result = CountWords(text);

        Console.WriteLine("\nBastapky matin: " + text);
        Console.WriteLine("Sozder sany: " + result);
    }
}

