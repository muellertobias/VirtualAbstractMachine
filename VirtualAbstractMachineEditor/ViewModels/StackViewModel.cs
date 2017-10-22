using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualAbstractMachineEditor.Utilities;

namespace VirtualAbstractMachineEditor.ViewModels
{
    public class StackViewModel : ViewModelBase
    {
        private string _stackContent;
        public string StackContent
        {
            get { return _stackContent; }
            private set
            {
                _stackContent = value;
                OnPropertyChanged();
            }
        }

        public StackViewModel(INotifyOnInstructionsFinished notifier)
        {
            notifier.InstructionsFinished += OnInstructionsFinished;
        }

        private void OnInstructionsFinished(object sender, InstructionsFinishedEventArgs e)
        {
            StringBuilder builder = new StringBuilder();
            foreach (string s in e.StackContent)
            {
                builder.AppendFormat("{0}\n", s);
            }
            StackContent = builder.ToString();
        }
    }
}
