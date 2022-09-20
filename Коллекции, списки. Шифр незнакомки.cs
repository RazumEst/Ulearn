using System;
using System.Collections.Generic;
using System.Text;
namespace Коллекции__списки._Шифр_незнакомки
{
    internal class Program
    {
        private static string DecodeMessage(string[] lines)
        {
            var list = new List<string>();
            for (int i = lines.Length - 1; i >= 0; i--)
            {
                for (int j = lines[i].Split(' ').Length - 1; j >= 0; j--)
                {
                    string word = lines[i].Split(' ')[j];
                    if (word.Length > 0 && char.IsUpper(word[0]))
                    {
                        list.Add(word);
                    }
                }
            }

            string message = "";
            foreach (var word in list)
            {
                message += word + " ";
            }
            return message;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
