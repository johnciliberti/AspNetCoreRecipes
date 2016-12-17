using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Threading.Tasks;

namespace Recipe09.TagHelpers
{
    [HtmlTargetElement("a", Attributes = GlyphIconName)]
    public class GlyphiconLinkTagHelper : TagHelper
    {
        private const string GlyphIconName = "asp-GlyphIcon";
        private const string EditIcon = "edit";
        private const string DeleteIcon = "trash";

        protected IHtmlGenerator Generator { get; }

        public GlyphiconLinkTagHelper(IHtmlGenerator generator)
        {
            Generator = generator;
        }


        [HtmlAttributeName(GlyphIconName)]
        public string IconName { get; set; }

        private string getIconName()
        {
            if (!string.IsNullOrEmpty(IconName) && IconName.ToLowerInvariant() == "edit")
            {
                return EditIcon;
            }
            return DeleteIcon;
        }

        public override async Task ProcessAsync(TagHelperContext context,
              TagHelperOutput output)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            if (output == null)
            {
                throw new ArgumentNullException(nameof(output));
            }

            
            var iconHTML =
               string.Format(" <span class='glyphicon glyphicon-{0}'> </span>", getIconName());
            var content = await output.GetChildContentAsync();
            if (content.IsEmptyOrWhiteSpace)
            {
                output.Content.SetHtmlContent(iconHTML);
            }
            else
            {
                output.Content.SetHtmlContent(content.AppendHtml(iconHTML).GetContent());
            }

        }
    }


}

