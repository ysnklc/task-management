using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Entity;


namespace _01_Entity
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string IdentityNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Mail { get; set; }

        
        //private string fullName;
        
        //public string FullName
        //{
        //    get { return fullName = FirstName+" "+LastName; }
            
        //}
        public int EmployeeRoleId { get; set; }
        public EmployeeRole EmployeeRole { get; set; }

    
      
    }
}
