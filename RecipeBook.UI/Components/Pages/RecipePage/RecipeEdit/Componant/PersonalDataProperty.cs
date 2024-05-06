using Microsoft.AspNetCore.Components;
using Radzen;
using Radzen.Blazor;
using RecipeBook.Service.Model;

namespace RecipeBook.UI.Components.Pages.RecipePage.RecipeEdit.Componant
{
    public class PersonalDataProperty<TItem> : RadzenDataFilterProperty<TItem>
    {

        [Parameter] public BindInput BindInput { get; set; } = new();

        [CascadingParameter] public List<BindInput> BindInputList { get; set; } = new();

        private Func<TItem, object> propertyValueGetter;

        private Type _filterPropertyType;

        private object filterValue;
        /// <summary>
        /// Gets or sets the DataFilter.
        /// </summary>
        /// <value>The DataFilter.</value>
        [CascadingParameter]
        public PersonalDataFilter<TItem> PersonalDataFilter { get; set; }

        public event Action<object> FilterValueChange;
       

        /// <summary>
        /// Gets the filter property type.
        /// </summary>
        public Type FilterPropertyType
        {
            get
            {
                return _filterPropertyType;
            }
        }

        

        internal object GetHeader()
        {
            if (!string.IsNullOrEmpty(Title))
            {
                return Title;
            }
            else
            {
                return Property;
            }
        }

        internal string GetFilterOperatorText(FilterOperator filterOperator)
        {
            switch (filterOperator)
            {
                case FilterOperator.Contains:
                    return DataFilter?.ContainsText;
                case FilterOperator.DoesNotContain:
                    return DataFilter?.DoesNotContainText;
                case FilterOperator.EndsWith:
                    return DataFilter?.EndsWithText;
                case FilterOperator.Equals:
                    return DataFilter?.EqualsText;
                case FilterOperator.GreaterThan:
                    return DataFilter?.GreaterThanText;
                case FilterOperator.GreaterThanOrEquals:
                    return DataFilter?.GreaterThanOrEqualsText;
                case FilterOperator.LessThan:
                    return DataFilter?.LessThanText;
                case FilterOperator.LessThanOrEquals:
                    return DataFilter?.LessThanOrEqualsText;
                case FilterOperator.StartsWith:
                    return DataFilter?.StartsWithText;
                case FilterOperator.NotEquals:
                    return DataFilter?.NotEqualsText;
                case FilterOperator.IsNull:
                    return DataFilter?.IsNullText;
                case FilterOperator.IsEmpty:
                    return DataFilter?.IsEmptyText;
                case FilterOperator.IsNotNull:
                    return DataFilter?.IsNotNullText;
                case FilterOperator.IsNotEmpty:
                    return DataFilter?.IsNotEmptyText;
                default:
                    return $"{filterOperator}";
            }
        }

        internal string GetFilterOperatorSymbol(FilterOperator filterOperator)
        {
            var symbol = DataFilter.FilterCaseSensitivity == FilterCaseSensitivity.CaseInsensitive ? "a" : "A";
            switch (filterOperator)
            {
                case FilterOperator.Contains:
                    return $"*{symbol}*";
                case FilterOperator.DoesNotContain:
                    return $"*{symbol}*";
                case FilterOperator.StartsWith:
                    return $"{symbol}**";
                case FilterOperator.EndsWith:
                    return $"**{symbol}";
                case FilterOperator.Equals:
                    return "=";
                case FilterOperator.GreaterThan:
                    return ">";
                case FilterOperator.GreaterThanOrEquals:
                    return "≥";
                case FilterOperator.LessThan:
                    return "<";
                case FilterOperator.LessThanOrEquals:
                    return "≤";
                case FilterOperator.NotEquals:
                    return "≠";
                case FilterOperator.IsNull:
                    return "∅";
                case FilterOperator.IsNotNull:
                    return "!∅";
                case FilterOperator.IsEmpty:
                    return "= ''";
                case FilterOperator.IsNotEmpty:
                    return "≠ ''";
                default:
                    return $"{filterOperator}";
            }
        }

        /// <summary>
        /// Called when initialized.
        /// </summary>
        protected override void OnInitialized()
        {
            if (PersonalDataFilter != null)
            {
                PersonalDataFilter.AddProperty(this);

                var property = GetFilterProperty();

                if (!string.IsNullOrEmpty(property) && Type == null)
                {
                    if (!string.IsNullOrEmpty(property))
                    {
                        _filterPropertyType = PropertyAccess.GetPropertyType(typeof(TItem), property);
                    }
                }

                if (_filterPropertyType == null)
                {
                    _filterPropertyType = Type;
                }
                else
                {
                    propertyValueGetter = PropertyAccess.Getter<TItem, object>(Property);
                }

                if (_filterPropertyType == typeof(string))
                {
                    FilterOperator = FilterOperator.Contains;
                }
            }
        }
        public override async Task SetParametersAsync(ParameterView parameters)
        {
            if (parameters.DidParameterChange("FilterValue", FilterValue))
            {
                object valueOrDefault = parameters.GetValueOrDefault<object>("FilterValue");
                if (filterValue != valueOrDefault)
                {
                    filterValue = valueOrDefault;
                    if (FilterTemplate != null)
                    {
                        if (this.FilterValueChange != null)
                        {
                            this.FilterValueChange(filterValue);
                        }

                        await DataFilter.Filter();
                        return;
                    }
                }
            }

            await base.SetParametersAsync(parameters);
        }



    }
}
