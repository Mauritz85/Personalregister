using System.IO.Pipes;

namespace StaffRegistry
{
    public class StaffRegistry
    {
        private List<Employee> employees = new List<Employee>();

        public void addEmployee(Employee e)
        {
            employees.Add(e);
        }

        public void printAll()
        {
            if (employees.Count == 0)
            {
                Console.WriteLine("Inga anställda registrerade");
            }

            foreach (var employee in employees)
            {
                Console.WriteLine($"Namn: {employee.Name} Lön: {employee.Salary}");
            }
        }
    }
}