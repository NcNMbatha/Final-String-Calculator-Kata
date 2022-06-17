using NSubstitute;
using NUnit.Framework;
using StringKataSix;
using StringKataSix.Interfaces;

namespace StringKataSixTest.InputSplitterTest.CalculationsTest
{
    public class AdditionTest
    {
        private Calculator _calculator;
        private ICalculator _calculatorMock;
        private IErrorHandler _errorHandlerMock;
        private IInputConverter _converterMock;

        [SetUp]
        public void Setup()
        {
            _calculatorMock = Substitute.For<ICalculator>();
            _errorHandlerMock = Substitute.For<IErrorHandler>();
            _converterMock = Substitute.For<IInputConverter>();

            _calculator = new Calculator(_calculatorMock, _errorHandlerMock, _converterMock);
        }

        [Test]
        public void Given_EmptyInputNumbers_When_Adding_Return_Zero()
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
        public void Given_OneInputNumbers_When_Adding_Return_One()
        {
            //Arrange
            var inputNumbers = "1";
            var expected = 1;
            _calculatorMock.Calculate(inputNumbers).Returns(expected);
            //Act
            var actual = _calculator.PerformCalculations(inputNumbers);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Given_TwoInputNumbersSeperatedByDelimeter_When_Adding_Return_SumOfTwoNumbers()
        {
            //Arrange
            var inputNumbers = "1,2";
            var expected = 3;
            _calculatorMock.Calculate(inputNumbers).Returns(expected);
            //Act
            var actual = _calculator.PerformCalculations(inputNumbers);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Given_InputNumbersSeperatedByDelimeters_When_Adding_Return_SumOfAllNumbers()
        {
            //Arrange
            var inputNumbers = "1,2\n3";
            var expected = 6;
            _calculatorMock.Calculate(inputNumbers).Returns(expected);
            //Act
            var actual = _calculator.PerformCalculations(inputNumbers);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Given_InputNumbersStartingWithSlashesSeperatedByDelimeters_When_Adding_Return_SumOfAllNumbers()
        {
            //Arrange
            var inputNumbers = "//;\n1;2";
            var expected = 3;
            _calculatorMock.Calculate(inputNumbers).Returns(expected);
            //Act
            var actual = _calculator.PerformCalculations(inputNumbers);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Given_InputNumbersWithNumbersGreaterThanBiggestNumber_When_Adding_Return_SumOfAllNumbersLessThanBiggestNumber()
        {
            //Arrange
            var inputNumbers = "1,2\n3,1200";
            var expected = 6;
            _calculatorMock.Calculate(inputNumbers).Returns(expected);
            //Act
            var actual = _calculator.PerformCalculations(inputNumbers);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
