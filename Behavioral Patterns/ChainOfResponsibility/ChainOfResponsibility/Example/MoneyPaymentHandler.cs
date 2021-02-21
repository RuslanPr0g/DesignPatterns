using System;

namespace ChainOfResponsibility
{
    class MoneyPaymentHandler : PaymentHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.MoneyTransfer == true)
                Console.WriteLine("Do payment using money");
            else if (Successor != null)
                Successor.Handle(receiver);
        }
    }
}
