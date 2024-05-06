




namespace RecipeBook.Common.UnitOfMeasurements.ViewModels
{
    public class GetUnitOfMeasurementVM
    {
        public Guid Id { get; set; }		
		public string Name { get; set; } = string.Empty;	
		public Guid TypeOfProductId { get; set; }		
		public float AverageQuantity { get; set; }	
		public string Abbreviation { get; set; } = string.Empty;
	}
}
