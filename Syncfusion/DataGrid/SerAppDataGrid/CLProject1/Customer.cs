using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLProject1
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBrith { get; set; }
        public Gender Gender { get; set; }
        public Department Department { get; set; }
        public string PhotoPath { get; set; }
        public void PrintCustomer(Customer cus)
        {
            Console.WriteLine(cus.CustomerId);
            Console.WriteLine(cus.FirstName);
            Console.WriteLine(cus.LastName);
            Console.WriteLine(cus.Email);
        }
    }

  
}
