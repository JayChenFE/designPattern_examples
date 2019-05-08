using System;

namespace Log
{
    public class TextFileLog : Log
    {
        public override void Write(string log)
        {
            Console.WriteLine($"记录{log}到文本");
        }
    }
}