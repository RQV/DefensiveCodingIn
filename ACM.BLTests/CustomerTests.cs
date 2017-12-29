using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTests
{
    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        public void CalculatePercentOfGoalStepsTestValid()
        {
            //-- Arrange
            var customer = new Customer();
            string goalStepsCount = "5000";
            string actualStepsCount = "2000";
            decimal expected = 40;

            //-- Act
            var actual = customer.CalculatePercentOfGoalSteps(goalStepsCount, actualStepsCount);

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculatePercentOfGoalStepsTestValidAndSame()
        {
            //-- Arrange
            var customer = new Customer();
            string goalStepsCount = "5000";
            string actualStepsCount = "5000";
            decimal expected = 100;

            //-- Act
            var actual = customer.CalculatePercentOfGoalSteps(goalStepsCount, actualStepsCount);

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculatePercentOfGoalStepsTestValidActualIsZero()
        {
            //-- Arrange
            var customer = new Customer();
            string goalStepsCount = "5000";
            string actualStepsCount = "0";
            decimal expected = 0;

            //-- Act
            var actual = customer.CalculatePercentOfGoalSteps(goalStepsCount, actualStepsCount);

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        //With invalid input
        [TestMethod]
        [ExpectedException (typeof(ArgumentException))]
        public void CalculatePercentOfGoalStepsTestGoalsIsNull()
        {
            //-- Arrange
            var customer = new Customer();
            string goalStepsCount = null;
            string actualStepsCount = "2000";

            //-- Act
            var actual = customer.CalculatePercentOfGoalSteps(goalStepsCount, actualStepsCount);

            //-- Assert            
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CalculatePercentOfGoalStepsTestGoalIsNotNumber()
        {
            //-- Arrange
            var customer = new Customer();
            string goalStepsCount = "none";
            string actualStepsCount = "2000";

            try
            {
                //-- Act
                var actual = customer.CalculatePercentOfGoalSteps(goalStepsCount, actualStepsCount);
            }
            catch (Exception ex)
            {
                //-- Assert 
                Assert.AreEqual("Goals must be numeric", ex.Message);
                throw;
            }
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CalculatePercentOfGoalStepsTestGoalIsWhiteSpace()
        {
            //-- Arrange
            var customer = new Customer();
            string goalStepsCount = "";
            string actualStepsCount = "2000";

            try
            {
                //-- Act
                var actual = customer.CalculatePercentOfGoalSteps(goalStepsCount, actualStepsCount);
            }
            catch (Exception ex)
            {
                //-- Assert 
                Assert.AreEqual("Goal must be entered", ex.Message);
                throw;
            }
        }
    }
}
