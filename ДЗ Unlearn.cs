using System;

namespace ДЗ_Unlearn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pi = Math.PI;
            int tenThousand = 10000;
            float tenThousandPi = (float)pi * tenThousand;
            int roundedTenThousandPi = (int)Math.Round(tenThousandPi);
            int integerPartOfTenThousandPi = (int)tenThousandPi;
            Console.WriteLine(integerPartOfTenThousandPi);
            Console.WriteLine(roundedTenThousandPi);

            double amount = 1.11; //количество биткоинов от одного человека
            int peopleCount = 60; // количество человек
            int totalMoney = (int)Math.Round(amount * peopleCount); // ← исправьте ошибку в этой строке
            Console.WriteLine(totalMoney);

            double doubleNumber = 894376.243643;
          
            Console.WriteLine(doubleNumber + 1);
        }
    }
}
