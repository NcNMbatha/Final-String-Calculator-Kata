using StringKataSix.Interfaces;

namespace StringKataSix
{
    public class Calculator
    {
        private readonly ICalculator _calculator;
        private readonly IErrorHandler _errorHandler;
        private readonly IInputConverter _inputConverter;

        public Calculator(ICalculator calculator,IErrorHandler errorHandler,IInputConverter inputConverter)
        {
            _calculator = calculator;
            _errorHandler = errorHandler;   
            _inputConverter = inputConverter;
        }

        public int PerformCalculations(string numbersToCalculate)
        {
            if(string.IsNullOrEmpty(numbersToCalculate))
                return 0;

            _errorHandler.NegativeNumbersException(_inputConverter.ConvertToNumbers(numbersToCalculate));
            return _calculator.Calculate(numbersToCalculate);
        }
    }
}