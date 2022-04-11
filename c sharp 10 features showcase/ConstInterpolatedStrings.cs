using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_10_features_showcase
{
    public class ConstInterpolatedStrings
    {
        const string Version = "10";
        const string Csharp = $"C# {Version}";
        public static void Print()
        {
            Console.WriteLine(Version,Csharp);
        }
        
    }
}
