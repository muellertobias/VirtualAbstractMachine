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

        public void Execute(Stack stack, InstructionLabels labels, ref int instructionIndex)
        {
            instructionIndex = labels[_label];
        }
    }

    public class Jumpz : IInstruction
    {
        protected string _label;

        public Jumpz(object args)
        {
            _label = args.ToString();
        }

        public void Execute(Stack stack, InstructionLabels labels, ref int instructionIndex)
        {
            var value = stack.Pop();
            if (value == 0m)
                instructionIndex = labels[_label];

            stack.Push(value);
        }

    }
}
