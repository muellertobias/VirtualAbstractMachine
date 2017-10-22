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
    public class EditorViewModel : ViewModelBase
    {
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
        {
            machine = new VirtualMachine();
            instructionLoader = new StringInstructionLoader();
            RunCommand = new Command(o => _run(), o => _validate());
        }

        private void _run()
        {
            var instuctions = instructionLoader.Load(Text);
            machine.Setup(instuctions);
            machine.Run();
        }

        private bool _validate()
        {
            return true;
        }
    }
}
