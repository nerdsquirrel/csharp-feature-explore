namespace CSharpFeatureExplore.Collections.Basics
{
    public class QueueExample
    {
        public static void Show()
        {
            Console.WriteLine("--- Queue<T> Example ---");

            var queue = new Queue<string>();
            queue.Enqueue("First");
            queue.Enqueue("Second");
            queue.Enqueue("Third");

            Console.WriteLine($"Dequeued: {queue.Dequeue()}");

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
        }
    }
}
