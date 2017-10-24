using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualAbstractMachine.VAM.Instructions.Comparsion
{
    public class Equal : IInstruction
    {
        public void Execute(IContext context)
        {
            var b = context.Stack.Pop();
            var a = context.Stack.Pop();
            context.Stack.Push(Convert.ToDecimal(a == b));
        }
    }
}
