using System;


namespace Calculator
{
    internal class CheckData
    {
        public static double CheckDataToDouble(string num1, out string message)
        {
            try
            {
                message = "Ihr Ergebnis ist: ";
                return double.Parse(num1);
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return 0;
            }
        }
    }
}
