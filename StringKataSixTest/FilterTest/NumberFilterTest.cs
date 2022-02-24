using NUnit.Framework;
using StringKataSix.Interfaces;
using StringKataSix.Services;
using System.Collections.Generic;

namespace StringKataSixTest.InputSplitterTest
{
    public class NumberFilterTest
    {
        private NumberFilter _numberFilter;
        private IInputConverter _converter;

        [SetUp]
        public void Setup()
        {
            _numberFilter = new NumberFilter();
        }

        [Test]
        public void Given_NumbersWithNumbersGreaterThanBiggestNumber_When_FilteringForBiggestNumbers_Return_ListOfNumbersLessThanBiggestNumber()
        {
            //Arrange 
            var InputNumbers = "1,2\n3,1001";
            var expected = new List<int>() { 1, 2, 3 };
            //Act
            var actual = _numberFilter.FilterBiggestNumbers(InputNumbers);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
