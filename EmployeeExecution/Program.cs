using Task2OOPLibrary;

namespace EmployeeExecution
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" ---- Employee System ---- ");

            Employee[] empArr = new Employee[3];
            empArr[0] = new Employee(1, "Samy", SecurityLevel.DBA, 10000, new HireDate(17, 9, 2019), Gender.M);
            empArr[1] = new Employee(2, "Salwa", SecurityLevel.Guest, 8500, new HireDate(26, 3, 2021), Gender.F);
            empArr[2] = new Employee(3, "Mayar", SecurityLevel.Developer, 12000, new HireDate(2, 12, 2020), Gender.F);

            Console.WriteLine("--- Before Sorting ---");
            foreach (var e in empArr)
                Console.WriteLine(e);
            int boxingCount = 0;

            Array.Sort(empArr, (e1, e2) =>
            {
                boxingCount++;
                return e1.CompareTo(e2);
            });

            Console.WriteLine("--- After Sorting ---");
            foreach (var e in empArr)
                Console.WriteLine(e);

            Console.WriteLine($"Boxing/Unboxing operations: {boxingCount}");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
