using Core.Calculator;
using Core.Interfaces;
using System.Collections.Generic;

namespace CoreTest.CalculatorTest
{
    public class BinaryCalculatorTest
    {
        [Theory]
        [InlineData("000", "000", "0")]
        [InlineData("000", "001", "1")]
        [InlineData("000", "010", "10")]
        [InlineData("000", "011", "11")]
        [InlineData("000", "100", "100")]
        [InlineData("011", "100", "111")]
        [InlineData("001", "101", "110")]
        public void TestCalculate(string input1, string input2, string expected)
        {
            BinaryCalculator calculator = new();

            List<int> nums1 = Translator.GetIntList(input1);
            List<int> nums2 = Translator.GetIntList(input2);

            List<int> ansList = calculator.Calculate(nums1, nums2);

            string actual = Translator.GetDisplayableAnswer(ansList);
            Assert.Equal(expected, actual);
        }
    }
}
