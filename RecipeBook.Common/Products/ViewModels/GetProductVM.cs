



namespace RecipeBook.Common.Products.ViewModels
{
    public class GetProductVM
    {
        public Guid Id { get; set; }	
		public string Name { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;	
		public Guid TypeOfProductId { get; set; }
		public string ImagePath { get; set; } = string.Empty;
	}
}
