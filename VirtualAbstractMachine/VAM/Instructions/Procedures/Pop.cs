using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualAbstractMachine.VAM.Instructions.Procedures
{
    public class Pop : IInstruction
    {
        public void Execute(Stack stack, InstructionLabels labels, ref int instructionIndex)
        {
            stack.Pop();
        }
    }
}
