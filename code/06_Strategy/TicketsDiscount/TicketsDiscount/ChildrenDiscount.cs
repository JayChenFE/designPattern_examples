using System;

namespace TicketsDiscount
{
    internal class ChildrenDiscount : IDiscount
    {
        public double Calculate(double price)
        {
            Console.WriteLine("儿童票：");
            return price - 10;
        }
    }
}