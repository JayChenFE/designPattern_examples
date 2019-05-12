using System;

namespace TicketsDiscount
{
    class Program
    {
        static void Main(string[] args)
        {

            #region old

            OldMovieTicket oldMovieTicket = new OldMovieTicket
            {
                Price = 60.0 //原始票价
            };

            Console.WriteLine($"原始价为：{oldMovieTicket.Price}");
            Console.WriteLine("---------------------------------");

            Console.WriteLine($"折后价为：{oldMovieTicket.GetPrice("student")}");//学生票
            Console.WriteLine("---------------------------------");

            Console.WriteLine($"折后价为：{oldMovieTicket.GetPrice("children")}");//儿童票
            Console.WriteLine("---------------------------------");

            Console.WriteLine($"折后价为：{oldMovieTicket.GetPrice("vip")}");//vip票
            Console.WriteLine("---------------------------------");

            #endregion

            #region new

            

            #endregion

        }
    }

    //电影票类
    class OldMovieTicket
    {
        /// <summary>
        /// 电影票价格
        /// </summary>
        public double Price { get; set; }

        //计算打折之后的票价
        public double GetPrice(string type)
        {

            //学生票折后票价计算
            if (type.Equals("student", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("学生票：");
                return Price * 0.8;
            }
            
            //儿童票折后票价计算
            if (type.Equals("children", StringComparison.OrdinalIgnoreCase)
                && Price >= 20)
            {
                Console.WriteLine("儿童票：");
                return Price - 10;
            }
            
            //VIP票折后票价计算
            if (type.Equals("vip", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("VIP票：");
                Console.WriteLine("增加积分！");
                return Price * 0.5;
            }

            return Price; //如果不满足任何打折要求，则返回原始票价
        }
    }
}
