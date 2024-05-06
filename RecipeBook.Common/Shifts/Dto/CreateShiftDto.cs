



namespace RecipeBook.Common.Shifts.Dto
{
    public class CreateShiftDto
    {		
		public DateTime Date { get; set; }		
		public int NumberOfPerson { get; set; }
		public bool IsStatementRecipe { get; set; }		
		public Guid RecipeId { get; set; }		
	}
}
