namespace CSharpFeatureExplore.DatatTypes
{
    public class StringFormattingExample
    {
        public static void Show()
        {
            Console.WriteLine("--- String Formatting Example ---");

            string name = "Alice";
            int age = 28;
            double balance = 1023.45;

            // String Interpolation
            Console.WriteLine($"Interpolation: Name = {name}, Age = {age}, Balance = {balance:C}");

            // String.Format
            Console.WriteLine(string.Format("Formatted: Name = {0}, Age = {1}, Balance = {2:C}", name, age, balance));

            // Composite formatting (older style)
            Console.WriteLine("Composite Format: Name = {0}, Age = {1}", name, age);

            // Verbatim string
            string filePath = @"C:\Users\Alice\Documents\file.txt";
            Console.WriteLine($"Verbatim String: {filePath}");

            // Escape sequences
            Console.WriteLine("Escape Sequences: Line1\nLine2\tTabbed");

            Console.WriteLine();
        }
    }
}
