using Core.Calculator.Parts;
using System;

namespace Core.Calculator.Adders
{
    /// <summary>
    /// 半加算器クラス
    /// </summary>
    public class HalfAdder
    {
        /// <summary>
        /// not演算器
        /// </summary>
        private NotCalculator Not1;

        /// <summary>
        /// and演算器1
        /// </summary>
        private AndCalculator And1;

        /// <summary>
        /// and演算器2
        /// </summary>
        private AndCalculator And2;

        /// <summary>
        /// or演算器
        /// </summary>
        private OrCalculator Or1;

        public HalfAdder()
        {
            Not1 = new NotCalculator();
            And1 = new AndCalculator();
            And2 = new AndCalculator();
            Or1 = new OrCalculator();
        }

        /// <summary>
        /// half-adder calc
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>(s,c)</returns>
        public Tuple<bool, bool> Calc(bool a, bool b)
        {
            bool boolC = And1.Calc(a, b);
            bool boolS = And2.Calc(Or1.Calc(a, b), Not1.Calc(boolC));

            var tuple = new Tuple<bool,bool>(boolS, boolC);
            return tuple;
        }
    }
}