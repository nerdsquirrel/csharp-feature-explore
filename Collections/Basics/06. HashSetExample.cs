namespace CSharpFeatureExplore.Collections.Basics
{
    public class HashSetExample
    {
        public static void Show()
        {
            Console.WriteLine("--- HashSet<T> Example ---");

            var uniqueNumbers = new HashSet<int> { 1, 2, 3 };
            uniqueNumbers.Add(3); // Duplicate, will not be added
            uniqueNumbers.Add(4);

            foreach (var number in uniqueNumbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine($"Contains 2? {uniqueNumbers.Contains(2)}");

            Console.WriteLine();
        }
    }
}
