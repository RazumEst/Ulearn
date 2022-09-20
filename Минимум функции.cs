using System;

namespace Минимум_функции
{
    internal class Program
    {
        private static string GetMinX(int a, int b, int c)
        {
            string x = "";
            if (a > 0)
            {
             x = Convert.ToString(Convert.ToDouble(-b)/(2*Convert.ToDouble(a)));   
            }
            else if (a <= 0 && b != 0)
                {
                    x = "Impossible";
                }
            return x;
        }
            
            
  
        
        static void Main(string[] args)
        {
            {
                Console.WriteLine(GetMinX(1, 2, 3));
                Console.WriteLine(GetMinX(0, 3, 2));
                Console.WriteLine(GetMinX(1, -2, -3));
                Console.WriteLine(GetMinX(5, 2, 1));
                Console.WriteLine(GetMinX(4, 3, 2));
                Console.WriteLine(GetMinX(0, 4, 5));

                // А в этих случаях решение существует:
                Console.WriteLine(GetMinX(0, 0, 2) != "Impossible");
                Console.WriteLine(GetMinX(0, 0, 0) != "Impossible");
            }
        }
    }
}
