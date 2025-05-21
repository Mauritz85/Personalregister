using System.Runtime.ConstrainedExecution;

namespace StaffRegistry;

class Program
{
    static void Main()
    {
        StaffRegistry registry = new StaffRegistry();

        Console.WriteLine("Hej! Vad vill du göra?");
        Console.WriteLine("1. Lägga till personal i personalregistret:");
        Console.WriteLine("2. Skriva ut hela personalregistret");
        Console.WriteLine("Ditt val:");
        string? input = Console.ReadLine();

        switch (input)
        {
            case "1":
                Console.WriteLine("Hur många vill du lägga till?");
                string? inputAmount = Console.ReadLine();
                if (!int.TryParse(inputAmount, out int amount))
                {
                    amount = 0;
                    Console.WriteLine("Ogiltig input");
                }

                for (int i = 1; i <= amount; i++)
                {
                    Console.WriteLine($"Namn på anställd nr {i}");
                    string? name = Console.ReadLine();

                    Console.WriteLine($"Lön på anställd nr {i}");
                    string? salaryInput = Console.ReadLine();
                    if (!int.TryParse(salaryInput, out int salary))
                    {
                        salary = 0;
                        Console.WriteLine("Ogiltig lön, satt till 0.");
                    }

                    registry.addEmployee(new Employee(name, salary));

                }
                ;
                Console.WriteLine("Här är alla registrerade anställda:");
                registry.printAll();
                break;

            case "2":
                registry.printAll();
                break;


            default:
                Console.WriteLine("Ogiltigt val");
                break;
        }

    }
}
