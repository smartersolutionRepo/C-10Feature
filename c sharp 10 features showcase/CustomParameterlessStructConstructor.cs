using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_10_features_showcase
{
    public class CustomParameterlessStructConstructor
    {
        public readonly struct User
        {
            public readonly string Name;
            public readonly int Age;

            public User()
            { // Struct constructor defined with no parameters
                Name = "Name";
                Age = 0;
            }
        }
        
        public static void Print()
        {
            var user = new User();
            Console.WriteLine(user.Name + " " + user.Age);
        }
    }
}
