using System;

namespace Observer
{
    class Bank : IObserver
    {
        public string Name { get; set; }
        IObservable stock;
        public Bank(string name, IObservable obs)
        {
            this.Name = name;
            stock = obs;
            stock.RegisterObserver(this);
        }
        public void Update(object ob)
        {
            StockInfo sInfo = (StockInfo)ob;

            if (sInfo.Euro > 40)
                Console.WriteLine("Bank {0} sell euro;  Exchange euro: {1}", this.Name, sInfo.Euro);
            else
                Console.WriteLine("Bank {0} buy euro;  Exchange euro: {1}", this.Name, sInfo.Euro);
        }
    }
}
