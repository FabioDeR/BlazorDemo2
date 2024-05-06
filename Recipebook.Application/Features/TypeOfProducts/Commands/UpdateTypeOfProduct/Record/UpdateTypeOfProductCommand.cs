using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBook.TypeOfProducts.Features.UpdateTypeOfProduct.Commands.UpdateTypeOfProduct.Record
{
    public class UpdateTypeOfProductCommand : IRequest
    {
		public Guid Id { get; set; }
		public string Name { get; set; } = string.Empty;

	}
}
