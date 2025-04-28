using CSharpFeatureExplore.Collections.ThreadSafe;
using CSharpFeatureExplore.DatatTypes;
using CSharpFeatureExplore.Event_Delegate;
using CSharpFeatureExplore.FileOperations;

namespace CSharpFeatureExplore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Data Types Examples:");

            // Call each example one by one
            FileOperationExamples.Show();
            ValueVsReferenceTypeExample.Show();
            NullableTypesExample.Show();
            VarTypeInferenceExample.Show();
            ConstAndReadonlyExample.Show();
            EnumExample.Show();
            StructExample.Show();
            BoxingUnboxingExample.Show();

            Console.WriteLine("=== String Examples ===");
            StringOperationsExample.Show();
            StringFormattingExample.Show();
            ImmutableCollectionsExample.Show();

            DelegateMultipleWay.Show();
        }
    }
}
