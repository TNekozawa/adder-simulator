using Core.Interfaces;

namespace CoreTest.InterfacesTest
{
    public class TranslatorTest
    {
        [Theory]
        #region TestCase
        [InlineData(1, true)]
        [InlineData(0, false)]
        #endregion TestCase
        public void TestTrans1(int num, bool expected)
        {
            bool actual = Translator.Trans(num);
            Assert.Equal(expected, actual);
        }

        [Theory]
        #region TestCase
        [InlineData(true, 1)]
        [InlineData(false, 0)]
        #endregion TestCase
        public void TestTrans2(bool b, int expected)
        {
            int actual = Translator.Trans(b);
            Assert.Equal(expected, actual);
        }

        [Theory]
        #region TestCase
        [InlineData(0, "000")]
        [InlineData(1, "001")]
        [InlineData(2, "010")]
        [InlineData(3, "011")]
        [InlineData(4, "100")]
        [InlineData(5, "101")]
        [InlineData(6, "110")]
        [InlineData(7, "111")]
        #endregion TestCase
        public void TestIntList(int num, string input)
        {
            List<int> expectedList = GetExpectedList(num);
            List<int> actualList = Translator.GetIntList(input);

            int counter = 0;
            foreach (int e in expectedList)
            {
                int a = actualList[counter];
                Assert.Equal(e, a);
                counter++;
            }
        }

        private static List<int> GetExpectedList(int num)
        {
            var list = new List<int>();

            switch (num)
            {
                case 0:
                    list.Add(0);
                    break;
                case 1:
                    list.Add(1);
                    break;
                case 2:
                    list.Add(0);
                    list.Add(1);
                    break;
                case 3:
                    list.Add(1);
                    list.Add(1);
                    break;
                case 4:
                    list.Add(0);
                    list.Add(0);
                    list.Add(1);
                    break;
                case 5:
                    list.Add(1);
                    list.Add(0);
                    list.Add(1);
                    break;
                case 6:
                    list.Add(0);
                    list.Add(1);
                    list.Add(1);
                    break;
                case 7:
                    list.Add(1);
                    list.Add(1);
                    list.Add(1);
                    break;
                default:
                    throw new Exception("存在しない入力");
            }

            return list;
        }

        [Theory]
        #region TestCase
        [InlineData("000", "0")]
        [InlineData("001", "1")]
        [InlineData("010", "2")]
        [InlineData("011", "3")]
        [InlineData("100", "4")]
        [InlineData("101", "5")]
        [InlineData("110", "6")]
        [InlineData("111", "7")]
        #endregion TestCase
        public void TestBinaryTranslate(string input, string expected)
        {
            string actual = Translator.TranslateBinary(input);
            Assert.Equal(expected, actual);
        }
    }
}
