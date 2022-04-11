using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_10_features_showcase
{
    public class WithExpressionsWithStructs
    {
        public struct User
        {
            public string Name;
            public int Age;

            public User(string name, int age)
            {
                Name = name;
                Age = age;
            }
        }
        public static void Print()
        {
            var user = new User("Tom", 36);
            var birthdayBoy = user with { Age = user.Age + 1 };
            Console.WriteLine(birthdayBoy.Name + " is now " + birthdayBoy.Age);
        }
    }
}
