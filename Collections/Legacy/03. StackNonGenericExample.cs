using System.Collections;

namespace CSharpFeatureExplore.Collections.Legacy
{
    public class StackNonGenericExample
    {
        public static void Show()
        {
            Console.WriteLine("--- Stack (non-generic) Example ---");

            Stack stack = new Stack();
            stack.Push("First");
            stack.Push(2);
            stack.Push(3.14);

            Console.WriteLine($"Popped: {stack.Pop()}");

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
        }
    }
}
