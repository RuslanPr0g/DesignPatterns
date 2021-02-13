namespace Command
{
    class Pult
    {
        ICommand command;

        public Pult()
        {
            command = new NoCommand();
        }

        public void SetCommand(ICommand com)
        {
            command = com;
        }

        public void PressButton()
        {
            command.Execute();
        }
        public void PressUndo()
        {
            command.Undo();
        }
    }
}
