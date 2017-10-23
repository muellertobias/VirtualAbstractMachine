namespace VirtualAbstractMachine.VAM.Instructions.Procedures
{
    public class JumpOnZero : IInstruction
    {
        protected string _label;

        public JumpOnZero(object args)
        {
            _label = args.ToString();
        }

        public void Execute(IContext context)
        {
            var value = context.Stack.Pop();
            if (value == 0m)
                context.InstructionIndex = context.Instructions.InstructionLabels[_label];

            context.Stack.Push(value);
        }

    }
}
