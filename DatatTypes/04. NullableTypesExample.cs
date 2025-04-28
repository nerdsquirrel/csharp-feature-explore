namespace CSharpFeatureExplore.DatatTypes
{
    public class NullableTypesExample
    {
        public static void Show()
        {
            int? nullableInt = null;
            Console.WriteLine("--- Nullable Types Example ---");
            Console.WriteLine($"Nullable int before assigning: {nullableInt}");

            nullableInt = 10;
            Console.WriteLine($"Nullable int after assigning: {nullableInt}");
            Console.WriteLine();
        }
    }
}
