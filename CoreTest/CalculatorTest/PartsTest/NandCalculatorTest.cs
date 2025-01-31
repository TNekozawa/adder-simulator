using Core.Calculator.Parts;

namespace CoreTest.CalculatorTest.PartsTest
{
    public class NandCalculatorTest
    {
        [Theory]
        [InlineData(true, true, false)]
        [InlineData(false, true, true)]
        [InlineData(true, false, true)]
        [InlineData(false, false, true)]
        public void TestNand(bool input1, bool input2, bool exp)
        {
            var nand = new NandCalculator();
            bool act = nand.Calc(input1, input2);

            Assert.Equal(exp, act);
        }
    }
}
