using StringKataSix.Interfaces;

namespace StringKataSix.Services
{
    public class InputConverter:IInputConverter
    {
        private ExtractNumbers _extractNumbers;

        public InputConverter()
        {
            _extractNumbers = new ExtractNumbers(); 
        }

        public List<int> ConvertToNumbers(string numbersToConvert)
        {
            var convertedToIntegerList = new List<int>();
            var numbersArray = _extractNumbers.ExtractNumbersFromTextInput(numbersToConvert);

            foreach (var number in numbersArray)
            {
                convertedToIntegerList.Add(Convert.ToInt32(number));
            }

            return convertedToIntegerList;
        }
    }
}
