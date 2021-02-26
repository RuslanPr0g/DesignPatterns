using System;

namespace Adapter
{
    class Auto : ITransport
    {
        public void Drive()
        {
            Console.WriteLine("Car is driving on the road");
        }
    }
}
