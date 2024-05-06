using Microsoft.AspNetCore.Components;
using Radzen;
using Radzen.Blazor;
using RecipeBook.Service.Contract;
using RecipeBook.Service.Model;

namespace RecipeBook.UI.Components.Pages.Administration.TypeOfProducts.TypeOfProductOverview
{
    public partial class TypeOfProductOverview
    {

        [Inject] public IRecipeBookDataServiceProvider ServiceProvider { get; set; } = default!;
        IEnumerable<GetListTypeOfProductVM> GetListTypeOfProductVMs;
        List<GetListTypeOfProductVM> TypeOfProductVMToInsert = new List<GetListTypeOfProductVM>();
        List<GetListTypeOfProductVM> TypeOfProductVMToUpdate = new List<GetListTypeOfProductVM>();
        RadzenDataGrid<GetListTypeOfProductVM> TypeOfProductGrid;
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
            GetListTypeOfProductVMs = await ServiceProvider.TypeOfProductAllAsync();
            isLoading = false;
        }

        protected async Task OnCreateRow(GetListTypeOfProductVM newTypeOfProduct)
        {
            await ServiceProvider.TypeOfProductPOSTAsync(new CreateTypeOfProductCommand { Name = newTypeOfProduct.Name });
            TypeOfProductVMToInsert.Remove(newTypeOfProduct);
            await LoadList();
        }

        async Task SaveRow(GetListTypeOfProductVM category)
        {
            await TypeOfProductGrid.UpdateRow(category);
        }

        void Reset()
        {
            TypeOfProductVMToInsert.Clear();
            TypeOfProductVMToUpdate.Clear();
        }

        void Reset(GetListTypeOfProductVM category)
        {
            TypeOfProductVMToInsert.Remove(category);
            TypeOfProductVMToUpdate.Remove(category);
        }
        async void OnUpdateRow(GetListTypeOfProductVM category)
        {
            Reset(category);
            await ServiceProvider.TypeOfProductPUTAsync(new UpdateTypeOfProductCommand { Name = category.Name, Id = category.Id });
        }

        async Task DeleteRow(GetListTypeOfProductVM category)
        {
            Reset(category);
            if (GetListTypeOfProductVMs.Contains(category))
            {
                await ServiceProvider.TypeOfProductDELETEAsync(category.Id);
                await LoadList();

            }
            else
            {
                TypeOfProductGrid.CancelEditRow(category);
                await LoadList();

            }
        }

        void CancelEdit(GetListTypeOfProductVM category)
        {
            Reset(category);
            TypeOfProductGrid.CancelEditRow(category);
        }

        async Task EditRow(GetListTypeOfProductVM category)
        {
            if (editMode == DataGridEditMode.Single && TypeOfProductVMToInsert.Count > 0)
            {
                Reset();
            }

            TypeOfProductVMToUpdate.Add(category);
            await TypeOfProductGrid.EditRow(category);
        }

        async Task InsertRow()
        {
            if (editMode == DataGridEditMode.Single)
            {
                Reset();
            }
            var category = new GetListTypeOfProductVM();
            TypeOfProductVMToInsert.Add(category);
            await TypeOfProductGrid.InsertRow(category);
        }
    }
}