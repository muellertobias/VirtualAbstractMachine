using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualAbstractMachine.VAM.Instructions.Storage
{
    public class Loadc : IInstruction
    {
        private decimal _value;

        public Loadc(decimal value)
        {
            _value = value;
        }

        public Loadc(object args)
        {
            _value = Convert.ToDecimal(args);
        }

        public void Execute(Stack stack, InstructionLabels labels, ref int instructionIndex)
        {
            stack.Push(_value);
        }
    }

    public class Load : IInstruction
    {
        public void Execute(Stack stack, InstructionLabels labels, ref int instructionIndex)
        {
            var index = (int)stack.Pop();
            var value = stack[index];
            stack.Push(value);
        }
    }

    public class Loada : IInstruction
    {
        private int _index;

        public Loada(int index)
        {
            _index = index;
        }

        public Loada(object args)
        {
            _index = Convert.ToInt32(args);
        }

        public void Execute(Stack stack, InstructionLabels labels, ref int instructionIndex)
        {
            var value = stack[_index];
            stack.Push(value);
        }
    }
}
