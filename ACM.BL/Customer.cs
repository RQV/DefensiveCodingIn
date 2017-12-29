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
           decimal goalStepsCount = 0;
           decimal actualStepsCount = 0;

           if(string.IsNullOrWhiteSpace(goalSteps)) throw new ArgumentException("Goal must be entered");
           if(string.IsNullOrWhiteSpace(actualSteps)) throw new ArgumentException("Actual Steps must be entered", "actualSteps");
           if(!decimal.TryParse(goalSteps, out goalStepsCount)) throw new ArgumentException("Goals must be numeric");
           if(!decimal.TryParse(actualSteps, out actualStepsCount))throw new ArgumentException("Actual Steps must be numeric");

           return CalculatePercentOfGoalSteps(goalStepsCount, actualStepsCount);
       }
       public decimal CalculatePercentOfGoalSteps(decimal goalStepsCount, decimal actualStepsCount)
       {
           if (goalStepsCount <= 0) throw new ArgumentException("Goal must be greater than 0", "goalSteps");
           return Math.Round((actualStepsCount / goalStepsCount) * 100, 2);
       }
    }
}
