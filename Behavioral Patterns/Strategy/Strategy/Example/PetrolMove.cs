using System;

namespace Strategy
{
    class PetrolMove : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Move using petrol...");
        }
    }
}
