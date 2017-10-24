using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualAbstractMachine.VAM;

namespace VirtualAbstractMachine.Utilities.StackLoader
{
    public abstract class AbstractStackLoader
    {
        public abstract Stack Load(string source);
    }
}
