namespace EmployeeTimeTracker.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public List<WorkSession>? WorkSessions { get; set; }
        public List<Holiday>? Holidays { get; set; }
    }
}
