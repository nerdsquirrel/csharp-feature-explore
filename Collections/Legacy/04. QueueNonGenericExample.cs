using System.Collections;

namespace CSharpFeatureExplore.Collections.Legacy
{
    public class QueueNonGenericExample
    {
        public static void Show()
        {
            Console.WriteLine("--- Queue (non-generic) Example ---");

            Queue queue = new Queue();
            queue.Enqueue("One");
            queue.Enqueue(2);
            queue.Enqueue(3.14);

            Console.WriteLine($"Dequeued: {queue.Dequeue()}");

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
        }
    }
}
