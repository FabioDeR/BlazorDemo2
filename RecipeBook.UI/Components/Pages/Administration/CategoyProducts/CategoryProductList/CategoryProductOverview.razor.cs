
using Microsoft.AspNetCore.Components;
using Radzen;
using Radzen.Blazor;
using RecipeBook.Service.Contract;
using RecipeBook.Service.Model;
using System.Linq.Dynamic.Core;

namespace RecipeBook.UI.Components.Pages.Administration.CategoyProducts.CategoryProductList
{
    public partial class CategoryProductOverview
    {


        [Inject] public IRecipeBookDataServiceProvider ServiceProvider { get; set; } = default!;
        IEnumerable<GetListCategoryProductVM> GetListCategoryProductVMs;
        List<GetListCategoryProductVM> categoryProductVMToInsert = new List<GetListCategoryProductVM>();
        List<GetListCategoryProductVM> categoryProductVMToUpdate = new List<GetListCategoryProductVM>();
        RadzenDataGrid<GetListCategoryProductVM> categoryProductGrid;
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
            GetListCategoryProductVMs = await ServiceProvider.CategoryProductAllAsync();
            isLoading = false;
        }

        protected async Task OnCreateRow(GetListCategoryProductVM newCategoryProduct)
        {
            await ServiceProvider.CategoryProductPOSTAsync(new CreateCategoryProductCommand { Name = newCategoryProduct.Name });
            categoryProductVMToInsert.Remove(newCategoryProduct);
            await LoadList();
        }

        async Task SaveRow(GetListCategoryProductVM category)
        {
            await categoryProductGrid.UpdateRow(category);
        }

        void Reset()
        {
            categoryProductVMToInsert.Clear();
            categoryProductVMToUpdate.Clear();
        }

        void Reset(GetListCategoryProductVM category)
        {
            categoryProductVMToInsert.Remove(category);
            categoryProductVMToUpdate.Remove(category);
        }
        async void OnUpdateRow(GetListCategoryProductVM category)
        {
            Reset(category);
            await ServiceProvider.CategoryProductPUTAsync(new UpdateCategoryProductCommand { Name = category.Name, Id = category.Id });
        }

        async Task DeleteRow(GetListCategoryProductVM category)
        {
            Reset(category);
            if (GetListCategoryProductVMs.Contains(category))
            {
                await ServiceProvider.CategoryProductDELETEAsync(category.Id);
                await LoadList();

            }
            else
            {
                categoryProductGrid.CancelEditRow(category);
                await LoadList();

            }
        }

        void CancelEdit(GetListCategoryProductVM category)
        {
            Reset(category);
            categoryProductGrid.CancelEditRow(category);
        }

        async Task EditRow(GetListCategoryProductVM category)
        {
            if (editMode == DataGridEditMode.Single && categoryProductVMToInsert.Count > 0)
            {
                Reset();
            }

            categoryProductVMToUpdate.Add(category);
            await categoryProductGrid.EditRow(category);
        }

        async Task InsertRow()
        {
            if (editMode == DataGridEditMode.Single)
            {
                Reset();
            }
            var category = new GetListCategoryProductVM();
            categoryProductVMToInsert.Add(category);
            await categoryProductGrid.InsertRow(category);
        }
    }
}