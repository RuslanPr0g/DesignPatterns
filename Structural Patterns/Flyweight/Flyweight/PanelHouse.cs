using System;

namespace Flyweight
{
    class PanelHouse : House
    {
        public PanelHouse()
        {
            stages = 16;
        }

        public override void Build(double longitude, double latitude)
        {
            Console.WriteLine("Panel house was built with 16 floors; coordinates: {0} latitude and {1} longitude",
                latitude, longitude);
        }
    }
}
