using NUnit.Framework;
using StringKataSix.Services;
using System;
using System.Collections.Generic;

namespace StringKataSixTest.ErrorHandlingTest
{
    public class ErrorHandlerTest
    {
        private ErrorHandler _errorHandler;

        [SetUp]
        public void Setup()
        {
            _errorHandler = new ErrorHandler();
        }

        [Test]
        public void Given_NumbersWithNegatives_When_NegetiveNumbersException_Should_ThrowException()
        {
            //Arrange
            var inputList = new List<int>() { 1, 2, 3, -3 };
            //Action and Assert
            Assert.Throws<Exception>(() => _errorHandler.NegativeNumbersException(inputList));
        }
    }
}
