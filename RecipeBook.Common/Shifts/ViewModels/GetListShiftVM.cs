
namespace RecipeBook.Common.Shifts.ViewModels
{
    public class GetListShiftVM
    {
		public Guid Id { get; set; }
		public DateTime Date { get; set; }
		public int NumberOfPerson { get; set; }
		public bool IsStatementRecipe { get; set; }
		public Guid RecipeId { get; set; }
	}
}
