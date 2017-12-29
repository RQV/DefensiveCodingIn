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
    }
}
