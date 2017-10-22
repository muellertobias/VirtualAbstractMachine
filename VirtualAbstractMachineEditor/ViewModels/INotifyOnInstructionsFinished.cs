using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualAbstractMachineEditor.ViewModels
{
    public class InstructionsFinishedEventArgs : EventArgs
    {
        public bool Successfully { get; private set; }
        public IReadOnlyList<string> StackContent { get; private set; }
        public InstructionsFinishedEventArgs(bool successfully, IReadOnlyList<string> stackContent)
        {
            Successfully = successfully;
            StackContent = stackContent;
        }
    }

    public delegate void InstructionsFinishedEventHandler(object sender, InstructionsFinishedEventArgs e);

    public interface INotifyOnInstructionsFinished
    {
        event InstructionsFinishedEventHandler InstructionsFinished;
    }
}
