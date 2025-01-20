using System;

namespace Core
{
    static class Program
    {
        static void Main(string[] args)
        {
            string string1 = "111";
            string string2 = "001";

            var x = Processor.RunCalculator(string1, string2);
            string answer = x.Item1;
            string message = x.Item2;

            Console.WriteLine(answer);
            Console.WriteLine(message);
        }
    }
}