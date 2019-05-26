namespace Calculator
{
    /// <summary>
    /// "ConcreteCommand"
    /// </summary>
    public class CalculatorCommand : Command
    {
        private readonly Calculator _calculator;
        private readonly char _operator;
        private readonly int _operand;

        public CalculatorCommand(Calculator calculator, char @operator, int operand)
        {
            _operator = @operator;
            _operand = operand;
            _calculator = calculator;
        }

        public override void Execute()
        {
            _calculator.Operation(_operator, _operand);
        }
        public override void UnExecute()
        {
            _calculator.Operation(Undo(_operator), _operand);
        }

        private char Undo(char @operator)
        {
            char undo;
            switch (@operator)
            {
                case '+':
                    undo = '-';
                    break;
                case '-':
                    undo = '+';
                    break;
                case '*':
                    undo = '/';
                    break;
                case '/':
                    undo = '*';
                    break;
                default:
                    undo = ' ';
                    break;
            }
            return undo;
        }
    }
}