using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Water water = new Water(new LiquidWaterState());
            water.Heat();
            water.Frost();
            water.Frost();

            Console.Read();
        }
    }
}
