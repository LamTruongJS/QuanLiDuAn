#pragma checksum "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Reader\Views\Home\Rating.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "817ae2538ff3b345dc07b012474e5ffcaf19f4c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Reader_Views_Home_Rating), @"mvc.1.0.view", @"/Areas/Reader/Views/Home/Rating.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"817ae2538ff3b345dc07b012474e5ffcaf19f4c1", @"/Areas/Reader/Views/Home/Rating.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"516ceadcaafc876581448fc66b7df29b054af23b", @"/Areas/Reader/Views/_ViewImports.cshtml")]
    public class Areas_Reader_Views_Home_Rating : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Book>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "reader", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Respo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Rating", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Reader\Views\Home\Rating.cshtml"
  
    ViewBag.Title = "Rating";
    Layout = "_LayoutEmpty";
    int star = Model.Interactions.Where(it => it.UserId == ViewBag.UID).Select(it => it.Evaluation).FirstOrDefault();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"my-3 fs-5 ms-5 p-2 my-0\">\r\n    <nav aria-label=\"breadcrumb\">\r\n        <ol class=\"breadcrumb\">\r\n            <li class=\"breadcrumb-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "817ae2538ff3b345dc07b012474e5ffcaf19f4c17526", async() => {
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
            WriteLiteral("</li>\r\n            <li class=\"breadcrumb-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "817ae2538ff3b345dc07b012474e5ffcaf19f4c19132", async() => {
                WriteLiteral("Purchased Books");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
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
            WriteLiteral("</li>\r\n            <li class=\"breadcrumb-item active\" aria-current=\"page\">Rating</li>\r\n        </ol>\r\n    </nav>\r\n</div>\r\n\r\n");
#nullable restore
#line 19 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Reader\Views\Home\Rating.cshtml"
 if (ViewBag.Success == true)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success\" role=\"alert\">\r\n        Successful evaluation !!\r\n    </div>\r\n");
#nullable restore
#line 24 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Reader\Views\Home\Rating.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row mx-0 justify-content-center\" id=\"container\">\r\n    <div class=\"d-flex row mx-0 col-2 \">\r\n        <div class=\"px-3\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 1021, "\"", 1073, 1);
#nullable restore
#line 29 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Reader\Views\Home\Rating.cshtml"
WriteAttributeValue("", 1027, _serverUrl.ThumbnailUrl(Model.ThumbnailUrl), 1027, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"w-100 p-2 height-thumbnail\" />\r\n            <hr class=\"my-0\" />\r\n            <p class=\"text-muted text-end\">");
#nullable restore
#line 31 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Reader\Views\Home\Rating.cshtml"
                                      Write(Model.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <div class=\"text-block-wrap height2line\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1289, "\"", 1334, 1);
#nullable restore
#line 33 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Reader\Views\Home\Rating.cshtml"
WriteAttributeValue("", 1296, _serverUrl.BookPdfUrl(Model.PdfUrl), 1296, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\"\r\n                   class=\"text-decoration-none text-dark fw-bold d-block\">");
#nullable restore
#line 34 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Reader\Views\Home\Rating.cshtml"
                                                                     Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            </div>\r\n\r\n            <p class=\"text-muted mb-0\">\r\n                <span>By : </span>\r\n                <a href=\"#\" class=\"text-success text-decoration-none\">");
#nullable restore
#line 39 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Reader\Views\Home\Rating.cshtml"
                                                                  Write(Model.Author.LastName + " " + Model.Author.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            </p>\r\n        </div>\r\n    </div>\r\n    <div class=\"col-4\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "817ae2538ff3b345dc07b012474e5ffcaf19f4c113777", async() => {
                WriteLiteral("\r\n            <input name=\"userId\"");
                BeginWriteAttribute("value", " value=\"", 1849, "\"", 1869, 1);
#nullable restore
#line 45 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Reader\Views\Home\Rating.cshtml"
WriteAttributeValue("", 1857, ViewBag.UID, 1857, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"hidden\" />\r\n            <input name=\"bookId\"");
                BeginWriteAttribute("value", " value=\"", 1921, "\"", 1938, 1);
#nullable restore
#line 46 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Reader\Views\Home\Rating.cshtml"
WriteAttributeValue("", 1929, Model.Id, 1929, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"hidden\" />\r\n");
#nullable restore
#line 47 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Reader\Views\Home\Rating.cshtml"
              
                for (int i = 1; i <= 5; i++)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"form-check\">\r\n");
#nullable restore
#line 51 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Reader\Views\Home\Rating.cshtml"
                          
                            if (star == i)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <input class=\"form-check-input\" type=\"radio\" name=\"star\"");
                BeginWriteAttribute("value", " value=\"", 2276, "\"", 2286, 1);
#nullable restore
#line 54 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Reader\Views\Home\Rating.cshtml"
WriteAttributeValue("", 2284, i, 2284, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" checked>\r\n");
#nullable restore
#line 55 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Reader\Views\Home\Rating.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <input class=\"form-check-input\" type=\"radio\" name=\"star\"");
                BeginWriteAttribute("value", " value=\"", 2482, "\"", 2492, 1);
#nullable restore
#line 58 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Reader\Views\Home\Rating.cshtml"
WriteAttributeValue("", 2490, i, 2490, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n");
#nullable restore
#line 59 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Reader\Views\Home\Rating.cshtml"
                            }
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Reader\Views\Home\Rating.cshtml"
                          
                            for (int j = 1; j <= 5; j++)
                            {
                                if (i >= j)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <i class=\"icofont-star fs-6 start-yellow\"></i>\r\n");
#nullable restore
#line 67 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Reader\Views\Home\Rating.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <i class=\"icofont-star fs-6\"></i>\r\n");
#nullable restore
#line 71 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Reader\Views\Home\Rating.cshtml"
                                }

                            }
                        

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </div>\r\n");
#nullable restore
#line 76 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Reader\Views\Home\Rating.cshtml"
                }
            

#line default
#line hidden
#nullable disable
                WriteLiteral("            <button type=\"submit\" class=\"my-3 btn btn-warning\">Rate</button>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Book> Html { get; private set; }
    }
}
#pragma warning restore 1591
