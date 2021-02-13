using System.Collections.Generic;

namespace Command
{
    class MultiPult
    {
        ICommand[] buttons;
        Stack<ICommand> commandsHistory;

        public MultiPult()
        {
            buttons = new ICommand[2];
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i] = new NoCommand();
            }
            commandsHistory = new Stack<ICommand>();
        }

        public void SetCommand(int number, ICommand com)
        {
            buttons[number] = com;
        }

        public void PressButton(int number)
        {
            buttons[number].Execute();
            commandsHistory.Push(buttons[number]);
        }
        public void PressUndoButton()
        {
            if (commandsHistory.Count > 0)
            {
                ICommand undoCommand = commandsHistory.Pop();
                undoCommand.Undo();
            }
        }
    }
}
