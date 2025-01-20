using Core.Calculator.Parts;

namespace CoreTest.CalculatorTest.PartsTest
{
    public class NotCalculatorTest
    {
        [Theory]
        [InlineData(true, false)]
        [InlineData(false, true)]
        public void TestNot(bool input, bool exp)
        {
            var notCalculator = new NotCalculator();
            bool act = notCalculator.Calc(input);

            Assert.Equal(exp, act);
        }
    }
}
