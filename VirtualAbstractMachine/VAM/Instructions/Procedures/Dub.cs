namespace VirtualAbstractMachine.VAM.Instructions.Procedures
{
    public class Dub : IInstruction
    {
        public void Execute(Stack stack, int instructionIndex)
        {
            var value = stack.Pop();
            stack.Push(value);
            stack.Push(value);
        }
    }
}
