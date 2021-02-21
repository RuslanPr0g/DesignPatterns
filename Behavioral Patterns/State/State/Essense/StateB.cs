namespace State
{
    class StateB : State
    {
        public override void Handle(Context context)
        {
            context.State = new StateA();
        }
    }
}
