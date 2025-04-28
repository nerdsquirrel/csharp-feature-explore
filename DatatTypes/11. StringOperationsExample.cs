namespace CSharpFeatureExplore.DatatTypes
{
    public class StringOperationsExample
    {
        public static void Show()
        {
            Console.WriteLine("--- String Operations Example ---");

            string firstName = "John";
            string lastName = "Doe";
            string fullName = firstName + " " + lastName; // Concatenation
            Console.WriteLine($"Full Name (concatenation): {fullName}");

            string upperName = fullName.ToUpper(); // To Uppercase
            Console.WriteLine($"Uppercase: {upperName}");

            string lowerName = fullName.ToLower(); // To Lowercase
            Console.WriteLine($"Lowercase: {lowerName}");

            int length = fullName.Length; // Length
            Console.WriteLine($"Length: {length}");

            bool containsDoe = fullName.Contains("Doe"); // Contains
            Console.WriteLine($"Contains 'Doe': {containsDoe}");

            string sub = fullName.Substring(0, 4); // Substring
            Console.WriteLine($"Substring (0,4): {sub}");

            string trimmed = "   hello world   ".Trim(); // Trim
            Console.WriteLine($"Trimmed string: '{trimmed}'");

            string replaced = fullName.Replace("John", "Jane"); // Replace
            Console.WriteLine($"Replaced Name: {replaced}");

            string[] parts = fullName.Split(' '); // Split
            Console.WriteLine($"First Part: {parts[0]}, Second Part: {parts[1]}");

            Console.WriteLine();
        }
    }
}
