#pragma checksum "D:\COSC4351\COSC4351\COSC4351\Views\EmployeeAccount\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "50880145c35bcd903136ade0bb157cc6514dc867"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EmployeeAccount_Login), @"mvc.1.0.view", @"/Views/EmployeeAccount/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/EmployeeAccount/Login.cshtml", typeof(AspNetCore.Views_EmployeeAccount_Login))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50880145c35bcd903136ade0bb157cc6514dc867", @"/Views/EmployeeAccount/Login.cshtml")]
    public class Views_EmployeeAccount_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<COSC4351.ViewModels.EmployeeLoginVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\COSC4351\COSC4351\COSC4351\Views\EmployeeAccount\Login.cshtml"
  
    ViewBag.Title = "Login";

#line default
#line hidden
            BeginContext(81, 29, true);
            WriteLiteral("\r\n<h2>Employee Login</h2>\r\n\r\n");
            EndContext();
#line 8 "D:\COSC4351\COSC4351\COSC4351\Views\EmployeeAccount\Login.cshtml"
 using (Html.BeginForm("Login", "EmployeeAccount", FormMethod.Post, new { @class = "form-horizontal", role = "form" }))
{

#line default
#line hidden
            BeginContext(234, 42, true);
            WriteLiteral("<h4>Login into an existing account.</h4>\r\n");
            EndContext();
            BeginContext(281, 58, false);
#line 11 "D:\COSC4351\COSC4351\COSC4351\Views\EmployeeAccount\Login.cshtml"
Write(Html.ValidationSummary("", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(341, 135, true);
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-md-8\">\r\n        <section id=\"loginForm\">\r\n            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(477, 73, false);
#line 16 "D:\COSC4351\COSC4351\COSC4351\Views\EmployeeAccount\Login.cshtml"
           Write(Html.LabelFor(m => m.Username, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(550, 63, true);
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
            EndContext();
            BeginContext(614, 65, false);
#line 18 "D:\COSC4351\COSC4351\COSC4351\Views\EmployeeAccount\Login.cshtml"
               Write(Html.TextBoxFor(m => m.Username, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(679, 102, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group\">\r\n\r\n                ");
            EndContext();
            BeginContext(782, 73, false);
#line 23 "D:\COSC4351\COSC4351\COSC4351\Views\EmployeeAccount\Login.cshtml"
           Write(Html.LabelFor(m => m.Password, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(855, 63, true);
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
            EndContext();
            BeginContext(919, 66, false);
#line 25 "D:\COSC4351\COSC4351\COSC4351\Views\EmployeeAccount\Login.cshtml"
               Write(Html.PasswordFor(m => m.Password, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(985, 269, true);
            WriteLiteral(@"
                </div>
            </div>
            <div class=""form-group"">
                <div class=""col-md-offset-2 col-md-10"">
                    <input type=""submit"" value=""Log in"" class=""btn btn-default"" />
                </div>
            </div>
");
            EndContext();
            BeginContext(1365, 40, true);
            WriteLiteral("        </section>\r\n    </div>\r\n</div>\r\n");
            EndContext();
#line 39 "D:\COSC4351\COSC4351\COSC4351\Views\EmployeeAccount\Login.cshtml"
}

#line default
#line hidden
            DefineSection("Scripts", async() => {
                BeginContext(1426, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1433, 37, false);
#line 41 "D:\COSC4351\COSC4351\COSC4351\Views\EmployeeAccount\Login.cshtml"
Write(Scripts.Render("~/bundles/jqueryval"));

#line default
#line hidden
                EndContext();
                BeginContext(1470, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(1475, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<COSC4351.ViewModels.EmployeeLoginVM> Html { get; private set; }
    }
}
#pragma warning restore 1591