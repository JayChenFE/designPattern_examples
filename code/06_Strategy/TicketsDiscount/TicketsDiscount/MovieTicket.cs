namespace TicketsDiscount
{
    public class MovieTicket
    {
        private double _price;
        private readonly IDiscount _discount; //维持一个对抽象折扣类的引用

        //注入一个折扣类对象
        public MovieTicket(IDiscount discount)
        {
            this._discount = discount;
        }

        public double Price
        {
            get => _discount.Calculate(this._price);
            set => _price = value;
        }
    }
}