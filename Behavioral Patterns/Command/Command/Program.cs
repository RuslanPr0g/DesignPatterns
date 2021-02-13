using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            TV tv = new TV();
            Volume volume = new Volume();
            MultiPult mPult = new MultiPult();
            mPult.SetCommand(0, new TVOnCommand(tv));
            mPult.SetCommand(1, new VolumeCommand(volume));
            mPult.PressButton(0);
            mPult.PressButton(1);
            mPult.PressButton(1);
            mPult.PressButton(1);
            mPult.PressUndoButton();
            mPult.PressUndoButton();
            mPult.PressUndoButton();
            mPult.PressUndoButton();

            Console.Read();
        }
    }
}
