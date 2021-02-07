using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern.Market.Products
{
    public class OdessaClamPizza : OdessaPizza
    {
        public override void Prepare()
        {
            Console.WriteLine("Preparing with clam...");
        }
    }
}
