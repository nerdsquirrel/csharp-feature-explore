using System.Collections.Concurrent;

namespace CSharpFeatureExplore.Collections.ThreadSafe
{
    public class ConcurrentDictionaryExample
    {
        public static void Show()
        {
            Console.WriteLine("--- ConcurrentDictionary<TKey, TValue> Example ---");

            var concurrentDict = new ConcurrentDictionary<int, string>();

            // Add key-value pairs
            concurrentDict.TryAdd(1, "One");
            concurrentDict.TryAdd(2, "Two");

            // Update existing or add new
            concurrentDict.AddOrUpdate(2, "Second", (key, oldValue) => "UpdatedTwo");
            concurrentDict.AddOrUpdate(3, "Three", (key, oldValue) => "UpdatedThree");

            foreach (var kvp in concurrentDict)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            // Try to get a value safely
            if (concurrentDict.TryGetValue(2, out string value))
            {
                Console.WriteLine($"Found: {value}");
            }

            Console.WriteLine();
        }
    }
}
