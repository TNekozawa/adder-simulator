namespace Core.Calculator.Parts
{
    public class AndCalculator
    {
        /// <summary>
        /// And演算を行うクラス
        /// </summary>
        public AndCalculator()
        {

        }

        /// <summary>
        /// bool値a, bに対してAnd演算を行う
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public bool Calc(bool a, bool b)
        {
            return a && b;
        }
    }
}
