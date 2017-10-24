using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualAbstractMachine.VAM.Instructions.Logics
{
    public class Not : IInstruction
    {
        public void Execute(IContext context)
        {
            var a = (int)context.Stack.Pop();
            context.Stack.Push(~a);
        }
    }
}
