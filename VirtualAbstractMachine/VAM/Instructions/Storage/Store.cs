using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualAbstractMachine.VAM.Instructions.Storage
{
    public class Store : IInstruction
    {
        public void Execute(Stack stack, InstructionLabels labels, ref int instructionIndex)
        {
            int index = (int)stack.Pop();
            var value = stack.Pop();
            stack.Insert(index, value);
        }
    }
}
