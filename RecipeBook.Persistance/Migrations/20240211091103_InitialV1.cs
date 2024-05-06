using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecipeBook.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class InitialV1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoriesProducts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreationTrackingUserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteTrackingUserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateTrackingUserId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriesProducts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CategoriesRecipes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreationTrackingUserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteTrackingUserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateTrackingUserId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriesRecipes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    NumberOfPerson = table.Column<int>(type: "int", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationTrackingUserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteTrackingUserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateTrackingUserId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeOfProducts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreationTrackingUserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteTrackingUserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateTrackingUserId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeOfProducts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CategoryRecipeRecipe",
                columns: table => new
                {
                    CategoryRecipesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RecipesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryRecipeRecipe", x => new { x.CategoryRecipesId, x.RecipesId });
                    table.ForeignKey(
                        name: "FK_CategoryRecipeRecipe_CategoriesRecipes_CategoryRecipesId",
                        column: x => x.CategoryRecipesId,
                        principalTable: "CategoriesRecipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_CategoryRecipeRecipe_Recipes_RecipesId",
                        column: x => x.RecipesId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Shifts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumberOfPerson = table.Column<int>(type: "int", nullable: false),
                    IsStatementRecipe = table.Column<bool>(type: "bit", nullable: false),
                    RecipeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreationTrackingUserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteTrackingUserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateTrackingUserId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shifts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shifts_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeOfProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationTrackingUserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteTrackingUserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateTrackingUserId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_TypeOfProducts_TypeOfProductId",
                        column: x => x.TypeOfProductId,
                        principalTable: "TypeOfProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "UnitOfMeasurement",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TypeOfProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AverageQuantity = table.Column<float>(type: "real", nullable: false),
                    Abbreviation = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreationTrackingUserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteTrackingUserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateTrackingUserId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitOfMeasurement", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UnitOfMeasurement_TypeOfProducts_TypeOfProductId",
                        column: x => x.TypeOfProductId,
                        principalTable: "TypeOfProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "CategoryProductProduct",
                columns: table => new
                {
                    CategoryProductsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryProductProduct", x => new { x.CategoryProductsId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_CategoryProductProduct_CategoriesProducts_CategoryProductsId",
                        column: x => x.CategoryProductsId,
                        principalTable: "CategoriesProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_CategoryProductProduct_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TypeOfProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IngredientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    RecipeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreationTrackingUserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteTrackingUserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateTrackingUserId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ingredients_CategoriesProducts_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "CategoriesProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Ingredients_Ingredients_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredients",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Ingredients_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Ingredients_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Ingredients_TypeOfProducts_TypeOfProductId",
                        column: x => x.TypeOfProductId,
                        principalTable: "TypeOfProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Quantity = table.Column<float>(type: "real", nullable: false),
                    UnitOfMeasurementId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExpiratedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IngredientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreationTrackingUserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteTrackingUserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateTrackingUserId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Articles_CategoriesProducts_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "CategoriesProducts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Articles_Ingredients_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredients",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Articles_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Articles_UnitOfMeasurement_UnitOfMeasurementId",
                        column: x => x.UnitOfMeasurementId,
                        principalTable: "UnitOfMeasurement",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "HistoricShoppings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IngredientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreationTrackingUserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteTrackingUserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateTrackingUserId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoricShoppings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HistoricShoppings_Ingredients_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredients",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "HistoricShoppingHasProducts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HistoricShoppingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<float>(type: "real", nullable: false),
                    QuantityPiece = table.Column<float>(type: "real", nullable: false),
                    UnitOfMeasurementName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IngredientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreationTrackingUserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteTrackingUserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateTrackingUserId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoricShoppingHasProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HistoricShoppingHasProducts_HistoricShoppings_HistoricShoppingId",
                        column: x => x.HistoricShoppingId,
                        principalTable: "HistoricShoppings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_HistoricShoppingHasProducts_Ingredients_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredients",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HistoricShoppingHasProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Articles_CategoryId",
                table: "Articles",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_IngredientId",
                table: "Articles",
                column: "IngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_ProductId",
                table: "Articles",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_UnitOfMeasurementId",
                table: "Articles",
                column: "UnitOfMeasurementId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryProductProduct_ProductsId",
                table: "CategoryProductProduct",
                column: "ProductsId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryRecipeRecipe_RecipesId",
                table: "CategoryRecipeRecipe",
                column: "RecipesId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoricShoppingHasProducts_HistoricShoppingId",
                table: "HistoricShoppingHasProducts",
                column: "HistoricShoppingId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoricShoppingHasProducts_IngredientId",
                table: "HistoricShoppingHasProducts",
                column: "IngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoricShoppingHasProducts_ProductId",
                table: "HistoricShoppingHasProducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoricShoppings_IngredientId",
                table: "HistoricShoppings",
                column: "IngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_CategoryId",
                table: "Ingredients",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_IngredientId",
                table: "Ingredients",
                column: "IngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_ProductId",
                table: "Ingredients",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_RecipeId",
                table: "Ingredients",
                column: "RecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_TypeOfProductId",
                table: "Ingredients",
                column: "TypeOfProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_TypeOfProductId",
                table: "Products",
                column: "TypeOfProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Shifts_RecipeId",
                table: "Shifts",
                column: "RecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_UnitOfMeasurement_TypeOfProductId",
                table: "UnitOfMeasurement",
                column: "TypeOfProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "CategoryProductProduct");

            migrationBuilder.DropTable(
                name: "CategoryRecipeRecipe");

            migrationBuilder.DropTable(
                name: "HistoricShoppingHasProducts");

            migrationBuilder.DropTable(
                name: "Shifts");

            migrationBuilder.DropTable(
                name: "UnitOfMeasurement");

            migrationBuilder.DropTable(
                name: "CategoriesRecipes");

            migrationBuilder.DropTable(
                name: "HistoricShoppings");

            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "CategoriesProducts");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Recipes");

            migrationBuilder.DropTable(
                name: "TypeOfProducts");
        }
    }
}
