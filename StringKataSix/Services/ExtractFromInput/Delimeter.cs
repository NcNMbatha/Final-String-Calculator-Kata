using StringKataSix.Interfaces;

namespace StringKataSix.Services
{
    public class Delimeter : IDelimeter
    {
        private InputSplitter _splitter;
        private const string forwardSlashes = "//";
        private const string customDelimeterOpeningBracket = "[";
        private const string customDelimeterClosingBracket = "]";
        private const string customDelimeterSplitter = "][";
        private List<string> delimterList = new List<string>() { ",", "\n" };

        public Delimeter()
        {
            _splitter = new InputSplitter();
        }

        public List<string> GetDelimeterList(string numbersWithDelimeters)
        {
            string customDelimeterBracket = numbersWithDelimeters[2].ToString();

            if (customDelimeterBracket.Equals(customDelimeterOpeningBracket))
            {
                return ExtractDelimetersInBrackets(numbersWithDelimeters);
            }

            if (numbersWithDelimeters.StartsWith(forwardSlashes))
            {
                string inputDelimeter = _splitter.InputSplitForDelimeterAndNumbers(numbersWithDelimeters, 0);
                inputDelimeter = inputDelimeter.Substring(2);
                delimterList.Add(inputDelimeter);

                return delimterList;
            }

            return delimterList;
        }

        public List<string> ExtractDelimetersInBrackets(string numbersWithDelimeters)
        {
            string customDelimeter = _splitter.InputSplitForDelimeterAndNumbers(numbersWithDelimeters, 0);
            customDelimeter = customDelimeter.Substring(3).Trim(Convert.ToChar(customDelimeterClosingBracket));
            List<string> customDelimeterList = customDelimeter.Split(customDelimeterSplitter).ToList();

            foreach (var delimeter in customDelimeterList)
            {
                delimterList.Add(delimeter);
            }

            return delimterList;
        }
    }
}
