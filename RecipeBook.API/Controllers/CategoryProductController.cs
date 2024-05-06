using MediatR;
using Microsoft.AspNetCore.Mvc;
using Productbook.Application.Features.CategoryProducts.Commands.CreateCategoryProduct.Record;
using Productbook.Application.Features.CategoryProducts.Queries.GetListCategoryProduct.Record;
using Recipebook.Application.Features.CategoryRecipes.Queries.GetCategoryProductById.Record;
using RecipeBook.Application.Features.CategoryProducts.Commands.UpdateCategoryProduct.Record;
using RecipeBook.Application.Features.CategoryRecipes.Commands.DeleteCategoryProduct.Record;
using RecipeBook.Common.Artciles.ViewModels;
using RecipeBook.Common.CategoryProducts.Responses;
using RecipeBook.Common.CategoryProducts.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RecipeBook.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryProductController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<GetListCategoryProductVM>>> GetAllAsync()
        {
            return Ok(await mediator.Send(new GetListCategoryProductQuery()));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GetCategoryProductVM>> GetAllAsync(Guid id)
        {
            return Ok(await mediator.Send(new GetCategoryProductByIdQuery { Id = id }));
        }

        [HttpPost()]
        public async Task<ActionResult<CreateCategoryProductCommandResponse>> PostAsync([FromBody] CreateCategoryProductCommand createCategoryProductCommand)
        {
            return Ok(await mediator.Send(createCategoryProductCommand));
        }

        [HttpPut()]
        public async Task<IActionResult> PutAsync([FromBody] UpdateCategoryProductCommand updateCategoryProductCommand)
        {
            await mediator.Send(updateCategoryProductCommand);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            await mediator.Send(new DeleteCategoryProductCommand { Id = id });
            return Ok();
        }
    }
}
