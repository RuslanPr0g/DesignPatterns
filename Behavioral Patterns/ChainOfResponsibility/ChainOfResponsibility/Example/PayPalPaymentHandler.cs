using System;

namespace ChainOfResponsibility
{
    class PayPalPaymentHandler : PaymentHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.PayPalTransfer == true)
                Console.WriteLine("Do payment using PayPal");
            else if (Successor != null)
                Successor.Handle(receiver);
        }
    }
}
