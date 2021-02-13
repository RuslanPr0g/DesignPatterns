namespace Command
{
    interface ICommand
    {
        void Execute();
        void Undo();
    }
}
