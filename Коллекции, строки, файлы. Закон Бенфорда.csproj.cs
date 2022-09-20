using System;
using System.Collections.Generic;

namespace Коллекции__строки__файлы._Закон_Бенфорда
{
    internal class Program
    {
        public static int[] GetBenfordStatistics(string text)
        {
            var statistics = new int[10];
            var list = new List<int>(); ;
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[0]) || (char.IsDigit(text[i]) && !char.IsDigit(text[i - 1])))
                {
                    list[i] = text[i] - 0;
                    var dictionary = new Dictionary<int, int>();

                    foreach (var e in list)
                    {
                        if (!dictionary.ContainsKey(e)) dictionary[e] = 0;
                        dictionary[e]++;
                    }
                }
            }
            return statistics;
        }

        static void Main(string[] args)
        {
            string tallestBuildings = "Burj Khalifa 830" +
            "Petronius(oil platform) 640" +
            "Tokyo Skytree 634" +
            "KVLY - TV mast 629" +
            "Canton Tower 604";
            PrintNumbers(GetBenfordStatistics("1"));
            PrintNumbers(GetBenfordStatistics("abc"));
            PrintNumbers(GetBenfordStatistics("123 456 789"));
            PrintNumbers(GetBenfordStatistics("abc 123 def 456 gf 789 i"));
            PrintNumbers(GetBenfordStatistics(tallestBuildings));
        }
    }
}
