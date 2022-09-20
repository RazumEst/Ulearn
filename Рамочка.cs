using System;

namespace Рамочка
{
    internal class Program
    {
        //Напишите функцию, которая принимает на вход строку текста
        //и печатает ее на экран в рамочке из символов +, - и |.
        //Для красоты текст должен отделяться от рамки слева и справа пробелом.
        //Например, текст Hello world должен выводиться так:

        //+-------------+
        //| Hello world |
        //+-------------+

        //Разбейте код на три части — верх рамки, середина и низ рамки

        //Верх и низ рамки одинаковый, можно один раз сформировать строку
        //и вывести ее дважды — в начале и в конце
        private static void WriteTextWithBorder(string text)
        {
            int index = text.Length;

            Console.Write("+-");
            for (int i = 0; i < index; i++)
            {
                Console.Write("-"); 
            }
            Console.Write("-+");
            Console.WriteLine();
            Console.WriteLine($"| {text} |");
            
            Console.Write("+-");
            for (int i = 0; i < index; i++)
            {
                Console.Write("-");
            }
            Console.Write("-+");
            Console.WriteLine();


        }
        static void Main(string[] args)
        {
            WriteTextWithBorder("Menu:");
            WriteTextWithBorder("");
            WriteTextWithBorder(" ");
            WriteTextWithBorder("Game Over!");
            WriteTextWithBorder("Select level:");
        }
    }
}
