using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            ManagerMediator mediator = new ManagerMediator();
            Colleague customer = new CustomerColleague(mediator);
            Colleague programmer = new ProgrammerColleague(mediator);
            Colleague tester = new TesterColleague(mediator);
            mediator.Customer = customer;
            mediator.Programmer = programmer;
            mediator.Tester = tester;
            customer.Send("Here is my order, it needs to make a program.");
            programmer.Send("Application is ready.");
            tester.Send("App was tested and production ready.");

            Console.Read();
        }
    }
}
