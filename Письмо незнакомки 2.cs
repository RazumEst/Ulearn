using System;
using System.Text;

namespace Письмо_незнакомки_2
{
    internal class Program
    {
        private static string ApplyCommands(string[] commands)
        {
            var builder = new StringBuilder();

            foreach(var line in commands)
            {
                if (line[1] == 'u') builder.Append(line.Substring(5));
                else
                {
                    var pop = int.Parse(line.Substring(4));
                    builder.Remove(builder.Length - pop, pop);
                }
            }
            return builder.ToString();
        }
        static void Main(string[] args)
        {
            
        }
    }
}
