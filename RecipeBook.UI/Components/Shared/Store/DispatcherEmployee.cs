namespace RecipeBook.UI.Components.Shared.Store
{
    public class DispatcherEmployee
    {
        private readonly IEmployeeStore _store;
        private readonly EmployeeState _state;

        public DispatcherEmployee(IEmployeeStore store, EmployeeState state)
        {
            _store = store;
            _state = state;
        }

        public async Task Dispatch(IAction action)
        {
            switch (action)
            {
                case LoadingEmployee _:
                    _state.Employees = await _store.LoadingEmployee();
                    break;
                case ReloadEmployee _:
                    _state.Employees = await _store.ReloadEmployee();
                    break;
                default:
                    break;
            }
        }
    }
}
