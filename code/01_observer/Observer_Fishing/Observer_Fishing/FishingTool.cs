using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Fishing
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
    /// 钓鱼工具抽象类
    /// 用来维护订阅者列表，并通知订阅者
    /// </summary>
    public abstract class FishingTool
    {
        private readonly List<ISubscriber> _subscribers;

        protected FishingTool()
        {
            _subscribers = new List<ISubscriber>();
        }

        public void AddSubscriber(ISubscriber subscriber)
        {
            if (!_subscribers.Contains(subscriber))
                _subscribers.Add(subscriber);
        }

        public void RemoveSubscriber(ISubscriber subscriber)
        {
            if (_subscribers.Contains(subscriber))
                _subscribers.Remove(subscriber);
        }

        public void Notify(FishType type)
        {
            foreach (var subscriber in _subscribers)
                subscriber.Update(type);
        }

    }
}
