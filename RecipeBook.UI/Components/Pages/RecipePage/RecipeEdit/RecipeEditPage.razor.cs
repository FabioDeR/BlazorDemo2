using Microsoft.AspNetCore.Http.Extensions;
using Radzen.Blazor;
using RecipeBook.Service.Model;

namespace RecipeBook.UI.Components.Pages.RecipePage.RecipeEdit
{
    public partial class RecipeEditPage
    {
        public List<QueryBuilderElement> QueryBuilders = new();
        public List<BindInput> bindInputs = new();
        public GetRecipeVM RecipeVM = new();
        public RadzenDataFilter<QueryBuilderElement> _radzenDataFilter;
        public RadzenDataFilterProperty<QueryBuilderElement> _radzenDataFilterProperty;

        protected override void OnInitialized()
        {
            QueryBuilders = new List<QueryBuilderElement>()
{
            new QueryBuilderElement("Recipe Name", "Name", "Recipes", "STRING", null),
            new QueryBuilderElement("Category", "Category", "Recipes", "DropDownList", new List<DropDownItem>()
            {
                new DropDownItem() { Name = "Breakfast", PK = "1" },
                new DropDownItem() { Name = "Lunch", PK = "2" },
                new DropDownItem() { Name = "Dinner", PK = "3" }
            }),
            new QueryBuilderElement("Rating","Rating","Recipe","STRING",new List<DropDownItem>()
            {
                  new DropDownItem() { Name = "1", PK = "1" },
                new DropDownItem() { Name = "2", PK = "2" },
                new DropDownItem() { Name = "3", PK = "3" }
            })
};

            bindInputs = new List<BindInput>()
        {
        new BindInput("Recipe Name", "Name", "STRING", QAFilterOperator.LessThan, "Gratin daufinois"),
        new BindInput("Category", "Category", "DropDownList", QAFilterOperator.NotEquals, "1"),
        new BindInput("Rating", "Rating", "STRING", QAFilterOperator.Equals, "")
        };
            base.OnInitialized();
        }



        void ValidInput()
        {
            Console.WriteLine(bindInputs);
        }



    }
}