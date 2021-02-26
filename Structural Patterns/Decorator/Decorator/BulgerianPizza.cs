namespace Decorator
{
    class BulgerianPizza : Pizza
    {
        public BulgerianPizza()
            : base("Bolgarian pizza")
        { }
        public override int GetCost()
        {
            return 8;
        }
    }
}
