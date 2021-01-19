using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern.Market.Products
{
    public class KievPizza : IPizza
    {
        public void Bake()
        {
            Console.WriteLine("Backing at 360...");
        }

        public void Box()
        {
            Console.WriteLine("Boxing with KievBoxOrg box...");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting as triangles...");
        }

        public virtual void Prepare()
        {
            Console.WriteLine("Preparing in the capital...");
        }
    }
}
