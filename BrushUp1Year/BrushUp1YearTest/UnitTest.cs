
using System;
using BrushUp1Year;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BrushUp1YearTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDoors5Pass()
        {
            // Arrange
            Car newCar = new Car(Car.Color.Black, 5, "A4", "AB56789");
            // Act

            // Assert
            Assert.IsNotNull(newCar);
        }

        [TestMethod]
        public void TestDoors6Fail()
        {
            // Arrange
            Car newCar = new Car(Car.Color.Black, 6, "A4", "AB56789");
            // Act

            // Assert
            Assert.IsNotNull(newCar);
        }
    }
}
