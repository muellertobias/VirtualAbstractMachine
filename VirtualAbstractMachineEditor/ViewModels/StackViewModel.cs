using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualAbstractMachineEditor.Utilities;

namespace VirtualAbstractMachineEditor.ViewModels
{
    public sealed class Content
    {
        public int Number { get; set; }
        public string Payload { get; set; }
    }

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
        private ObservableCollection<Content> _stackContent;
        public ObservableCollection<Content> StackContent
        {
            get => _stackContent;
            private set => _stackContent = value;
        }

        public StackViewModel(INotifyOnInstructionsFinished notifier)
        {
            StackContent = new ObservableCollection<Content>();
            notifier.InstructionsFinished += OnInstructionsFinished;
        }

        private void OnInstructionsFinished(object sender, InstructionsFinishedEventArgs e)
        {
            StackContent.Clear();

            var stack = e.StackContent;

            if (e.Successfully)
            {
                for (int i = stack.Count - 1; i >= 0; i--)
                {
                    StackContent.Add(new Content() { Number =  i, Payload = stack[i] });
                }
            }
            else
            {
                StackContent.Add(new Content() { Number = 0, Payload = "ERROR" });
            }
        }
    }
}
