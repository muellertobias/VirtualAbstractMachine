using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualAbstractMachine.VAM.Instructions.Arithmetics
{
    public class Add : IInstruction
    {
        public void Execute(Stack stack, InstructionLabels labels, ref int instructionIndex)
        {
            var b = stack.Pop();
            var a = stack.Pop();
            stack.Push(a + b);
        }
    }
}
