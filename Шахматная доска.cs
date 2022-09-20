using System;

namespace Шахматная_доска
{
    internal class Program
    {
        //переделать этот код так, чтобы он умел выводить доску любого заданного размера.
        //Белая клетка обозначается точкой, черная — шарпом.
        private static void WriteBoard(int size)
        {
            char white = '.';
            char black = '#';
            for (int i = 1; i <= size; i++ )
            {
              
                if (i % 2 == 0)
                {
                   
                    for (int j = 1; j <= size; j++)
                    {
                        if (j % 2 == 0)
                        {
                            Console.Write(black);
                        }
                        else 
                        {
                            Console.Write(white);
                        }
                    }
                    Console.WriteLine();

                }
                else 
                {
                    
                    for (int j = 1; j <= size; j++)
                    {
                        if (j % 2 == 0)
                        {
                            Console.Write(white);
                        }
                        else 
                        {
                            Console.Write(black);
                        }
                    }
                    Console.WriteLine();
                }
            }
            
            Console.WriteLine();
            
        }
        static void Main(string[] args)
        {
            WriteBoard(8);
            WriteBoard(1);
            WriteBoard(2);
            WriteBoard(3);
            WriteBoard(10);
        }
    }
}
