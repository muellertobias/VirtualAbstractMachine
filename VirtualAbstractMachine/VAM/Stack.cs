using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualAbstractMachine.VAM
{
    public class Stack
    {
        public int Count
        {
            get => _stack.Count;
        }

        private List<decimal> _stack;

        public decimal this[int index]
        {
            get { return _stack[index]; }
            set { _stack[index] = value; }
        }

        public Stack()
        {
            _stack = new List<decimal>();
        }

        public decimal Pop()
        {
            var value = _stack.Last();
            _stack.RemoveAt(_stack.Count - 1);

            return value;
        }

        public void Push(decimal value)
        {
            _stack.Add(value);
        }

        public void Insert(int index, decimal value)
        {
            _stack.Insert(index, value);
        }

        public decimal[] AsArray()
        {
            var copy = new decimal[_stack.Count];
            _stack.CopyTo(copy);
            return copy.Reverse().ToArray();
        }

        public void Reset()
        {
            _stack.Clear();
        }
    }
}
