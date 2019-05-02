using System;

namespace Observer_Fishing_Delegate
{
    /// <summary>
    /// 鱼的品类枚举
    /// </summary>
    public enum FishType
    {
        鲫鱼,
        鲤鱼,
        黑鱼,
        青鱼,
        草鱼,
        鲈鱼
    }

    /// <summary>
    /// 鱼竿
    /// </summary>
    public class FishingRod
    {
        public delegate void FishingHandler(FishType type); //声明委托
        public event FishingHandler FishingEvent; //声明事件

        public void Fishing()
        {
            Console.WriteLine("开始下钩！");

            //用随机数模拟鱼咬钩，若随机数为偶数，则为鱼咬钩
            if (new Random().Next() % 2 == 0)
            {
                var type = (FishType)new Random().Next(0, 5);
                Console.WriteLine("铃铛：叮叮叮，鱼儿咬钩了");
                FishingEvent?.Invoke(type);
            }
        }
    }
}