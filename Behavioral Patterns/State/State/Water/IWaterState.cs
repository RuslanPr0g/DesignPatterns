namespace State
{
    interface IWaterState
    {
        void Heat(Water water);
        void Frost(Water water);
    }
}
