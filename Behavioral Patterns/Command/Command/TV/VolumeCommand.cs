namespace Command
{
    class VolumeCommand : ICommand
    {
        Volume volume;
        public VolumeCommand(Volume v)
        {
            volume = v;
        }
        public void Execute()
        {
            volume.RaiseLevel();
        }

        public void Undo()
        {
            volume.DropLevel();
        }
    }
}
