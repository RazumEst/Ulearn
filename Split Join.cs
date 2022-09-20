using System;
using System.Linq;

namespace Split_Join
{
    internal class Program
    {
        public static string ReplaceIncorrectSeparators(string text)
        {
            string[] seps = new string[] { "-", ":", " ", ";", "," };
            string[] array = text.Split(seps, StringSplitOptions.RemoveEmptyEntries);
            return string.Join('\t', array);

        }
        static void Main(string[] args)
        {
            
        }
    }
}
