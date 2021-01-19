using FactoryMethodPattern.Market.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern.Market.Stores
{
    public class KievPizzaStore : PizzaStore
    {
        public override IPizza CreatePizza(string type)
        {
            return type switch
            {
                "Papperoni" => new KievPapperoniPizza(),
                _ => null,
            };
        }
    }
}
