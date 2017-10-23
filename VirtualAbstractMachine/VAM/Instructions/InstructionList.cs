using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualAbstractMachine.VAM.Instructions
{
    public sealed class InstructionList : List<IInstruction>
    {
        private Dictionary<string, int> _labels;

        public InstructionList()
        {
            _labels = new Dictionary<string, int>();
        }

        public int GetInstructionIndex(string label)
        {
            return _labels[label];
        }

        public void Add(IInstruction instruction, string label)
        {
            this.Add(instruction);
            _labels.Add(label, this.Count - 1);
        }
    }
}
