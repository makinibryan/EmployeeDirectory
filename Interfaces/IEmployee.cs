namespace EmployeeDirectory.Interfaces
{
    public interface IEmployee
    {
        // Method to calculate the employee's annual salary
        decimal CalculateAnnualSalary();

        // Method to get the employee's full name
        string GetFullName();
    }
}
