

using MediatR;
using Microsoft.AspNetCore.Mvc;
using Recipebook.Application.Features.Articles.Queries.GetListArticle.Handler;
using Recipebook.Application.Features.Ingredients.Commands.CreateIngredient.Record;
using Recipebook.Application.Features.Ingredients.Commands.DeleteIngredient.Record;
using RecipeBook.Application.Features.Ingredients.Commands.Updateingredient;
using RecipeBook.Application.Features.Ingredients.Queries.IngredientDetail;
using RecipeBook.Common.Ingredients.Responses;
using RecipeBook.Common.Ingredients.ViewModels;

namespace RecipeBook.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredientController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<GetListIngredientVM>>> GetAllAsync()
        {
            return Ok(await mediator.Send(new GetListIngredientQuery()));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GetIngredientVM>> GetAllAsync(Guid id)
        {
            return Ok(await mediator.Send(new GetIngredientByIdQuery { Id = id }));
        }

        [HttpPost()]
        public async Task<ActionResult<CreateIngredientCommandResponse>> PostAsync([FromBody] CreateIngredientCommand createIngredientCommand)
        {
            return Ok(await mediator.Send(createIngredientCommand));
        }

        [HttpPut()]
        public async Task<IActionResult> PutAsync([FromBody] UpdateIngredientCommand updateIngredientCommand)
        {
            await mediator.Send(updateIngredientCommand);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            await mediator.Send(new DeleteIngredientCommand { Id = id });
            return Ok();
        }
    }
}
