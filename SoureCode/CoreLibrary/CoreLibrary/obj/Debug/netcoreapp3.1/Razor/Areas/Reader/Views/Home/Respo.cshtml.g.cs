#pragma checksum "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Reader\Views\Home\Respo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "230413f49b6d99970c284c879e5a87950d0712ba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Reader_Views_Home_Respo), @"mvc.1.0.view", @"/Areas/Reader/Views/Home/Respo.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"230413f49b6d99970c284c879e5a87950d0712ba", @"/Areas/Reader/Views/Home/Respo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"516ceadcaafc876581448fc66b7df29b054af23b", @"/Areas/Reader/Views/_ViewImports.cshtml")]
    public class Areas_Reader_Views_Home_Respo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Book>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "reader", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Rating", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Reader\Views\Home\Respo.cshtml"
  
    ViewBag.Title = "Purchased";
    Layout = "_LayoutEmpty";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"my-3 fs-5 ms-5 p-2 my-0\">\r\n    <nav aria-label=\"breadcrumb\">\r\n        <ol class=\"breadcrumb\">\r\n            <li class=\"breadcrumb-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "230413f49b6d99970c284c879e5a87950d0712ba6895", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n            <li class=\"breadcrumb-item active\" aria-current=\"page\">Purchased Books</li>\r\n        </ol>\r\n    </nav>\r\n</div>\r\n\r\n<div class=\"row mx-0 justify-content-center\" id=\"container\">\r\n    <div class=\"col-8 row mx-0\">\r\n");
#nullable restore
#line 19 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Reader\Views\Home\Respo.cshtml"
         foreach (var book in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-3 px-3\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 717, "\"", 768, 1);
#nullable restore
#line 22 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Reader\Views\Home\Respo.cshtml"
WriteAttributeValue("", 723, _serverUrl.ThumbnailUrl(book.ThumbnailUrl), 723, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"w-100 p-2 height-thumbnail\" />\r\n                <hr class=\"my-0\" />\r\n                <p class=\"text-muted text-end\">");
#nullable restore
#line 24 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Reader\Views\Home\Respo.cshtml"
                                          Write(book.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <div class=\"text-block-wrap height2line\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 999, "\"", 1043, 1);
#nullable restore
#line 26 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Reader\Views\Home\Respo.cshtml"
WriteAttributeValue("", 1006, _serverUrl.BookPdfUrl(book.PdfUrl), 1006, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\"\r\n                       class=\"text-decoration-none text-dark fw-bold d-block\">");
#nullable restore
#line 27 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Reader\Views\Home\Respo.cshtml"
                                                                         Write(book.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </div>\r\n\r\n                <p class=\"text-muted mb-0\">\r\n                    <span>By : </span>\r\n                    <a href=\"#\" class=\"text-success text-decoration-none\">");
#nullable restore
#line 32 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Reader\Views\Home\Respo.cshtml"
                                                                      Write(book.Author.LastName + " " + book.Author.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                </p>
                <p class=""mb-2"">
                    <i class=""icofont-star fs-6 start-yellow""></i>
                    <i class=""icofont-star fs-6 start-yellow""></i>
                    <i class=""icofont-star fs-6 start-yellow""></i>
                    <i class=""icofont-star fs-6 start-yellow""></i>
                    <i class=""icofont-star fs-6""></i>
                </p>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "230413f49b6d99970c284c879e5a87950d0712ba11625", async() => {
                WriteLiteral("Rate");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 41 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Reader\Views\Home\Respo.cshtml"
                                         WriteLiteral(book.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 43 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Reader\Views\Home\Respo.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public CoreLibrary.Helper.Services.ServerUrlService _serverUrl { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591
