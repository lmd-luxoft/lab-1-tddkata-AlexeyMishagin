// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using NUnit.Framework;
using System;
using System.Globalization;
using System.Linq;
using System.Text;

namespace TDDKata
{
    internal class StringCalc
    {
        internal int Sum(string v)
        {
            if (v.Length == 0) return 0;

            string[] allstrval = v.Split(FindSplits(v));

            if (allstrval.Length > 0)
            {
                if (int.TryParse(v, out int j))
                return j + j;
            }

            int sum = 0;
            foreach (string strval in allstrval)
            {
                if (int.TryParse(strval, out int j))
                    sum += j;
            }
            return sum;
                
            throw new NotImplementedException();
        }

        /// <summary>
        /// Метод который ищет в строке любые символы, кроме цифр
        /// </summary>
        /// <param name="st">string строка в которой ищем</param>
        /// <returns>char[]<LogRecord> - массив символов</returns>
        private char[] FindSplits (string st)
        {
            StringBuilder retsymbols = new StringBuilder();

            if (st.Contains("//"))
            {
                return retsymbols.Append(st.Substring( st.IndexOf("//") + 2 , 1)).ToString().ToCharArray();
            }

            foreach(char ch in st)
            {
                if (!(ch >= '0' & ch <= '9')) retsymbols.Append(ch);
            }
            return retsymbols.ToString().ToCharArray();
        }
    }
}