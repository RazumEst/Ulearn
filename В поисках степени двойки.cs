using System;

namespace В_поисках_степени_двойки
{
    internal class Program
    {
        private static int GetMinPowerOfTwoLargerThan(int number)
        {
            int result = 1;
            int power = 1;
            while (number >= result)
            {
                power++;
                result = (int)Math.Pow(2,power);

            }


            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(GetMinPowerOfTwoLargerThan(2)); // => 4
            Console.WriteLine(GetMinPowerOfTwoLargerThan(15)); // => 16
            Console.WriteLine(GetMinPowerOfTwoLargerThan(-2)); // => 1
            Console.WriteLine(GetMinPowerOfTwoLargerThan(-100));
            Console.WriteLine(GetMinPowerOfTwoLargerThan(100));
        }
    }
}
