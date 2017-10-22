using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualAbstractMachine.VAM.Instructions
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

        public void Execute(Stack stack)
        {
            stack.Push(_value);
        }
    }
}
