﻿namespace VirtualAbstractMachine.VAM.Instructions.Procedures
{
    public class Dublication : IInstruction
    {
        public void Execute(IContext context)
        {
            var value = context.Stack.Pop();
            context.Stack.Push(value);
            context.Stack.Push(value);
        }
    }
}
