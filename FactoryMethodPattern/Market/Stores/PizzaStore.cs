using FactoryMethodPattern.Market.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern.Market.Stores
{
    public abstract class PizzaStore
    {
        public IPizza OrderPizza(string type)
        {
            IPizza pizza = CreatePizza(type);



            return pizza;
        }

        public abstract IPizza CreatePizza(string type);
    }
}
