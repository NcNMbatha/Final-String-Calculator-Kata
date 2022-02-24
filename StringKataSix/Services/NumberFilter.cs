namespace StringKataSix.Services
{
    public class NumberFilter
    {
        private InputConverter _converter;
        private const int BiggestNumber = 1000;

        public NumberFilter()
        {
            _converter = new InputConverter();  
        }

        public List<int> FilterBiggestNumbers(string numbersToFilter)
        {
            var convertedList = _converter.ConvertToNumbers(numbersToFilter);

            foreach (var number in _converter.ConvertToNumbers(numbersToFilter))
            {
                if (number > BiggestNumber)
                {
                    convertedList.Remove(number);
                }
            }

            return convertedList;
        }
    }
}
