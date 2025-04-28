using System.Collections.Immutable;

namespace CSharpFeatureExplore.Collections.ThreadSafe
{
    public class ImmutableCollectionsExample
    {
        public static void Show()
        {
            Console.WriteLine("--- ImmutableList<T> Example ---");

            var list = ImmutableList.Create<int>(1, 2, 3);
            var newList = list.Add(4); // old list stays unchanged

            Console.WriteLine("Original List:");
            foreach (var number in list)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("New List:");
            foreach (var number in newList)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine();
        }
    }
}
