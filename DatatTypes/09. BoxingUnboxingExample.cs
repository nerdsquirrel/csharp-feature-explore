namespace CSharpFeatureExplore.DatatTypes
{
    public class BoxingUnboxingExample
    {
        public static void Show()
        {
            int number = 123;
            object boxed = number; // Boxing
            int unboxed = (int)boxed; // Unboxing

            Console.WriteLine("--- Boxing and Unboxing Example ---");
            Console.WriteLine($"Boxed value: {boxed}");
            Console.WriteLine($"Unboxed value: {unboxed}");
            Console.WriteLine();
        }
    }
}
