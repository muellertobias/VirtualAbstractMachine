namespace VirtualAbstractMachine.VAM.Instructions.Arithmetics
{
    public class Neg : IInstruction
    {
        public void Execute(Stack stack, int instructionIndex)
        {
            var a = stack.Pop();
            stack.Push(-a);
        }
    }
}
