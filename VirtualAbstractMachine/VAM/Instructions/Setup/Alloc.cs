using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualAbstractMachine.VAM.Instructions.Setup
{
    public class Alloc : IInstruction
    {
        private int _reserved;

        public Alloc(int reserved)
        {
            _reserved = reserved;
        }

        public Alloc(object args)
        {
            _reserved = Convert.ToInt32(args);
        }

        public void Execute(IContext context)
        {
            context.Stack.Allocate(_reserved);
        }
    }
}
