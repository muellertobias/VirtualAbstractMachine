using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using VirtualAbstractMachine.Utilities;
using VirtualAbstractMachine.VAM;
using VirtualAbstractMachineEditor.Utilities;

namespace VirtualAbstractMachineEditor.ViewModels
{
    public class EditorViewModel : ViewModelBase, INotifyOnInstructionsFinished
    {
        public event InstructionsFinishedEventHandler InstructionsFinished;

        private VirtualMachine machine;
        private StringInstructionLoader instructionLoader;

        private string _text;

        public string Text
        {
            get { return _text; }
            set
            {
                _text = value;
                OnPropertyChanged();
            }
        }

        public ICommand RunCommand { get; private set; }
        public ICommand StepCommand { get; private set; }
        public ICommand ResetCommand { get; private set; }

        public EditorViewModel() 
            : this(null) { }

        public EditorViewModel(VirtualMachine machine)
        {
            this.machine = machine;
            instructionLoader = new StringInstructionLoader();
            RunCommand = new Command(_ => _run(), _ => _validate());
            StepCommand = new Command(_ => _step(), _ => _validate());
            ResetCommand = new Command(_ => machine.Reset());
        }

        private void _run()
        {
            var instuctions = instructionLoader.Load(Text);
            machine.Setup(instuctions);

            bool successful = machine.Run(); // TODO Exception handling

            OnInstructionsFinished(successful, machine.GetStackContent());
        }

        private void _step()
        {
            
        }

        private bool _validate()
        {
            return true;
        }

        protected void OnInstructionsFinished(bool successfully, IReadOnlyList<string> stackContent)
        {
            InstructionsFinished?.Invoke(this, new InstructionsFinishedEventArgs(successfully, stackContent));
        }
    }
}
