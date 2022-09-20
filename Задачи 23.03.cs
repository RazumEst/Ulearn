using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задачи_23._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Составить программу обмена значениями двух переменных величин.
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());

            //(a, b) = (b, a);

            //Console.WriteLine(a + " " + b);

            //int c = 3;
            //int d = 5;

            //c = c + d;
            //d = d - c;
            //d = -d;
            //c = c - d;
            //Console.WriteLine(c + " " + d);

            int a = int.Parse(Console.ReadLine());//через промежуточную переменную
            int b = int.Parse(Console.ReadLine());
            int c;
            c = a;
            a = b;
            b = c;
           
           
            Console.WriteLine(a + " " + b);

        }
    }
}
