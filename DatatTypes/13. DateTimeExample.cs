namespace CSharpFeatureExplore.DatatTypes
{
    public class DateTimeExample
    {
        public static void Show()
        {
            Console.WriteLine("--- DateTime Example ---");

            DateTime now = DateTime.Now;
            Console.WriteLine($"Current Date and Time: {now}");

            DateTime today = DateTime.Today;
            Console.WriteLine($"Today's Date: {today.ToShortDateString()}");

            DateTime specificDate = new DateTime(2024, 12, 25);
            Console.WriteLine($"Specific Date: {specificDate:D}");

            DateTime tomorrow = today.AddDays(1);
            Console.WriteLine($"Tomorrow's Date: {tomorrow.ToShortDateString()}");

            TimeSpan duration = DateTime.Now - specificDate;
            Console.WriteLine($"Days since {specificDate.ToShortDateString()}: {duration.Days}");

            Console.WriteLine();
        }
    }
}
