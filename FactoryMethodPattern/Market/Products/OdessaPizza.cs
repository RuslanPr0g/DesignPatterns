using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern.Market.Products
{
    public class OdessaPizza : IPizza
    {
        public void Bake()
        {
            Console.WriteLine("Backing at 360, near the sea...");
        }

        public void Box()
        {
            Console.WriteLine("Boxing with OdessaBoxOrg box...");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting as squares...");
        }

        public void Prepare()
        {
            Console.WriteLine("Preparing...");
        }
    }
}
