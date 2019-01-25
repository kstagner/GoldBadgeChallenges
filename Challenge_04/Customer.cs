using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_04
{
    public enum CType { Current, Potential, Past}
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public CType CType { get; set; }
        public string Email { get; set; }

        public Customer(string firstName, string lastName, CType cType, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            CType = cType;
            Email = email;
        }

        public Customer()
        {
            

        }
    
              
    
    }
}
