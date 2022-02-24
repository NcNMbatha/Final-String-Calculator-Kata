using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringKataSix.Services
{
    public class InputSplitter
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
