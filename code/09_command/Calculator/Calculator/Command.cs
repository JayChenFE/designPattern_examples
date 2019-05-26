namespace Calculator
{
    /// <summary>
    /// "Command"
    /// </summary>
    public abstract class Command
    {
        public abstract void Execute();
        public abstract void UnExecute();
    }
}