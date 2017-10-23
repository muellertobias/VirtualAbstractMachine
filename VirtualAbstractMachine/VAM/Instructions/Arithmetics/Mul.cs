namespace VirtualAbstractMachine.VAM.Instructions.Arithmetics
{
    public class Multiplication : IInstruction
    {
        public void Execute(IContext context)
        {
            var a = context.Stack.Pop();
            var b = context.Stack.Pop();
            context.Stack.Push(b * a);
        }
    }
}
