using System;

namespace Ulearn_Задачи_к_семинару_11
{
    internal class Program
    {
        public static bool IsLeapYear(int year)
        {
           return (year % 4 == 0 && year % 100 != 0) || (year % 100 == 0 && year % 400 == 0 );
        }
        //Дано время в часах и минутах. Найти угол от часовой к минутной стрелке на обычных часах.
        static void Main(string[] args)
        {
            Console.WriteLine(IsLeapYear(2014));
            Console.WriteLine(IsLeapYear(1999));
            Console.WriteLine(IsLeapYear(8992));
            Console.WriteLine(IsLeapYear(1));
            Console.WriteLine(IsLeapYear(14));
            Console.WriteLine(IsLeapYear(400));
            Console.WriteLine(IsLeapYear(600));
            Console.WriteLine(IsLeapYear(3200));

            //    var dateTimeNow = new DateTime(2008, 4, 8, 12, 45, 55);
            //    var angleBetweenHourMinute = dateTimeNow.Minute * 6;

            //    Console.WriteLine(angleBetweenHourMinute);
        }
    }
}
