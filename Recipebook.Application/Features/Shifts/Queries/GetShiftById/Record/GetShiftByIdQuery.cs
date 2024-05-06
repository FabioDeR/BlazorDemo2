using MediatR;
using RecipeBook.Common.Shifts.ViewModels;


namespace Recipebook.Shifts.Features.Shifts.Queries.GetCategoryRecipeById.Record
{
    public record GetShiftByIdQuery : IRequest<GetShiftVM>
    {
        public Guid Id { get; set; }
    }
}
