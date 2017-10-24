using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualAbstractMachine.VAM.Instructions.Storage
{
    public class LoadConstant : IInstruction
    {
        private decimal _value;

        public LoadConstant(decimal value)
        {
            _value = value;
        }

        public LoadConstant(object args)
        {
            _value = Convert.ToDecimal(args);
        }

        public void Execute(IContext context)
        {
            context.Stack.Push(_value);
        }
    }
}
