using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern.Market.Products
{
    public class KievPapperoniPizza : KievPizza
    {
        public override void Prepare()
        {
            Console.WriteLine("Preparing in the capital with some papperoni...");
        }
    }
}
