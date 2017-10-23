using System;

namespace VirtualAbstractMachine.VAM.Instructions.Storage
{
    public class Loada : IInstruction
    {
        private int _index;

        public Loada(int index)
        {
            _index = index;
        }

        public Loada(object args)
        {
            _index = Convert.ToInt32(args);
        }

        public void Execute(IContext context)
        {
            var value = context.Stack[_index];
            context.Stack.Push(value);
        }
    }
}
