using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualAbstractMachine.VAM.Instructions
{
    public interface IInstruction
    {
        void Execute(Stack stack, InstructionLabels labels, ref int instructionIndex);
    }
}
