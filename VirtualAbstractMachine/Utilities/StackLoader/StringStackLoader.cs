using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualAbstractMachine.VAM;

namespace VirtualAbstractMachine.Utilities.StackLoader
{
    public class StringStackLoader : AbstractStackLoader
    {
        public override Stack Load(string source)
        {
            throw new NotImplementedException("TODO");

            var lines = source.Split('\n').ToList();

            Stack stack = new Stack();

            foreach (var line in lines)
            {
                if (line.StartsWith("p("))
                {
                    // p(x) = 1
                    var s = line.Split('=');
                    int value = Convert.ToInt32(s.Last());

                }
                else
                {
                    // SYNTAX ERROR
                }
            }

            return stack;
        }
    }
}
