using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_10_features_showcase
{
    public class AssignmentAndDeclarationInSameDeconstruction
    {
        public record User(string Name, int Age);
        public static void Print()
        {
            var user = new User("Tom", 36);
            
            //Before:
            //(string Name, int Age) = user;
            //string name = "John";
            //int age = 35;
            //(name, age) = user;
            
            //C#10:
            (string Name, int Age) = user;
            string name = "Tom";
            (name, int age) = user;
            Console.WriteLine($"Name: {name}, Age: {age}");
        }
    }
}
