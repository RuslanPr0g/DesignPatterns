namespace Iterator.Essense
{
    class Client
    {
        public void Main()
        {
            Aggregate a = new ConcreteAggregate();
            Iterator i = a.CreateIterator();
            _ = i.First();
            while (!i.IsDone())
            {
                _ = i.Next();
            }
        }
    }
}
