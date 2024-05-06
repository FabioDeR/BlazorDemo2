
namespace RecipeBook.Common.Recipes.ViewModels
{
    public class GetListRecipeVM
    {
		public Guid Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;
		public Guid TypeOfRecipeId { get; set; }
		public string ImagePath { get; set; } = string.Empty;
	}
}
