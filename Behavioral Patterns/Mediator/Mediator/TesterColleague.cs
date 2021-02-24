using System;

namespace Mediator
{
    class TesterColleague : Colleague
    {
        public TesterColleague(Mediator mediator)
            : base(mediator)
        { }

        public override void Notify(string message)
        {
            Console.WriteLine("Message for tester: " + message);
        }
    }
}
