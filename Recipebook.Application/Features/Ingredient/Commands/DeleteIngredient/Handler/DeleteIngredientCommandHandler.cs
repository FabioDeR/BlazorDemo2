using MediatR;
using Recipebook.Application.Features.Ingredients.Commands.DeleteIngredient.Record;
using RecipeBook.Application.Exceptions;
using RecipeBook.Domain.Contract.Common;
using RecipeBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipebook.Application.Features.Ingredients.Commands.DeleteIngredient.Handler
{
	public class DeleteIngredientCommandHandler : IRequestHandler<DeleteIngredientCommand>
	{

		private readonly IAsyncRepository<Ingredient> _IngredientRepository;

		public DeleteIngredientCommandHandler(IAsyncRepository<Ingredient> IngredientRepository)
		{
			_IngredientRepository = IngredientRepository;
		}



		public async Task Handle(DeleteIngredientCommand request, CancellationToken cancellationToken)
		{

			try
			{
				var IngredientDeleted = await _IngredientRepository.GetByIdAsync(request.Id);

				if (IngredientDeleted == null)
				{
					throw new NotFoundException(nameof(Ingredient), request.Id);
				}

				await _IngredientRepository.DeleteAsync(IngredientDeleted);
			}
			catch (Exception ex)
			{

				throw;
			}
			
		}
	}
}
