using MediatR;
using RecipeBook.Common.UnitOfMeasurements.ViewModels;


namespace Recipebook.UnitOfMeasurements.Features.UnitOfMeasurements.Queries.GetCategoryRecipeById.Record
{
    public record GetUnitOfMeasurementByIdQuery : IRequest<GetUnitOfMeasurementVM>
    {
        public Guid Id { get; set; }
    }
}
