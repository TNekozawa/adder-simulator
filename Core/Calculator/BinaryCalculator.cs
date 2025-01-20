using Core.Calculator.Adders;
using Core.Interfaces;
using System;
using System.Collections.Generic;

namespace Core.Calculator
{
    public class BinaryCalculator
    {
        private HalfAdder HalfAdder;
        private List<FullAdder> FullAdders;
        public BinaryCalculator()
        {
            HalfAdder = new();
            FullAdders = new();
        }

        private void Initialize(int digits)
        {
            FullAdders.Clear();
            for (int i = 0; i < digits - 1; i++)
            {
                FullAdders.Add(new FullAdder(i + 1));
            }
        }
        public List<int> Calculate(List<int> numList1, List<int> numList2)
        {
            int digits = Math.Max(numList1.Count, numList2.Count);
            Initialize(digits);

            bool[] boolArray1 = new bool[digits];
            bool[] boolArray2 = new bool[digits];
            bool[] boolArray3 = new bool[digits + 1];

            for (int i = 0; i < numList1.Count; i++)
            {
                boolArray1[i] = Translator.Trans(numList1[i]);
            }
            for (int i = 0; i < numList2.Count; i++)
            {
                boolArray2[i] = Translator.Trans(numList2[i]);
            }
            for (int i = 0; i < digits + 1; i++)
            {
                boolArray3[i] = false;
            }

            var tuple0 = HalfAdder.Calc(boolArray1[0], boolArray2[0]);
            bool bools0 = tuple0.Item1;
            bool boolc0 = tuple0.Item2;

            boolArray3[0] = bools0;
            boolArray3[1] = boolc0;

            for (int i = 0; i < digits - 1; i++)
            {
                FullAdder fullAdder = FullAdders[i];
                var tuple = fullAdder.Calc(boolArray1[i + 1], boolArray2[i + 1], boolArray3[i + 1]);
                boolArray3[i + 1] = tuple.Item1;
                boolArray3[i + 2] = tuple.Item2;
            }

            List<int> outputList = new();
            for (int i = 0; i < digits + 1; i++)
            {
                int x = Translator.Trans(boolArray3[i]);
                outputList.Add(x);
            }

            return outputList;
        }
    }
}