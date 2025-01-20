namespace Core.Calculator.Parts
{
    public class NotCalculator
    {
        /// <summary>
        /// And演算を行うクラス
        /// </summary>
        public NotCalculator()
        {

        }


        /// <summary>
        /// bool値xに対してNot演算を行う
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public bool Calc(bool x)
        {
            return !x;
        }
    }
}
