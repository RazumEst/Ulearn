using System;
using System.Text.RegularExpressions;

namespace Метод_возвращает_половину_строки
{
    internal class Program
    {
        static string GetLastHalf (string text)
        {
           string textb = text.Remove(0, text.Length / 2);
           string space = " ";
           return Regex.Replace(textb, space, string.Empty);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(GetLastHalf("I love CSharp!"));
            Console.WriteLine(GetLastHalf("1234567890"));
            Console.WriteLine(GetLastHalf("до ре ми фа соль ля си"));
        }
    }
}
