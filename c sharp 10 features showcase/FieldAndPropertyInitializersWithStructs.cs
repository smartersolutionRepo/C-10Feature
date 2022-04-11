using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_10_features_showcase
{
    public class FieldAndPropertyInitializersWithStructs
    {
        public readonly struct User
        {
            public readonly string Name;
            public readonly int Age = 0;
            public User(string name) => Name = name;
            public User(string name, int age)
            {
                Name = name;
                Age = age;
            }
        }
        public static void Print()
        {
            var user = new User("User");
            Console.WriteLine(user.Name + "Test" + user.Age);
        }

    }
}
