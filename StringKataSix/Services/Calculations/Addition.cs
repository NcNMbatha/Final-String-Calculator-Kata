using StringKataSix.Interfaces;

namespace StringKataSix.Services
{
    public class Addition : ICalculator
    {
        private NumberFilter _filter;

        public Addition()
        {
            _filter = new NumberFilter();
        }

        public int SumOfAllNumbers(string nummbersToAdd)
        {
            int sumOfNumbers = 0;
            var filteredList = _filter.FilterBiggestNumbers(nummbersToAdd);

            foreach (var number in filteredList)
            {
                sumOfNumbers += number;
            }

            return sumOfNumbers;
        }

        public int Calculate(string numbersToCalculate)
        {
            return SumOfAllNumbers(numbersToCalculate);
        }
    }
}
