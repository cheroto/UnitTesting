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
        public void CalculateVerificationDigit_Success()
        {

            //Arrange
            var input = "46621468";
            var expecteResult = 6;

            //Act
            var result = _verificationDigitCalulator.CalculateVerificationDigit(input);

            //Assert
            Assert.AreEqual(expecteResult, result);
        }
    }
}
