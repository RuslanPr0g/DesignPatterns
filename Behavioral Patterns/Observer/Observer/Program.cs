using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Stock stock = new Stock();
            Bank bank = new Bank("UnitBank", stock);
            Broker broker = new Broker("Ivan Inavovich", stock);
            // imitation of trades
            stock.Market();
            // the broker stops watching trades
            broker.StopTrade();
            // imitation of trades
            stock.Market();

            Console.Read();
        }
    }
}
