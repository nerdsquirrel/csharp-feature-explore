namespace CSharpFeatureExplore.Collections.Basics
{
    public class StackExample
    {
        public static void Show()
        {
            Console.WriteLine("--- Stack<T> Example ---");

            var stack = new Stack<string>();
            stack.Push("First");
            stack.Push("Second");
            stack.Push("Third");

            Console.WriteLine($"Popped: {stack.Pop()}");

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
        }
    }
}
