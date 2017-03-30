using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Linq.Expressions;

namespace Recipe06.HtmlHelpers
{
    public static class EditInPlaceHelpers
    {
        // returns the default editor for the property   when isSelected
        // is true
        public static IHtmlContent DataGridEditorFor<TModel, TProperty>
                             (this IHtmlHelper<TModel> helper,
                              bool isSelected,
                              Expression<Func<TModel, TProperty>> expression)
                              where TModel : class
        {
            if (isSelected)
            {
                return helper.EditorFor(expression);
            }
            else
            {
                return helper.DisplayFor(expression);
            }
        }

        // returns a text box for the property when isSelected
        // is true
        public static IHtmlContent DataGridTextBoxFor<TModel, TProperty>
                            (this IHtmlHelper<TModel> helper,
                             bool isSelected,
                             Expression<Func<TModel, TProperty>> expression)
                             where TModel : class
        {
            if (isSelected)
            {
                return helper.TextBoxFor(expression);
            }
            else
            {
                return helper.DisplayFor(expression);
            }
        }

        // returns the default editor for the property when isSelected
        // is true  
        public static IHtmlContent DataGridTextAreaFor<TModel, TProperty>
                             (this IHtmlHelper<TModel> helper,
                             bool isSelected,
                             Expression<Func<TModel, TProperty>> expression)
                             where TModel : class
        {
            if (isSelected)
            {
                return helper.TextAreaFor(expression);
            }
            else
            {
                return helper.DisplayFor(expression);
            }
        }

    }

}
