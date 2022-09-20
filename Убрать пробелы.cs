using System;

namespace Убрать_пробелы
{
	//Убрать пробелы
	//нужен цикл по символам текста до тех пор пока символы пробельные.
	//все методы работы со строками не меняют исходную строку, а возвращают новую
	//s.Substring(i) не изменит s, а вернет новую строку,
	//такую же как s, но без i первых символов
	//Пробельные символы бывают разные. Проще всего проверить,
	//является ли символ пробельным, можно спомощью метода char.IsWhiteSpace()
	internal class Program
    {
		public static string RemoveStartSpaces(string text)
		{
			int index = 0;
			
			while (char.IsWhiteSpace(text[index]))
            {
				index ++;
				if (index == text.Length) break;
            }
			
			return text.Substring(index);
		}
		static void Main(string[] args)
        {
			Console.WriteLine(RemoveStartSpaces("a"));
			Console.WriteLine(RemoveStartSpaces(" b"));
			Console.WriteLine(RemoveStartSpaces(" cd"));
			Console.WriteLine(RemoveStartSpaces(" efg"));
			Console.WriteLine(RemoveStartSpaces(" text"));
			Console.WriteLine(RemoveStartSpaces(" two words"));
			Console.WriteLine(RemoveStartSpaces("  two spaces"));
			Console.WriteLine(RemoveStartSpaces("	tabs"));
			Console.WriteLine(RemoveStartSpaces("		two	tabs"));
			Console.WriteLine(RemoveStartSpaces("                             many spaces"));
			Console.WriteLine(RemoveStartSpaces("               "));
			Console.WriteLine(RemoveStartSpaces("\n\r line breaks are spaces too"));
		}
    }
}
