using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualAbstractMachine.Utilities.Exceptions
{

    [Serializable]
    public class VAMException : Exception
    {
        public int InstructionIndex { get; protected set; }
        public VAMException(int instructionIndex) { }
        public VAMException(int instructionIndex, string message) : base(message) { }
        public VAMException(int instructionIndex, string message, Exception inner) : base(message, inner) { }
        protected VAMException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
