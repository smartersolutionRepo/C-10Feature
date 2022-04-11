namespace System.Runtime.CompilerServices
{   
    internal static class IsExternalInit { }
}
namespace c_sharp_10_features_showcase
{
    class Showcase
    {
        static void Main(string[] args)
        {
            CustomParameterlessStructConstructor.Print();
            FieldAndPropertyInitializersWithStructs.Print();
            WithExpressionsWithStructs.Print();
            RecordStruct.Print();
            LambdaImprovements.Print();
            ConstInterpolatedStrings.Print();
            RecordTypesCanSealToString.Print();
            AssignmentAndDeclarationInSameDeconstruction.Print();
        }
    }
}