namespace Liskov
{
    public class EmployeeContractor : Employee
    {

        public EmployeeContractor(string fullname, int hoursWorked, int extrahours) : base(fullname, hoursWorked)
        {
        }
        public override decimal CalculateSalary()
        {
            decimal hourValue = 40;
            return hourValue * (HoursWorked);
        }
    }
}