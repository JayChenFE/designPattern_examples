using System;

namespace EmployeeVisitor
{
    /// <summary>
    /// "ConcreteVisitor1"
    /// </summary>
    public class IncomeVisitor : IVisitor
    {
        public void Visit(Element element)
        {
            // Provide 10% pay raise
            if (!(element is Employee employee))
            {
                return;
            }
            employee.Income *= 1.10;
            Console.WriteLine("{0} {1}'s new income: {2:C}", employee.GetType().Name, employee.Name,
                employee.Income);
        }
    }
}