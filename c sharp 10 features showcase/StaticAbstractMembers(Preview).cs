using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_10_features_showcase
{
    public class StaticAbstractMembers
    {
        class TestClass
        {
            //Static abstract preview feature
            void HasSeeds<T>(T fruit) where T : IFruit
            {
                Console.WriteLine(T.HasSeeds);
            }


            public void Show()
            {
                HasSeeds(new Apple());
                HasSeeds(new Watermelon());
            }
            public record Watermelon : IFruit
            {
                public static bool HasSeeds => false;
            }

            public record Apple : IFruit
            {
                public static bool HasSeeds => true;
            }

            public interface IFruit
            {
#pragma warning disable CA2252 // Just disabled warning for this example
                static abstract bool HasSeeds { get; }
#pragma warning restore CA2252 // Just disabled warning for this example
            }
        }
    }
}    



