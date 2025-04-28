namespace CSharpFeatureExplore.Collections.Basics
{
    public class LinkedListExample
    {
        public static void Show()
        {
            Console.WriteLine("--- LinkedList<T> Example ---");

            var linkedList = new LinkedList<string>();
            linkedList.AddLast("First");
            linkedList.AddLast("Second");
            linkedList.AddFirst("Zero");

            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
        }
    }
}
