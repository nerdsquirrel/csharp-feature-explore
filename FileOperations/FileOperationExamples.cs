namespace CSharpFeatureExplore.FileOperations
{
    public class FileOperationExamples
    {
        public static void Show()
        {
            string filePath = "example.txt";

            // 1. Create and Write
            File.WriteAllText(filePath, "Hello, this is the first line!");
            Console.WriteLine("File created and written.");

            // 2. Read
            if (File.Exists("NewFileForRead.txt"))
            {
                string content = File.ReadAllText(filePath);
                Console.WriteLine("\nReading File:");
                Console.WriteLine(content);
            }

            // 3. Append
            File.AppendAllText(filePath, "\nThis is an appended line.");
            Console.WriteLine("\nContent appended.");

            // 4. File Info
            FileInfo fileInfo = new FileInfo(filePath);
            if (fileInfo.Exists)
            {
                Console.WriteLine($"\nFile Info:");
                Console.WriteLine($"Size: {fileInfo.Length} bytes");
                Console.WriteLine($"Created: {fileInfo.CreationTime}");
            }

            // 5. Delete
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                Console.WriteLine("\nFile deleted.");
            }
        }
    }
}
