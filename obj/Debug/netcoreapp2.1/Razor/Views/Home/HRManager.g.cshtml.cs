#pragma checksum "D:\COSC4351\COSC4351\COSC4351\Views\Home\HRManager.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43cd31e82730b3fffd88a9089b8fe87337a35dd7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_HRManager), @"mvc.1.0.view", @"/Views/Home/HRManager.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/HRManager.cshtml", typeof(AspNetCore.Views_Home_HRManager))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43cd31e82730b3fffd88a9089b8fe87337a35dd7", @"/Views/Home/HRManager.cshtml")]
    public class Views_Home_HRManager : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\COSC4351\COSC4351\COSC4351\Views\Home\HRManager.cshtml"
  
    ViewBag.Title = "HRManager";
    Layout = "~/Views/Shared/_Layout.cshtml";


#line default
#line hidden
            BeginContext(90, 220, true);
            WriteLiteral("\r\n<h2>HR Manager Home</h2>\r\n\r\n<section>\r\n    <div class=\"container\">\r\n        <div class=\"row align-items-center\">\r\n\r\n            <div class=\"col-xl-4\">\r\n                <div class=\"card h-100\">\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=", 310, "", 349, 1);
#line 15 "D:\COSC4351\COSC4351\COSC4351\Views\Home\HRManager.cshtml"
WriteAttributeValue("", 315, Url.Content("~/Media/Global.jpg"), 315, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(349, 250, true);
            WriteLiteral(" alt=\"\" class=\"card-img-top h-25\">\r\n                    <div class=\"card-body\">\r\n                        <h3 class=\"card-title\">Global Hub</h3>\r\n                        <p class=\"card-text\">Provides all the Global links.</p>\r\n                        ");
            EndContext();
            BeginContext(600, 107, false);
#line 19 "D:\COSC4351\COSC4351\COSC4351\Views\Home\HRManager.cshtml"
                   Write(Html.ActionLink("GlobalHub", "Index", "GlobalHub", null, new { @class = "btn btn-lg btn-outline-success" }));

#line default
#line hidden
            EndContext();
            BeginContext(707, 178, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"col-xl-4\">\r\n                <div class=\"card h-100\">\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=", 885, "", 920, 1);
#line 26 "D:\COSC4351\COSC4351\COSC4351\Views\Home\HRManager.cshtml"
WriteAttributeValue("", 890, Url.Content("~/Media/HR.jpg"), 890, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(920, 258, true);
            WriteLiteral(@" alt="""" class=""card-img-top h-25"">
                    <div class=""card-body"">
                        <h3 class=""card-title"">HR Manager Hub</h3>
                        <p class=""card-text"">Provides all the HR Manager links.</p>
                        ");
            EndContext();
            BeginContext(1179, 113, false);
#line 30 "D:\COSC4351\COSC4351\COSC4351\Views\Home\HRManager.cshtml"
                   Write(Html.ActionLink("HRManagerHub", "Index", "HRManagerHub", null, new { @class = "btn btn-lg btn-outline-success" }));

#line default
#line hidden
            EndContext();
            BeginContext(1292, 116, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
