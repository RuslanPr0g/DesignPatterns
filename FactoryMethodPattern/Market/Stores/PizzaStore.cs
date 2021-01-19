using FactoryMethodPattern.Market.Ingridients;
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

            if(pizza is null)
            {
                Console.WriteLine("No pizza in the warehouse.");

                return null;
            }

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            
            return pizza;
        }

        public abstract IPizza CreatePizza(string type);
    }
}
