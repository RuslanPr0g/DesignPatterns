using FactoryMethodPattern.Market.Ingridients;
using FactoryMethodPattern.Market.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern.Market.Stores
{
    public class OdessaPizzaStore : PizzaStore
    {
        public override IPizza CreatePizza(string type)
        {
            return type switch
            {
                "Cheese" => new OdessaCheesePizza(),
                "Clam" => new OdessaClamPizza(),
                _ => null,
            };
        }
    }
}
