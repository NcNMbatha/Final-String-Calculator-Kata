using StringKataSix.Interfaces;

namespace StringKataSix.Services
{
    public class InputSplitter:IInputSplitter
    {
        private const string forwardSlashes = "//";
        private const string nextLine = "\n";

        public string InputSplitForDelimeterAndNumbers(string numbersToSplit, int indexOfSplit)
        {
            if (numbersToSplit.StartsWith(forwardSlashes))
            {
                return numbersToSplit.Split(nextLine)[indexOfSplit];
            }

            return numbersToSplit;
        }
    }
}
