using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualAbstractMachine.VAM.Instructions;

namespace VirtualAbstractMachine.Utilities
{
    public class StringInstructionLoader : AbstractInstructionLoader
    {
        private List<string> _instructionLines;

        public StringInstructionLoader()
            : this(new List<string>()) { }

        public StringInstructionLoader(List<string> instructionLines)
        {
            _instructionLines = instructionLines;
        }

        public override InstructionList Load()
        {
            InstructionList instructions = new InstructionList();

            foreach (string line in _instructionLines)
            {
                string[] tokens = line.Split(' ');
                string key = tokens.First().Replace("\r", "").Replace("\n", "");
                var type = InstructionSet[key];
                string[] args = null;
                if (tokens.Length > 1)
                {
                    args = tokens.Skip(1).ToArray();
                }
                instructions.Add((IInstruction)Activator.CreateInstance(type, args));
            }

            return instructions;
        }

        public override InstructionList Load(string source)
        {
            _instructionLines = source.Split('\n').ToList();
            return Load();
        }
    }
}
