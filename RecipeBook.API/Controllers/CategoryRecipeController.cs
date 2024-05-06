using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Recipebook.Application.Features.CategoryRecipes.Commands.CreateCategoryRecipe.Record;
using Recipebook.Application.Features.CategoryRecipes.Queries.GetCategoryRecipeById.Record;
using Recipebook.Application.Features.CategoryRecipes.Queries.GetListCategoryRecipe.Record;
using RecipeBook.Application.Features.CategoryRecipes.Commands.DeleteCategoryRecipe.Record;
using RecipeBook.Application.Features.CategoryRecipes.Commands.UpdateCategoryRecipe.Record;
using RecipeBook.Common.CategoryProducts.ViewModels;
using RecipeBook.Common.CategoryRecipes.ViewModels;


namespace RecipeBook.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryRecipeController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<GetListCategoryRecipeVM>>> GetAllAsync()
        {
            return Ok(await mediator.Send(new GetListCategoryRecipeQuery()));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GetCategoryRecipeVM>> GetAllAsync(Guid id)
        {
            return Ok(await mediator.Send(new GetCategoryRecipeByIdQuery { Id = id }));
        }

        [HttpPost()]
        public async Task<ActionResult<CreateCategoryRecipeCommand>> PostAsync([FromBody] CreateCategoryRecipeCommand createCategoryRecipeCommand)
        {
            return Ok(await mediator.Send(createCategoryRecipeCommand));
        }

        [HttpPut()]
        public async Task<IActionResult> PutAsync([FromBody] UpdateCategoryRecipeCommand updateCategoryRecipeCommand)
        {
            await mediator.Send(updateCategoryRecipeCommand);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            await mediator.Send(new DeleteCategoryRecipeCommand { Id = id });
            return Ok();
        }
    }
}
