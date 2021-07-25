using System;

namespace ServerSideModel
{
    public class Employees
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBrith { get; set; }
        public Gender Gender { get; set; }
        public Departments Department { get; set; }
        public string PhotoPath { get; set; }
    }
}
