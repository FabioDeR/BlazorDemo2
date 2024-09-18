namespace RecipeBook.UI.Components.Shared.Store
{
    public interface IAction
    {
    }


    public record class LoadingEmployee() : IAction;
    public record class ReloadEmployee() : IAction;
}
