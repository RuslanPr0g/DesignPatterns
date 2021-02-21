using System;

namespace State
{
    class SolidWaterState : IWaterState
    {
        public void Heat(Water water)
        {
            Console.WriteLine("Heat solid to liquid");
            water.State = new LiquidWaterState();
        }

        public void Frost(Water water)
        {
            Console.WriteLine("Frost more solid");
        }
    }
}
