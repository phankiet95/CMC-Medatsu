using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMC_Medatsu
{
    public class MedatsuStringHelper
    {
        public static string zeroLib = "0000000000000000000000000000000000000000000000000000000000000";
        public static string getNext(int s, int numberDigit)
        {
            s++;
            int offset = numberDigit - s.ToString().Length;

            if (offset > 0)
            {
                return zeroLib.Substring(0, offset) + s.ToString();
            } else
            {
                return s.ToString();
            }
        }

        public static string getExcelColumnName(int columnNumber)
        {
            string columnName = "";

            while (columnNumber > 0)
            {
                int modulo = (columnNumber - 1) % 26;
                columnName = Convert.ToChar('A' + modulo) + columnName;
                columnNumber = (columnNumber - modulo) / 26;
            }

            return columnName;
        }
    }


}
