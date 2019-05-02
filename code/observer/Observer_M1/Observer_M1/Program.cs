using System;

namespace Observer_M1
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Stock ms = new Microsoft("Microsoft", 120.00);

    //        ms.AddObserver(new Investor("Tom"));

    //        ms.AddObserver(new Investor("Jerry"));

    //        ms.Update();

    //        Console.ReadLine();
    //    }
    //}

    class Program
    {
        static void Main(string[] args)
        {
            Stock1 stock = new Stock1("Microsoft", 120.00);

            Investor1 investor = new Investor1("Tom");

            stock.NotifyEvent += investor.SendData;

            stock.Update();

            Console.ReadLine();
        }
    }

    public class Stock1
    {
        public event Action<object> NotifyEvent;

        public Stock1(string symbol, double price)

        {
            this.Symbol = symbol;

            this.Price = price;
        }

        public void Update()
        {
            OnNotifyChange();
        }

        public void OnNotifyChange()
        {
            NotifyEvent?.Invoke(this);
        }

        public string Symbol { get; }

        public double Price { get; }
    }

    public class Investor1
    {
        private readonly string _name;

        public Investor1(string name)
        {
            this._name = name;
        }

        public void SendData(object obj)
        {
            if (obj is Stock1 stock)
            {
                Console.WriteLine("Notified {0} of {1}'s " + "change to {2:C}",
                                   _name, stock.Symbol, stock.Price);
            }
        }
    }
}
