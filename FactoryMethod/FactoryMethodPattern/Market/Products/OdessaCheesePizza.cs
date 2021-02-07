using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern.Market.Products
{
    public class OdessaCheesePizza : OdessaPizza
    {
        public override void Prepare()
        {
            Console.WriteLine("Preparing with lots of cheese...");
        }
    }
}
