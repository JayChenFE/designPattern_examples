using System;
using System.Threading;

namespace Observer_Fishing_Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("委托实现的观察者模式：");
            Console.WriteLine("=======================");
            //1、初始化鱼竿
            var fishingRod = new FishingRod();

            //2、声明垂钓者
            var fisher = new FishingMan("fisher1");

            //3、注册观察者
            fishingRod.FishingEvent += fisher.Update;

            //4、循环钓鱼
            while (fisher.FishCount < 5)
            {
                fishingRod.Fishing();
                Console.WriteLine("-------------------");
                //睡眠0.5s
                Thread.Sleep(500);
            }
        }
    }
}
