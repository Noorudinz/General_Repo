using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPOD
{
    class Employee
    {
        //When we allow the function CheckEmployee to be accessed from the outside world and hide the internal processes
        //like IsEmployeeExist and DeleteEmployee as an abstraction.
        public void CheckEmployee(int Id)
        {

            IsEmployeeExist(1);
            DeleteEmployee(2);
        }

        //When we convert the functions IsEmployeeExist and DeleteEmployee access modifiers to private,
        //then we have done encapsulation.

        private bool IsEmployeeExist(int Id)
        {
            return true;
        }

        private bool DeleteEmployee(int Id)
        {
            return true;
        }
    }

    class Encapsulation_and_Abstraction
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.CheckEmployee(1);
        }

    }
}
