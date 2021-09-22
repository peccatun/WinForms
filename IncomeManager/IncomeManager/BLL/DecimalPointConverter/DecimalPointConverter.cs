using System;
using System.Threading;

namespace BLL.DecimalPointConverter
{
    public static class DecimalPointConverter
    {
        public static double GetDoubleFromString(string numberString)
        {
            return double.Parse(GetStringDecimal(numberString));
        }

        public static string GetStringDecimal(string numberString)
        {
            char enviromentSeparator = Convert.ToChar(Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            char pointSeparator = '.';
            char commaSeparator = ',';

            if (numberString.Contains(pointSeparator))
            {
                return numberString.Replace(pointSeparator, enviromentSeparator);
            }

            return numberString.Replace(commaSeparator, enviromentSeparator);
        }
    }


}
