using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualAbstractMachine.VAM;
using VirtualAbstractMachineEditor.Utilities;
using VirtualAbstractMachineEditor.ViewModels;

namespace VirtualAbstractMachineEditor
{
    public class MainViewModel : ViewModelBase
    {
        public EditorViewModel EditorViewModel { get; private set; }
        public StackViewModel StackViewModel { get; private set; }

        public MainViewModel()
        {
            VirtualMachine machine = new VirtualMachine();
            EditorViewModel = new EditorViewModel(machine);
            StackViewModel = new StackViewModel(EditorViewModel);
        }
    }
}
