﻿namespace VirtualAbstractMachine.VAM.Instructions.Arithmetics
{
    public class Negation : IInstruction
    {
        public void Execute(IContext context)
        {
            var a = context.Stack.Pop();
            context.Stack.Push(-a);
        }
    }
}
