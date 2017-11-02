using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualAbstractMachine.VAM
{
    public class Stack
    {
        private int _reserved;
        private int _maxSize;
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
            _reserved = 0;
            _maxSize = int.MaxValue;
        }

        public void Allocate(int reserved)
        {
            _reserved = reserved;
            while (_stack.Count < _reserved)
            {
                Push(0);
            }
        }

        public decimal Pop()
        {
            var value = _stack.Last();
            _stack.RemoveAt(_stack.Count - 1);

            return value;
        }

        public void Push(decimal value)
        {
            if (_stack.Count + 1 == _maxSize)
            {
                // STACK OVERFLOW
            }
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
            return copy; 
        }


        public void Reserve(int stackSize)
        {
            _maxSize = stackSize;
        }

        public void Reset()
        {
            _stack.Clear();
            _reserved = 0;
            _maxSize = int.MaxValue;
        }
    }
}
