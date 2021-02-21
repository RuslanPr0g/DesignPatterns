using System;

namespace State
{
    class LiquidWaterState : IWaterState
    {
        public void Heat(Water water)
        {
            Console.WriteLine("Heat water tp gas");
            water.State = new GasWaterState();
        }

        public void Frost(Water water)
        {
            Console.WriteLine("Frost water to solid");
            water.State = new SolidWaterState();
        }
    }
}
