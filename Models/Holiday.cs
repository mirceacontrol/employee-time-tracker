namespace EmployeeTimeTracker.Models
{
    public class Holiday
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Reason { get; set; } = string.Empty;
        public int EmployeeId { get; set; }
        public Employee? Employee { get; set; }
    }
}
