using RecipeBook.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RecipeBook.Domain.Entities
{
	public class Article : AuditableEntity
	{

		[Required(ErrorMessage = "Please Select a product")]
		[ForeignKey("ProductId")]
		public Guid ProductId { get; set; }
		public virtual Product Product { get; set; } = default!;

		[ForeignKey("CategoryProductId")]
		public Guid? CategoryProductId { get; set; }
		public virtual CategoryProduct Category { get; set; } = default!;

		[Required(ErrorMessage = "Quantity is required")]
		[Range(0, float.MaxValue,ErrorMessage = "Quantity must be greater or equals than 0")]
		public float Quantity { get; set; }

		[Required(ErrorMessage = "Please Select a Unit Of Measurement")]
		[ForeignKey("UnitOfMeasurementId")]
		public Guid UnitOfMeasurementId { get; set; }
		public virtual UnitOfMeasurement UnitOfMeasurement { get; set; } = default!;

		public DateTime? ExpiratedDate { get; set; }
	}
}