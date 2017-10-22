using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VirtualAbstractMachine.Utilities;
using VirtualAbstractMachine.VAM;
using VirtualAbstractMachine.VAM.Instructions;

namespace VirtualAbstractMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            InstructionList Instructions = new FileInstructionLoader("test.txt").Load();
            VirtualMachine VirtualMachine = new VirtualMachine(Instructions);

            VirtualMachine.Run();
            var content = VirtualMachine.GetStackContent();

            foreach (var c in content)
            {
                Console.WriteLine(c);
            }

            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
