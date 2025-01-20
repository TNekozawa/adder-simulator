using Core.Calculator.Adders;

namespace CoreTest.CalculatorTest.AddersTest
{
    public class HalfAdderTest
    {
        [Theory]
        [InlineData(false, false, false, false)]
        [InlineData(false, true, true, false)]
        [InlineData(true, false, true, false)]
        [InlineData(true, true, false, true)]
        public void TestHalfAdder(bool input1, bool input2, bool exp1, bool exp2)
        {
            var halfAdder = new HalfAdder();
            var tuple = halfAdder.Calc(input1, input2);
            Assert.Equal(exp1, tuple.Item1);
            Assert.Equal(exp2, tuple.Item2);
        }
    }
}
