using RecipeBook.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RecipeBook.Domain.Entities
{
    public class Ingredient : AuditableEntity
    {
        [Required(ErrorMessage = "Please select a recipe")]
        [ForeignKey("RecipeId")]
        public Guid RecipeId { get; set; }
        public virtual Recipe Recipe { get; set; } = default!;

        [Required(ErrorMessage = "Please select a product")]
        [ForeignKey("ProductId")]

        public Guid ProductId { get; set; }
        public virtual Product Product { get; set; } = default!;

        [Required]
        [Range(0, float.MaxValue)]
        public float Quantity { get; set; }

        [Required(ErrorMessage = "Please select a unit")]
        [ForeignKey("UnitOfMeasurementId")]
        public Guid UnitOfMeasurementId { get; set; }
        public virtual UnitOfMeasurement UnitOfMeasurement { get; set; } = default!;
    }
}