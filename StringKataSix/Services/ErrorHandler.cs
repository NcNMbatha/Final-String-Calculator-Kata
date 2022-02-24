using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringKataSix.Services
{
    public class ErrorHandler
    {
        public void NegativeNumbersException(List<int> arrayOfNumbers)
        {
            string negatives = String.Empty;

            foreach (var item in arrayOfNumbers)
            {
                if (item < 0)
                {
                    negatives += $"\n {item}";
                }
            }

            if (!string.IsNullOrEmpty(negatives))
            {
                throw new Exception($"Negative Numbers are not allowed {negatives}");
            }
        }
    }
}
