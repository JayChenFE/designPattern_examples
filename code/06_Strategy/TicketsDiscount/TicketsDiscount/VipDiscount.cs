using System;

namespace TicketsDiscount
{
    public class VipDiscount : IDiscount
    {
        public double Calculate(double price)
        {
            Console.WriteLine("VIP票：");
            Console.WriteLine("增加积分！");
            return price * 0.5;
        }
    }
}