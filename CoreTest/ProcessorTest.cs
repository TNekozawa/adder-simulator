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
        [InlineData("", "000", "", "input1が空白です")]
        [InlineData("000", "", "", "input2が空白です")]

        [InlineData("hot", "000", "", "input1が数値ではありません")]
        [InlineData("000", "pep", "", "input2が数値ではありません")]

        [InlineData("222", "000", "", "input1が2進数ではありません")]
        [InlineData("000", "222", "", "input2が2進数ではありません")]

        [InlineData("", "hot", "", "input1が空白です\ninput2が数値ではありません")]
        [InlineData("222", "", "", "input1が2進数ではありません\ninput2が空白です")]
        public void ProcessorTestAbnormal(string input1, string input2, string answer, string message)
        {
            Tuple<string, string> result = Processor.RunCalculator(input1, input2);
            Assert.Equal(answer, result.Item1);
            Assert.Equal(message, result.Item2);
        }
    }
}