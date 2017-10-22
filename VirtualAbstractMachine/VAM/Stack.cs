using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualAbstractMachine.VAM
{
    public class Stack
    {
        private Stack<decimal> _stack;

        public Stack()
        {
            _stack = new Stack<decimal>();
        }

        public decimal Pop()
        {
            return _stack.Pop();
        }

        public void Push(decimal value)
        {
            _stack.Push(value);
        }

        public bool IsEmpty()
        {
            return _stack.Count == 0;
        }

        public void Insert(int index, decimal value)
        {
            throw new NotImplementedException("Stack - Insert");
        }
    }
}
