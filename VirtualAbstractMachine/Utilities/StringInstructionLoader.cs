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
                if (!string.IsNullOrWhiteSpace(line))
                {
                    string[] tokens = line.Split(' ');

                    string label = null;
                    if (tokens.First().EndsWith(":"))
                    {
                        label = tokens.First().Remove(tokens.First().Length - 1);
                        tokens = tokens.Skip(1).ToArray();
                    }
                    //string key = tokens.First().Replace("\r", "").Replace("\n", "");
                    string key = tokens.First().Trim();
                    var type = InstructionSet[key];
                    string[] args = null;
                    if (tokens.Length > 1)
                    {
                        args = tokens.Skip(1).ToArray();
                    }

                    IInstruction instruction = (IInstruction)Activator.CreateInstance(type, args);

                    if (label == null)
                        instructions.Add(instruction);
                    else
                        instructions.Add(instruction, label);
                }
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
