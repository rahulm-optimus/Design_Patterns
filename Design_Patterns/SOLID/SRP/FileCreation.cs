namespace Design_Patterns.SOLID.SRP
{
    public class FileCreation
    {
        public void CreateFile()
        {
            Console.WriteLine("Welcome to file creation!");

            while (true)
            {
                Console.WriteLine("Enter a filename (or 'exit' to quit): ");
                string fileName = Console.ReadLine()?.ToLower();

                if (fileName == "exit")
                {
                    break;
                }

                try
                {
                    string fullPath = Path.Combine(@"C:\Users\Public\Documents", fileName);  // Replace with a generic location

                    Console.WriteLine("Enter content for the file: ");
                    string content = Console.ReadLine();

                    // Write content to the file
                    File.WriteAllText(fullPath, content);
                    Console.WriteLine("File created successfully!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error creating file: {0}", ex.Message);
                }
            }

            Console.WriteLine("Exiting...");
        }
    }
}
