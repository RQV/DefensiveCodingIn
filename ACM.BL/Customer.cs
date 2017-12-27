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
       public decimal CalculatePercentOfGoalSteps(string goalSteps, string actualSteps)
       {
           decimal result = 0;
           decimal goalStepsCount = 0;
           decimal actualStepsCount = 0;
           decimal.TryParse(goalSteps, out goalStepsCount);
           decimal.TryParse(actualSteps, out actualStepsCount);

           if (goalStepsCount > 0)
           { 
               result = (actualStepsCount / goalStepsCount) * 100;
           }
           return result;
       }
    }
}
