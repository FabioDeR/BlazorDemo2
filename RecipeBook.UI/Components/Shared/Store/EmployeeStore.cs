

using static RecipeBook.UI.Components.Pages.Home;

namespace RecipeBook.UI.Components.Shared.Store
{
    public class EmployeeStore : IEmployeeStore
    {




        public Task<IEnumerable<Employee>> LoadingEmployee()
        {
            var employees = GetEmployees1();
            return Task.FromResult(employees);
        }

        public IEnumerable<Employee> GetEmployees1()
        {
            return new List<Employee>
        {
            new Employee { EmployeeID = 1, FirstName = "John", LastName = "Doe" },
            new Employee { EmployeeID = 2, FirstName = "Jane", LastName = "Smith" },
            new Employee { EmployeeID = 3, FirstName = "Alice", LastName = "Johnson" },
            new Employee { EmployeeID = 4, FirstName = "Bob", LastName = "Brown" },
            new Employee { EmployeeID = 5, FirstName = "Chris", LastName = "Davis" },
            new Employee { EmployeeID = 6, FirstName = "Emma", LastName = "Wilson" },
            new Employee { EmployeeID = 7, FirstName = "George", LastName = "Taylor" },
            new Employee { EmployeeID = 8, FirstName = "Hannah", LastName = "Moore" },
            new Employee { EmployeeID = 9, FirstName = "Isaac", LastName = "Martin" },
            new Employee { EmployeeID = 10, FirstName = "Julia", LastName = "Clark" }
        };
        }

        public IEnumerable<Employee> GetEmployees2()
        {
            return new List<Employee>
        {
            new Employee { EmployeeID = 1, FirstName = "John", LastName = "Doe" },
            new Employee { EmployeeID = 2, FirstName = "Jane", LastName = "Smith" },
            new Employee { EmployeeID = 3, FirstName = "Alice", LastName = "Johnson" },
            new Employee { EmployeeID = 4, FirstName = "Bob", LastName = "Brown" },
            new Employee { EmployeeID = 5, FirstName = "Chris", LastName = "Davis" },
            new Employee { EmployeeID = 6, FirstName = "Emma", LastName = "Wilson" },
            new Employee { EmployeeID = 7, FirstName = "George", LastName = "Taylor" },
            new Employee { EmployeeID = 8, FirstName = "Hannah", LastName = "Moore" },
            new Employee { EmployeeID = 9, FirstName = "Isaac", LastName = "Martin" },
            new Employee { EmployeeID = 10, FirstName = "Julia", LastName = "Clark" },
            new Employee { EmployeeID = 12, FirstName = "Julia", LastName = "Clark" },
            new Employee { EmployeeID = 13, FirstName = "Julia", LastName = "Clark" },
            new Employee { EmployeeID = 14, FirstName = "Julia", LastName = "Clark" },
            new Employee { EmployeeID = 15, FirstName = "Julia", LastName = "Clark" },
            new Employee { EmployeeID = 16, FirstName = "Julia", LastName = "Clark" },

        };
        }

        public Task<IEnumerable<Employee>> ReloadEmployee()
        {
            var employees = GetEmployees2();
            return Task.FromResult(employees);
        }
    }
}
