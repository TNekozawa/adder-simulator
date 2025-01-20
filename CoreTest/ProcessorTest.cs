using Core;
using System;

namespace CoreTest
{
    public class ProcessorTest
    {
        [Theory]
        [InlineData("000", "000", "0", "0 + 0 = 0")]
        [InlineData("000", "001", "1", "0 + 1 = 1")]
        [InlineData("000", "010", "10", "0 + 2 = 2")]
        [InlineData("000", "011", "11", "0 + 3 = 3")]
        [InlineData("001", "001", "10", "1 + 1 = 2")]
        [InlineData("001", "010", "11", "1 + 2 = 3")]
        public void ProcessorTestNormal (string input1, string input2, string answer, string message)
        {
            Tuple<string, string> result = Processor.RunCalculator(input1, input2);
            Assert.Equal(answer, result.Item1);
            Assert.Equal(message, result.Item2);
        }

        [Theory]
        [InlineData("", "000", "", "input1���󔒂ł�")]
        [InlineData("000", "", "", "input2���󔒂ł�")]

        [InlineData("hot", "000", "", "input1�����l�ł͂���܂���")]
        [InlineData("000", "pep", "", "input2�����l�ł͂���܂���")]

        [InlineData("222", "000", "", "input1��2�i���ł͂���܂���")]
        [InlineData("000", "222", "", "input2��2�i���ł͂���܂���")]

        [InlineData("", "hot", "", "input1���󔒂ł�\ninput2�����l�ł͂���܂���")]
        [InlineData("222", "", "", "input1��2�i���ł͂���܂���\ninput2���󔒂ł�")]
        public void ProcessorTestAbnormal(string input1, string input2, string answer, string message)
        {
            Tuple<string, string> result = Processor.RunCalculator(input1, input2);
            Assert.Equal(answer, result.Item1);
            Assert.Equal(message, result.Item2);
        }
    }
}