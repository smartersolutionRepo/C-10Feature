using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_10_features_showcase
{
    public class RecordTypesCanSealToString
    {
        public record Person
        {
            public string FirstName { get; init; }

            public string LastName { get; init; }

            public sealed override string ToString()
            {
                return $"My name is {FirstName} {LastName}";
            }
        }
        public record Student : Person
        {
            //public override string ToString()
            //{
            //    return $"My name is {FirstName} {LastName}";
            //}
            
            // Error CS0239 'Student.ToString()': cannot override inherited member 'Person.ToString()' because it is sealed
        }
        public static void Print()
        {
            Person person = new Person() { FirstName = "John", LastName = "Doe" };
            Console.WriteLine(person.ToString());
        }

    }
}
