using System;
using System.Collections.Generic;

namespace Calculator
{
    /// <summary>
    /// "Receiver"
    /// </summary>
    public class Calculator
    {

        private int _curr = 0;

        public void Operation(char @operator, int operand)
        {
            switch (@operator)
            {
                case '+': _curr += operand; break;
                case '-': _curr -= operand; break;
                case '*': _curr *= operand; break;
                case '/': _curr /= operand; break;
            }
            Console.WriteLine($"Current value = {_curr} (afterOperating: {@operator} {operand})");
        }
    }
}