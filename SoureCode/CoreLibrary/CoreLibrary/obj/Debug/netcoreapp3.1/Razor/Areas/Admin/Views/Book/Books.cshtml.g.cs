#pragma checksum "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Admin\Views\Book\Books.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a975a23c9c64c317f5f17755c3c80601918af08f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Book_Books), @"mvc.1.0.view", @"/Areas/Admin/Views/Book/Books.cshtml")]
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
#line 3 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Admin\Views\_ViewImports.cshtml"
using CoreLibrary.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Admin\Views\_ViewImports.cshtml"
using CoreLibrary.Areas.Reader.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a975a23c9c64c317f5f17755c3c80601918af08f", @"/Areas/Admin/Views/Book/Books.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea7c7e65be92c195afccd594deed147137e3478c", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Book_Books : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<Book>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Admin\Views\Book\Books.cshtml"
  
    ViewBag.Title = "Books Manager";
    int pos = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("styles", async() => {
                WriteLiteral("\r\n\r\n");
            }
            );
            WriteLiteral(@"<div class=""alert alert-success"" role=""alert"">
    <span class=""fs-2"">Books Manager</span>
</div>

<table class=""table table-hover"">
    <thead>
        <tr>
            <th scope=""col"">STT</th>
            <th scope=""col"">Name</th>
            <th scope=""col"">Date Published</th>
            <th scope=""col"">Category</th>
            <th scope=""col"">Language</th>
            <th scope=""col"">Author</th>
            <th scope=""col"">Price</th>
            <th scope=""col"">Sold</th>
            <th scope=""col"">Rate</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 29 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Admin\Views\Book\Books.cshtml"
         foreach (var book in Model)
        {
            int star = 0;
            int n = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th scope=\"row\">");
#nullable restore
#line 34 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Admin\Views\Book\Books.cshtml"
                           Write(pos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 35 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Admin\Views\Book\Books.cshtml"
               Write(book.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 36 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Admin\Views\Book\Books.cshtml"
               Write(book.DateTimePosted);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 37 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Admin\Views\Book\Books.cshtml"
               Write(book.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 38 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Admin\Views\Book\Books.cshtml"
               Write(book.Language.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 39 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Admin\Views\Book\Books.cshtml"
                Write(book.Author.LastName + " " + book.Author.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 40 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Admin\Views\Book\Books.cshtml"
               Write(book.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 41 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Admin\Views\Book\Books.cshtml"
               Write(book.Baskets.Sum(bk => bk.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 42 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Admin\Views\Book\Books.cshtml"
                 foreach(var i in book.Interactions)
                {                    
                    if(i.Evaluation != 0)
                    {
                        star = star + i.Evaluation;
                        n = n + 1;
                    }
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Admin\Views\Book\Books.cshtml"
                 if(n != 0 )
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>");
#nullable restore
#line 52 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Admin\Views\Book\Books.cshtml"
                    Write(star / n);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 53 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Admin\Views\Book\Books.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>0</td>\r\n");
#nullable restore
#line 57 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Admin\Views\Book\Books.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\r\n");
#nullable restore
#line 59 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Admin\Views\Book\Books.cshtml"
            pos++;
            star = 0;
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591
