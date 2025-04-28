namespace CSharpFeatureExplore.Collections.Basics
{
    public class ArrayExample
    {
        public static void Show()
        {
            Console.WriteLine("--- Array Example ---");

            int[] numbers = { 1, 2, 3, 4, 5 };

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine($"First Element: {numbers[0]}");

            Console.WriteLine();
        }
    }
}
