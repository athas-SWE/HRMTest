
namespace mvccemx.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public bool IsActive { get; set; }
    }
}
