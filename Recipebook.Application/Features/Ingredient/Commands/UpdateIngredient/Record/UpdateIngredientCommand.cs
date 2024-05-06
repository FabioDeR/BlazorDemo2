using MediatR;
using RecipeBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBook.Application.Features.Ingredients.Commands.Updateingredient
{
    public class UpdateIngredientCommand : IRequest
    {
        public Guid Id { get; set; }
        public Guid RecipeId { get; set; }
        public Guid ProductId { get; set; }
        public float Quantity { get; set; }
        public Guid UnitOfMeasurementId { get; set; }

    }
}
