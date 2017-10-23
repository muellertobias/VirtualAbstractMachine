using System;

namespace VirtualAbstractMachine.VAM.Instructions.Storage
{
    public class LoadAddress : IInstruction
    {
        private int _index;

        public LoadAddress(int index)
        {
            _index = index;
        }

        public LoadAddress(object args)
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
