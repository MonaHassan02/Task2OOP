using Task2OOPLibrary;

namespace BookExecution
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("--- Library System ----");

            Book b1 = new PrintedBook("The Great Gatsby", "F. Scott Fitzgerald", "978-0-743-27356-5", 180);
            Book b2 = new EBook("Clean Code", "Robert C. Martin", "978-0-132-35088-4", 2.5);
            Book b3 = new EBook("Design Patterns", "Erich Gamma", "978-0-201-63361-0", 3.2);


            b1.DisplayInfo();
            b2.DisplayInfo();
            b3.DisplayInfo();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
