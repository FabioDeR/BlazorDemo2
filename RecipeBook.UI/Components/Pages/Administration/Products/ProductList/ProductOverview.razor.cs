using Microsoft.AspNetCore.Components;
using Radzen;
using Radzen.Blazor;
using RecipeBook.Service.Contract;
using RecipeBook.Service.Model;

namespace RecipeBook.UI.Components.Pages.Administration.Products.ProductList
{
    public partial class ProductOverview
    {
        [Inject] public IRecipeBookDataServiceProvider ServiceProvider { get; set; } = default!;
        IEnumerable<GetListProductVM> GetListProductVMs;
        IEnumerable<GetListTypeOfProductVM> TypeOfProductVMs;
        List<GetListProductVM> ProductVMToInsert = new List<GetListProductVM>();
        List<GetListProductVM> ProductVMToUpdate = new List<GetListProductVM>();
        RadzenDataGrid<GetListProductVM> ProductGrid;
        int count;
        public bool isLoading;
        DataGridEditMode editMode = DataGridEditMode.Single;
        List<Guid> selectedCategoryProduct;
        IEnumerable<GetListCategoryProductVM> CategoryProductVMs;


        protected override async Task OnInitializedAsync()
        {
            await LoadList();
        }

        private async Task LoadList()
        {
            isLoading = true;
            GetListProductVMs = await ServiceProvider.ProductAllAsync();
            TypeOfProductVMs = await ServiceProvider.TypeOfProductAllAsync();
            CategoryProductVMs = await ServiceProvider.CategoryProductAllAsync();
            isLoading = false;
            StateHasChanged();
        }

        protected async Task OnCreateRow(GetListProductVM newProduct)
        {
            await ServiceProvider.ProductPOSTAsync(new CreateProductCommand
            {
                Name = newProduct.Name,
               TypeOfProductId = newProduct.TypeOfProductId,
               ImagePath = newProduct.ImagePath, 
               CategoryProducts = selectedCategoryProduct.ToList(),
            }
            );
            ProductVMToInsert.Remove(newProduct);
            await LoadList();
        }

        async Task SaveRow(GetListProductVM product)
        {
            await ProductGrid.UpdateRow(product);
        }

        void Reset()
        {
            ProductVMToInsert.Clear();
            ProductVMToUpdate.Clear();
        }

        void Reset(GetListProductVM product)
        {
            ProductVMToInsert.Remove(product);
            ProductVMToUpdate.Remove(product);
        }
        async void OnUpdateRow(GetListProductVM product)
        {
            Reset(product);
            await ServiceProvider.ProductPUTAsync(new UpdateProductCommand
            {
                Id = product.Id,
                Name = product.Name,
                ImagePath = product.ImagePath,
                TypeOfProductId = product.TypeOfProductId,
            });
        }

        async Task DeleteRow(GetListProductVM product)
        {
            Reset(product);
            if (GetListProductVMs.Contains(product))
            {
                await ServiceProvider.ProductDELETEAsync(product.Id);
                await LoadList();

            }
            else
            {
                ProductGrid.CancelEditRow(product);
                await LoadList();

            }
        }

        void CancelEdit(GetListProductVM product)
        {
            Reset(product);
            ProductGrid.CancelEditRow(product);
        }

        async Task EditRow(GetListProductVM product)
        {
            if (editMode == DataGridEditMode.Single && ProductVMToInsert.Count > 0)
            {
                Reset();
            }

            ProductVMToUpdate.Add(product);
            await ProductGrid.EditRow(product);
        }

        async Task InsertRow()
        {
            if (editMode == DataGridEditMode.Single)
            {
                Reset();
            }
            var product = new GetListProductVM();
            ProductVMToInsert.Add(product);
            await ProductGrid.InsertRow(product);
        }
    }
}
