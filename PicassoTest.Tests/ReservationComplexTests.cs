using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace PicassoTest.Tests
{
    class ReservationComplexTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ReservationComplex_MoneyBiggerThanPrice_ReturnsZero()
        {
            //Arrange
            var reservationComplex = new ReservationComplex()
            {
                Price=500
            };
            var paco = new UserComplex()
            {
                Money = 1000
            }; 

            //Act
            var result = reservationComplex.PayReservation(paco);

            //Assert
            Assert.AreEqual(result, 0);
        }

        [Test]
        public void ReservationComplex_MoneySmallerThanPrice_ReturnsZero()
        {
            //Arrange
            var reservationComplex = new ReservationComplex()
            {
                Price = 500
            };
            var paco = new UserComplex()
            {
                Money = 200
            };

            //Act
            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => reservationComplex.PayReservation(paco));
        }

        [Test]
        public void ReservationComplex_MoneyEqualThanPrice_ReturnsZero()
        {
            //Arrange
            var reservationComplex = new ReservationComplex()
            {
                Price = 1000
            };
            var paco = new UserComplex()
            {
                Money = 1000
            };

            //Act
            var result = reservationComplex.PayReservation(paco);
            //Assert
            Assert.AreEqual(result, 0);
        }
    }
}
