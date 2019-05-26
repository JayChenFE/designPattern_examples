using System;
using System.Collections;
using System.Collections.Generic;

namespace Calculator
{
    /// <summary>
    /// "Invoker"
    /// </summary>
    public class User
    {
        private readonly Calculator _calculator = new Calculator();
        private readonly List<Command> _commandList = new List<Command>();
        private int _current = 0;

        public void Redo(int levels)
        {
            Console.WriteLine("\n---- Redo {0} levels ", levels);

            for (int i = 0; i < levels; i++)
            {
                if (_current >= _commandList.Count - 1)
                {
                    break;
                }
                var command = _commandList[_current++];
                command.Execute();
            }
        }

        public void Undo(int levels)
        {
            Console.WriteLine("\n---- Undo {0} levels ", levels);
            // Perform undo operations
            for (int i = 0; i < levels; i++)
            {
                if (_current <= 0)
                {
                    break;
                }
                var command = _commandList[--_current];
                command.UnExecute();
            }
        }

        public void Compute(char @operator, int operand)
        {
            // Create command operation and execute it
            Command command = new CalculatorCommand(_calculator, @operator, operand);
            command.Execute();
            // Add command to undo list
            _commandList.Add(command);
            _current++;
        }
    }
}