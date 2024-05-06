

namespace RecipeBook.Common.Ingredients.ViewModels
{
	public class GetIngredientVM
	{

		public Guid RecipeId { get; set; }
		public Guid ProductId { get; set; }
		public float Quantity { get; set; }
		public Guid UnitOfMeasurementId { get; set; }

	}
}
