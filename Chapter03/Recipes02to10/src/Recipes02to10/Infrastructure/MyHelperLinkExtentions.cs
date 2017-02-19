using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
/// <summary>
/// these are the extension methods described in Recipe 3-7.
/// </summary>
namespace Recipe02to10.Infrastructure
{
    /// <summary>
    /// Summary description for MyHelperLinkExtensions
    /// </summary>
    public static class MyHelperLinkExtensions
    {
        public static IHtmlContent SslActionLink(
            this IHtmlHelper helper,
            string linkText,
            string actionName)
        {

            return helper.SslActionLink(linkText, actionName, null);
        }

        public static IHtmlContent SslActionLink(
            this IHtmlHelper helper,
            string linkText,
            string actionName,
            string controllerName)
        {
            if (helper == null)
                throw new ArgumentNullException("helper");

            if (string.IsNullOrEmpty(linkText))
                throw new ArgumentNullException("linkText");

            return helper.ActionLink(
                linkText,
                actionName,
                controllerName,
                protocol: "https",
                hostname: null,
                fragment: null,
                routeValues: null,
                htmlAttributes: null);
        }



    }
}