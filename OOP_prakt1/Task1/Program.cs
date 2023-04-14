using System;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operation Add = (int a, int b) => a + b;
            Operation Sub = (int a, int b) => a - b;
            Operation Mul = (int a, int b) => a * b;
            Operation Div = (int a, int b) => { if (b != 0) return a / b; else throw new ArgumentException("b is zero"); };

            Console.WriteLine(Add(3, 5));
            Console.WriteLine(Sub(6, 2));
            Console.WriteLine(Mul(4, 1));
            Console.WriteLine(Div(10, 5));
        }
        delegate double Operation(int a, int b);
    }
}
