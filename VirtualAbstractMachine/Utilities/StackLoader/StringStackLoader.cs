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
            var lines = source.Split('\n').ToList();

            Stack stack = new Stack();

            foreach (var line in lines)
            {
                if (line.StartsWith("p("))
                {
                    // p(x) = 1
                    var s = line.Split('=');
                    int pointer = Convert.ToInt32(s.Last());

                    if (stack.Count - 1 < pointer)
                    {

                    }
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
