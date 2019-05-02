using System;
using System.Collections.Generic;

namespace Observer_M1
{
    public interface IObserver
    {
        void SendData(Stock stock);
    }

    public abstract class Stock
    {
        private readonly List<IObserver> _observers = new List<IObserver>();

        protected Stock(string symbol, double price)

        {
            this.Symbol = symbol;

            this.Price = price;
        }

        public void Update()

        {
            foreach (IObserver ob in _observers)

            {
                ob.SendData(this);
            }

        }

        public void AddObserver(IObserver observer)

        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)

        {
            _observers.Remove(observer);
        }

        public string Symbol { get; }

        public double Price { get; }
    }

    public class Microsoft : Stock
    {
        public Microsoft(string symbol, double price) : base(symbol, price)

        { }
    }

    public class Investor : IObserver
    {
        private readonly string _name;

        public Investor(string name)

        {
            this._name = name;
        }

        public void SendData(Stock stock)

        {
            Console.WriteLine("Notified {0} of {1}'s " + "change to {2:C}", _name, stock.Symbol, stock.Price);

        }

    }

}