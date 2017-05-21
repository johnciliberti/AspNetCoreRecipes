using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Threading.Tasks;

namespace Recipe03.Web.TagHelpers
{

    public class ColumnListTagHelper_Step2 : TagHelper
    {

        public const string NumberOfColumnsAttributeName = "asp-number-of-columns";
        private const string ForAttributeName = "asp-for";
        private const string ViewComponentAttributeName = "asp-view-component";

        [HtmlAttributeName(NumberOfColumnsAttributeName)]
        public int NumberOfColumns { get; set; }


        [HtmlAttributeName(ForAttributeName)]
        public ModelExpression For { get; set; }


        [HtmlAttributeName(ViewComponentAttributeName)]
        public string ViewComponentName { get; set; }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
          
        }

    }
}
