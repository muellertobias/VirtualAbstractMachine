using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualAbstractMachine.VAM.Instructions.Procedures
{
    public class Jump : IInstruction
    {
        private string _label;

        public Jump(object args)
        {
            _label = args.ToString();
        }

        public void Execute(Stack stack, int instructionIndex)
        {
            //instructionIndex = // TODO Zugriff auf die Labels also InstructionsList
        }
    }
}
