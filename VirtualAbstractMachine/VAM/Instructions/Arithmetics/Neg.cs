namespace VirtualAbstractMachine.VAM.Instructions.Arithmetics
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
