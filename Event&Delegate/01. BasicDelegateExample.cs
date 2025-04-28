namespace CSharpFeatureExplore.Event_Delegate
{
    public delegate void SimpleDelegate(string message);

    public class BasicDelegateExample
    {
        public static void Show()
        {
            SimpleDelegate del = PrintMessage;
            del("Hello, World from BasicDelegate Example!");
        }

        private static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
