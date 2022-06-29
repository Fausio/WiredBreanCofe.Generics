using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiredBreanCofe.Generics.Models
{
    public class SimpleStack
    {
        private readonly double[] _items;
        private int index = -1;

        public SimpleStack()
        {
            _items = new double[10];
        }

        public void push(double item) => _items[++ index] = item;
        public double pop() => _items[index--];
    
    }
}
