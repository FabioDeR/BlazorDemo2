using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Recipebook.Application.Features.TypeOfProducts.Commands.CreateTypeOfProduct.Record;
using Recipebook.TypeOfProducts.Features.TypeOfProducts.Queries.GetCategoryRecipeById.Record;
using RecipeBook.Application.Features.TypeOfProducts.Commands.DeleteTypeOfProduct.Record;
using RecipeBook.Common.TypeOfProducts.ViewModels;
using RecipeBook.TypeOfProducts.Features.UpdateTypeOfProduct.Commands.UpdateTypeOfProduct.Record;
using TypeOfProductbook.Application.Features.TypeOfProducts.Queries.GetListTypeOfProduct.Record;

namespace RecipeBook.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypeOfProductController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<GetListTypeOfProductVM>>> GetAllAsync()
        {
            return Ok(await mediator.Send(new GetListTypeOfProductQuery()));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GetTypeOfProductVM>> GetAllAsync(Guid id)
        {
            return Ok(await mediator.Send(new GetTypeOfProductByIdQuery { Id = id }));
        }

        [HttpPost()]
        public async Task<ActionResult<CreateTypeOfProductCommand>> PostAsync([FromBody] CreateTypeOfProductCommand createTypeOfProductCommand)
        {
            return Ok(await mediator.Send(createTypeOfProductCommand));
        }

        [HttpPut()]
        public async Task<IActionResult> PutAsync([FromBody] UpdateTypeOfProductCommand updateTypeOfProductCommand)
        {
            await mediator.Send(updateTypeOfProductCommand);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            await mediator.Send(new DeleteTypeOfProductCommand { Id = id });
            return Ok();
        }
    }
}
