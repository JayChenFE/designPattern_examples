using System;

namespace Log
{
    class Program
    {
        static void Main(string[] args)
        {
            Log dbLog = new DatabaseLog();
            LogWrapper logErrorWrapper1 = new LogErrorWrapper(dbLog);

            //扩展了记录错误严重级别
            logErrorWrapper1.Write("Log Message");
            Console.WriteLine();

            LogPriorityWrapper logPriorityWrapper1 = new LogPriorityWrapper(dbLog);
            //扩展了记录优先级别
            logPriorityWrapper1.Write("Log Message");
            Console.WriteLine();

            LogWrapper logErrorWrapper2 = new LogErrorWrapper(dbLog);
            LogPriorityWrapper logPriorityWrapper2 = new LogPriorityWrapper(logErrorWrapper2);
            //同时扩展了错误严重级别和优先级别
            logPriorityWrapper2.Write("Log Message");
        }
    }
}
