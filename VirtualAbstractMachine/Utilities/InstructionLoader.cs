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

    public class InstructionLoader : AbstractInstructionLoader
    {
        private string _filename;
        public InstructionLoader(string filename)
        {
            _filename = filename;
        }

        public override InstructionList Load()
        {
            if (!File.Exists(_filename))
            {
                throw new FileNotFoundException(string.Empty, _filename);
            }

            InstructionList instructions = new InstructionList();

            using (var fileStream = File.OpenRead(_filename))
            {
                using (var reader = new StreamReader(fileStream, Encoding.UTF8))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] tokens = line.Split(' ');
                        var type = InstructionSet[tokens.First()];
                        string[] args = null;
                        if (tokens.Length > 1)
                        {
                            args = tokens.Skip(1).ToArray();
                        }
                        instructions.Add((IInstruction)Activator.CreateInstance(type, args));
                    }
                }
            }

            return instructions;
        }
    }
}
