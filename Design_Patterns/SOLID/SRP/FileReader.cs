namespace Design_Patterns.SOLID.SRP
{

    public class FileReader
    {
        public void ReadFile()
        {
            Console.WriteLine("Welcome to file Reading!");

            while (true)
            {
                Console.WriteLine("Enter the name of the file to read (or 'exit' to quit): ");
                string fileName = Console.ReadLine();

                if (fileName == null || fileName.Trim() == "")
                {
                    Console.WriteLine("Null or empty value is not accepted. Please enter a valid filename.");
                    continue;
                }

                if (fileName.ToLower() == "exit")
                {
                    break;
                }

                string fullPath = Path.Combine(@"C:\Users\Public\Documents", fileName); // Replace with a generic location

                try
                {
                    // Read all text content into a string
                    string fileContents = File.ReadAllText(fullPath);

                    Console.WriteLine("File contents:");
                    Console.WriteLine(fileContents);
                    break; // Exit the loop after successful read
                }
                catch (FileNotFoundException ex)
                {
                    Console.WriteLine("Error: File '{0}' not found.", fileName);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred while reading the file: {0}", ex.Message);
                }
            }

            Console.WriteLine("Exiting...");
        }
    }
}
