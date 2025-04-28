namespace CSharpFeatureExplore.Event_Delegate
{
    public class MultiCastDelegateExample
    {
        public delegate void Notify(string message);

        public static void Show()
        {
            Notify notify = ShowMessage;
            notify += ShowUpperMessage;

            notify.Invoke("Multicast Delegate Example");
        }

        private static void ShowMessage(string msg)
        {
            Console.WriteLine($"Message: {msg}");
        }

        private static void ShowUpperMessage(string msg)
        {
            Console.WriteLine($"Uppercase Message: {msg.ToUpper()}");
        }
    }
}
