using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualAbstractMachine.VAM.Instructions;

namespace VirtualAbstractMachine.Utilities
{
    public abstract class AbstractInstructionLoader
    {
        protected Dictionary<string, Type> InstructionSet;

        public AbstractInstructionLoader()
        {
            InstructionSet = new Dictionary<string, Type>
            {
                { "loadc", typeof(Loadc) },
                { "add", typeof(Add) },
                { "div", typeof(Div) },
                { "mul", typeof(Mul) },
                { "store", typeof(Store) },
                { "sub", typeof(Sub) },
                { "neg", typeof(Neg) }
            };
        }
        public abstract InstructionList Load();
    }
}
