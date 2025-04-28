namespace CSharpFeatureExplore.DatatTypes
{
    public class DynamicTypeExample
    {
        public static void Show()
        {
            Console.WriteLine("--- Dynamic Type Example ---");

            dynamic value = 10;
            Console.WriteLine($"Value (int): {value}");

            value = "Hello World";
            Console.WriteLine($"Value (string): {value}");

            value = true;
            Console.WriteLine($"Value (bool): {value}");

            // Dynamic allows calling members at runtime (unsafe)
            dynamic person = new { Name = "Alice", Age = 30 };
            Console.WriteLine($"Dynamic Object: Name = {person.Name}, Age = {person.Age}");

            Console.WriteLine();
        }
    }
}
