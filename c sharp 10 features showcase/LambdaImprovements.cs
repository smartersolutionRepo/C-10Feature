using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_10_features_showcase
{
    public class LambdaImprovements
    {
        public static void Print()
        {
            //Before
            Func<string, int> parse = (string s) => int.Parse(s);
            //C#10
            var _parse = (string s) => int.Parse(s);
        }
    }
}
