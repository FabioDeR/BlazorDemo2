using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBook.Domain.Common
{
	public class AuditableEntity
	{
		[Key]
		public Guid Id { get; set; }	


		[Required]
		public string CreationTrackingUserId { get; set; } = string.Empty;
		public DateTime? CreationDate { get; set; }


		public DateTime? DeleteDate { get; set; }
		public string DeleteTrackingUserId { get; set; } = string.Empty;

		public DateTime? UpdateDate { get; set; }
		public string UpdateTrackingUserId { get; set; } = string.Empty;
	}
}
