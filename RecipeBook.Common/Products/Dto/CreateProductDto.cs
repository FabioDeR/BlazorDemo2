

namespace RecipeBook.Common.Products.Dto
{
    public class CreateProductDto
	{		
		public string Name { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;		
		public Guid TypeOfProductId { get; set; }
		public string ImagePath { get; set; } = string.Empty;
	}
}
