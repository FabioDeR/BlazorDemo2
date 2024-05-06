using Microsoft.EntityFrameworkCore;
using RecipeBook.Domain.Common;
using RecipeBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RecipeBook.Persistance.Context
{
	public class RecipeBookDbContext : DbContext
	{
		public RecipeBookDbContext(DbContextOptions options) : base(options)
		{
		}
		public DbSet<CategoryProduct> CategoriesProducts { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<CategoryRecipe> CategoriesRecipes { get; set; }
		public DbSet<Article> Articles { get; set; }
		public DbSet<Recipe> Recipes { get; set; }
		public DbSet<Ingredient> Ingredients { get; set; }
		public DbSet<Shift> Shifts { get; set; }
		public DbSet<HistoricShopping> HistoricShoppings { get; set; }
		public DbSet<HistoricShoppingHasProduct> HistoricShoppingHasProducts { get; set; }
		public DbSet<UnitOfMeasurement> UnitOfMeasurement { get; set; }
		public DbSet<TypeOfProduct> TypeOfProducts { get; set; }


		public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
		{

			foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
			{
				switch (entry.State)
				{
					case EntityState.Added:
						entry.Entity.CreationDate = DateTime.Now;
						entry.Entity.CreationTrackingUserId = "f84f074c-54fe-4a95-8eca-3a36226d4583";
						break;
					case EntityState.Modified:
						entry.Entity.UpdateDate = DateTime.Now;
						entry.Entity.UpdateTrackingUserId = "f84f074c-54fe-4a95-8eca-3a36226d4583";
						break;
					case EntityState.Deleted:
						entry.Entity.DeleteDate = DateTime.Now;
						entry.Entity.DeleteTrackingUserId = "f84f074c-54fe-4a95-8eca-3a36226d4583";
						break;
				}
			}
			return base.SaveChangesAsync(cancellationToken);
		}
	}
}
