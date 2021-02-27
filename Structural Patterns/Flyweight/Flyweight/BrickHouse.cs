using System;

namespace Flyweight
{
    class BrickHouse : House
    {
        public BrickHouse()
        {
            stages = 5;
        }

        public override void Build(double longitude, double latitude)
        {
            Console.WriteLine("Brick house was built with 5 stages; coordinates: {0} latitude and {1} longitude",
                latitude, longitude);
        }
    }
}
