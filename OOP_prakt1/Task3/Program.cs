using System;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Average average = delegate (int a, int b, int c)
            {
                return (a + b + c) / 3;
            };
            Console.WriteLine(average(5, 7, 9));
        }
        delegate int Average(int a, int b, int c);
    }
}
