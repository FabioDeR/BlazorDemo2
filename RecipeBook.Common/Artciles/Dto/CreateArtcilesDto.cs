using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBook.Common.Artciles.Dto
{
    public class CreateArtcilesDto
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public Guid? CategoryId { get; set; }
        public float Quantity { get; set; }
        public Guid UnitOfMeasurementId { get; set; }
        public DateTime? ExpiratedDate { get; set; }
    }
}
