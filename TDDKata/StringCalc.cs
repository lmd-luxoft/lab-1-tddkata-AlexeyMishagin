// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System;
using System.Globalization;

namespace TDDKata
{
    internal class StringCalc
    {
        internal int Sum(string v)
        {
            if (v.Length == 0) return 0;

            if (v.Contains(","))
            {
                int sum = 0;
                string[] allstrval = v.Split(',');
                foreach (string strval in allstrval)
                {
                    if (int.TryParse(strval, out int j))
                        sum += j;
                }
                return sum;
            }
            else
            {
                if (int.TryParse(v, out int j))
                    return j + j;
            }
                
            throw new NotImplementedException();
        }
    }
}