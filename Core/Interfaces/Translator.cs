using System;
using System.Collections.Generic;

namespace Core.Interfaces
{
    public static class Translator
    {
        public static bool Trans(int i)
        {
            return i switch
            {
                0 => false,
                1 => true,
                _ => throw new InvalidCastException("{0} is not castable.", i),
            };
        }
        public static int Trans(bool b)
        {
            return b ? 1 : 0;
        }
        public static List<int> GetIntList(string input)
        {
            List<int> outputList = new();
            string[] a1 = InputChecker.GetStringArray(input);
            int counter = 0;
            foreach (string a in a1)
            {
                if (a == "1")
                {
                    counter++;
                }
                if (counter >= 1)
                {
                    outputList.Add(int.Parse(a));
                }
            }
            outputList.Reverse();

            if (outputList.Count == 0)
            {
                outputList.Add(0);
            }

            return outputList;
        }
        public static string TranslateBinary(string input)
        {
            List<int> list = GetIntList(input);
            double num = 0;

            for (int i = 0; i < list.Count; i++)
            {
                int bit = list[i];
                num += bit * Math.Pow(2, i);
            }

            num = Math.Truncate(num);
            return num.ToString();
        }
        public static string GetDisplayableAnswer(List<int> intList)
        {
            intList.Reverse();
            string output = "";
            int counter = 0;
            for (int i = 0; i < intList.Count; i++)
            {
                int num = intList[i];
                if (num == 1)
                {
                    counter++;
                }
                if (counter > 0)
                {
                    output += num.ToString();
                }
            }
            if (output == "")
            {
                output = "0";
            }
            return output;
        }
        public static string GetStringFormulae(string input1, string input2, string answer)
        {
            input1 = TranslateBinary(input1);
            input2 = TranslateBinary(input2);
            answer = TranslateBinary(answer);

            string output = input1 + " + " + input2 + " = " + answer;

            return output;
        }
    }
}
