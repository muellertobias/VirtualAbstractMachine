namespace VirtualAbstractMachine.VAM.Instructions
{
    public class Neg : IInstruction
    {
        public void Execute(Stack stack)
        {
            var a = stack.Pop();
            stack.Push(-a);
        }
    }
}
