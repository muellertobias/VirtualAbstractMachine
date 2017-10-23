using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualAbstractMachine.VAM.Instructions;
using VirtualAbstractMachine.VAM.Instructions.Arithmetics;
using VirtualAbstractMachine.VAM.Instructions.Comparsion;
using VirtualAbstractMachine.VAM.Instructions.Logics;
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
                #region Storage
                { "load", typeof(Load) },
                { "loada", typeof(Loada) },
                { "loadc", typeof(Loadc) },
                { "store", typeof(Store) },
                #endregion

                #region Arithmetics
                { "add", typeof(Add) },
                { "div", typeof(Div) },
                { "mul", typeof(Mul) },
                { "sub", typeof(Sub) },
                { "neg", typeof(Neg) },
                #endregion

                #region Procedures
                { "dub", typeof(Dub) },
                { "pop", typeof(Pop) },
                { "jump", typeof(Jump) },
                { "jumpz", typeof(Jumpz) },
                { "halt", typeof(Halt) },
                { "nop", typeof(Nop) },
                #endregion

                #region Comparsion
                { "eq", typeof(Equal) },
                { "neq", typeof(NotEqual) },
                { "leq", typeof(LessEqual) },
                { "geq", typeof(GreaterEqual) },
                { "le", typeof(Less) },
                { "ge", typeof(Greater) },

                #region Logics
                { "and", typeof(And) },
                { "not", typeof(Not) },
                { "or", typeof(Or) },
                { "xor", typeof(Xor) },
                #endregion
            };
        }
        public abstract InstructionList Load();
        public abstract InstructionList Load(string source);

    }
}
