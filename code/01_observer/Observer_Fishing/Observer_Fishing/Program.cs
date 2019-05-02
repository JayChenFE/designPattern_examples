using System;
using System.Threading;

namespace Observer_Fishing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("简单实现的观察者模式：");
            Console.WriteLine("=======================");
            //1、初始化鱼竿
            var fishingRod = new FishingRod();

            //2、声明垂钓者
            var fisher1 = new FishingMan("fisher1");
            var fisher2 = new FishingMan("fisher2");

            //3、将垂钓者观察鱼竿
            fishingRod.AddSubscriber(fisher1);
            fishingRod.AddSubscriber(fisher2);

            //4、循环钓鱼
            while (fisher1.FishCount < 5 || fisher2.FishCount < 5)
            {
                fishingRod.Fishing();
                Console.WriteLine("-------------------");
                //睡眠0.5s
                Thread.Sleep(500);
            }
        }
    }
}
