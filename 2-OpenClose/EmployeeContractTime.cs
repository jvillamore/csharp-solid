namespace OpenClose
{
    public class EmployeeContractTime : Employee
    {
        public EmployeeContractTime(string fullname, int hoursWorked)
        {
            Fullname = fullname;
            HoursWorked = hoursWorked;
        }

        public string Fullname { get; set; }
        public int HoursWorked { get; set; }

        public decimal GetCalculateSalaryMonthly()
        {
            decimal hourValue = 10000M;
            decimal salary = hourValue * HoursWorked;
            return salary;
        }
    }
}