﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RecipeBook.Persistance.Context;

#nullable disable

namespace RecipeBook.Persistance.Migrations
{
    [DbContext(typeof(RecipeBookDbContext))]
    [Migration("20240311165306_intiialv1")]
    partial class intiialv1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CategoryProductProduct", b =>
                {
                    b.Property<Guid>("CategoryProductsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CategoryProductsId", "ProductsId");

                    b.HasIndex("ProductsId");

                    b.ToTable("CategoryProductProduct");
                });

            modelBuilder.Entity("CategoryRecipeRecipe", b =>
                {
                    b.Property<Guid>("CategoryRecipesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RecipesId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CategoryRecipesId", "RecipesId");

                    b.HasIndex("RecipesId");

                    b.ToTable("CategoryRecipeRecipe");
                });

            modelBuilder.Entity("RecipeBook.Domain.Entities.Article", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CategoryProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreationTrackingUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeleteTrackingUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ExpiratedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("Quantity")
                        .HasColumnType("real");

                    b.Property<Guid>("UnitOfMeasurementId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdateTrackingUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryProductId");

                    b.HasIndex("ProductId");

                    b.HasIndex("UnitOfMeasurementId");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("RecipeBook.Domain.Entities.CategoryProduct", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreationTrackingUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeleteTrackingUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdateTrackingUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CategoriesProducts");
                });

            modelBuilder.Entity("RecipeBook.Domain.Entities.CategoryRecipe", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreationTrackingUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeleteTrackingUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdateTrackingUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CategoriesRecipes");
                });

            modelBuilder.Entity("RecipeBook.Domain.Entities.HistoricShopping", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreationTrackingUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeleteTrackingUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdateTrackingUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("HistoricShoppings");
                });

            modelBuilder.Entity("RecipeBook.Domain.Entities.HistoricShoppingHasProduct", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreationTrackingUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeleteTrackingUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("HistoricShoppingId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("Quantity")
                        .HasColumnType("real");

                    b.Property<float>("QuantityPiece")
                        .HasColumnType("real");

                    b.Property<string>("UnitOfMeasurementName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdateTrackingUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("HistoricShoppingId");

                    b.HasIndex("ProductId");

                    b.ToTable("HistoricShoppingHasProducts");
                });

            modelBuilder.Entity("RecipeBook.Domain.Entities.Ingredient", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreationTrackingUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeleteTrackingUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("Quantity")
                        .HasColumnType("real");

                    b.Property<Guid>("RecipeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UnitOfMeasurementId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdateTrackingUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("RecipeId");

                    b.HasIndex("UnitOfMeasurementId");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("RecipeBook.Domain.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreationTrackingUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeleteTrackingUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid>("TypeOfProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdateTrackingUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("TypeOfProductId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("RecipeBook.Domain.Entities.Recipe", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreationTrackingUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeleteTrackingUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("NumberOfPerson")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdateTrackingUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Recipes");
                });

            modelBuilder.Entity("RecipeBook.Domain.Entities.Shift", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreationTrackingUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeleteTrackingUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsStatementRecipe")
                        .HasColumnType("bit");

                    b.Property<int>("NumberOfPerson")
                        .HasColumnType("int");

                    b.Property<Guid>("RecipeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdateTrackingUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RecipeId");

                    b.ToTable("Shifts");
                });

            modelBuilder.Entity("RecipeBook.Domain.Entities.TypeOfProduct", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreationTrackingUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeleteTrackingUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdateTrackingUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TypeOfProducts");
                });

            modelBuilder.Entity("RecipeBook.Domain.Entities.UnitOfMeasurement", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Abbreviation")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<float>("AverageQuantity")
                        .HasColumnType("real");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreationTrackingUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeleteTrackingUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid>("TypeOfProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdateTrackingUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("TypeOfProductId");

                    b.ToTable("UnitOfMeasurement");
                });

            modelBuilder.Entity("CategoryProductProduct", b =>
                {
                    b.HasOne("RecipeBook.Domain.Entities.CategoryProduct", null)
                        .WithMany()
                        .HasForeignKey("CategoryProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RecipeBook.Domain.Entities.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CategoryRecipeRecipe", b =>
                {
                    b.HasOne("RecipeBook.Domain.Entities.CategoryRecipe", null)
                        .WithMany()
                        .HasForeignKey("CategoryRecipesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RecipeBook.Domain.Entities.Recipe", null)
                        .WithMany()
                        .HasForeignKey("RecipesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RecipeBook.Domain.Entities.Article", b =>
                {
                    b.HasOne("RecipeBook.Domain.Entities.CategoryProduct", "Category")
                        .WithMany("Articles")
                        .HasForeignKey("CategoryProductId");

                    b.HasOne("RecipeBook.Domain.Entities.Product", "Product")
                        .WithMany("Articles")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RecipeBook.Domain.Entities.UnitOfMeasurement", "UnitOfMeasurement")
                        .WithMany("Articles")
                        .HasForeignKey("UnitOfMeasurementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Product");

                    b.Navigation("UnitOfMeasurement");
                });

            modelBuilder.Entity("RecipeBook.Domain.Entities.HistoricShoppingHasProduct", b =>
                {
                    b.HasOne("RecipeBook.Domain.Entities.HistoricShopping", "HistoricShopping")
                        .WithMany("HistoricShoppingHasProducts")
                        .HasForeignKey("HistoricShoppingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RecipeBook.Domain.Entities.Product", "Product")
                        .WithMany("HistoricShoppingHasProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HistoricShopping");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("RecipeBook.Domain.Entities.Ingredient", b =>
                {
                    b.HasOne("RecipeBook.Domain.Entities.Product", "Product")
                        .WithMany("Ingredients")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RecipeBook.Domain.Entities.Recipe", "Recipe")
                        .WithMany("Ingredients")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RecipeBook.Domain.Entities.UnitOfMeasurement", "UnitOfMeasurement")
                        .WithMany()
                        .HasForeignKey("UnitOfMeasurementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Recipe");

                    b.Navigation("UnitOfMeasurement");
                });

            modelBuilder.Entity("RecipeBook.Domain.Entities.Product", b =>
                {
                    b.HasOne("RecipeBook.Domain.Entities.TypeOfProduct", "TypeOfProduct")
                        .WithMany("Products")
                        .HasForeignKey("TypeOfProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TypeOfProduct");
                });

            modelBuilder.Entity("RecipeBook.Domain.Entities.Shift", b =>
                {
                    b.HasOne("RecipeBook.Domain.Entities.Recipe", "Recipe")
                        .WithMany("Shifts")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("RecipeBook.Domain.Entities.UnitOfMeasurement", b =>
                {
                    b.HasOne("RecipeBook.Domain.Entities.TypeOfProduct", "TypeOfProduct")
                        .WithMany("UnitOfMeasurements")
                        .HasForeignKey("TypeOfProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TypeOfProduct");
                });

            modelBuilder.Entity("RecipeBook.Domain.Entities.CategoryProduct", b =>
                {
                    b.Navigation("Articles");
                });

            modelBuilder.Entity("RecipeBook.Domain.Entities.HistoricShopping", b =>
                {
                    b.Navigation("HistoricShoppingHasProducts");
                });

            modelBuilder.Entity("RecipeBook.Domain.Entities.Product", b =>
                {
                    b.Navigation("Articles");

                    b.Navigation("HistoricShoppingHasProducts");

                    b.Navigation("Ingredients");
                });

            modelBuilder.Entity("RecipeBook.Domain.Entities.Recipe", b =>
                {
                    b.Navigation("Ingredients");

                    b.Navigation("Shifts");
                });

            modelBuilder.Entity("RecipeBook.Domain.Entities.TypeOfProduct", b =>
                {
                    b.Navigation("Products");

                    b.Navigation("UnitOfMeasurements");
                });

            modelBuilder.Entity("RecipeBook.Domain.Entities.UnitOfMeasurement", b =>
                {
                    b.Navigation("Articles");
                });
#pragma warning restore 612, 618
        }
    }
}
