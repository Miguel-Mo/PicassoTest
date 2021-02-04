using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace PicassoTest.Tests
{
    class FizzBuzzTests
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void FizzBuzz_MultipleOfThreeAndFive_ReturnsFizzBuzz()
        {
            //Arrange
            int number = 15;

            //Act
            var result = FizzBuzz.GetOutput(number);

            //Assert
            Assert.AreEqual(result, "FizzBuzz");
        }

        [Test]
        public void FizzBuzz_MultipleOfThree_ReturnsFizzBuzz()
        {
            //Arrange
            int number = 12;

            //Act
            var result = FizzBuzz.GetOutput(number);

            //Assert
            Assert.AreEqual(result, "Fizz");
        }

        [Test]
        public void FizzBuzz_MultipleOfFive_ReturnsFizzBuzz()
        {
            //Arrange
            int number = 20;

            //Act
            var result = FizzBuzz.GetOutput(number);

            //Assert
            Assert.AreEqual(result, "Buzz");
        }

        [Test]
        public void FizzBuzz_IsNotMultipleOfThreeOrFive_ReturnsFizzBuzz()
        {
            //Arrange
            int number = 17;

            //Act
            var result = FizzBuzz.GetOutput(number);
            var numbertostring = number.ToString();

            //Assert
            Assert.AreEqual(result, numbertostring);
        }
    }
}
