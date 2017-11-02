using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualAbstractMachine.Utilities.Exceptions;
using VirtualAbstractMachine.VAM.Instructions;

namespace VirtualAbstractMachine.VAM
{
    public class VirtualMachine : IContext
    {
        public int InstructionIndex { get; set; }
        public InstructionList Instructions { get; set; }
        public Stack Stack { get; set; }

        public VirtualMachine() 
            : this(new InstructionList() { }) { }

        public VirtualMachine(InstructionList instructions)
        {
            Instructions = instructions ?? throw new ArgumentNullException("instructions");
            Stack = new Stack();
            InstructionIndex = 0;
        }

        public void Setup(InstructionList instructions)
        {
            Instructions = instructions;
            Reset();
        }

        public bool Run()
        {
            try
            {
                while (InstructionIndex >= 0 && InstructionIndex < Instructions.Count)
                {
                    var instruction = Instructions[InstructionIndex];
                    InstructionIndex++;
                    instruction.Execute(this);
                }
            }
            catch (Exception e)
            {
                throw new VAMException(InstructionIndex - 1, "", e);
            }
            return true;
        }

        public bool Step()
        {
            if (InstructionIndex < Instructions.Count)
            {
                var instruction = Instructions[InstructionIndex];
                InstructionIndex++;
                instruction.Execute(this);

                return true;
            }
            return false;
        }

        public void Reset()
        {
            Stack.Reset();
            InstructionIndex = 0;
        }

        public List<string> GetStackContent()
        {
            List<string> content = new List<string>();

            foreach (var v in Stack.AsArray())
            {
                content.Add(v.ToString());
            }

            return content;
        }
    }
}
