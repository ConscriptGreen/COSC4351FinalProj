#pragma checksum "D:\COSC4351\COSC4351\COSC4351\Views\Employee\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e04a2a2f701e0d92ee957c65d5a3e6e1bda4724"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Index), @"mvc.1.0.view", @"/Views/Employee/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employee/Index.cshtml", typeof(AspNetCore.Views_Employee_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e04a2a2f701e0d92ee957c65d5a3e6e1bda4724", @"/Views/Employee/Index.cshtml")]
    public class Views_Employee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<COSC4351.Employee>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(39, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\COSC4351\COSC4351\COSC4351\Views\Employee\Index.cshtml"
      
    ViewBag.Title = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

    

#line default
#line hidden
            BeginContext(135, 49, true);
            WriteLiteral("\r\n    <h2>Employee List</h2>\r\n\r\n    <p>\r\n        ");
            EndContext();
            BeginContext(185, 39, false);
#line 12 "D:\COSC4351\COSC4351\COSC4351\Views\Employee\Index.cshtml"
   Write(Html.ActionLink("Create New", "Create"));

#line default
#line hidden
            EndContext();
            BeginContext(224, 87, true);
            WriteLiteral("\r\n    </p>\r\n    <table class=\"table\">\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(312, 53, false);
#line 17 "D:\COSC4351\COSC4351\COSC4351\Views\Employee\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Departments.DName));

#line default
#line hidden
            EndContext();
            BeginContext(365, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(421, 45, false);
#line 20 "D:\COSC4351\COSC4351\COSC4351\Views\Employee\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(466, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(522, 46, false);
#line 23 "D:\COSC4351\COSC4351\COSC4351\Views\Employee\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MiddleName));

#line default
#line hidden
            EndContext();
            BeginContext(568, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(624, 44, false);
#line 26 "D:\COSC4351\COSC4351\COSC4351\Views\Employee\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(668, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(724, 49, false);
#line 29 "D:\COSC4351\COSC4351\COSC4351\Views\Employee\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.StreetAddress));

#line default
#line hidden
            EndContext();
            BeginContext(773, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(829, 41, false);
#line 32 "D:\COSC4351\COSC4351\COSC4351\Views\Employee\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.State));

#line default
#line hidden
            EndContext();
            BeginContext(870, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(926, 40, false);
#line 35 "D:\COSC4351\COSC4351\COSC4351\Views\Employee\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
            EndContext();
            BeginContext(966, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1022, 43, false);
#line 38 "D:\COSC4351\COSC4351\COSC4351\Views\Employee\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ZipCode));

#line default
#line hidden
            EndContext();
            BeginContext(1065, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1121, 39, false);
#line 41 "D:\COSC4351\COSC4351\COSC4351\Views\Employee\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DoB));

#line default
#line hidden
            EndContext();
            BeginContext(1160, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1216, 39, false);
#line 44 "D:\COSC4351\COSC4351\COSC4351\Views\Employee\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Sex));

#line default
#line hidden
            EndContext();
            BeginContext(1255, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1311, 44, false);
#line 47 "D:\COSC4351\COSC4351\COSC4351\Views\Employee\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.JobTitle));

#line default
#line hidden
            EndContext();
            BeginContext(1355, 61, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n\r\n");
            EndContext();
#line 52 "D:\COSC4351\COSC4351\COSC4351\Views\Employee\Index.cshtml"
         foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1456, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1505, 52, false);
#line 55 "D:\COSC4351\COSC4351\COSC4351\Views\Employee\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Departments.DName));

#line default
#line hidden
            EndContext();
            BeginContext(1557, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1613, 44, false);
#line 58 "D:\COSC4351\COSC4351\COSC4351\Views\Employee\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(1657, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1713, 45, false);
#line 61 "D:\COSC4351\COSC4351\COSC4351\Views\Employee\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MiddleName));

#line default
#line hidden
            EndContext();
            BeginContext(1758, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1814, 43, false);
#line 64 "D:\COSC4351\COSC4351\COSC4351\Views\Employee\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(1857, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1913, 48, false);
#line 67 "D:\COSC4351\COSC4351\COSC4351\Views\Employee\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.StreetAddress));

#line default
#line hidden
            EndContext();
            BeginContext(1961, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2017, 40, false);
#line 70 "D:\COSC4351\COSC4351\COSC4351\Views\Employee\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.State));

#line default
#line hidden
            EndContext();
            BeginContext(2057, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2113, 39, false);
#line 73 "D:\COSC4351\COSC4351\COSC4351\Views\Employee\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.City));

#line default
#line hidden
            EndContext();
            BeginContext(2152, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2208, 42, false);
#line 76 "D:\COSC4351\COSC4351\COSC4351\Views\Employee\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ZipCode));

#line default
#line hidden
            EndContext();
            BeginContext(2250, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2306, 38, false);
#line 79 "D:\COSC4351\COSC4351\COSC4351\Views\Employee\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DoB));

#line default
#line hidden
            EndContext();
            BeginContext(2344, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2400, 38, false);
#line 82 "D:\COSC4351\COSC4351\COSC4351\Views\Employee\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Sex));

#line default
#line hidden
            EndContext();
            BeginContext(2438, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2494, 43, false);
#line 85 "D:\COSC4351\COSC4351\COSC4351\Views\Employee\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.JobTitle));

#line default
#line hidden
            EndContext();
            BeginContext(2537, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2593, 59, false);
#line 88 "D:\COSC4351\COSC4351\COSC4351\Views\Employee\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id=item.EmployeeID }));

#line default
#line hidden
            EndContext();
            BeginContext(2652, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2673, 65, false);
#line 89 "D:\COSC4351\COSC4351\COSC4351\Views\Employee\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { id=item.EmployeeID }));

#line default
#line hidden
            EndContext();
            BeginContext(2738, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2759, 63, false);
#line 90 "D:\COSC4351\COSC4351\COSC4351\Views\Employee\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id=item.EmployeeID }));

#line default
#line hidden
            EndContext();
            BeginContext(2822, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 93 "D:\COSC4351\COSC4351\COSC4351\Views\Employee\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2869, 16, true);
            WriteLiteral("\r\n    </table>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<COSC4351.Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
