#pragma checksum "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Reader\Views\Book\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c493b1881e9855d1f369f18a4c4a31e44e40c30"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Reader_Views_Book_Detail), @"mvc.1.0.view", @"/Areas/Reader/Views/Book/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c493b1881e9855d1f369f18a4c4a31e44e40c30", @"/Areas/Reader/Views/Book/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"516ceadcaafc876581448fc66b7df29b054af23b", @"/Areas/Reader/Views/_ViewImports.cshtml")]
    public class Areas_Reader_Views_Book_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Book>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Payment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success btn-sm me-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ToggleFavorite", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-success", new global::Microsoft.AspNetCore.Html.HtmlString("success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-method", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("heart"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-secondary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Reader\Views\Book\Detail.cshtml"
  
    ViewBag.Title = "Book Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-8 row mx-0 justify-content-between\">\r\n    <div class=\"col-4\">\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 342, "\"", 394, 1);
#nullable restore
#line 10 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Reader\Views\Book\Detail.cshtml"
WriteAttributeValue("", 348, _serverUrl.ThumbnailUrl(Model.ThumbnailUrl), 348, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"w-100\" />\r\n    </div>\r\n    <div class=\"col-7\">\r\n        <h3>");
#nullable restore
#line 13 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Reader\Views\Book\Detail.cshtml"
       Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
        <p>
            <i class=""icofont-star fs-4 start-yellow""></i>
            <i class=""icofont-star fs-4 start-yellow""></i>
            <i class=""icofont-star fs-4 start-yellow""></i>
            <i class=""icofont-star fs-4 start-yellow""></i>
            <i class=""icofont-star fs-4""></i>
        </p>
        <p class=""text-muted"">
            <span>By : </span>
            <a href=""#"" class=""text-success text-decoration-none fw-bold fs-3"">");
#nullable restore
#line 23 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Reader\Views\Book\Detail.cshtml"
                                                                           Write(Model.Author.LastName + " " + Model.Author.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n        </p>\r\n        <div class=\"row mx-0 mb-2\">\r\n            <div class=\"col\">\r\n                <strong class=\"text-dark fs-3\">");
#nullable restore
#line 27 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Reader\Views\Book\Detail.cshtml"
                                          Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n            </div>\r\n");
#nullable restore
#line 29 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Reader\Views\Book\Detail.cshtml"
             if (Model.ReducedPrice >= 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col\">\r\n                    <del class=\"text-muted fs-4\">");
#nullable restore
#line 32 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Reader\Views\Book\Detail.cshtml"
                                            Write(Model.ReducedPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</del>\r\n                </div>\r\n");
#nullable restore
#line 34 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Reader\Views\Book\Detail.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 36 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Reader\Views\Book\Detail.cshtml"
          
            if (_signInManager.IsSignedIn(User))
            {
                string userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
                var basket = _db.Baskets.Where(bk => bk.BookId == Model.Id && bk.UserId == userId).FirstOrDefault();
                if (basket != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <button class=\"btn btn-primary btn-sm me-3\">Read now</button>\r\n");
#nullable restore
#line 44 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Reader\Views\Book\Detail.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c493b1881e9855d1f369f18a4c4a31e44e40c3012364", async() => {
                WriteLiteral("Buy Now");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 47 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Reader\Views\Book\Detail.cshtml"
                                                                     WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 48 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Reader\Views\Book\Detail.cshtml"
                }
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c493b1881e9855d1f369f18a4c4a31e44e40c3015112", async() => {
                WriteLiteral("Buy Now");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 52 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Reader\Views\Book\Detail.cshtml"
                                                                 WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 53 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Reader\Views\Book\Detail.cshtml"
            }
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Reader\Views\Book\Detail.cshtml"
          
            if (_signInManager.IsSignedIn(User))
            {
                string userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
                bool isHeart = Model.Interactions.Where(it => it.BookId == Model.Id && it.UserId == userId).Select(it => it.IsLove).FirstOrDefault();
                if (isHeart)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c493b1881e9855d1f369f18a4c4a31e44e40c3018339", async() => {
                WriteLiteral("<i class=\"icofont-heart\"></i>");
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
#line 62 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Reader\Views\Book\Detail.cshtml"
                                                     WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 64 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Reader\Views\Book\Detail.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c493b1881e9855d1f369f18a4c4a31e44e40c3021218", async() => {
                WriteLiteral("<i class=\"icofont-heart\"></i>");
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
#line 67 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Reader\Views\Book\Detail.cshtml"
                                                     WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 69 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Reader\Views\Book\Detail.cshtml"
                }
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <ul class=""nav nav-tabs mt-5 tab-about"">
            <li class=""nav-item bg-light"">
                <a class=""nav-link link-success active"" data-transform=""#about-book"" aria-current=""page"" href=""#"">About this book</a>
            </li>
            <li class=""nav-item bg-light"">
                <a class=""nav-link link-success"" data-transform=""#about-authors"" href=""#"">About the authors</a>
            </li>
            <li class=""nav-item bg-light"">
                <a class=""nav-link link-success"" data-transform=""#reviews"" href=""#"">Reviews</a>
            </li>
        </ul>

        <div class=""p-3"">
            <p class=""text-muted detail wrap-break-word"" id=""about-book"">");
#nullable restore
#line 85 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Reader\Views\Book\Detail.cshtml"
                                                                    Write(Model.AboutBook);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p class=\"text-muted detail wrap-break-word d-none\" id=\"about-authors\">");
#nullable restore
#line 86 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Reader\Views\Book\Detail.cshtml"
                                                                              Write(Model.Author.AboutAuthor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p class=\"text-muted detail wrap-break-word d-none\" id=\"reviews\">");
#nullable restore
#line 87 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Reader\Views\Book\Detail.cshtml"
                                                                        Write(Model.Review);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n\r\n    </div>\r\n\r\n\r\n</div>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $('.tab-about > li').click(function (e) {
                e.preventDefault();
                $('.tab-about li a').removeClass('active');
                $('.detail').addClass('d-none');
                $(e.target).addClass('active');
                console.log($(e.target));
                let selector = $(e.target).attr('data-transform');
                $(selector).removeClass('d-none');
            });
        });
        var success = function (data) {
            var heart = document.getElementById('heart');
            if (data == 'ADD' || data == 'REMOVE') {
                if (heart.classList.contains('btn-outline-secondary')) {
                    heart.classList.remove('btn-outline-secondary');
                    heart.classList.add('btn-outline-danger');
                    alert('Added to favorite books');
                }
                else {
                    heart.classList.remove('btn-outline-danger");
                WriteLiteral(@"');
                    heart.classList.add('btn-outline-secondary');
                    alert('Removed to favorite books');
                }
            }
            else {
                alert('Error! An error occurred. Please try again later');
            }
        };
    </script>

");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public CoreLibrary.Areas.Reader.Data.EBookContext _db { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Identity.SignInManager<User> _signInManager { get; private set; }
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