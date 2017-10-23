using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualAbstractMachine.VAM.Instructions
{
    public sealed class InstructionLabels : Dictionary<string, int> { }

    public sealed class InstructionList : List<IInstruction>
    {
        public InstructionLabels InstructionLabels { get; private set; }

        public InstructionList()
        {
            InstructionLabels = new InstructionLabels();
        }

        public int GetInstructionIndex(string label)
        {
            return InstructionLabels[label];
        }

        public void Add(IInstruction instruction, string label)
        {
            Add(instruction);
            InstructionLabels.Add(label, Count - 1);
        }
    }
}
