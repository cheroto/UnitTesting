using System;
using NUnit.Framework;
using UnitTesting.Core;

namespace UnitTesting.Core.Tests
{
    [TestFixture]
    public class VerificationDigitCalculatorTest
    {
        private VerificationDigitCalculator _verificationDigitCalulator;

        [SetUp]
        public void Setup()
        {
            _verificationDigitCalulator = new VerificationDigitCalculator();
        } 

        [Test]
        [TestCase("46621468","6")]
        [TestCase("10907440","3")]
        [TestCase("45261246","9")]
        public void CalculateVerificationDigit_Success(string input, string expectedResult)
        {

            //Arrange


            //Act
            var result = _verificationDigitCalulator.CalculateVerificationDigit(input);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void CalculateVerificationDigit_ResultEqualsX()
        {

            //Arrange
            var input = "46621425";
            var expecteResult = "X";

            //Act
            var result = _verificationDigitCalulator.CalculateVerificationDigit(input);

            //Assert
            Assert.AreEqual(expecteResult, result);
        }

        [Test]
        public void CalculateVerificationDigit_InvalidInput()
        {

            //Arrange
            var input = "4662t425";
           

            //Act
            var ex = Assert.Throws<FormatException>(() => _verificationDigitCalulator.CalculateVerificationDigit(input));

            //Assert
            Assert.AreEqual("Invalid Input.", ex.Message);
        }

        [Test]
        public void CalculateVerificationDigit_InputSizeError()
        {
            //Arrange
            var input = "46621212425";
            var expectedResult = "Incorrect input size.";


            //Act
            var ex = Assert.Throws<FormatException>(() => _verificationDigitCalulator.CalculateVerificationDigit(input));

            //Assert
            Assert.AreEqual(expectedResult, ex.Message);
        }
    }
}
