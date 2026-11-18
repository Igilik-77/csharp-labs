using System;

class Program
{
    static void Main()
    {
        string text;
        // Бос жол енгізілсе, do-while арқылы қайта сұрау
        do
        {
            Console.WriteLine("Жолды енгізіңіз:");
            text = Console.ReadLine();
            
            if (string.IsNullOrWhiteSpace(text))
            {
                Console.WriteLine("Қате: Жол бос болмауы керек! Қайтадан енгізіңіз.");
            }
        } while (string.IsNullOrWhiteSpace(text));

        Console.WriteLine($"Бастапқы жол: \"{text}\"");

        // Әдісті шақыру
        int wordCount = CountWords(text);
        Console.WriteLine($"Бағдарлама жауабы (сөздер саны): {wordCount}");
    }

    // Split-ті қолданбай, for циклімен символ бойынша санау
    static int CountWords(string text)
    {
        int count = 0;
        bool inWord = false;

        for (int i = 0; i < text.Length; i++)
        {
            char ch = text[i];

            if (ch != ' ' && !inWord)
            {
                inWord = true;
                count++; // Жаңа сөз басталды
            }
            else if (ch == ' ')
            {
                inWord = false; // Бос орын кездессе сөз аяқталды
            }
        }

        return count;
    }
}
