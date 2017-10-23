namespace VirtualAbstractMachine.VAM.Instructions.Arithmetics
{
    public class Div : IInstruction
    {
        public void Execute(Stack stack)
        {
            var a = stack.Pop();
            var b = stack.Pop();
            stack.Push(b / a);
        }
    }
}
