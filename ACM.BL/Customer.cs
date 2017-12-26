using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
   public class Customer
    {
       public int CustomerId { get; set; }
       public string FirstName { get; set; }
       public string LastName { get; set; }
       public string Email { get; set; }

       public void ValidateEmail()
       {
           //Code to validate the customer email
       }
    }
}
