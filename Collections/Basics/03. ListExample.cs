namespace CSharpFeatureExplore.Collections.Basics
{
    public class ListExample
    {
        public static void Show()
        {
            Console.WriteLine("--- List<T> Example ---");

            var fruits = new List<string> { "Apple", "Banana" };
            fruits.Add("Cherry");
            fruits.Remove("Banana");

            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            Console.WriteLine();
        }
    }
}
