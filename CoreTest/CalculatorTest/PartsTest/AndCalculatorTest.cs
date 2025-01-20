using Core.Calculator.Parts;

namespace CoreTest.CalculatorTest.PartsTest
{
    public class AndCalculatorTest
    {
        [Theory]
        [InlineData(true, true, true)]
        [InlineData(false, true, false)]
        [InlineData(true, false, false)]
        [InlineData(false, false, false)]
        public void TestAnd(bool input1, bool input2, bool exp)
        {
            var andCalculator = new AndCalculator();
            bool act = andCalculator.Calc(input1, input2);

            Assert.Equal(exp, act);
        }
    }
}
