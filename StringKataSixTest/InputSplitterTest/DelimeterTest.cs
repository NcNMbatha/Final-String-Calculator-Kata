using NUnit.Framework;
using StringKataSix.Services;
using System.Collections.Generic;

namespace StringKataSixTest.InputSplitterTest
{
    public class DelimeterTest
    {
        private Delimeter _delimeter;

        [SetUp]
        public void Setup()
        {
            _delimeter = new Delimeter();
        }

        [Test]
        public void Given_NumbersWithCustomDelimeters_When_ExtractingDelimetersInBrackets_Return_CustomDelimeters()
        {
            //Arrange
            var inputNumbers = "//[***][%%%%]\n1***2%%%%3";
            var expected = new List<string> { "***", "%%%%" };
            //Act
            var actual = _delimeter.ExtractDelimetersInBrackets(inputNumbers);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Given_NumbersWithCustomDelimeters_When_GettingDelimeterList_Return_ListOfAllDelimeters()
        {
            //Arrange
            var inputNumbers = "//[***][%%%%]\n1***2%%%%3";
            var expected = new List<string> { ",","\n","***", "%%%%" };
            //Act
            var actual = _delimeter.GetDelimeterList(inputNumbers);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Given_NumbersWithDelimeters_When_GettingDelimeterList_Return_ListOfAllDelimeters()
        {
            //Arrange
            var inputNumbers = "//***\n1***2,3";
            var expected = new List<string> { ",", "\n", "***" };
            //Act
            var actual = _delimeter.GetDelimeterList(inputNumbers);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
