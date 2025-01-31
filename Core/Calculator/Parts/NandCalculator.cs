namespace Core.Calculator.Parts
{
    public class NandCalculator
    {
        /// <summary>
        /// Nand演算を行うクラス
        /// </summary>
        public NandCalculator()
        {

        }

        /// <summary>
        /// bool値a, bに対してNand演算を行う
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public bool Calc(bool a, bool b)
        {
            return !(a && b);
        }
    }
}
