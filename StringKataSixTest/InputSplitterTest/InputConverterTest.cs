using NUnit.Framework;
using StringKataSix.Services;
using System.Collections.Generic;

namespace StringKataSixTest.InputSplitterTest
{
    public  class InputConverterTest
    {
        private InputConverter _inputConverter;

        [SetUp]
        public void Setup()
        {
            _inputConverter = new InputConverter();
        }

        [Test]
        public void Given_NumbersWithCustomDelimeters_When_ConvertingToNumbers_Return_IntegerListOfNumbers()
        {
            //Arrange
            var inputNumbers = "//[***][%%%%]\n1***2%%%%3";
            var expected = new List<int> { 1,2,3 };
            //Act
            var actual = _inputConverter.ConvertToNumbers(inputNumbers);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
