namespace CSharpFeatureExplore.DatatTypes
{
    public class DefaultValuesExample
    {
        public static void Show()
        {
            int defaultInt = default;
            bool defaultBool = default;
            string defaultString = default;

            Console.WriteLine("--- Default Values Example ---");
            Console.WriteLine($"Default int: {defaultInt}");
            Console.WriteLine($"Default bool: {defaultBool}");
            Console.WriteLine($"Default string: {defaultString ?? "null"}");
            Console.WriteLine();
        }
    }
}
