using System;

namespace ChainOfResponsibility
{
    class BankPaymentHandler : PaymentHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.BankTransfer == true)
                Console.WriteLine("Do transaction");
            else if (Successor != null)
                Successor.Handle(receiver);
        }
    }
}
