using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using RecipeBook.Domain.Common;

namespace RecipeBook.Domain.Entities
{
	public class Product : AuditableEntity
	{
		[Required(ErrorMessage = "Name is required")]
		[MaxLength(50, ErrorMessage = "Name must not exceed 50 characters")]
		public string Name { get; set; } = string.Empty;		

		[Required(ErrorMessage = "Please select a type")]
		[ForeignKey("TypeOfProductId")]
		public Guid TypeOfProductId { get; set; }
		public virtual TypeOfProduct TypeOfProduct { get; set; } = default!;

		public string ImagePath { get; set; } = string.Empty;

		public virtual ICollection<Article>? Articles { get; set; }
		public virtual ICollection<Ingredient>? Ingredients { get; set; }		
		public virtual ICollection<HistoricShoppingHasProduct>? HistoricShoppingHasProducts { get; set; }
		public virtual ICollection<CategoryProduct> CategoryProducts { get; set; } = default!;
	}
}