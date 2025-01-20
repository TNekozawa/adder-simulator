using Core.Calculator.Parts;
using System;

namespace Core.Calculator.Adders
{
    /// <summary>
    /// 全加算器クラス
    /// </summary>
    public class FullAdder
    {
        public readonly int Digit;

        private HalfAdder Half1;
        private HalfAdder Half2;
        private OrCalculator Or1;

        public bool A;
        public bool B;
        public bool X;

        public FullAdder(int digit)
        {
            Half1 = new HalfAdder();
            Half2 = new HalfAdder();
            Or1 = new OrCalculator();

            A = false;
            B = false;
            X = false;
            Digit = digit;
        }

        public Tuple<bool, bool> Calc(bool a, bool b, bool x)
        {
            A = a;
            B = b;
            X = x;

            Tuple<bool, bool> tuple1 = Half1.Calc(a, b);
            Tuple<bool, bool> tuple2 = Half2.Calc(tuple1.Item1, x);

            bool boolS = tuple2.Item1;
            bool boolC = Or1.Calc(tuple1.Item2, tuple2.Item2);

            var tuple = new Tuple<bool, bool>(boolS, boolC);
            return tuple;
        }
    }
}