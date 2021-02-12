using System;

namespace Strategy
{
    class ElectricMove : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Move using electricity...");
        }
    }
}
