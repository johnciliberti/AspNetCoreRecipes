using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace Recipe04.Web.TagHelpers
{
    [HtmlTargetElement(TagName)]
    public class ColumnListTagHelper : TagHelper
    {
        public const string NumberOfColumnsAttributeName = "asp-number-of-columns";
        private const string ForAttributeName = "asp-for";
        private const string ViewComponentAttributeName = "asp-view-component";
        private const string TagName = "columnlist";
        private readonly IViewComponentHelper _viewComponentHelper;
        public ColumnListTagHelper(IViewComponentHelper viewComponentHelper)
        {
            _viewComponentHelper = viewComponentHelper;
        }

        /// <summary>
        /// The context of the current view
        /// </summary>
        [HtmlAttributeNotBound] // do not show in VS as something for users to add
        [ViewContext]
        public ViewContext ViewContext { get; set; } // set View Context property once constructed

        /// <summary>
        /// The number of columns to be displayed, should be between 1 and 12
        /// </summary>
        [HtmlAttributeName(NumberOfColumnsAttributeName)]
        public int NumberOfColumns { get; set; }

        /// <summary>
        /// An expression to be evaluated against the current model.
        /// </summary>
        [HtmlAttributeName(ForAttributeName)]
        public ModelExpression For { get; set; }

        /// <summary>
        /// The name of the View Component that will be used to render each item passed in the Model Expression
        /// </summary>
        [HtmlAttributeName(ViewComponentAttributeName)]
        public string ViewComponentName { get; set; }

        public override void Init(TagHelperContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }
            base.Init(context);
        }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            if (output == null)
            {
                throw new ArgumentNullException(nameof(output));
            }

            if(NumberOfColumns<1 || NumberOfColumns > 12)
            {
                throw new ArgumentOutOfRangeException("NumberOfColumns", "The number of columns must be at least 1 and at most 12.");
            }
            if (For == null)
            {
                return;
            }
            
            

            output.TagName = "div";
            output.Attributes.SetAttribute("class", "container-fluid");

            var viewComponentName = context.AllAttributes[ViewComponentAttributeName].Value.ToString();
            //var numberOfColumns = 

            var collection = For.Model as ICollection;
            if(collection != null)
            {
                var columnsInRow = 1;
                var rowsDone = 0;
                var numberOfItemsDone = 0;
                var numberOfExtraColumnsInLastRow = 0;
                //calculate the needed table structure
                int numberOfRows = collection.Count / NumberOfColumns;

                
                foreach (var item in collection)
                {
                    if (columnsInRow == 1)
                    {
                        output.Content.AppendHtml(@"<div class=""row"">");
                    }

                    output.Content.AppendHtml(GetColumnDivTag());
                    //add the view context of the current view to the view component, enable to invoke
                    ((IViewContextAware)_viewComponentHelper).Contextualize(ViewContext);
                    var viewContent = await _viewComponentHelper.InvokeAsync(viewComponentName, item);
                    output.Content.AppendHtml(viewContent);
                    output.Content.AppendHtml("</div>");

                    bool isLastItem = (collection.Count == numberOfItemsDone + 1);

                    if ((columnsInRow == NumberOfColumns) || isLastItem)
                    {
                        if (isLastItem)
                        {
                            numberOfExtraColumnsInLastRow = NumberOfColumns - columnsInRow;
                            output.Content.AppendHtml((RenderExtraColumns(numberOfExtraColumnsInLastRow)));
                        }
                        output.Content.AppendHtml("</div>");
                        columnsInRow = 1;
                        rowsDone++;
                    }
                    else
                    {
                        columnsInRow++;
                    }

                    numberOfItemsDone++;

                }
            }
        }


        private  string RenderExtraColumns(int numberOfExtraColumnsInLastRow)
        {
            if (numberOfExtraColumnsInLastRow > 0)
            {
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < numberOfExtraColumnsInLastRow; i++)
                {
                    builder.Append(GetColumnDivTag());
                    builder.Append("</div>");
                }
                return builder.ToString();
            }
            return string.Empty;

        }

        private string GetColumnDivTag()
        {
            var colSpan = (int)Math.Round((double)(12 / NumberOfColumns));
            return string.Format(@"<div class=""col-xs-{0} col-sm-{0} col-md-{0} col-lg-{0}"">", colSpan);
        }
    }
}
