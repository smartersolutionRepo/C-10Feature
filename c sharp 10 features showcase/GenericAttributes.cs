using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_10_features_showcase
{
    public class GenericAttributes
    {
        class CustomAttribute : Attribute
        {
            public object? info;
        }
        public class GenericClass1<T> { }

        [CustomAttribute(info = typeof(GenericClass1<>))]
        class ClassA { }
    }
}
