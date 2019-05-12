using System;

namespace TicketsDiscount
{
    public class StudentDiscount : IDiscount
    {
        public double Calculate(double price)
        {
            Console.WriteLine("学生票：");
            return price * 0.8;
        }
    }
}