using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualAbstractMachine.VAM.Instructions;

namespace VirtualAbstractMachine.Utilities
{
    public class FileInstructionLoader : AbstractInstructionLoader
    {
        private string _filename;
        public FileInstructionLoader(string filename)
        {
            _filename = filename;
        }

        public override InstructionList Load()
        {
            if (!File.Exists(_filename))
            {
                throw new FileNotFoundException(string.Empty, _filename);
            }

            List<string> lines = new List<string>();
            using (var fileStream = File.OpenRead(_filename))
            {
                using (var reader = new StreamReader(fileStream, Encoding.UTF8))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        lines.Add(line);
                    }
                }
            }

            return new StringInstructionLoader(lines).Load();
        }
    }
}
