namespace Core.Calculator.Parts
{
    public class NotCalculator
    {
        private NandCalculator nand;
        /// <summary>
        /// And演算を行うクラス
        /// </summary>
        public NotCalculator()
        {
            nand = new();
        }


        /// <summary>
        /// bool値xに対してNot演算を行う
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public bool Calc(bool x)
        {
            return nand.Calc(x, x);
        }
    }
}
