using System;

namespace State
{
    class GasWaterState : IWaterState
    {
        public void Heat(Water water)
        {
            Console.WriteLine("Heat gas");
        }

        public void Frost(Water water)
        {
            Console.WriteLine("Frost water (gas)");
            water.State = new LiquidWaterState();
        }
    }
}
