namespace Log
{
    public class LogWrapper: Log
    {
        private readonly Log _log;

        public LogWrapper(Log log)
        {
            _log = log;
        }

        public override void Write(string log)
        {
            _log.Write(log);
        }
    }
}