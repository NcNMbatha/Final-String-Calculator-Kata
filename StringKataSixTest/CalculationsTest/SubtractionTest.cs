using NSubstitute;
using NUnit.Framework;
using StringKataSix;
using StringKataSix.Interfaces;

namespace StringKataSixTest.InputSplitterTest.CalculationsTest
{
    public class SubtractionTest
    {
        private Calculator _calculator;
        private ICalculator _calculatorMock;
        private IInputConverter _inputConverterMock;
        private IErrorHandler _errorHandlerMock;

        [SetUp]
        public void Setup()
        {
            _calculatorMock = Substitute.For<ICalculator>();
            _errorHandlerMock = Substitute.For<IErrorHandler>();
            _inputConverterMock = Substitute.For<IInputConverter>();

            _calculator = new Calculator(_calculatorMock, _errorHandlerMock, _inputConverterMock);
        }

        [Test]
        public void Given_EmptyInputNumbers_When_Subtracting_Return_Zero()
        {
            //Arrange
            var inputNumbers = "";
            var expected = 0;
            _calculatorMock.Calculate(inputNumbers).Returns(expected);
            //Act
            var actual = _calculator.PerformCalculations(inputNumbers);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Given_OneInputNumber_When_Subtracting_Return_NegetiveInputNumber()
        {
            //Arrange
            var inputNumbers = "1";
            var expected = -1;
            _calculatorMock.Calculate(inputNumbers).Returns(expected);
            //Act
            var actual = _calculator.PerformCalculations(inputNumbers);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Given_TwoInputNumbersSeperatedByDelimeter_When_Subtracting_Return_TotalDifference()
        {
            //Arrange
            var inputNumbers = "1,2";
            var expected = -3;
            _calculatorMock.Calculate(inputNumbers).Returns(expected);
            //Act
            var actual = _calculator.PerformCalculations(inputNumbers);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Given_MultiplyInputNumbersSeperatedByDelimeters_When_Subtracting_Return_TotalDifference()
        {
            //Arrange
            var inputNumbers = "1,2\n3";
            var expected = -6;
            _calculatorMock.Calculate(inputNumbers).Returns(expected);
            //Act
            var actual = _calculator.PerformCalculations(inputNumbers);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Given_MultiplyInputNumbersStartingWithSlashesSeperatedByDelimeters_When_Subtracting_Return_TotalDifference()
        {
            //Arrange
            var inputNumbers = "//;\n1;2";
            var expected = -3;
            _calculatorMock.Calculate(inputNumbers).Returns(expected);
            //Act
            var actual = _calculator.PerformCalculations(inputNumbers);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Given_InputNumbersWithNumbersGreaterThanBiggestNumber_When_Subtracting_Return_TotalDifference()
        {
            //Arrange
            var inputNumbers = "1,2\n3,1200";
            var expected = -6;
            _calculatorMock.Calculate(inputNumbers).Returns(expected);
            //Act
            var actual = _calculator.PerformCalculations(inputNumbers);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Given_NumbersSeperatedByDelimiters_OfDifferentLength_When_Subtracting_Return_TotalDifference()
        {
            //Arrange
            var inputNumbers = "//%%%\n1%%%2,3";
            var expected = -6;
            _calculatorMock.Calculate(inputNumbers).Returns(expected);
            //Act
            var actual = _calculator.PerformCalculations(inputNumbers);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Given_NumbersSeperatedByMultiplyDelimiters_InSquareBrackets_When_Subtracting_Return_TotalDifference()
        {
            //Arrange
            var inputNumbers = "//[*][%]\n1*2%3";
            var expected = -6;
            _calculatorMock.Calculate(inputNumbers).Returns(expected);
            //Act
            var actual = _calculator.PerformCalculations(inputNumbers);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Given_NumbersSeperatedByMultiplyDelimitersOfDifferentLength_InSquareBrackets_When_Subtracting_Return_TotalDifference()
        {
            //Arrange
            var inputNumbers = "//[***][%%%%]\n1***2%%%%3";
            var expected = -6;
            _calculatorMock.Calculate(inputNumbers).Returns(expected);
            //Act
            var actual = _calculator.PerformCalculations(inputNumbers);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
