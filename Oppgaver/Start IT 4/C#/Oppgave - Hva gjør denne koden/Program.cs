using System;

namespace Oppgave___Hva_gjør_denne_koden
{
    class Program
    {
        private static void Main(string[] args)
        {
            const int range = 250;
            ReadTextAndShowCharCounts(range);
        }

        private static void ReadTextAndShowCharCounts(int range)
        {
            string text = "something";
            while (!string.IsNullOrWhiteSpace(text))
            {
                text = Console.ReadLine();
                var counts = CountChars(text, range);
                ShowCounts(range, counts);
            }
        }

        private static void ShowCounts(int range, int[] counts)
        {
            for (var i = 0; i < range; i++)
            {
                if (counts[i] == 0) continue;
                var character = (char) i;
                Console.WriteLine("\"" + character + "\" - " + counts[i]);
            }
        }

        private static int[] CountChars(string text, int range)
        {
            var counts = new int[range];
            foreach (var character in text)
            {
                counts[(int) character]++;
            }

            return counts; 
        }
    }
}

