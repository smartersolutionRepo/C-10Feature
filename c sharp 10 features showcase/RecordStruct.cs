using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_10_features_showcase
{
    public class RecordStruct
    {
        public readonly record struct User(string Name, int Age);
        
        public static void Print()
        {
            var user = new User { Name = "Tom", Age = 36 };
            Console.WriteLine($"{user.Name} is {user.Age} years old.");
        }
    }
}
