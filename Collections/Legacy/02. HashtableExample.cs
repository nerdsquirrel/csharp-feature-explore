using System.Collections;

namespace CSharpFeatureExplore.Collections.Legacy
{
    public class HashtableExample
    {
        public static void Show()
        {
            Console.WriteLine("--- Hashtable Example ---");

            Hashtable hashtable = new Hashtable();
            hashtable.Add("Id", 101);
            hashtable.Add("Name", "John Doe");
            hashtable.Add("IsActive", true);

            foreach (DictionaryEntry entry in hashtable)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }

            Console.WriteLine($"Name from Hashtable: {hashtable["Name"]}");

            Console.WriteLine();
        }
    }
}
