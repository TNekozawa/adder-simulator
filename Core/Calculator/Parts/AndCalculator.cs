namespace Core.Calculator.Parts
{
    public class AndCalculator
    {
        private NandCalculator nand;
        private NotCalculator not;

        /// <summary>
        /// And演算を行うクラス
        /// </summary>
        public AndCalculator()
        {
            nand = new();
            not = new();
        }

        /// <summary>
        /// bool値a, bに対してAnd演算を行う
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public bool Calc(bool a, bool b)
        {
            return not.Calc(nand.Calc(a, b));
        }
    }
}
