using NUnit.Framework;
using StringKataSix.Services;
using System.Collections.Generic;

namespace StringKataSixTest.InputSplitterTest
{
    public class ExtractNumbersTest
    {
        private ExtractNumbers _extractNumbers;

        [SetUp]
        public void Setup()
        {
            _extractNumbers = new ExtractNumbers();
        }

        [Test]
        public void Given_NumbersWithDelimeters_When_ExtractingNumbers_Return_ListOfNumbers()
        {
            //Arrange
            var inputNumbers = "//%%%\n1%%%2,3";
            var expected = new List<string>(){"1","2","3" };
            //Act
            var actual = _extractNumbers.ExtractNumbersFromTextInput(inputNumbers);
            //Assert
            Assert.AreEqual(expected, actual);  
        }
    }
}
