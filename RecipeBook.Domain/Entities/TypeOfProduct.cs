using RecipeBook.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace RecipeBook.Domain.Entities
{
	public class TypeOfProduct : AuditableEntity
	{
		[Required(ErrorMessage = "Name is required")]
		[MaxLength(50, ErrorMessage = "Name must not exceed 50 characters")]
		public string Name { get; set; } = string.Empty;

		public virtual ICollection<Product> Products { get; set; } = default!;
		public virtual ICollection<UnitOfMeasurement> UnitOfMeasurements { get; set; } = default!;
	}
}