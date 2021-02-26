using System;

namespace Adapter
{
    class Camel : IAnimal
    {
        public void Move()
        {
            Console.WriteLine("Camel is going on sand");
        }
    }
}
