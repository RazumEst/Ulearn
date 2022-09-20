using System;
using System.Linq;

namespace Sum_of_positive_integers
{
    internal class Program
    {
        //найти сумму всех положительных чисел меньше 1000 кратных 3 или 5. 


        static void Main(string[] args)
        {
            //Enumerable.Range - генерирует последовательность целых чисел в заданном диапазоне
            int x;
            int sum = Enumerable.Range(0, 1000).Where(Multiple3Or5()).Sum();
            Console.WriteLine(sum);
        }

        private static Func<int, bool> Multiple3Or5()
        {
            return x => x % 3 == 0 | x % 5 == 0;
        }
    }
}
