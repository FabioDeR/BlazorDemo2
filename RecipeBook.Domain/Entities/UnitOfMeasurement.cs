using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using RecipeBook.Domain.Common;

namespace RecipeBook.Domain.Entities 
{
	public class UnitOfMeasurement : AuditableEntity
	{
		[Required(ErrorMessage = "Name is required")]
		[MaxLength(50, ErrorMessage = "Name must not exceed 50 characters")]
		public string Name { get; set; } = string.Empty;

		[Required(ErrorMessage = "Please select a type")]
		[ForeignKey("TypeOfProductId")]
		public Guid TypeOfProductId { get; set; }
		public virtual TypeOfProduct TypeOfProduct { get; set; } = default!;

		[Range(0, float.MaxValue,ErrorMessage = "AverageQuantity must be greater than 0 ")]
		public float AverageQuantity { get; set; }

		[Required(ErrorMessage = "Abbreviation is required")]
		[MaxLength(50, ErrorMessage = "Abbreviation must not exceed 50 characters")]
		public string Abbreviation { get; set; } = string.Empty;

		public virtual ICollection<Article>? Articles { get; set; }


	
	}
}