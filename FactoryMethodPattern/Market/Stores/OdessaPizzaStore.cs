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
            switch (type)
            {
                case "Odessa":
                    break;
                case "Kiev":
                    break;
                default: 
                    break;
            }
        }
    }
}
