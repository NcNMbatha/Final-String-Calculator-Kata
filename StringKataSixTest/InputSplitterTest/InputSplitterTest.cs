using NUnit.Framework;
using StringKataSix.Services;

namespace StringKataSixTest.InputSplitterTest
{
    public class InputSplitterTest
    {
        private InputSplitter _inputSplitter;

        [SetUp]
        public void Setup()
        {
            _inputSplitter = new InputSplitter();
        }

        [Test]
        public void Given_InputNumbersSeperatedbyDelimeter_When_SplittingForNumbers_Return_NumbersWithSeperatingDelimeters()
        {
            //Arrange
            var inputNumbers = "//;\n1,2;3";
            var inputIndex = 1;
            var expected = "1,2;3";
            //Act
            var actual = _inputSplitter.InputSplitForDelimeterAndNumbers(inputNumbers, inputIndex);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Given_NumbersWithCustomDelimeters_When_ExtractingDelimetersInBrackets_Return_CustomDelimeters()
        {
            //Arrange
            var inputNumbers = "//[***][%%%%]\n1***2%%%%3";
            var inputIndex = 0;
            var expected = "//[***][%%%%]";
            //Act
            var actual = _inputSplitter.InputSplitForDelimeterAndNumbers(inputNumbers,inputIndex);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }

}

