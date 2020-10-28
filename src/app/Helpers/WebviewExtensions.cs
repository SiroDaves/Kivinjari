using HtmlAgilityPack;

namespace Kivinjari.Helpers
{
    public static class WebviewExtensions
    {
        public static void Delete(this Webview.Webview webview, string selector)
        {
            webview.Eval($@"
            (function () {{
                 document.document.querySelector('{selector}').remove();
            }})");
        }
        
        public static void Replace(this Webview.Webview webview, string selector, string newInnerHtml)
        {
            webview.Eval($@"
            (function () {{
                 document.document.querySelector('{selector}').innerHtml = {newInnerHtml};
            }})");
        }
        
        public static void Replace(this Webview.Webview webview, string selector, HtmlNode newContent)
        {
            webview.Replace(selector, newContent.InnerHtml);
        }
    }
}