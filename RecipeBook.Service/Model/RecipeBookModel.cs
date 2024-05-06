namespace RecipeBook.Service.Model
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Article
    {

        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public System.Guid Id { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("creationTrackingUserId")]
        [System.ComponentModel.DataAnnotations.Required]
        public string CreationTrackingUserId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("creationDate")]
        public System.DateTimeOffset? CreationDate { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("deleteDate")]
        public System.DateTimeOffset? DeleteDate { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("deleteTrackingUserId")]
        public string DeleteTrackingUserId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("updateDate")]
        public System.DateTimeOffset? UpdateDate { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("updateTrackingUserId")]
        public string UpdateTrackingUserId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("productId")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public System.Guid ProductId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("product")]
        public Product Product { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("categoryProductId")]
        public System.Guid? CategoryProductId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("category")]
        public CategoryProduct Category { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("quantity")]
        [System.ComponentModel.DataAnnotations.Range(0D, double.MaxValue)]
        public float Quantity { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("unitOfMeasurementId")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public System.Guid UnitOfMeasurementId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("unitOfMeasurement")]
        public UnitOfMeasurement UnitOfMeasurement { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("expiratedDate")]
        public System.DateTimeOffset? ExpiratedDate { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class CategoryProduct
    {

        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public System.Guid Id { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("creationTrackingUserId")]
        [System.ComponentModel.DataAnnotations.Required]
        public string CreationTrackingUserId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("creationDate")]
        public System.DateTimeOffset? CreationDate { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("deleteDate")]
        public System.DateTimeOffset? DeleteDate { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("deleteTrackingUserId")]
        public string DeleteTrackingUserId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("updateDate")]
        public System.DateTimeOffset? UpdateDate { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("updateTrackingUserId")]
        public string UpdateTrackingUserId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(50, MinimumLength = 1)]
        public string Name { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("articles")]
        public System.Collections.Generic.ICollection<Article> Articles { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("products")]
        public System.Collections.Generic.ICollection<Product> Products { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class CategoryRecipe
    {

        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public System.Guid Id { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("creationTrackingUserId")]
        [System.ComponentModel.DataAnnotations.Required]
        public string CreationTrackingUserId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("creationDate")]
        public System.DateTimeOffset? CreationDate { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("deleteDate")]
        public System.DateTimeOffset? DeleteDate { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("deleteTrackingUserId")]
        public string DeleteTrackingUserId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("updateDate")]
        public System.DateTimeOffset? UpdateDate { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("updateTrackingUserId")]
        public string UpdateTrackingUserId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(50, MinimumLength = 1)]
        public string Name { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("recipes")]
        public System.Collections.Generic.ICollection<Recipe> Recipes { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class CreateArtcilesDto
    {

        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public System.Guid Id { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("productId")]
        public System.Guid ProductId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("categoryId")]
        public System.Guid? CategoryId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("quantity")]
        public float Quantity { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("unitOfMeasurementId")]
        public System.Guid UnitOfMeasurementId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("expiratedDate")]
        public System.DateTimeOffset? ExpiratedDate { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class CreateArticleCommand
    {

        [System.Text.Json.Serialization.JsonPropertyName("productId")]
        public System.Guid ProductId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("categoryProductId")]
        public System.Guid? CategoryProductId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("quantity")]
        public float Quantity { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("unitOfMeasurementId")]
        public System.Guid UnitOfMeasurementId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("expiratedDate")]
        public System.DateTimeOffset? ExpiratedDate { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class CreateArticleCommandResponse
    {

        [System.Text.Json.Serialization.JsonPropertyName("success")]
        public bool Success { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("message")]
        public string Message { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("validationErrors")]
        public System.Collections.Generic.ICollection<string> ValidationErrors { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("articlesDto")]
        public CreateArtcilesDto ArticlesDto { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class CreateCategoryProductCommand
    {

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class CreateCategoryProductCommandResponse
    {

        [System.Text.Json.Serialization.JsonPropertyName("success")]
        public bool Success { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("message")]
        public string Message { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("validationErrors")]
        public System.Collections.Generic.ICollection<string> ValidationErrors { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("createCategoryProductDto")]
        public CreateCategoryProductDto CreateCategoryProductDto { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class CreateCategoryProductDto
    {

        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public System.Guid Id { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("typeOfProductId")]
        public System.Guid TypeOfProductId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("imagePath")]
        public string ImagePath { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class CreateCategoryRecipeCommand
    {

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class CreateIngredientCommand
    {

        [System.Text.Json.Serialization.JsonPropertyName("recipeId")]
        public System.Guid RecipeId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("productId")]
        public System.Guid ProductId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("quantity")]
        public float Quantity { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("unitOfMeasurementId")]
        public System.Guid UnitOfMeasurementId { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class CreateIngredientCommandResponse
    {

        [System.Text.Json.Serialization.JsonPropertyName("success")]
        public bool Success { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("message")]
        public string Message { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("validationErrors")]
        public System.Collections.Generic.ICollection<string> ValidationErrors { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("createIngredientDto")]
        public CreateIngredientDto CreateIngredientDto { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class CreateIngredientDto
    {

        [System.Text.Json.Serialization.JsonPropertyName("recipeId")]
        public System.Guid RecipeId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("productId")]
        public System.Guid ProductId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("quantity")]
        public float Quantity { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("unitOfMeasurementId")]
        public System.Guid UnitOfMeasurementId { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class CreateProductCommand
    {

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("typeOfProductId")]
        public System.Guid TypeOfProductId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("imagePath")]
        public string ImagePath { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("categoryProducts")]
        public System.Collections.Generic.ICollection<System.Guid> CategoryProducts { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class CreateProductCommandResponse
    {

        [System.Text.Json.Serialization.JsonPropertyName("success")]
        public bool Success { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("message")]
        public string Message { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("validationErrors")]
        public System.Collections.Generic.ICollection<string> ValidationErrors { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("createProductDto")]
        public CreateProductDto CreateProductDto { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class CreateProductDto
    {

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string Description { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("typeOfProductId")]
        public System.Guid TypeOfProductId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("imagePath")]
        public string ImagePath { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class CreateRecipeCommand
    {

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("comment")]
        public string Comment { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("numberOfPerson")]
        public int NumberOfPerson { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("imagePath")]
        public string ImagePath { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class CreateRecipeCommandResponse
    {

        [System.Text.Json.Serialization.JsonPropertyName("success")]
        public bool Success { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("message")]
        public string Message { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("validationErrors")]
        public System.Collections.Generic.ICollection<string> ValidationErrors { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("createRecipeDto")]
        public CreateRecipeDto CreateRecipeDto { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class CreateRecipeDto
    {

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("comment")]
        public string Comment { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("numberOfPerson")]
        public int NumberOfPerson { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("imagePath")]
        public string ImagePath { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class CreateShiftCommand
    {

        [System.Text.Json.Serialization.JsonPropertyName("date")]
        public System.DateTimeOffset Date { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("numberOfPerson")]
        public int NumberOfPerson { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("isStatementRecipe")]
        public bool IsStatementRecipe { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("recipeId")]
        public System.Guid RecipeId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("recipe")]
        public Recipe Recipe { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class CreateShiftCommandResponse
    {

        [System.Text.Json.Serialization.JsonPropertyName("success")]
        public bool Success { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("message")]
        public string Message { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("validationErrors")]
        public System.Collections.Generic.ICollection<string> ValidationErrors { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("createShiftDto")]
        public CreateShiftDto CreateShiftDto { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class CreateShiftDto
    {

        [System.Text.Json.Serialization.JsonPropertyName("date")]
        public System.DateTimeOffset Date { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("numberOfPerson")]
        public int NumberOfPerson { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("isStatementRecipe")]
        public bool IsStatementRecipe { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("recipeId")]
        public System.Guid RecipeId { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class CreateTypeOfProductCommand
    {

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class CreateUnitOfMeasurementCommand
    {

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("typeOfProductId")]
        public System.Guid TypeOfProductId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("averageQuantity")]
        public float AverageQuantity { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("abbreviation")]
        public string Abbreviation { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class GetArticleVM
    {

        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public System.Guid Id { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("productId")]
        public System.Guid ProductId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("quantity")]
        public float Quantity { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("unitOfMeasurementId")]
        public System.Guid UnitOfMeasurementId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("categoryProductId")]
        public System.Guid? CategoryProductId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("expirationDate")]
        public System.DateTimeOffset ExpirationDate { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class GetCategoryProductVM
    {

        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public System.Guid Id { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class GetCategoryRecipeVM
    {

        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public System.Guid Id { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class GetIngredientVM
    {

        [System.Text.Json.Serialization.JsonPropertyName("recipeId")]
        public System.Guid RecipeId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("productId")]
        public System.Guid ProductId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("quantity")]
        public float Quantity { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("unitOfMeasurementId")]
        public System.Guid UnitOfMeasurementId { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class GetListArticleVM
    {

        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public System.Guid Id { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("productId")]
        public System.Guid ProductId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("quantity")]
        public float Quantity { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("unitOfMeasurementId")]
        public System.Guid UnitOfMeasurementId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("categoryProductId")]
        public System.Guid? CategoryProductId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("expirationDate")]
        public System.DateTimeOffset ExpirationDate { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class GetListCategoryProductVM
    {

        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public System.Guid Id { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class GetListCategoryRecipeVM
    {

        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public System.Guid Id { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class GetListIngredientVM
    {

        [System.Text.Json.Serialization.JsonPropertyName("recipeId")]
        public System.Guid RecipeId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("productId")]
        public System.Guid ProductId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("quantity")]
        public float Quantity { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("unitOfMeasurementId")]
        public System.Guid UnitOfMeasurementId { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class GetListProductVM
    {

        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public System.Guid Id { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string Description { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("typeOfProductId")]
        public System.Guid TypeOfProductId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("imagePath")]
        public string ImagePath { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class GetListRecipeVM
    {

        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public System.Guid Id { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string Description { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("typeOfRecipeId")]
        public System.Guid TypeOfRecipeId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("imagePath")]
        public string ImagePath { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class GetListShiftVM
    {

        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public System.Guid Id { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("date")]
        public System.DateTimeOffset Date { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("numberOfPerson")]
        public int NumberOfPerson { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("isStatementRecipe")]
        public bool IsStatementRecipe { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("recipeId")]
        public System.Guid RecipeId { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class GetListTypeOfProductVM
    {

        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public System.Guid Id { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class GetListUnitOfMeasurementVM
    {

        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public System.Guid Id { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("typeOfProductId")]
        public System.Guid TypeOfProductId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("averageQuantity")]
        public float AverageQuantity { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("abbreviation")]
        public string Abbreviation { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class GetProductVM
    {

        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public System.Guid Id { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string Description { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("typeOfProductId")]
        public System.Guid TypeOfProductId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("imagePath")]
        public string ImagePath { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class GetRecipeVM
    {

        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public System.Guid Id { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string Description { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("typeOfRecipeId")]
        public System.Guid TypeOfRecipeId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("imagePath")]
        public string ImagePath { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class GetShiftVM
    {

        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public System.Guid Id { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("date")]
        public System.DateTimeOffset Date { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("numberOfPerson")]
        public int NumberOfPerson { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("isStatementRecipe")]
        public bool IsStatementRecipe { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("recipeId")]
        public System.Guid RecipeId { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class GetTypeOfProductVM
    {

        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public System.Guid Id { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class GetUnitOfMeasurementVM
    {

        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public System.Guid Id { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("typeOfProductId")]
        public System.Guid TypeOfProductId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("averageQuantity")]
        public float AverageQuantity { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("abbreviation")]
        public string Abbreviation { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class HistoricShopping
    {

        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public System.Guid Id { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("creationTrackingUserId")]
        [System.ComponentModel.DataAnnotations.Required]
        public string CreationTrackingUserId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("creationDate")]
        public System.DateTimeOffset? CreationDate { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("deleteDate")]
        public System.DateTimeOffset? DeleteDate { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("deleteTrackingUserId")]
        public string DeleteTrackingUserId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("updateDate")]
        public System.DateTimeOffset? UpdateDate { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("updateTrackingUserId")]
        public string UpdateTrackingUserId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(50, MinimumLength = 1)]
        public string Name { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("historicShoppingHasProducts")]
        public System.Collections.Generic.ICollection<HistoricShoppingHasProduct> HistoricShoppingHasProducts { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class HistoricShoppingHasProduct
    {

        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public System.Guid Id { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("creationTrackingUserId")]
        [System.ComponentModel.DataAnnotations.Required]
        public string CreationTrackingUserId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("creationDate")]
        public System.DateTimeOffset? CreationDate { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("deleteDate")]
        public System.DateTimeOffset? DeleteDate { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("deleteTrackingUserId")]
        public string DeleteTrackingUserId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("updateDate")]
        public System.DateTimeOffset? UpdateDate { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("updateTrackingUserId")]
        public string UpdateTrackingUserId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("historicShoppingId")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public System.Guid HistoricShoppingId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("historicShopping")]
        public HistoricShopping HistoricShopping { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("productId")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public System.Guid ProductId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("product")]
        public Product Product { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("quantity")]
        [System.ComponentModel.DataAnnotations.Range(0D, double.MaxValue)]
        public float Quantity { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("quantityPiece")]
        public float QuantityPiece { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("unitOfMeasurementName")]
        public string UnitOfMeasurementName { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Ingredient
    {

        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public System.Guid Id { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("creationTrackingUserId")]
        [System.ComponentModel.DataAnnotations.Required]
        public string CreationTrackingUserId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("creationDate")]
        public System.DateTimeOffset? CreationDate { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("deleteDate")]
        public System.DateTimeOffset? DeleteDate { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("deleteTrackingUserId")]
        public string DeleteTrackingUserId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("updateDate")]
        public System.DateTimeOffset? UpdateDate { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("updateTrackingUserId")]
        public string UpdateTrackingUserId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("recipeId")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public System.Guid RecipeId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("recipe")]
        public Recipe Recipe { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("productId")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public System.Guid ProductId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("product")]
        public Product Product { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("quantity")]
        [System.ComponentModel.DataAnnotations.Range(0D, double.MaxValue)]
        public float Quantity { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("unitOfMeasurementId")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public System.Guid UnitOfMeasurementId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("unitOfMeasurement")]
        public UnitOfMeasurement UnitOfMeasurement { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Product
    {

        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public System.Guid Id { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("creationTrackingUserId")]
        [System.ComponentModel.DataAnnotations.Required]
        public string CreationTrackingUserId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("creationDate")]
        public System.DateTimeOffset? CreationDate { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("deleteDate")]
        public System.DateTimeOffset? DeleteDate { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("deleteTrackingUserId")]
        public string DeleteTrackingUserId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("updateDate")]
        public System.DateTimeOffset? UpdateDate { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("updateTrackingUserId")]
        public string UpdateTrackingUserId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(50, MinimumLength = 1)]
        public string Name { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("typeOfProductId")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public System.Guid TypeOfProductId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("typeOfProduct")]
        public TypeOfProduct TypeOfProduct { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("imagePath")]
        public string ImagePath { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("articles")]
        public System.Collections.Generic.ICollection<Article> Articles { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("ingredients")]
        public System.Collections.Generic.ICollection<Ingredient> Ingredients { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("historicShoppingHasProducts")]
        public System.Collections.Generic.ICollection<HistoricShoppingHasProduct> HistoricShoppingHasProducts { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("categoryProducts")]
        public System.Collections.Generic.ICollection<CategoryProduct> CategoryProducts { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Recipe
    {

        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public System.Guid Id { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("creationTrackingUserId")]
        [System.ComponentModel.DataAnnotations.Required]
        public string CreationTrackingUserId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("creationDate")]
        public System.DateTimeOffset? CreationDate { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("deleteDate")]
        public System.DateTimeOffset? DeleteDate { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("deleteTrackingUserId")]
        public string DeleteTrackingUserId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("updateDate")]
        public System.DateTimeOffset? UpdateDate { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("updateTrackingUserId")]
        public string UpdateTrackingUserId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(50, MinimumLength = 1)]
        public string Name { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("comment")]
        [System.ComponentModel.DataAnnotations.StringLength(255)]
        public string Comment { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("numberOfPerson")]
        [System.ComponentModel.DataAnnotations.Range(0, 2147483647)]
        public int NumberOfPerson { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("imagePath")]
        public string ImagePath { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("ingredients")]
        public System.Collections.Generic.ICollection<Ingredient> Ingredients { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("shifts")]
        public System.Collections.Generic.ICollection<Shift> Shifts { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("categoryRecipes")]
        public System.Collections.Generic.ICollection<CategoryRecipe> CategoryRecipes { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Shift
    {

        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public System.Guid Id { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("creationTrackingUserId")]
        [System.ComponentModel.DataAnnotations.Required]
        public string CreationTrackingUserId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("creationDate")]
        public System.DateTimeOffset? CreationDate { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("deleteDate")]
        public System.DateTimeOffset? DeleteDate { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("deleteTrackingUserId")]
        public string DeleteTrackingUserId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("updateDate")]
        public System.DateTimeOffset? UpdateDate { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("updateTrackingUserId")]
        public string UpdateTrackingUserId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("date")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public System.DateTimeOffset Date { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("numberOfPerson")]
        [System.ComponentModel.DataAnnotations.Range(0, 2147483647)]
        public int NumberOfPerson { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("isStatementRecipe")]
        public bool IsStatementRecipe { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("recipeId")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public System.Guid RecipeId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("recipe")]
        public Recipe Recipe { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class TypeOfProduct
    {

        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public System.Guid Id { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("creationTrackingUserId")]
        [System.ComponentModel.DataAnnotations.Required]
        public string CreationTrackingUserId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("creationDate")]
        public System.DateTimeOffset? CreationDate { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("deleteDate")]
        public System.DateTimeOffset? DeleteDate { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("deleteTrackingUserId")]
        public string DeleteTrackingUserId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("updateDate")]
        public System.DateTimeOffset? UpdateDate { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("updateTrackingUserId")]
        public string UpdateTrackingUserId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(50, MinimumLength = 1)]
        public string Name { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("products")]
        public System.Collections.Generic.ICollection<Product> Products { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("unitOfMeasurements")]
        public System.Collections.Generic.ICollection<UnitOfMeasurement> UnitOfMeasurements { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class UnitOfMeasurement
    {

        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public System.Guid Id { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("creationTrackingUserId")]
        [System.ComponentModel.DataAnnotations.Required]
        public string CreationTrackingUserId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("creationDate")]
        public System.DateTimeOffset? CreationDate { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("deleteDate")]
        public System.DateTimeOffset? DeleteDate { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("deleteTrackingUserId")]
        public string DeleteTrackingUserId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("updateDate")]
        public System.DateTimeOffset? UpdateDate { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("updateTrackingUserId")]
        public string UpdateTrackingUserId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(50, MinimumLength = 1)]
        public string Name { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("typeOfProductId")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public System.Guid TypeOfProductId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("typeOfProduct")]
        public TypeOfProduct TypeOfProduct { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("averageQuantity")]
        [System.ComponentModel.DataAnnotations.Range(0D, double.MaxValue)]
        public float AverageQuantity { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("abbreviation")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(50, MinimumLength = 1)]
        public string Abbreviation { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("articles")]
        public System.Collections.Generic.ICollection<Article> Articles { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class UpdateArticleCommand
    {

        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public System.Guid Id { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("productId")]
        public System.Guid ProductId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("quantity")]
        public float Quantity { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("unitOfMeasurementId")]
        public System.Guid UnitOfMeasurementId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("categoryProductId")]
        public System.Guid? CategoryProductId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("expirationDate")]
        public System.DateTimeOffset ExpirationDate { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class UpdateCategoryProductCommand
    {

        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public System.Guid Id { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class UpdateCategoryRecipeCommand
    {

        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public System.Guid Id { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class UpdateIngredientCommand
    {

        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public System.Guid Id { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("recipeId")]
        public System.Guid RecipeId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("productId")]
        public System.Guid ProductId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("quantity")]
        public float Quantity { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("unitOfMeasurementId")]
        public System.Guid UnitOfMeasurementId { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class UpdateProductCommand
    {

        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public System.Guid Id { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("typeOfProductId")]
        public System.Guid TypeOfProductId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("imagePath")]
        public string ImagePath { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class UpdateRecipeCommand
    {

        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public System.Guid Id { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("comment")]
        public string Comment { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("numberOfPerson")]
        public int NumberOfPerson { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("imagePath")]
        public string ImagePath { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class UpdateShiftCommand
    {

        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public System.Guid Id { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("date")]
        public System.DateTimeOffset Date { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("numberOfPerson")]
        public int NumberOfPerson { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("isStatementRecipe")]
        public bool IsStatementRecipe { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("recipeId")]
        public System.Guid RecipeId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("recipe")]
        public Recipe Recipe { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class UpdateTypeOfProductCommand
    {

        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public System.Guid Id { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class UpdateUnitOfMeasurementCommand
    {

        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public System.Guid Id { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("typeOfProductId")]
        public System.Guid TypeOfProductId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("averageQuantity")]
        public float AverageQuantity { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("abbreviation")]
        public string Abbreviation { get; set; }

    }
}
