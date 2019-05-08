using System;

namespace Log
{
    public class LogErrorWrapper : LogWrapper
    {
        public LogErrorWrapper(Log log) : base(log)
        {
        }

        public override void Write(string log)
        {
            SetError();
            base.Write(log);
        }

        public void SetError()
        {
            Console.WriteLine("......功能扩展，实现了记录错误严重级别");
        }
    }
}