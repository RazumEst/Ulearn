using System;

namespace Массивы._Поиска_массива_в_массиве
{
    internal class Program
    {
        //Вернуть минимальный индекс,
        //с которого начинается подмассив в исходном массиве.
        //Например, поиск подмассива "3,4" в массиве "1,2,3,4,3,4" должен вернуть 2.
        public static int FindSubarrayStartIndex(int[] array, int[] subArray)
        {
            for (var i = 0; i < array.Length - subArray.Length + 1; i++)
                if (ContainsAtIndex(array, subArray, i))
                    return i;
            return -1;
        }

        public static bool ContainsAtIndex(int[] array, int[] subArray, int i)
        {
            for (int count = 0; count < subArray.Length; count++)
                if (array[count + i] != subArray[count]) return false;
            return true;
        }

        static void Main(string[] args)
        {
            
        }
    }
}
