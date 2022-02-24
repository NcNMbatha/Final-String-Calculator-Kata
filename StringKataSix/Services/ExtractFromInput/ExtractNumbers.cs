namespace StringKataSix.Services
{
    public class ExtractNumbers
    {
        private InputSplitter _splitter;
        private Delimeter _delimeter;

        public ExtractNumbers()
        {
            _splitter = new InputSplitter();
            _delimeter = new Delimeter();   
        }

        public string[] ExtractNumbersFromTextInput(string numbersToExtract)
        {
            string[] delimeterList = _delimeter.GetDelimeterList(numbersToExtract).ToArray();
            string numbersSeperatedByDelimeters = _splitter.InputSplitForDelimeterAndNumbers(numbersToExtract, 1);

            return numbersSeperatedByDelimeters.Split(delimeterList, StringSplitOptions.None);
        }
    }
}
