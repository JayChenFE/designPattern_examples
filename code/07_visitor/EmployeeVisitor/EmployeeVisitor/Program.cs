using System;

namespace EmployeeVisitor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Setup employee collection
            var e = new Employees();
            e.Attach(new Clerk());
            e.Attach(new Director());
            e.Attach(new President());
            
            // Employees are 'visited'
            e.Accept(new IncomeVisitor());
            e.Accept(new VacationVisitor());
            
            // Wait for user
            Console.Read();
        }
    }
}
