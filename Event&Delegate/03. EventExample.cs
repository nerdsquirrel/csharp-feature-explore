namespace CSharpFeatureExplore.Event_Delegate
{
    public class EventExample
    {
        public delegate void Notify(string message);
        public static event Notify OnNotify;

        public static void Show()
        {
            OnNotify += Subscriber1;
            OnNotify += Subscriber2;

            FireEvent("Event has been triggered!");
        }

        private static void FireEvent(string message)
        {
            OnNotify?.Invoke(message);
        }

        private static void Subscriber1(string msg)
        {
            Console.WriteLine($"Subscriber 1 received: {msg}");
        }

        private static void Subscriber2(string msg)
        {
            Console.WriteLine($"Subscriber 2 received: {msg}");
        }
    }
}
