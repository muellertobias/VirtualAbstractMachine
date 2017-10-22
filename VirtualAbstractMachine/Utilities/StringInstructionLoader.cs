﻿using System;
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
                var type = InstructionSet[tokens.First()];
                string[] args = null;
                if (tokens.Length > 1)
                {
                    args = tokens.Skip(1).ToArray();
                }
                instructions.Add((IInstruction)Activator.CreateInstance(type, args));
            }

            return instructions;
        }
    }
}
