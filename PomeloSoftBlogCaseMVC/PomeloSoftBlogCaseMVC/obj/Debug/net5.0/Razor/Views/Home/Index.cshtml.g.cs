#pragma checksum "C:\Users\Salim\source\repos\PomeloSoftBlogCaseMVC\PomeloSoftBlogCaseMVC\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d28055da5c8b4364e261f3c97c3a53bd12a92a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Salim\source\repos\PomeloSoftBlogCaseMVC\PomeloSoftBlogCaseMVC\Views\_ViewImports.cshtml"
using PomeloSoftBlogCaseMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Salim\source\repos\PomeloSoftBlogCaseMVC\PomeloSoftBlogCaseMVC\Views\_ViewImports.cshtml"
using PomeloSoftBlogCaseMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d28055da5c8b4364e261f3c97c3a53bd12a92a4", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c78eea81c511e870dbd5a846c627a119e669190", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/blog.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/bootstrap.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Salim\source\repos\PomeloSoftBlogCaseMVC\PomeloSoftBlogCaseMVC\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Ana Sayfa";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d28055da5c8b4364e261f3c97c3a53bd12a92a45162", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
    <meta name=""description""");
                BeginWriteAttribute("content", " content=\"", 398, "\"", 408, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n    <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 435, "\"", 445, 0);
                EndWriteAttribute();
                WriteLiteral(@">
    <link rel=""icon"" href=""../../favicon.ico"">
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css"">
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js""></script>

    <title>Blog Template for Bootstrap</title>

    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0d28055da5c8b4364e261f3c97c3a53bd12a92a46498", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0d28055da5c8b4364e261f3c97c3a53bd12a92a47680", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d28055da5c8b4364e261f3c97c3a53bd12a92a49574", async() => {
                WriteLiteral("\r\n\r\n    <h1>En Çok Okunan Blog Yazıları</h1>\r\n\r\n    <div class=\"row\">\r\n\r\n        <div class=\"col-sm-8 blog-main\">\r\n");
#nullable restore
#line 35 "C:\Users\Salim\source\repos\PomeloSoftBlogCaseMVC\PomeloSoftBlogCaseMVC\Views\Home\Index.cshtml"
              
                if (ViewBag.Data != null)
                {
                    int sayac = 0;
                    foreach (var item in ViewBag.Data)
                    {

                        if (sayac++ > 4)
                        {
                            break;
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div id=\"blog-post\" class=\"blog-post\" style=\"width:100%;\">\r\n                            <img type=\"submit\"");
                BeginWriteAttribute("src", " src=\"", 1552, "\"", 1569, 1);
#nullable restore
#line 47 "C:\Users\Salim\source\repos\PomeloSoftBlogCaseMVC\PomeloSoftBlogCaseMVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 1558, item.Resim, 1558, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"height:50%; width:100%;\" />\r\n                            <h2 class=\"blog-post-title\">");
#nullable restore
#line 48 "C:\Users\Salim\source\repos\PomeloSoftBlogCaseMVC\PomeloSoftBlogCaseMVC\Views\Home\Index.cshtml"
                                                   Write(item.Baslik);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n                            <p class=\"blog-post-meta\">");
#nullable restore
#line 49 "C:\Users\Salim\source\repos\PomeloSoftBlogCaseMVC\PomeloSoftBlogCaseMVC\Views\Home\Index.cshtml"
                                                 Write(item.Aciklama);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                            <h3>");
#nullable restore
#line 50 "C:\Users\Salim\source\repos\PomeloSoftBlogCaseMVC\PomeloSoftBlogCaseMVC\Views\Home\Index.cshtml"
                           Write(item.Tarih);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n                        </div>\r\n");
                WriteLiteral("                        <p>---------------------------------------------------------</p>\r\n");
#nullable restore
#line 54 "C:\Users\Salim\source\repos\PomeloSoftBlogCaseMVC\PomeloSoftBlogCaseMVC\Views\Home\Index.cshtml"
                    }
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <span style=\"color:red\">");
#nullable restore
#line 58 "C:\Users\Salim\source\repos\PomeloSoftBlogCaseMVC\PomeloSoftBlogCaseMVC\Views\Home\Index.cshtml"
                                       Write(Html.Label((string)ViewBag.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n");
#nullable restore
#line 59 "C:\Users\Salim\source\repos\PomeloSoftBlogCaseMVC\PomeloSoftBlogCaseMVC\Views\Home\Index.cshtml"
                }

            

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <script src=\"https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js\"></script>\r\n    <script>window.jQuery || document.write(\'<script src=\"../../assets/js/vendor/jquery.min.js\"><\\/script>\')</script>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d28055da5c8b4364e261f3c97c3a53bd12a92a413390", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
