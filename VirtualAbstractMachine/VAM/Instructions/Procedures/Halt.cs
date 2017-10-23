using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualAbstractMachine.VAM.Instructions.Procedures
{
    public class Halt : IInstruction
    {
        public void Execute(Stack stack, int instructionIndex)
        {
            throw new NotImplementedException();
        }
    }
}
