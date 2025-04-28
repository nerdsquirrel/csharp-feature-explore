using System.Collections;

namespace CSharpFeatureExplore.Collections.Legacy
{
    public class ArrayListExample
    {
        public static void Show()
        {
            Console.WriteLine("--- ArrayList Example ---");

            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("Hello");
            arrayList.Add(3.14);
            arrayList.Add(true);

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"First item (object type): {arrayList[0]}");

            Console.WriteLine();
        }
    }
}
