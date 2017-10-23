using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualAbstractMachine.VAM.Instructions.Procedures
{
    public class Nop : IInstruction
    {
        public void Execute(IContext context)
        {
            // nothing to do here!
        }
    }
}
