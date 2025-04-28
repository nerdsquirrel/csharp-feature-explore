namespace CSharpFeatureExplore.DatatTypes
{
    public class EnumExample
    {
        public static void Show()
        {
            Day today = Day.Monday;

            Console.WriteLine("--- Enum Example ---");
            Console.WriteLine($"Today is: {today}");
            Console.WriteLine();
        }

        private enum Day
        {
            Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
        }
    }
}
