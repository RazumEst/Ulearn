using System;

namespace Ход_ферзя
{
    internal class Program
    {
        public static bool IsCorrectMove(string from, string to)
        {
            var dx = Math.Abs(to[0] - from[0]); //смещение фигуры по горизонтали
            var dy = Math.Abs(to[1] - from[1]); //смещение фигуры по вертикали
            return (((dx == dy) || (dx == 0) || (dy == 0)) && (from != to));
        }
        public static void TestMove(string from, string to)
        {
            Console.WriteLine("{0}-{1} {2}", from, to, IsCorrectMove(from, to));

        }
        static void Main(string[] args)
        {
            TestMove("a1", "d4");
            TestMove("f4", "e7");
            TestMove("a1", "a4");

        }
    }
    
}
