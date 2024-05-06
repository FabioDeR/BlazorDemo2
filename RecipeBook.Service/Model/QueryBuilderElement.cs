using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBook.Service.Model
{
    public class QueryBuilderElement
    {
        public string LabeledText { get; set; } = string.Empty;
        public string ColumnName { get; set; } = string.Empty;
        public string TableName { get; set; } = string.Empty;
        public string TypeOfFilter { get; set; } = string.Empty;
        public List<DropDownItem> DropDownItems { get; set; } = [];
        public QueryBuilderElement(string labeledText, string columnName, string tableName, string typeOfFilter, List<DropDownItem> dropDownItems)
        {
            LabeledText = labeledText;
            ColumnName = columnName;
            TableName = tableName;
            TypeOfFilter = typeOfFilter;
            DropDownItems = dropDownItems;
        }

    }

    public class BindInput
    {
        public string PK { get; set; } = string.Empty;
        public string LabelName { get; set; } = string.Empty;
        public string ColumnName { get; set; } = string.Empty;
        public string TypeOfFilter { get; set; } = string.Empty;
        public string Value { get; set; } = string.Empty;
        public QAFilterOperator FilterOperator { get; set; } // Opérateur de filtrage

        public BindInput(string labelName, string columnName, string typeOfFilter, QAFilterOperator filterOperator, string value)
        {
            LabelName = labelName;
            ColumnName = columnName;
            TypeOfFilter = typeOfFilter;
            FilterOperator = filterOperator;
            Value = value;
        }

        public BindInput() { }
    }

    public class DropDownItem
    {
        public string Name { get; set; } = string.Empty;
        public string PK { get; set; } = string.Empty;
    }

    public enum QAFilterOperator
    {
        //
        // Résumé :
        //     Satisfied if the current value equals the specified value.
        Equals,
        //
        // Résumé :
        //     Satisfied if the current value does not equal the specified value.
        NotEquals,
        //
        // Résumé :
        //     Satisfied if the current value is less than the specified value.
        LessThan,
        //
        // Résumé :
        //     Satisfied if the current value is less than or equal to the specified value.
        LessThanOrEquals,
        //
        // Résumé :
        //     Satisfied if the current value is greater than the specified value.
        GreaterThan,
        //
        // Résumé :
        //     Satisfied if the current value is greater than or equal to the specified value.
        GreaterThanOrEquals,
        //
        // Résumé :
        //     Satisfied if the current value contains the specified value.
        Contains,
        //
        // Résumé :
        //     Satisfied if the current value starts with the specified value.
        StartsWith,
        //
        // Résumé :
        //     Satisfied if the current value ends with the specified value.
        EndsWith,
        //
        // Résumé :
        //     Satisfied if the current value does not contain the specified value.
        DoesNotContain,
        //
        // Résumé :
        //     Satisfied if the current value is in the specified value.
        In,
        //
        // Résumé :
        //     Satisfied if the current value is not in the specified value.
        NotIn,
        //
        // Résumé :
        //     Satisfied if the current value is null.
        IsNull,
        //
        // Résumé :
        //     Satisfied if the current value is System.String.Empty.
        IsEmpty,
        //
        // Résumé :
        //     Satisfied if the current value is not null.
        IsNotNull,
        //
        // Résumé :
        //     Satisfied if the current value is not System.String.Empty.
        IsNotEmpty,
        //
        // Résumé :
        //     Custom operator if not need to generate the filter.
        Custom
    }
}
