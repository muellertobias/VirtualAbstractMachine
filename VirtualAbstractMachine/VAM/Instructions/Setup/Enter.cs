using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualAbstractMachine.VAM.Instructions.Setup
{
    public class Enter : IInstruction
    {
        private int _stackSize;

        public Enter(int stackSize)
        {
            _stackSize = stackSize;
        }

        public Enter(object args)
        {
            _stackSize = Convert.ToInt32(args);
        }

        public void Execute(IContext context)
        {
            context.Stack.Reserve(_stackSize);
        }
    }
}
