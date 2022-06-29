using System;
using WiredBreanCofe.Generics.Models;

namespace WiredBreanCofe.Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SimpleStack stack = new SimpleStack();
            stack.Push(1.2);
            stack.Push(2.8);
            stack.Push(3.0);

            while (stack.Count() > 0)
            {
                var  item = stack.Pop();
                Console.WriteLine($"Count {stack.Count()}, Item {item}");
            }

            Console.ReadLine();
        }
    }
}
