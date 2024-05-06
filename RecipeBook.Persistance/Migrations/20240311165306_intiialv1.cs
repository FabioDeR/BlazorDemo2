using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecipeBook.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class intiialv1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_CategoriesProducts_CategoryId",
                table: "Articles");

            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Ingredients_IngredientId",
                table: "Articles");

            migrationBuilder.DropForeignKey(
                name: "FK_HistoricShoppingHasProducts_Ingredients_IngredientId",
                table: "HistoricShoppingHasProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_HistoricShoppings_Ingredients_IngredientId",
                table: "HistoricShoppings");

            migrationBuilder.DropForeignKey(
                name: "FK_Ingredients_CategoriesProducts_CategoryId",
                table: "Ingredients");

            migrationBuilder.DropForeignKey(
                name: "FK_Ingredients_Ingredients_IngredientId",
                table: "Ingredients");

            migrationBuilder.DropForeignKey(
                name: "FK_Ingredients_Products_ProductId",
                table: "Ingredients");

            migrationBuilder.DropForeignKey(
                name: "FK_Ingredients_Recipes_RecipeId",
                table: "Ingredients");

            migrationBuilder.DropForeignKey(
                name: "FK_Ingredients_TypeOfProducts_TypeOfProductId",
                table: "Ingredients");

            migrationBuilder.DropIndex(
                name: "IX_Ingredients_CategoryId",
                table: "Ingredients");

            migrationBuilder.DropIndex(
                name: "IX_Ingredients_IngredientId",
                table: "Ingredients");

            migrationBuilder.DropIndex(
                name: "IX_HistoricShoppings_IngredientId",
                table: "HistoricShoppings");

            migrationBuilder.DropIndex(
                name: "IX_HistoricShoppingHasProducts_IngredientId",
                table: "HistoricShoppingHasProducts");

            migrationBuilder.DropIndex(
                name: "IX_Articles_CategoryId",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "IngredientId",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "IngredientId",
                table: "HistoricShoppings");

            migrationBuilder.DropColumn(
                name: "IngredientId",
                table: "HistoricShoppingHasProducts");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Articles");

            migrationBuilder.RenameColumn(
                name: "TypeOfProductId",
                table: "Ingredients",
                newName: "UnitOfMeasurementId");

            migrationBuilder.RenameIndex(
                name: "IX_Ingredients_TypeOfProductId",
                table: "Ingredients",
                newName: "IX_Ingredients_UnitOfMeasurementId");

            migrationBuilder.RenameColumn(
                name: "IngredientId",
                table: "Articles",
                newName: "CategoryProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Articles_IngredientId",
                table: "Articles",
                newName: "IX_Articles_CategoryProductId");

            migrationBuilder.AlterColumn<string>(
                name: "Comment",
                table: "Recipes",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(350)",
                oldMaxLength: 350);

            migrationBuilder.AlterColumn<Guid>(
                name: "RecipeId",
                table: "Ingredients",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ProductId",
                table: "Ingredients",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Quantity",
                table: "Ingredients",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_CategoriesProducts_CategoryProductId",
                table: "Articles",
                column: "CategoryProductId",
                principalTable: "CategoriesProducts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredients_Products_ProductId",
                table: "Ingredients",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredients_Recipes_RecipeId",
                table: "Ingredients",
                column: "RecipeId",
                principalTable: "Recipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredients_UnitOfMeasurement_UnitOfMeasurementId",
                table: "Ingredients",
                column: "UnitOfMeasurementId",
                principalTable: "UnitOfMeasurement",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_CategoriesProducts_CategoryProductId",
                table: "Articles");

            migrationBuilder.DropForeignKey(
                name: "FK_Ingredients_Products_ProductId",
                table: "Ingredients");

            migrationBuilder.DropForeignKey(
                name: "FK_Ingredients_Recipes_RecipeId",
                table: "Ingredients");

            migrationBuilder.DropForeignKey(
                name: "FK_Ingredients_UnitOfMeasurement_UnitOfMeasurementId",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Ingredients");

            migrationBuilder.RenameColumn(
                name: "UnitOfMeasurementId",
                table: "Ingredients",
                newName: "TypeOfProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Ingredients_UnitOfMeasurementId",
                table: "Ingredients",
                newName: "IX_Ingredients_TypeOfProductId");

            migrationBuilder.RenameColumn(
                name: "CategoryProductId",
                table: "Articles",
                newName: "IngredientId");

            migrationBuilder.RenameIndex(
                name: "IX_Articles_CategoryProductId",
                table: "Articles",
                newName: "IX_Articles_IngredientId");

            migrationBuilder.AlterColumn<string>(
                name: "Comment",
                table: "Recipes",
                type: "nvarchar(350)",
                maxLength: 350,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<Guid>(
                name: "RecipeId",
                table: "Ingredients",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "ProductId",
                table: "Ingredients",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "CategoryId",
                table: "Ingredients",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Ingredients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "IngredientId",
                table: "Ingredients",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Ingredients",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "IngredientId",
                table: "HistoricShoppings",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "IngredientId",
                table: "HistoricShoppingHasProducts",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CategoryId",
                table: "Articles",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_CategoryId",
                table: "Ingredients",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_IngredientId",
                table: "Ingredients",
                column: "IngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoricShoppings_IngredientId",
                table: "HistoricShoppings",
                column: "IngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoricShoppingHasProducts_IngredientId",
                table: "HistoricShoppingHasProducts",
                column: "IngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_CategoryId",
                table: "Articles",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_CategoriesProducts_CategoryId",
                table: "Articles",
                column: "CategoryId",
                principalTable: "CategoriesProducts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Ingredients_IngredientId",
                table: "Articles",
                column: "IngredientId",
                principalTable: "Ingredients",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HistoricShoppingHasProducts_Ingredients_IngredientId",
                table: "HistoricShoppingHasProducts",
                column: "IngredientId",
                principalTable: "Ingredients",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HistoricShoppings_Ingredients_IngredientId",
                table: "HistoricShoppings",
                column: "IngredientId",
                principalTable: "Ingredients",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredients_CategoriesProducts_CategoryId",
                table: "Ingredients",
                column: "CategoryId",
                principalTable: "CategoriesProducts",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredients_Ingredients_IngredientId",
                table: "Ingredients",
                column: "IngredientId",
                principalTable: "Ingredients",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredients_Products_ProductId",
                table: "Ingredients",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredients_Recipes_RecipeId",
                table: "Ingredients",
                column: "RecipeId",
                principalTable: "Recipes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredients_TypeOfProducts_TypeOfProductId",
                table: "Ingredients",
                column: "TypeOfProductId",
                principalTable: "TypeOfProducts",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }
    }
}
