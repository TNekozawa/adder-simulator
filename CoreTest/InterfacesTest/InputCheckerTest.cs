using Core.Interfaces;

namespace CoreTest.InterfacesTest
{
    public class InputCheckerTest
    {
        [Theory]
        #region TestCase
        [InlineData("", States.Empty)]

        [InlineData("000", States.Capable)]
        [InlineData("001", States.Capable)]
        [InlineData("010", States.Capable)]
        [InlineData("011", States.Capable)]
        [InlineData("100", States.Capable)]
        [InlineData("101", States.Capable)]
        [InlineData("110", States.Capable)]
        [InlineData("111", States.Capable)]

        [InlineData("121", States.NotBinary)]
        [InlineData("109", States.NotBinary)]

        [InlineData("1hh", States.NotNumeric)]
        [InlineData("1-t", States.NotNumeric)]
        #endregion TestCase
        public void StateTest(string input, States expectedState)
        {
            States actualState = InputChecker.GetStates(input);
            Assert.Equal(expectedState, actualState);
        }

        [Theory]
        #region TestCase
        [InlineData("000", "")]
        [InlineData("001", "")]
        [InlineData("010", "")]
        [InlineData("011", "")]

        [InlineData("", "空白です")]

        [InlineData("121", "2進数ではありません")]
        [InlineData("042", "2進数ではありません")]

        [InlineData("1hh", "数値ではありません")]
        [InlineData("1-t", "数値ではありません")]
        #endregion TestCase
        public void MessageTest(string input, string expectedMessage)
        {
            States actualState = InputChecker.GetStates(input);
            string actualMessage = InputChecker.GetErrorMessage(actualState);
            Assert.Equal(expectedMessage, actualMessage);
        }

        [Theory]
        #region TestCase
        [InlineData("000", "0", "0", "0")]
        [InlineData("001", "0", "0", "1")]
        [InlineData("010", "0", "1", "0")]
        [InlineData("011", "0", "1", "1")]
        [InlineData("100", "1", "0", "0")]
        [InlineData("101", "1", "0", "1")]
        [InlineData("110", "1", "1", "0")]
        [InlineData("111", "1", "1", "1")]
        #endregion TestCase
        public void StringArrayTest(string input, string a0, string a1, string a2)
        {
            string[] expectedArray = [a0, a1, a2];
            string[] actualArray = InputChecker.GetStringArray(input);

            for (int i = 0; i < 3; i++)
            {
                string e = expectedArray[i];
                string a = actualArray[i];

                Assert.Equal(e, a);
            }
        }
    }
}
