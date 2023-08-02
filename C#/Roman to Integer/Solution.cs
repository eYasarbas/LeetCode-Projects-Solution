using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Roman_to_Integer
{
    public class Solution
    {
        readonly Dictionary<char, int> romanValues = new()
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };
        public int RomanToInt(string s)
        {
            int result = 0;
            if (s == null || string.IsNullOrEmpty(s)) return result;

            for (int i = 0; i < s.Length; i++)
            {
                char key = s[i];
                if (romanValues.ContainsKey(key))
                {
                    int currentValue = romanValues[key];
                    if (i < s.Length - 1 && currentValue < romanValues[s[i + 1]])
                    {
                        // Sonuçtan şimdiki karakterin değerini çıkartıyorum
                        result -= currentValue;
                    }
                    else
                    {
                        // Sonuca şimdiki karakterin değerini ekliyorum
                        result += currentValue;
                    }
                }
                else
                {
                    return 0;
                }
            }

            return result;
        }
    }
}
