using StringKataSix.Interfaces;

namespace StringKataSix.Services
{
    public class Subtraction : ICalculator
    {
        private NumberFilter _filter;

        public Subtraction()
        {
            _filter = new NumberFilter();
        }

        public int DifferenceOfAllNumbers(string nummbersToAdd)
        {
            int sumOfNumbers = 0;
            var filteredList = _filter.FilterBiggestNumbers(nummbersToAdd);

            foreach (var number in filteredList)
            {
                sumOfNumbers -= number;
            }

            return sumOfNumbers;
        }

        public int Calculate(string numbersToCalculate)
        {
            return DifferenceOfAllNumbers(numbersToCalculate);
        }
    }
}
