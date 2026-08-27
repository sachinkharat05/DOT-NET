using HR.Models;

namespace HR.Services
{
    public class HROperationService
    {
        public async Task<List<Employee>> GetEmployeesAsync()
        {
            await Task.Delay(2000);

            return new List<Employee>
            {
                new Employee { Id = 101, Name = "Amit", Department = "IT", Salary = 50000 },
                new Employee { Id = 102, Name = "Neha", Department = "HR", Salary = 40000 },
                new Employee { Id = 103, Name = "Ravi", Department = "Finance", Salary = 60000 }
            };
        }

        public async Task<double> CalculateBonusAsync(Employee emp)
        {
            await Task.Delay(1000);
            return emp.Salary * 0.10;
        } 

        public async Task SaveEmployeeAsync(Employee emp)
        {
            await Task.Delay(1500);
            Console.WriteLine($"Employee saved asynchronously: {emp.Name}");
        }
    }
}
