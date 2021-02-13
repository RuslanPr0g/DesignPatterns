using System;
using System.Threading.Tasks;

namespace Command
{
    class Microwave
    {
        public void StartCooking(int time)
        {
            Console.WriteLine("Heat the food");
            Task.Delay(time).GetAwaiter().GetResult();
        }

        public void StopCooking()
        {
            Console.WriteLine("Food heated!");
        }
    }
}
