using Core.Calculator;
using Core.Interfaces;
using System;
using System.Collections.Generic;

namespace Core
{
    public static class Processor
    {
        public static Tuple<string, string> RunCalculator(string input1, string input2)
        {
            string answer;
            string message;

            try
            {
                States state1 = InputChecker.GetStates(input1);
                States state2 = InputChecker.GetStates(input2);

                if (state1 == States.Capable && state2 == States.Capable)
                {
                    BinaryCalculator calculator = new BinaryCalculator();

                    List<int> nums1 = Translator.GetIntList(input1);
                    List<int> nums2 = Translator.GetIntList(input2);

                    List<int> ansList = calculator.Calculate(nums1, nums2);

                    answer = Translator.GetDisplayableAnswer(ansList);
                    message = Translator.GetStringFormulae(input1, input2, answer);
                }
                else
                {
                    string errorMessage1 = InputChecker.GetErrorMessage(state1);
                    string errorMessage2 = InputChecker.GetErrorMessage(state2);
                    string error;
                    if (errorMessage1 == "")
                    {
                        error = "input2が" + errorMessage2;
                    }
                    else
                    {
                        error = "input1が" + errorMessage1;
                        if (errorMessage2 != "")
                        {
                            error += "\n" + "input2が" + errorMessage2;
                        }
                    }

                    answer = "";
                    message = error;
                }
            }
            catch (Exception ex)
            {
                answer = "";
                message = ex.Message + ex.StackTrace;
            }

            Tuple<string, string> output = new(answer, message);
            return output;
        }
    }
}
