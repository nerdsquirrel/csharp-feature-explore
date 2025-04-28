namespace CSharpFeatureExplore.DatatTypes
{
    public class VarTypeInferenceExample
    {
        public static void Show()
        {
            var message = "Hello, World!";
            var number = 42;
            var price = 19.99m;

            Console.WriteLine("--- var Type Inference Example ---");
            Console.WriteLine($"Message: {message} ({message.GetType()})");
            Console.WriteLine($"Number: {number} ({number.GetType()})");
            Console.WriteLine($"Price: {price} ({price.GetType()})");
            Console.WriteLine();
        }
    }
}
