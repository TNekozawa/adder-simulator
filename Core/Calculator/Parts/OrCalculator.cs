namespace Core.Calculator.Parts
{
    public class OrCalculator
    {
        /// <summary>
        /// Or演算を行うクラス
        /// </summary>
        public OrCalculator()
        {

        }

        /// <summary>
        /// bool値a, bに対してOr演算を行う
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public bool Calc(bool a, bool b)
        {
            return a || b;
        }
    }
}
