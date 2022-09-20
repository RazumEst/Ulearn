using System;

namespace Percents
{
    internal class Program
    {
        public static double Calculate(string userInput)
        {
            
            var split = userInput.Split(' ');
            var sum = double.Parse(split[0]);
            var percent = double.Parse(split[1]);
            double percents = (percent / 100)/12;

            var months = double.Parse(split[2]);

            double result = sum * Math.Pow((1.0 + percents), months);
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 3 числа: исходная сумма, % ставка, и срок вклада в месяцах через запятую");
            string userInput = Console.ReadLine();
            
            Console.WriteLine(Calculate(userInput));
            
            
        }
    }
}
