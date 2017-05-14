using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Primitives;
using System;
using System.Threading.Tasks;

namespace Recipe04.TagHelpers
{
    public class GridPagerTagHelper : TagHelper
    {
        public GridPagerTagHelper(IHtmlGenerator generator)
        {
            Generator = generator;
        }
        protected IHtmlGenerator Generator { get; }

        [HtmlAttributeName("asp-total-number-of-results")]
        public int TotalNumberOfResults { get; set; }

        [HtmlAttributeName("asp-items-per-page")]
        public int ItemsPerPage { get; set; } = 20;

        [HtmlAttributeName("asp-current-page")]
        public int CurrentPage { get; set; } = 1;

        [HtmlAttributeName("asp-pager-css-class")]
        public string PagerCssClass { get; set; } = "pagination";

        [HtmlAttributeName("asp-active-css-class")]
        public string ActiveCssClass { get; set; } = "active";

        [HtmlAttributeNotBound]
        [ViewContext]
        public ViewContext ViewContext { get; set; }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            if(TotalNumberOfResults <= ItemsPerPage)
            {
                // pager is not required so return nothing
                output.SuppressOutput();
                return;
            }
            if (ItemsPerPage == 0)
            {
                throw new InvalidOperationException("ItemsPerPage must be greater then 0");
            }

            int numberOfPages = TotalNumberOfResults / ItemsPerPage;
            var maxNumberOfPagesShown = 20;

            bool showFirstAndLast = numberOfPages > maxNumberOfPagesShown;
            int startPage = getStartPage(numberOfPages, CurrentPage);
            int endPage = getEndPage(numberOfPages, CurrentPage, startPage);

            output.TagName = "div";

            output.Content.AppendHtml(string.Format("<ul class={0}>", PagerCssClass));
            if (showFirstAndLast && startPage > 1)
            {
                output.Content.AppendHtml("<li>");
                output.Content.AppendHtml(buildActionLink("...", 1));
                output.Content.AppendHtml("</li>");
            }
            for (int i = startPage; i <= endPage; i++)
            {
                string PageLinkText = i.ToString();

                if (i != CurrentPage)
                {
                    output.Content.AppendHtml("<li>");
                    output.Content.AppendHtml(buildActionLink(PageLinkText, i));
                }
                else
                {
                    output.Content.AppendHtml(string.Format(@"<li class=""{0}"">",
                             ActiveCssClass));
                    output.Content.AppendHtml(string.Format(@"<a href=""#"">{0}</a>", i));
                }
                output.Content.AppendHtml(" </li>");

            }
            if (showFirstAndLast && (endPage != numberOfPages))
            {
                output.Content.AppendHtml("<li>");
                output.Content.AppendHtml(buildActionLink("...", numberOfPages));
                output.Content.AppendHtml("</li>");
            }
            output.Content.AppendHtml("</ul>");
        }

        private TagBuilder buildActionLink(string linkText, int page)
        {
            if(ViewContext.HttpContext.Request.QueryString.HasValue)
            {
                var queryString =  
                    QueryHelpers.ParseQuery(ViewContext.HttpContext.Request.QueryString.Value);
                StringValues sort, categoryId;
                queryString.TryGetValue("SortExpression", out sort);
                queryString.TryGetValue("Genres", out categoryId);
                return Generator.GenerateActionLink(
                    ViewContext,
                    linkText: linkText,
                    actionName: ViewContext.RouteData.Values["action"].ToString(),
                    controllerName: ViewContext.RouteData.Values["controller"].ToString(),
                    protocol: null,
                    hostname: null,
                    fragment: null,
                    routeValues: new
                    {
                        SortExpression = sort,
                        Genres = categoryId,
                        Page = page

                    },
                    htmlAttributes: null
                    );
                
            }

            return Generator.GenerateActionLink(
                    ViewContext,
                    linkText: linkText,
                    actionName: ViewContext.RouteData.Values["action"].ToString(),
                    controllerName: ViewContext.RouteData.Values["controller"].ToString(),
                    protocol: null,
                    hostname: null,
                    fragment: null,
                    routeValues: new
                    {
                        Page = page
                    },
                    htmlAttributes: null
                    );
        }

        private int getStartPage(int numberOfPages, int currentPage)
        {
            int minToDisplay = 1;
            if (currentPage > 10)
            {
                minToDisplay = currentPage - 9;
            }
            if (currentPage > (numberOfPages - 10) && (numberOfPages > 20))
            {
                minToDisplay = numberOfPages - 20;
            }
            return minToDisplay;
        }

        private int getEndPage(int numberOfPages, int currentPage, int startPage)
        {
            int maxToDisplay = startPage + 19;
            if (maxToDisplay > numberOfPages)
            {
                maxToDisplay = maxToDisplay - (maxToDisplay - numberOfPages);
            }
            if ((currentPage > numberOfPages - 10) && (startPage != 1))
            {
                maxToDisplay = numberOfPages;
            }
            return maxToDisplay;
        }

    }
}
