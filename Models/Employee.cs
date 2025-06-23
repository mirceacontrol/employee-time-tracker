namespace EmployeeTimeTracker.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        // Add more fields as you go (Department, etc.)
        public List<WorkSession>? WorkSessions { get; set; }
        public List<Holiday>? Holidays { get; set; }
    }
}
