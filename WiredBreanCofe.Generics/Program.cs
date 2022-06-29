using System;
using WiredBreanCofe.Generics.Models;

namespace WiredBreanCofe.Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DoubleSimpleStack();

            Console.ReadLine();
        }

        private static void DoubleSimpleStack()
        {
            SimpleStack stack = new SimpleStack();
            stack.Push(1.2);
            stack.Push(2.8);
            stack.Push(3.0);

            double sum = 0;

            while (stack.Count() > 0)
            {
                var item = stack.Pop();

                sum += item;

                Console.WriteLine($"Count {stack.Count()}, Item {item}");
            }

            Console.WriteLine($"Sum {sum}");
        }
    }
}
