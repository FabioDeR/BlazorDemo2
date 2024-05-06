using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Recipebook.Application.Features.Recipes.Commands.CreateRecipe.Record;
using RecipeBook.Application.Features.Recipes.Commands.DeleteRecipe.Record;
using RecipeBook.Common.Recipes.Responses;
using RecipeBook.Common.Recipes.ViewModels;
using Recipebook.Recipes.Features.Recipes.Queries.GetCategoryRecipeById.Record;
using RecipeBook.Recipes.Features.UpdateRecipe.Commands.UpdateRecipe.Record;
using Recipebook.Application.Features.Recipes.Queries.GetListRecipe.Record;

namespace RecipeBook.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController(IMediator mediator) : ControllerBase
    {

        [HttpGet]
        public async Task<ActionResult<List<GetListRecipeVM>>> GetAllAsync()
        {
            return Ok(await mediator.Send(new GetListRecipeQuery()));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GetRecipeVM>> GetAllAsync(Guid id)
        {
            return Ok(await mediator.Send(new GetRecipeByIdQuery { Id = id }));
        }

        [HttpPost()]
        public async Task<ActionResult<CreateRecipeCommandResponse>> PostAsync([FromBody] CreateRecipeCommand createRecipeCommand)
        {
            return Ok(await mediator.Send(createRecipeCommand));
        }

        [HttpPut()]
        public async Task<IActionResult> PutAsync([FromBody] UpdateRecipeCommand updateRecipeCommand)
        {
            await mediator.Send(updateRecipeCommand);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            await mediator.Send(new DeleteRecipeCommand { Id = id });
            return Ok();
        }
    }
}
