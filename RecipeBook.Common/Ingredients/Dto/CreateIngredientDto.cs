

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RecipeBook.Common.Ingredients.Dto
{
    public class CreateIngredientDto
    {		
		public Guid RecipeId { get; set; }	
		public Guid ProductId { get; set; }
		public float Quantity { get; set; }		
		public Guid UnitOfMeasurementId { get; set; }	
	}
}
