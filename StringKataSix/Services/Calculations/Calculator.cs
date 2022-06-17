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

            List<int> convertedNumbersList = _inputConverter.ConvertToNumbers(numbersToCalculate);
            _errorHandler.NegativeNumbersException(convertedNumbersList);

            return _calculator.Calculate(numbersToCalculate);
        }
    }
}