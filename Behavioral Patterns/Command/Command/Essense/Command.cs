﻿namespace Command
{
    abstract class Command
    {
        public abstract void Execute();
        public abstract void Undo();
    }
}
