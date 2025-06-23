namespace CSharpFeatureExplore.LINQ
{
    public class Person
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int Age { get; set; }
        public required string City { get; set; }
    }

    internal class LinqExamples
    {
        private static List<Person> people = new()
        {
            new Person { Id = 1, Name = "Alice", Age = 25, City = "Dhaka" },
            new Person { Id = 2, Name = "Bob", Age = 17, City = "Chittagong" },
            new Person { Id = 3, Name = "Charlie", Age = 30, City = "Dhaka" },
            new Person { Id = 4, Name = "David", Age = 22, City = "Sylhet" },
        };

        public static void Filtering()
        {
            var adults = people.Where(p => p.Age >= 18);
            Console.WriteLine("Adults:");
            foreach (var person in adults)
                Console.WriteLine($" - {person.Name} ({person.Age})");
        }

        public static void Projection()
        {
            var names = people.Select(p => p.Name);
            Console.WriteLine("Names: " + string.Join(", ", names));
        }

        public static void Flattening()
        {
            var students = new[]
            {
                new { Name = "Alice", Courses = new[] { "Math", "Physics" } },
                new { Name = "Bob", Courses = new[] { "Math", "Biology" } }
            };

            var allCourses = students.SelectMany(s => s.Courses).Distinct();
            Console.WriteLine("All Courses: " + string.Join(", ", allCourses));
        }

        public static void Sorting()
        {
            var sorted = people.OrderBy(p => p.City).ThenBy(p => p.Name);
            Console.WriteLine("Sorted People by City then Name:");
            foreach (var person in sorted)
                Console.WriteLine($" - {person.Name} ({person.City})");
        }

        public static void Grouping()
        {
            var grouped = people.GroupBy(p => p.City);
            Console.WriteLine("Grouped by City:");
            foreach (var group in grouped)
            {
                Console.WriteLine(group.Key + ":");
                foreach (var person in group)
                    Console.WriteLine($" - {person.Name}");
            }
        }

        public static void Joining()
        {
            var orders = new[]
            {
                new { OrderId = 101, PersonId = 1 },
                new { OrderId = 102, PersonId = 3 }
            };

            var joined = orders.Join(people,
                o => o.PersonId,
                p => p.Id,
                (o, p) => new { o.OrderId, p.Name });

            Console.WriteLine("Join Orders with People:");
            foreach (var item in joined)
                Console.WriteLine($" - OrderId: {item.OrderId}, Name: {item.Name}");
        }

        public static void GroupJoining()
        {
            var orders = new[]
            {
                new { OrderId = 101, PersonId = 1 },
                new { OrderId = 102, PersonId = 3 }
            };

            var groupJoined = people.GroupJoin(orders,
                p => p.Id,
                o => o.PersonId,
                (p, oGroup) => new { p.Name, Orders = oGroup.Select(o => o.OrderId) });

            Console.WriteLine("GroupJoin People with Orders:");
            foreach (var item in groupJoined)
                Console.WriteLine($" - {item.Name}: [{string.Join(", ", item.Orders)}]");
        }

        public static void Aggregation()
        {
            Console.WriteLine("Total People: " + people.Count());
            Console.WriteLine("Sum of Ages: " + people.Sum(p => p.Age));
            Console.WriteLine("Average Age: " + people.Average(p => p.Age));
        }

        public static void Quantifiers()
        {
            Console.WriteLine("Any minors? " + people.Any(p => p.Age < 18));
            Console.WriteLine("All adults? " + people.All(p => p.Age >= 18));
            Console.WriteLine("Contains Alice? " + people.Select(p => p.Name).Contains("Alice"));
        }

        public static void SetOperations()
        {
            var cities = people.Select(p => p.City).Distinct();
            Console.WriteLine("Unique Cities: " + string.Join(", ", cities));

            var a = new[] { "a", "b", "c" };
            var b = new[] { "b", "c", "d" };

            Console.WriteLine("Union: " + string.Join(", ", a.Union(b)));
            Console.WriteLine("Except: " + string.Join(", ", a.Except(b)));
            Console.WriteLine("Intersect: " + string.Join(", ", a.Intersect(b)));
        }

        public static void ElementOperators()
        {
            var first = people.First();
            Console.WriteLine("First Person: " + first.Name);

            var firstFromDhaka = people.First(p => p.City == "Dhaka");
            Console.WriteLine("First from Dhaka: " + firstFromDhaka.Name);

            var maybeZahid = people.FirstOrDefault(p => p.Name == "Zahid");
            Console.WriteLine("Zahid exists? " + (maybeZahid != null));


            var isDhakaPresent = people.Any(p => p.City == "Dhaka");
            isDhakaPresent = people.Where(p => p.City == "Dhaka").Count() > 0;

            var isListEmpty = !people.Any();
            isListEmpty = people.Count == 0;
        }
    }
}
