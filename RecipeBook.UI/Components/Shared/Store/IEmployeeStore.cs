using System.Threading.Tasks;
using static RecipeBook.UI.Components.Pages.Home;

namespace RecipeBook.UI.Components.Shared.Store
{
    public interface IEmployeeStore
    {
        Task<IEnumerable<Employee>> LoadingEmployee();

        Task<IEnumerable<Employee>> ReloadEmployee();
    }
}
