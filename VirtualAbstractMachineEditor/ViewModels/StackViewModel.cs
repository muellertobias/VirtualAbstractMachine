using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualAbstractMachineEditor.Utilities;

namespace VirtualAbstractMachineEditor.ViewModels
{
    public class StackViewModel : ViewModelBase
    {
        private int _maximumStackSize;
        public int MaximumStackSize
        {
            get { return _maximumStackSize; }
            private set
            {
                _maximumStackSize = value;
                OnPropertyChanged();
            }
        }
        private ObservableCollection<string> _stackContent;
        public ObservableCollection<string> StackContent
        {
            get => _stackContent;
            private set => _stackContent = value;
        }

        public StackViewModel(INotifyOnInstructionsFinished notifier)
        {
            StackContent = new ObservableCollection<string>();
            notifier.InstructionsFinished += OnInstructionsFinished;
        }

        private void OnInstructionsFinished(object sender, InstructionsFinishedEventArgs e)
        {
            StackContent.Clear();

            if (e.Successfully)
            {
                foreach (string s in e.StackContent)
                {
                    StackContent.Add(s);
                }
            }
            else
            {
                StackContent.Add("ERROR");
            }
        }
    }
}
