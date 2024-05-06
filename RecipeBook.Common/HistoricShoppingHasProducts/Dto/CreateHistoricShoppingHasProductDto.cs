

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RecipeBook.Common.HistoricShoppingHasProduct.Dto
{
    public class CreateHistoricShoppingHasProductDto
	{
		
		public Guid HistoricShoppingId { get; set; }		
		public Guid ProductId { get; set; }		
		public float Quantity { get; set; }
		public float QuantityPiece { get; set; }
		public string UnitOfMeasurementName { get; set; } = string.Empty;
	}
}
