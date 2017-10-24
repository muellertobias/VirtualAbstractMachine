using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualAbstractMachine.VAM.Instructions.Storage
{
    public class Store : IInstruction
    {
        public void Execute(IContext context)
        {
            int index = (int)context.Stack.Pop();
            var value = context.Stack.Pop();
            context.Stack.Insert(index, value);
        }
    }
}
