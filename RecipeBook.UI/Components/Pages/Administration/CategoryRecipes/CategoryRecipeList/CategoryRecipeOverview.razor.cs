using Microsoft.AspNetCore.Components;
using Radzen.Blazor;
using Radzen;
using RecipeBook.Service.Contract;
using RecipeBook.Service.Model;

namespace RecipeBook.UI.Components.Pages.Administration.CategoryRecipes.CategoryRecipeList
{
    public partial class CategoryRecipeOverview
    {

        [Inject] public IRecipeBookDataServiceProvider ServiceProvider { get; set; } = default!;
        IEnumerable<GetListCategoryRecipeVM> GetListCategoryRecipeVMs;
        List<GetListCategoryRecipeVM> categoryRecipeVMToInsert = new List<GetListCategoryRecipeVM>();
        List<GetListCategoryRecipeVM> categoryRecipeVMToUpdate = new List<GetListCategoryRecipeVM>();
        RadzenDataGrid<GetListCategoryRecipeVM> categoryRecipeGrid;
        int count;
        public bool isLoading;
        DataGridEditMode editMode = DataGridEditMode.Single;


        protected override async Task OnInitializedAsync()
        {
            await LoadList();
        }

        private async Task LoadList()
        {
            isLoading = true;
            GetListCategoryRecipeVMs = await ServiceProvider.CategoryRecipeAllAsync();
            isLoading = false;
        }

        protected async Task OnCreateRow(GetListCategoryRecipeVM newCategoryRecipe)
        {
            await ServiceProvider.CategoryRecipePOSTAsync(new CreateCategoryRecipeCommand { Name = newCategoryRecipe.Name });
            categoryRecipeVMToInsert.Remove(newCategoryRecipe);
            await LoadList();
        }

        async Task SaveRow(GetListCategoryRecipeVM category)
        {
            await categoryRecipeGrid.UpdateRow(category);
        }

        void Reset()
        {
            categoryRecipeVMToInsert.Clear();
            categoryRecipeVMToUpdate.Clear();
        }

        void Reset(GetListCategoryRecipeVM category)
        {
            categoryRecipeVMToInsert.Remove(category);
            categoryRecipeVMToUpdate.Remove(category);
        }
        async void OnUpdateRow(GetListCategoryRecipeVM category)
        {
            Reset(category);
            await ServiceProvider.CategoryRecipePUTAsync(new UpdateCategoryRecipeCommand { Name = category.Name, Id = category.Id });
        }

        async Task DeleteRow(GetListCategoryRecipeVM category)
        {
            Reset(category);
            if (GetListCategoryRecipeVMs.Contains(category))
            {
                await ServiceProvider.CategoryRecipeDELETEAsync(category.Id);
                await LoadList();

            }
            else
            {
                categoryRecipeGrid.CancelEditRow(category);
                await LoadList();

            }
        }

        void CancelEdit(GetListCategoryRecipeVM category)
        {
            Reset(category);
            categoryRecipeGrid.CancelEditRow(category);
        }

        async Task EditRow(GetListCategoryRecipeVM category)
        {
            if (editMode == DataGridEditMode.Single && categoryRecipeVMToInsert.Count > 0)
            {
                Reset();
            }

            categoryRecipeVMToUpdate.Add(category);
            await categoryRecipeGrid.EditRow(category);
        }

        async Task InsertRow()
        {
            if (editMode == DataGridEditMode.Single)
            {
                Reset();
            }
            var category = new GetListCategoryRecipeVM();
            categoryRecipeVMToInsert.Add(category);
            await categoryRecipeGrid.InsertRow(category);
        }
    }
}