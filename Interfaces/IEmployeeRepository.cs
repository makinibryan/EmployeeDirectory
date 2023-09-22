using Domain;

namespace EmployeeDirectory.Interfaces
{
    public interface IEmployeeRepository
    {
        // Create a new employee and add it to the repository
        Task<Employee> AddEmployee(Employee employee);

        // Retrieve an employee by their unique identifier
        Task<Employee> GetEmployeeById(int employeeId);

        // Update an existing employee in the repository
        Task UpdateEmployee(Employee employee);

        // Delete an employee from the repository
        Task DeleteEmployee(int employeeId);

        // Get all employees from the repository
        Task<IEnumerable<Employee>> GetAllEmployees();
        //Save Changes

        Task Save();
    }
}
