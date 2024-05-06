using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipebook.Application.Features.Articles.Commands.DeleteArticle.Record
{
	public record DeleteArticleCommand : IRequest
	{
		public Guid Id { get; set; }
	}
}
