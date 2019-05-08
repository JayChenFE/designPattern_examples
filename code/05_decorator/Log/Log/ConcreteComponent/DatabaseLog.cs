using System;

namespace Log
{
    public class DatabaseLog : Log
    {
        public override void Write(string log)
        {
            Console.WriteLine($"记录{log}到数据库");
        }
    }
}