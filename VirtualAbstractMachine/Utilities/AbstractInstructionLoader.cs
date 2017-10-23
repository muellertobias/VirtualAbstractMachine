using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualAbstractMachine.VAM.Instructions;
using VirtualAbstractMachine.VAM.Instructions.Arithmetics;
using VirtualAbstractMachine.VAM.Instructions.Procedures;
using VirtualAbstractMachine.VAM.Instructions.Storage;

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
                { "neg", typeof(Neg) },
                { "nop", typeof(Nop) },
                { "jump", typeof(Jump) },
                { "jumpz", typeof(Jumpz) }
            };
        }
        public abstract InstructionList Load();
        public abstract InstructionList Load(string source);

    }
}
