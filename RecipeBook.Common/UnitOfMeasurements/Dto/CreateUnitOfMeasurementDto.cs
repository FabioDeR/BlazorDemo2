

namespace RecipeBook.Common.UnitOfMeasurements.Dto
{
    public class CreateUnitOfMeasurementDto
    {		
		public string Name { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;		
		public Guid TypeOfProductId { get; set; }
		public string ImagePath { get; set; } = string.Empty;
	}
}
