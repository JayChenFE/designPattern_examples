using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Fishing
{
    /// <summary>
    /// 订阅者（观察者）接口
    /// 由具体的订阅者实现Update()方法
    /// </summary>
    public interface ISubscriber
    {
        void Update(FishType type);
    }
}
