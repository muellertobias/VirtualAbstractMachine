using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualAbstractMachine.VAM.Instructions
{
    public class Add : IInstruction
    {
        public void Execute(Stack stack)
        {
            var a = stack.Pop();
            var b = stack.Pop();
            stack.Push(a + b);
        }
    }

    public class Neg : IInstruction
    {
        public void Execute(Stack stack)
        {
            var a = stack.Pop();
            stack.Push(-a);
        }
    }
}
