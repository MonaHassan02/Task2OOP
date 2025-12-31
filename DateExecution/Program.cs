using Task2OOPLibrary;

namespace DateExecution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---- Hire Date Validation ----");

            HireDate[] testDates = new HireDate[]
            {
                new HireDate(32, 1, 2023),  
                new HireDate(29, 2, 2023),  
                new HireDate(29, 2, 2024),  
                new HireDate(15, 13, 2023), 
                new HireDate(15, 6, 1800)   
            };

            Console.WriteLine(" Hire Date Validation Results:");
            foreach (var date in testDates)
            {
                Console.WriteLine($"Date: {date}");
            }

            Console.WriteLine(" Press any key to exit...");
            Console.ReadKey();
        }
    }
}
