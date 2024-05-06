using Microsoft.AspNetCore.Components;
using Radzen;
using Radzen.Blazor;
using RecipeBook.Service.Model;
using System.Linq;

namespace RecipeBook.UI.Components.Pages.RecipePage.RecipeEdit.Componant
{
    [CascadingTypeParameter(nameof(TItem))]
    public partial class PersonalDataFilter<TItem> : RadzenDataFilter<TItem>
    {
        [Parameter] public List<BindInput> bindInputs { get; set; } = new();

        public List<PersonalDataProperty<TItem>> properties = new List<PersonalDataProperty<TItem>>();

        public new IList<PersonalDataProperty<TItem>> PropertiesCollection => properties;        

        public async Task AddFilter()
        {
            if (UniqueFilters && properties.All(f => f.IsSelected))
            {
                return;
            }           
            Filters = Filters.Concat(new CompositeFilterDescriptor[] { new CompositeFilterDescriptor() });
            

            if (Auto)
            {
                await Filter();
            }
        }

        internal async void AddProperty(PersonalDataProperty<TItem> property)
        {
            if (!properties.Contains(property))
            {
                properties.Add(property);
               
            }

            await ChangeState();
        }

        public async Task ChangeState()
        {
            await InvokeAsync(StateHasChanged);
        }


        /// <summary>
        /// Clear filters.
        /// </summary>
        public async Task MyClearFilter()
        {
            Filters = Enumerable.Empty<CompositeFilterDescriptor>();

            properties.ForEach(p => p.IsSelected = false);

            if (Auto)
            {
                await Filter();
            }
        }

       
    }
}
