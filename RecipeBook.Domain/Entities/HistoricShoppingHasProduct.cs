using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using RecipeBook.Domain.Common;

namespace RecipeBook.Domain.Entities
{
	public class HistoricShoppingHasProduct : AuditableEntity
	{

		[Required]
		[ForeignKey("HistoricShoppingId")]
		public Guid HistoricShoppingId { get; set; }
		public virtual HistoricShopping HistoricShopping { get; set; } = default!;

		[Required]
		[ForeignKey("ProductId")]
		public Guid ProductId { get; set; }
		public virtual Product Product { get; set; } = default!;

		[Required]
		[Range(0, float.MaxValue)]
		public float Quantity { get; set; }

		public float QuantityPiece { get; set; }


		public string UnitOfMeasurementName { get; set; } = string.Empty;
	}
}