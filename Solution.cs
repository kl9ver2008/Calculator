using System;


namespace Calculator
{
    internal class Solution
    {
        public static double Work (string k, string a, string b, out string exMessage)
        {
            double a1 = CheckData.CheckDataToDouble(a, out exMessage);
            double b1 = CheckData.CheckDataToDouble(b, out exMessage);
            string sm1 = Convert.ToString(k);
            

            if (a1 == 0 || b1 == 0)
            {
                exMessage = "Kaputt!Geben Sie die Nummer richtig ein";
                return 0;
            }
            if (sm1.Length > 1)
            {
                exMessage = "Kaputt!Geben Sie das Zeichen richtig ein";
                return 0;
            }
            else
            {
                char sm2 = Convert.ToChar(k);

                switch (sm2)
                {
                    case '+':
                        return a1 + b1;
                    case '-':
                        return a1 - b1;
                    case '*':
                        return a1 * b1;
                    case '/':
                        return a1 / b1;
                    default:
                        exMessage = "Kaputt!Geben Sie das Zeichen richtig ein";
                        break;
                }
                 return 0;
            }
        }
    }
}
