namespace CSharpFeatureExplore.DatatTypes
{
    public class StructExample
    {
        public static void Show()
        {
            Point p = new Point { X = 10, Y = 20 };

            Console.WriteLine("--- Struct Example ---");
            Console.WriteLine($"Point coordinates: ({p.X}, {p.Y})");
            Console.WriteLine();
        }

        struct Point
        {
            public int X;
            public int Y;
        }
    }
}
