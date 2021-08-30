#pragma checksum "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Reader\Views\Home\LatestNews.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb4a577ae523c6382dc8659a0304ffea46bfe7ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Reader_Views_Home_LatestNews), @"mvc.1.0.view", @"/Areas/Reader/Views/Home/LatestNews.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 3 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Reader\Views\_ViewImports.cshtml"
using CoreLibrary.Areas.Reader.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Reader\Views\_ViewImports.cshtml"
using CoreLibrary.Areas.Reader.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Reader\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Reader\Views\_ViewImports.cshtml"
using CoreLibrary.Areas.Reader.Models.Book;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Reader\Views\_ViewImports.cshtml"
using CoreLibrary.Areas.Reader.Models.Home;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Reader\Views\_ViewImports.cshtml"
using CoreLibrary.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Reader\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Reader\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Reader\Views\_ViewImports.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Reader\Views\_ViewImports.cshtml"
using CoreLibrary.Areas.Reader.Models.Author;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Reader\Views\_ViewImports.cshtml"
using CoreLibrary.Areas.Reader.Models.Payment;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb4a577ae523c6382dc8659a0304ffea46bfe7ed", @"/Areas/Reader/Views/Home/LatestNews.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"516ceadcaafc876581448fc66b7df29b054af23b", @"/Areas/Reader/Views/_ViewImports.cshtml")]
    public class Areas_Reader_Views_Home_LatestNews : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/news/img-01.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-thumbnail w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/reader/latest_news.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Reader\Views\Home\LatestNews.cshtml"
  
    ViewBag.Title = "Latest News";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"col-8\">\r\n    <p>Latest News</p>\r\n    <h3>What\'s hot in the news</h3>\r\n    <hr />\r\n\r\n    <div class=\"row mx-0\">\r\n        <div class=\"col-4\">\r\n            <a href=\"#\" class=\"d-block\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bb4a577ae523c6382dc8659a0304ffea46bfe7ed6528", async() => {
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
            WriteLiteral(@"
            </a>
            <p class=""text-muted mb-0"">Mon, August 10</p>
            <hr class=""my-1"" />
            <p class=""fw-bold mb-0""><a href=""#"" class=""text-decoration-none text-dark"">Where The Wild Things Are</a></p>
            <p class=""mb-0"">By : <a href=""#"" class=""text-decoration-none text-success"">Johnson Adam</a></p>
            <p class=""text-muted fw-lighter""><i class=""icofont-speech-comments""></i> 21,145 Comments / <i class=""icofont-eye""></i> 201,455 Views</p>
        </div>
    </div>
</div>

");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb4a577ae523c6382dc8659a0304ffea46bfe7ed8289", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
