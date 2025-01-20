using System.Linq;
using System;

namespace Core.Interfaces
{
    public static class InputChecker
    {
        public static string[] GetStringArray(string input)
        {
            return input.ToCharArray().Select(c => new string(c, 1)).ToArray();
        }

        public static States GetStates(string input)
        {
            States state;
            if (input == "")
            {
                state = States.Empty;
            }
            else
            {
                string[] array = GetStringArray(input);
                try
                {
                    state = States.Capable;
                    foreach (string str in array)
                    {
                        int x = int.Parse(str);
                        if (x == 1 || x == 0)
                        {
                            continue;
                        }
                        else
                        {
                            state = States.NotBinary;
                            break;
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    state = States.NotNumeric;
                }
            }

            return state;
        }

        public static string GetErrorMessage(States state)
        {
            return state switch
            {
                States.Capable => "",
                States.Empty => "空白です",
                States.NotBinary => "2進数ではありません",
                States.NotNumeric => "数値ではありません",
                States.Unknown => "StateがUnknownです",
                _ => "その他の問題が発生しています",
            };
        }
    }
}
