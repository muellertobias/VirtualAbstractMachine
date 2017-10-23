using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualAbstractMachine.VAM.Instructions;

namespace VirtualAbstractMachine.VAM
{
    public interface IContext
    {
        int InstructionIndex { get; set; }
        InstructionList Instructions { get; set; }
        Stack Stack { get; set; }
    }
}
