using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualAbstractMachine.VAM.Instructions
{
    public class Nop : IInstruction
    {
        public void Execute(Stack stack)
        {
            // nothing to do here!
        }
    }
}
