namespace OpenClose
{
    public class EmployeeContractTime : Employee
    {
        public EmployeeContractTime(string fullname, int hoursWorked)
        {
            Fullname = fullname;
            HoursWorked = hoursWorked;
        }

        public override decimal CalculateSalaryMonthly()
        {
            decimal hourValue = 10000M;
            decimal salary = hourValue * HoursWorked;
            return salary;
        }
    }
}