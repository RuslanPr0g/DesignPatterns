namespace Decorator
{
    class TomatoPizza : PizzaDecorator
    {
        public TomatoPizza(Pizza p)
            : base(p.Name + ", with tomatoes", p)
        { }

        public override int GetCost()
        {
            return pizza.GetCost() + 3;
        }
    }
}
