#pragma checksum "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Admin\Views\Account\Readers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bdb0c9044be997796b9351327d289beec94a7e74"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Account_Readers), @"mvc.1.0.view", @"/Areas/Admin/Views/Account/Readers.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bdb0c9044be997796b9351327d289beec94a7e74", @"/Areas/Admin/Views/Account/Readers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea7c7e65be92c195afccd594deed147137e3478c", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Account_Readers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<User>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Admin\Views\Account\Readers.cshtml"
  
    ViewBag.Title = "Reader Accounts";
    int pos = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""alert alert-success"" role=""alert"">
    <span class=""fs-2"">Reader accounts</span>
</div>
<table class=""table table-hover"">
    <thead>
        <tr>
            <th scope=""col"">STT</th>
            <th scope=""col"">Last Name</th>
            <th scope=""col"">First Name</th>
            <th scope=""col"">Email</th>
            <th scope=""col"">PhoneNumber</th>
            <th scope=""col"">Country</th>
            <th scope=""col"">Block</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 23 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Admin\Views\Account\Readers.cshtml"
         foreach (var admin in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th scope=\"row\">");
#nullable restore
#line 26 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Admin\Views\Account\Readers.cshtml"
                           Write(pos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 27 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Admin\Views\Account\Readers.cshtml"
               Write(admin.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Admin\Views\Account\Readers.cshtml"
               Write(admin.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Admin\Views\Account\Readers.cshtml"
               Write(admin.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 30 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Admin\Views\Account\Readers.cshtml"
               Write(admin.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 31 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Admin\Views\Account\Readers.cshtml"
               Write(admin.Country.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <i class=\"icofont-ui-unlock\"></i>\r\n                    <i class=\"icofont-ui-lock\"></i>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 37 "D:\NST\CS\Projects\CoreLibrary\CoreLibrary\Areas\Admin\Views\Account\Readers.cshtml"
            pos++;
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
