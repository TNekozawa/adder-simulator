using Core.Calculator.Parts;

namespace CoreTest.CalculatorTest.PartsTest
{
    public class OrCalculatorTest
    {
        [Theory]
        [InlineData(true, true, true)]
        [InlineData(false, true, true)]
        [InlineData(true, false, true)]
        [InlineData(false, false, false)]
        public void TestOr(bool input1, bool input2, bool exp)
        {
            var orCalculator = new OrCalculator();
            bool act = orCalculator.Calc(input1, input2);

            Assert.Equal(exp, act);
        }
    }
}
