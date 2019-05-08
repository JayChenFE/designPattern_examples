using System;

namespace Log
{
    public class LogPriorityWrapper : LogWrapper
    {
        public LogPriorityWrapper(Log log) : base(log)
        {
        }

        public override void Write(string log)
        {
            SetPriority();
            base.Write(log);
        }

        public void SetPriority()
        {
            Console.WriteLine("......功能扩展,实现了记录优先级别");
        }
    }
}