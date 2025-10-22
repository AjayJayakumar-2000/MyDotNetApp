using System;

namespace MyApp
{
    public class Program
    {
        public static int Main(string[] args)
        {
            Console.WriteLine("Hello from MyDotNetApp!");
            Console.WriteLine($"2 + 3 = {Calculator.Add(2,3)}");
            return 0;
        }
    }

    public static class Calculator
    {
        public static int Add(int a, int b) => a + b;
    }
}
