using StringKataSix.Interfaces;

namespace StringKataSix.Services
{
    public class ExtractNumbers
    {
        private IInputSplitter _splitter;
        private IDelimeter _delimeter;

        public ExtractNumbers(IDelimeter delimeter, IInputSplitter inputSplitter)
        {
            _splitter = inputSplitter;
            _delimeter = delimeter;   
        }

        public string[] ExtractNumbersFromTextInput(string numbersToExtract)
        {
            string[] delimeterList = _delimeter.GetDelimeterList(numbersToExtract).ToArray();
            string numbersSeperatedByDelimeters = _splitter.InputSplitForDelimeterAndNumbers(numbersToExtract, 1);

            return numbersSeperatedByDelimeters.Split(delimeterList, StringSplitOptions.None);
        }
    }
}
