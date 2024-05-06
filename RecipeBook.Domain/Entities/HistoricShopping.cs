using RecipeBook.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace RecipeBook.Domain.Entities
{
	public class HistoricShopping : AuditableEntity
	{
		[Required(ErrorMessage = "Name is required")]
		[MaxLength(50, ErrorMessage = "Name must not exceed 50 characters")]
		public string Name { get; set; } = string.Empty;
		public virtual ICollection<HistoricShoppingHasProduct>? HistoricShoppingHasProducts { get; set; }
	}
}