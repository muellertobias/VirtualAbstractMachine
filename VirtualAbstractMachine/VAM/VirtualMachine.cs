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
            try
            {
                while (_instructionIndex >= 0 && _instructionIndex < _instructions.Count) // TODO 
                {
                    var instruction = _instructions[_instructionIndex];
                    _instructionIndex++;
                    instruction.Execute(_stack, _instructions.InstructionLabels, ref _instructionIndex);
                }
            }
            catch (Exception e)
            { 
                return false;
            }
            return true;
        }

        public bool Step()
        {
            if (_instructionIndex < _instructions.Count)
            {
                var instruction = _instructions[_instructionIndex];
                _instructionIndex++;
                instruction.Execute(_stack, _instructions.InstructionLabels, ref _instructionIndex);

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
