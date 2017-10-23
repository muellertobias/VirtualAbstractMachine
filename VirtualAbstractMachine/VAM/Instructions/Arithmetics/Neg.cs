namespace VirtualAbstractMachine.VAM.Instructions.Arithmetics
{
    public class Neg : IInstruction
    {
        public void Execute(Stack stack, InstructionLabels labels, ref int instructionIndex)
        {
            var a = stack.Pop();
            stack.Push(-a);
        }
    }
}
