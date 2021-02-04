using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace PicassoTest.Tests
{
    class DemeritPointsCalculatorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CalculateDemeritPoints_SpeedIsSmallerSpeedLimit_ReturnsZero()
        {
            //Arrange
            var demeritPointsCalculator = new DemeritPointsCalculator();
            int speed = 60;

            //Act
            var result = demeritPointsCalculator.CalculateDemeritPoints(speed);

            //Assert
            Assert.AreEqual(result, 0);
        }

        [Test]
        public void CalculateDemeritPoints_SpeedIsBiggerMaxSpeed_ThrowsNullException()
        {
            //Arrange
            var demeritPointsCalculator = new DemeritPointsCalculator();
            int speed = 305;

            //Assert //Act
            Assert.Throws<ArgumentOutOfRangeException>(() => demeritPointsCalculator.CalculateDemeritPoints(speed));
        }

        [Test]
        public void CalculateDemeritPoints_SpeedIsSmallerZero_ThrowsNullException()
        {
            //Arrange
            var demeritPointsCalculator = new DemeritPointsCalculator();
            int speed = -1;

            //Assert //Act
            Assert.Throws<ArgumentOutOfRangeException>(() => demeritPointsCalculator.CalculateDemeritPoints(speed));
        }

        [Test]
        public void CalculateDemeritPoints_ItWorks_demeritPoints()
        {
            //Arrange
            var demeritPointsCalculator = new DemeritPointsCalculator();
            int speed = 80;

            //Act
            var result = demeritPointsCalculator.CalculateDemeritPoints(speed);

            //Assert
            Assert.AreEqual(result, 3);
        }

    }
}
