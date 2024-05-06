using MediatR;
using RecipeBook.Common.Ingredients.Responses;
using RecipeBook.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Recipebook.Application.Features.Ingredients.Commands.CreateIngredient.Record
{
    public record CreateIngredientCommand : IRequest<CreateIngredientCommandResponse>
	{
       
        public Guid RecipeId { get; set; }
        public Guid ProductId { get; set; }      
        public float Quantity { get; set; }       
        public Guid UnitOfMeasurementId { get; set; }
       
    }
}
