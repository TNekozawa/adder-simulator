namespace Core.Calculator.Parts
{
    public class OrCalculator
    {
        private NandCalculator nand;
        private NotCalculator not;

        /// <summary>
        /// Or演算を行うクラス
        /// </summary>
        public OrCalculator()
        {
            nand = new();
            not = new();
        }

        /// <summary>
        /// bool値a, bに対してOr演算を行う
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public bool Calc(bool a, bool b)
        {
            bool notA = not.Calc(a);
            bool notB = not.Calc(b);
            return nand.Calc(notA, notB);
        }
    }
}
