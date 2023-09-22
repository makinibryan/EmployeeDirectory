using EmployeeDirectory.Interfaces;

namespace Domain
{
    public class Employee: IEmployee
    {
        public Employee(int employeeId, string firstName, string lastName, string email, DateTime hireDate,
                        decimal salary)
        {
            EmployeeId = employeeId;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            HireDate = hireDate;
            Salary = salary;
        }

        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime HireDate { get; set; }
        public decimal Salary { get; }
        

        public decimal CalculateAnnualSalary( )
        {
            return Salary * 12;
        }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}