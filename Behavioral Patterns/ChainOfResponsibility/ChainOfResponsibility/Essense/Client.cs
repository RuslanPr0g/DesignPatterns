using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    class Client
    {
        void Main()
        {
            Handler h1 = new ConcreteHandler1();
            Handler h2 = new ConcreteHandler2();
            h1.Successor = h2;
            h1.HandleRequest(2);
        }
    }
}
