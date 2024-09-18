using static RecipeBook.UI.Components.Pages.Home;

namespace RecipeBook.UI.Components.Shared.Store
{
    public class EmployeeState
    {
        public IEnumerable<Employee> Employees;

        public event Action OnChange;

        public void NotifyStateChanged() => OnChange?.Invoke();
    }
}
