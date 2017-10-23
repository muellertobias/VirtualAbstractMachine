using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualAbstractMachine.VAM.Instructions.Procedures
{
    public class Jump : IInstruction
    {
        protected string _label;

        public Jump(object args)
        {
            _label = args.ToString();
        }

        public void Execute(IContext context)
        {
            context.InstructionIndex = context.Instructions.InstructionLabels[_label];
        }
    }
}
