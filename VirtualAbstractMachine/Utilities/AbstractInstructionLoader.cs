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
using VirtualAbstractMachine.VAM.Instructions.Setup;
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
                { "loada", typeof(LoadAddress) },
                { "loadc", typeof(LoadConstant) },
                { "store", typeof(Store) },
                #endregion

                #region Arithmetics
                { "add", typeof(Addition) },
                { "div", typeof(Division) },
                { "mul", typeof(Multiplication) },
                { "sub", typeof(Substraction) },
                { "neg", typeof(Negation) },
                #endregion

                #region Procedures
                { "dub", typeof(Dublication) },
                { "pop", typeof(Pop) },
                { "jump", typeof(Jump) },
                { "jumpz", typeof(JumpOnZero) },
                { "halt", typeof(Halt) },
                { "nop", typeof(NoOperation) },
                #endregion

                #region Comparsion
                { "eq", typeof(Equal) },
                { "neq", typeof(NotEqual) },
                { "leq", typeof(LessEqual) },
                { "geq", typeof(GreaterEqual) },
                { "le", typeof(Less) },
                { "ge", typeof(Greater) },
                #endregion

                #region Logics
                { "and", typeof(And) },
                { "not", typeof(Not) },
                { "or", typeof(Or) },
                { "xor", typeof(Xor) },
                #endregion

                #region Setup
                { "enter", typeof(Enter) },
                { "alloc", typeof(Alloc) }
                #endregion
            };
        }
        public abstract InstructionList Load();
        public abstract InstructionList Load(string source);

    }
}
