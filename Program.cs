using System;
using System.Diagnostics.CodeAnalysis;

namespace Num_To_Text_Converter
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tipee el número que quiere psasr a texto");

            var num = Console.ReadLine();

            var partialResult = new Converter();

            var result = partialResult.InText(num);

            Console.WriteLine(result);
        }
    }
}
