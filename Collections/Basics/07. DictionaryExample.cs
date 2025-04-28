namespace CSharpFeatureExplore.Collections.Basics
{
    public class DictionaryExample
    {
        public static void Show()
        {
            Console.WriteLine("--- Dictionary<TKey, TValue> Example ---");

            var capitals = new Dictionary<string, string>
            {
                {"USA", "Washington, D.C."},
                {"France", "Paris"},
                {"Japan", "Tokyo"}
            };

            foreach (var kvp in capitals)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            Console.WriteLine();
        }
    }
}
