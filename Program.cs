using System;
using System.Threading;

namespace Module_9_3_2
{
    class Program
    {
        public delegate int SubstractDelegate(int a, int b);

        static void Main(string[] args)
        {
            SubstractDelegate substractDelegate = Substract;
            int result = substractDelegate(10, 5);
            Console.WriteLine(result);
            Console.ReadKey();
        }

        static int Substract(int a, int b)
        {
            return a - b;
        }
    }
}