using System;

namespace EmployeeVisitor
{
    public class VacationVisitor : IVisitor
    {
        public void Visit(Element element)
        {
            // Provide 3 extra vacation days
            if (element is Employee employee)
            {
                Console.WriteLine("{0} {1}'s new vacation days: {2}", employee.GetType().Name, employee.Name, employee.VacationDays);

            }
        }
    }
}