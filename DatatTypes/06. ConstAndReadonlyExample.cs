namespace CSharpFeatureExplore.DatatTypes
{
    public class ConstAndReadonlyExample
    {
        public static void Show()
        {
            const double Pi = 3.14159;
            Console.WriteLine("--- Const Example ---");
            Console.WriteLine($"Pi: {Pi}");

            var example = new ExampleClass();
            Console.WriteLine("--- Readonly Example ---");
            Console.WriteLine($"Course Name: {example.CourseName}");
            Console.WriteLine();
        }

        internal class ExampleClass
        {
            public readonly string CourseName = "C# Programming";
        }
    }
}
