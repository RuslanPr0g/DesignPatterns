using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Client
{
    class Client
    {
        private readonly AbstractProductA abstractProductA;
        private readonly AbstractProductB abstractProductB;

        public Client(AbstractFactory factory)
        {
            abstractProductB = factory.CreateProductB();
            abstractProductA = factory.CreateProductA();
        }

        public void Run()
        {
            Console.WriteLine("Running...");
        }
    }
}
