using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualAbstractMachine.VAM.Instructions;

namespace VirtualAbstractMachine.VAM
{
    public class VirtualMachine
    {
        private int _instructionIndex;
        private InstructionList _instructions;
        private Stack _stack;

        public VirtualMachine() 
            : this(new InstructionList() { }) { }

        public VirtualMachine(InstructionList instructions)
        {
            _instructions = instructions ?? throw new ArgumentNullException("instructions");
            _stack = new Stack();
            _instructionIndex = 0;
        }

        public void Setup(InstructionList instructions)
        {
            _instructions = instructions;
            Reset();
        }

        public bool Run()
        {
            //while (_instructionIndex >= 0) // TODO 
            //{
            //    _instructionIndex++;
            //    _instructions[_instructionIndex].Execute(_stack, _instructionIndex);
            //}

            for (int i = 0; i < _instructions.Count; i++)
            {
                try
                {
                    // TODO i an Instrution übergeben
                    _instructions[i].Execute(_stack);

                }
                catch
                {
                    return false;
                }
            }
            return true;
        }

        public bool Step()
        {
            if (_instructionIndex < _instructions.Count)
            {
                _instructions[_instructionIndex].Execute(_stack);
                _instructionIndex++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            _stack.Reset();
            _instructionIndex = 0;
        }

        public List<string> GetStackContent()
        {
            List<string> content = new List<string>();

            foreach (var v in _stack.AsArray())
            {
                content.Add(v.ToString());
            }

            return content;
        }
    }
}
