using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Fishing
{
    /// <summary>
    /// 鱼竿
    /// </summary>
    public class FishingRod : FishingTool
    {
        public void Fishing()
        {
            Console.WriteLine("开始下钩！");

            //用随机数模拟鱼咬钩，若随机数为偶数，则为鱼咬钩
            if (new Random().Next() % 2 == 0)
            {
                var type = (FishType)new Random().Next(0, 5);
                Console.WriteLine("铃铛：叮叮叮，鱼儿咬钩了");
                Notify(type);
            }
        }
    }
}
