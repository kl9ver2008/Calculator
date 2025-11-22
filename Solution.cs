using System;

namespace Calculator
{
    internal class Solution
    {
        public static double Minus(string k, string a, string b, out string exMessage)
        {
            double a1 = CheckData.CheckDataToDouble(a, out exMessage);
            double b1 = CheckData.CheckDataToDouble(b, out exMessage);
            
            if (k == "-")
            {
                return a1 - b1;
            }
            else if (k == "+")
            {
                return a1 + b1;
            }
            else if (k == "*")
            {
                return a1 * b1;
            }
            else if (k == "/")
            {
                return a1 / b1;
            }
            else 
            {
                exMessage = "Unknown operation";
                return 0;
            }



        }


    }
}
