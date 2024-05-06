

using MediatR;
using Microsoft.AspNetCore.Mvc;
using Productbook.Application.Features.Products.Queries.GetListProduct.Record;
using Recipebook.Application.Features.Products.Commands.CreateProduct.Record;
using Recipebook.Products.Features.Products.Queries.GetCategoryRecipeById.Record;
using RecipeBook.Application.Features.Products.Commands.DeleteProduct.Record;
using RecipeBook.Common.Products.Responses;
using RecipeBook.Common.Products.ViewModels;
using RecipeBook.Products.Features.UpdateProduct.Commands.UpdateProduct.Record;

namespace RecipeBook.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<GetListProductVM>>> GetAllAsync()
        {
            return Ok(await mediator.Send(new GetListProductQuery()));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GetProductVM>> GetAllAsync(Guid id)
        {
            return Ok(await mediator.Send(new GetProductByIdQuery { Id = id }));
        }

        [HttpPost()]
        public async Task<ActionResult<CreateProductCommandResponse>> PostAsync([FromBody] CreateProductCommand createProductCommand)
        {
            return Ok(await mediator.Send(createProductCommand));
        }

        [HttpPut()]
        public async Task<IActionResult> PutAsync([FromBody] UpdateProductCommand updateProductCommand)
        {
            await mediator.Send(updateProductCommand);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            await mediator.Send(new DeleteProductCommand { Id = id });
            return Ok();
        }
    }
}
