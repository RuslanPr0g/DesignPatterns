using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class ConcreteFactory1 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ConcreteProductA1();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ConcreteProductB1();
        }
    }
}
