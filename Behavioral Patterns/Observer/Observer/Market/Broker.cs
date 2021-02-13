using System;

namespace Observer
{
    class Broker : IObserver
    {
        public string Name { get; set; }
        IObservable stock;
        public Broker(string name, IObservable obs)
        {
            this.Name = name;
            stock = obs;
            stock.RegisterObserver(this);
        }
        public void Update(object ob)
        {
            StockInfo sInfo = (StockInfo)ob;

            if (sInfo.USD > 30)
                Console.WriteLine("Broker {0} sell dollars;  Exchange dollar: {1}", this.Name, sInfo.USD);
            else
                Console.WriteLine("Broker {0} buys dollars;  Exchange dollar: {1}", this.Name, sInfo.USD);
        }
        public void StopTrade()
        {
            stock.RemoveObserver(this);
            stock = null;
        }
    }
}
