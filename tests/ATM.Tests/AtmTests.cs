using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ATM;


namespace ATM.Tests
{
    [TestClass]
    public class AtmTests
    {
        [TestMethod]
        public void CalculateTest()
        {
            // Arrange
            var ATM = new Atm();

            // Act
            var expected = new int[] {0, 0, 0, 0, 1, 4};
            ATM.Calculate(450);

            // Assert
            CollectionAssert.AreEqual(expected, ATM.GetArray());
        }
    }
}
