using Microsoft.AspNetCore.Components;
using Radzen;
using Radzen.Blazor;
using RecipeBook.Service.Contract;
using RecipeBook.Service.Model;

namespace RecipeBook.UI.Components.Pages.Administration.UnitOfMeasurements.UnitOfMeasurmementList
{
    public partial class UnitOfMeasurementOverview
    {

        [Inject] public IRecipeBookDataServiceProvider ServiceProvider { get; set; } = default!;
        IEnumerable<GetListUnitOfMeasurementVM> GetListUnitOfMeasurementVMs;
        IEnumerable<GetListTypeOfProductVM> TypeOfProductVMs;
        List<GetListUnitOfMeasurementVM> UnitOfMeasurementVMToInsert = new List<GetListUnitOfMeasurementVM>();
        List<GetListUnitOfMeasurementVM> UnitOfMeasurementVMToUpdate = new List<GetListUnitOfMeasurementVM>();
        RadzenDataGrid<GetListUnitOfMeasurementVM> UnitOfMeasurementGrid;
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
            GetListUnitOfMeasurementVMs = await ServiceProvider.UnitOfMeasurementAllAsync();
            TypeOfProductVMs = await ServiceProvider.TypeOfProductAllAsync();
            isLoading = false;
            StateHasChanged();
        }

        protected async Task OnCreateRow(GetListUnitOfMeasurementVM newUnitOfMeasurement)
        {
            await ServiceProvider.UnitOfMeasurementPOSTAsync(new CreateUnitOfMeasurementCommand
            {
                Name = newUnitOfMeasurement.Name,
                Abbreviation = newUnitOfMeasurement.Abbreviation,
                AverageQuantity = newUnitOfMeasurement.AverageQuantity,
                TypeOfProductId = newUnitOfMeasurement.TypeOfProductId
            }
            );
            UnitOfMeasurementVMToInsert.Remove(newUnitOfMeasurement);
            await LoadList();
        }

        async Task SaveRow(GetListUnitOfMeasurementVM unit)
        {
            await UnitOfMeasurementGrid.UpdateRow(unit);
        }

        void Reset()
        {
            UnitOfMeasurementVMToInsert.Clear();
            UnitOfMeasurementVMToUpdate.Clear();
        }

        void Reset(GetListUnitOfMeasurementVM unit)
        {
            UnitOfMeasurementVMToInsert.Remove(unit);
            UnitOfMeasurementVMToUpdate.Remove(unit);
        }
        async void OnUpdateRow(GetListUnitOfMeasurementVM unit)
        {
            Reset(unit);
            await ServiceProvider.UnitOfMeasurementPUTAsync(new UpdateUnitOfMeasurementCommand
            {
                Id = unit.Id,
                Name = unit.Name,
                Abbreviation = unit.Abbreviation,
                AverageQuantity = unit.AverageQuantity,
                TypeOfProductId = unit.TypeOfProductId
            });
        }

        async Task DeleteRow(GetListUnitOfMeasurementVM unit)
        {
            Reset(unit);
            if (GetListUnitOfMeasurementVMs.Contains(unit))
            {
                await ServiceProvider.UnitOfMeasurementDELETEAsync(unit.Id);
                await LoadList();

            }
            else
            {
                UnitOfMeasurementGrid.CancelEditRow(unit);
                await LoadList();

            }
        }

        void CancelEdit(GetListUnitOfMeasurementVM unit)
        {
            Reset(unit);
            UnitOfMeasurementGrid.CancelEditRow(unit);
        }

        async Task EditRow(GetListUnitOfMeasurementVM unit)
        {
            if (editMode == DataGridEditMode.Single && UnitOfMeasurementVMToInsert.Count > 0)
            {
                Reset();
            }

            UnitOfMeasurementVMToUpdate.Add(unit);
            await UnitOfMeasurementGrid.EditRow(unit);
        }

        async Task InsertRow()
        {
            if (editMode == DataGridEditMode.Single)
            {
                Reset();
            }
            var unit = new GetListUnitOfMeasurementVM();
            UnitOfMeasurementVMToInsert.Add(unit);
            await UnitOfMeasurementGrid.InsertRow(unit);
        }
    }
}