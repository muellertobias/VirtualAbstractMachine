namespace VirtualAbstractMachine.VAM.Instructions.Storage
{
    public class Load : IInstruction
    {
        public void Execute(IContext context)
        {
            var index = (int)context.Stack.Pop();
            var value = context.Stack[index];
            context.Stack.Push(value);
        }
    }
}
