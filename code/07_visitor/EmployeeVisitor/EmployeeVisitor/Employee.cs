namespace EmployeeVisitor
{
    /// <summary>
    /// ConcreteElement
    /// </summary>
    public class Employee : Element
    {
        // Constructor
        public Employee(string name, double income, int vacationDays)
        {
            Name = name;
            Income = income;
            VacationDays = vacationDays;
        }
        // Properties
        public string Name { get; set; }

        public double Income { get; set; }

        public int VacationDays { get; set; }
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}