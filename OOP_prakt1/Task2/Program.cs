using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RandomDelegate[] delegates = new RandomDelegate[3];
            delegates[0] = () => new Random().Next(0, 9);
            delegates[1] = () => new Random().Next(0, 9);
            delegates[2] = () => new Random().Next(0, 9);

            Func<RandomDelegate[], double> calculateAverage = delegate (RandomDelegate[] dels)
            {
                double sum = 0;
                foreach (var del in dels)
                {
                    sum += del.Invoke();
                }
                return sum / dels.Length;
            };

            Console.WriteLine(calculateAverage(delegates));
        }
        delegate int RandomDelegate();
    }
}
