using Core.Calculator.Adders;

namespace CoreTest.CalculatorTest.AddersTest
{
    public class FullAdderTest
    {
        [Theory]
        [InlineData(false, false, false, false, false)]
        [InlineData(false, false, true, true, false)]
        [InlineData(false, true, false, true, false)]
        [InlineData(false, true, true, false, true)]
        [InlineData(true, false, false, true, false)]
        [InlineData(true, false, true, false, true)]
        [InlineData(true, true, false, false, true)]
        [InlineData(true, true, true, true, true)]
        public void TestFullAdder(bool input1, bool input2, bool input3, bool exp1, bool exp2)
        {
            var fullAdder = new FullAdder(0);
            var tuple = fullAdder.Calc(input1, input2, input3);

            Assert.Equal(exp1, tuple.Item1);
            Assert.Equal(exp2, tuple.Item2);
        }
    }
}
