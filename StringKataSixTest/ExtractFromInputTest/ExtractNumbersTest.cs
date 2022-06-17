using NSubstitute;
using NUnit.Framework;
using StringKataSix.Interfaces;
using StringKataSix.Services;
using System.Collections.Generic;

namespace StringKataSixTest.InputSplitterTest
{
    public class ExtractNumbersTest
    {
        private ExtractNumbers _extractNumbers;
        private IDelimeter _delimeterMock;
        private IInputSplitter _inputSplitterMock;

        [SetUp]
        public void Setup()
        {
            _inputSplitterMock = Substitute.For<IInputSplitter>();
            _delimeterMock = Substitute.For<IDelimeter>();

            _extractNumbers = new ExtractNumbers(_delimeterMock, _inputSplitterMock);
        }

        [Test]
        public void Given_NumbersWithDelimeters_When_ExtractingNumbers_Return_ListOfNumbers()
        {
            //Arrange
            var inputNumbers = "//%%%\n1%%%2,3";
            var expected = new List<string>(){"1","2","3" };
            var delimeterMock = new List<string>() { ",", "\n", "%%%" };
            var splitterMock = "1%%%2,3";
            //Arrange Mock
            _delimeterMock.GetDelimeterList(inputNumbers).Returns(delimeterMock);
            _inputSplitterMock.InputSplitForDelimeterAndNumbers(inputNumbers,1).Returns(splitterMock);
            //Act
            var actual = _extractNumbers.ExtractNumbersFromTextInput(inputNumbers);
            //Assert
            Assert.AreEqual(expected, actual);  
        }
    }
}
