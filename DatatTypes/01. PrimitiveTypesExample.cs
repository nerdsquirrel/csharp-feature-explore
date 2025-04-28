namespace CSharpFeatureExplore.DatatTypes
{
    public class PrimitiveTypesExample
    {
        public static void Show()
        {
            int age = 25;
            float temperature = 36.6f;
            double pi = 3.14159;
            decimal salary = 50000.75m;
            bool isAvailable = true;
            char grade = 'A';
            string name = "John Doe";
            object anything = 123;

            Console.WriteLine("--- Primitive Types Example ---");
            Console.WriteLine($"Age: {age}, Temperature: {temperature}, Pi: {pi}, Salary: {salary}");
            Console.WriteLine($"Available: {isAvailable}, Grade: {grade}, Name: {name}, Object: {anything}");
            Console.WriteLine();
        }
    }
}
