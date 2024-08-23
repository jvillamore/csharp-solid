namespace OpenClose
{
    public interface Employee
    {
        public string Fullname { get; set; }
        public int HoursWorked { get; set; }

        decimal GetCalculateSalaryMonthly();
    }
}