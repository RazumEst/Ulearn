using System;

namespace Карты_Таро._Массивы
{
    internal class Program
    {
        enum Suits
        {
            Wands,
            Coins,
            Cups,
            Swords
        }

        private static string GetSuit(Suits suit)
        {
            //if (suit == Suits.Wands) return "жезлов";
            //else if (suit == Suits.Coins) return "монет";
            //else if (suit == Suits.Cups) return "кубков";
            //else return "мечей";
            //var cards = new[] { "жезлов", "монет", "кубков", "мечей" };
            //var element = cards[(int)suit];
            return new[] { "жезлов", "монет", "кубков", "мечей" }[(int)suit];

        }


        public static void Main()
        {
            Console.WriteLine(GetSuit(Suits.Wands));
            Console.WriteLine(GetSuit(Suits.Coins));
            Console.WriteLine(GetSuit(Suits.Cups));
            Console.WriteLine(GetSuit(Suits.Swords));
        }
    }
}
