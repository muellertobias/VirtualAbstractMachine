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
        private InstructionList _instructions;
        private Stack _stack;

        public VirtualMachine(InstructionList instructions)
        {
            _instructions = instructions ?? throw new ArgumentNullException("instructions");
            _stack = new Stack();
        }

        public void Run()
        {
            for (int i = 0; i < _instructions.Count; i++)
            {
                _instructions[i].Execute(_stack);
            }
        }

        public List<string> GetStackContent()
        {
            List<string> content = new List<string>();
            while (!_stack.IsEmpty())
            {
                content.Add(_stack.Pop().ToString());
            }

            return content;
        }
    }
}
