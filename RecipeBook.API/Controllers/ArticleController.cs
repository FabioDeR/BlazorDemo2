using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Recipebook.Application.Features.Articles.Commands.CreateArticle.Record;
using Recipebook.Application.Features.Articles.Commands.DeleteArticle.Record;
using Recipebook.Application.Features.Articles.Queries.GetListArticle.Handler;
using RecipeBook.Application.Features.Articles.Commands.UpdateArticle;
using RecipeBook.Application.Features.Articles.Queries.ArticleDetail;
using RecipeBook.Common.Artciles.Responses;
using RecipeBook.Common.Artciles.ViewModels;

namespace RecipeBook.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<GetListArticleVM>>> GetAllAsync()
        {
            return Ok(await mediator.Send(new GetListArticleQuery()));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GetArticleVM>> GetAllAsync(Guid id)
        {
            return Ok(await mediator.Send(new GetArticleByIdQuery { Id = id }));
        }

        [HttpPost()]
        public async Task<ActionResult<CreateArticleCommandResponse>> PostAsync([FromBody] CreateArticleCommand createArticleCommand)
        {            
            return Ok(await mediator.Send(createArticleCommand));
        }

        [HttpPut()]
        public async Task<IActionResult> PutAsync([FromBody] UpdateArticleCommand updateArticleCommand)
        {
            await mediator.Send(updateArticleCommand);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            await mediator.Send(new DeleteArticleCommand { Id = id });
            return Ok();
        }

    }
}
