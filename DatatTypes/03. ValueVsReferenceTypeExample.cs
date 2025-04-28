namespace CSharpFeatureExplore.DatatTypes
{
    public class ValueVsReferenceTypeExample
    {
        public static void Show()
        {
            int a = 5;
            int b = a;
            b = 10;

            Console.WriteLine("--- Value Type Example ---");
            Console.WriteLine($"a: {a}, b: {b}");            

            Person p1 = new Person { Name = "Alice" };
            Person p2 = p1;
            p2.Name = "Bob";

            Console.WriteLine("--- Reference Type Example ---");
            Console.WriteLine($"p1.Name: {p1.Name}, p2.Name: {p2.Name}");
            Console.WriteLine();
        }

        internal class Person { 
            public string Name; 
        }
    }
}
