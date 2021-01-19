using FactoryMethodPattern.Market.Products;
using FactoryMethodPattern.Market.Stores;
using System;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // The Factory Method Pattern

            start:

            Console.WriteLine("Which store to visit?");
            string storeType = Console.ReadLine();

            PizzaStore store;

            if (storeType == "Odessa")
                store = new OdessaPizzaStore();
            else
                store = new KievPizzaStore();

            Console.WriteLine("Make your order: ");
            string pizzaType = Console.ReadLine();
            // Papperoni - kiev, Cheese, Clam - odessa.

            store.OrderPizza(pizzaType);

            goto start;
        }
    }
}
