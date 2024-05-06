using MediatR;
using RecipeBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBook.Application.Features.Articles.Commands.UpdateArticle
{
    public class UpdateArticleCommand : IRequest
    {
        public Guid Id { get; set; }     
        public Guid ProductId { get; set; }
        public float Quantity { get; set; }
        public Guid UnitOfMeasurementId { get; set; }
        public Guid? CategoryProductId { get; set; }           
        public DateTime ExpirationDate { get; set; }
    }
}
