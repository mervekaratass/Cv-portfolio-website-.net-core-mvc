#pragma checksum "D:\vscode2019\Core_Proje\Core_Proje\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ec2a4dd8e150acfc39a9c04813dd1a80b518189"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Index), @"mvc.1.0.view", @"/Views/Dashboard/Index.cshtml")]
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
#line 1 "D:\vscode2019\Core_Proje\Core_Proje\Views\_ViewImports.cshtml"
using Core_Proje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\vscode2019\Core_Proje\Core_Proje\Views\_ViewImports.cshtml"
using Core_Proje.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ec2a4dd8e150acfc39a9c04813dd1a80b518189", @"/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3916d9c95bde3173996b91a771a7fba1f38cc4f", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\vscode2019\Core_Proje\Core_Proje\Views\Dashboard\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"content-wrapper\">\r\n\r\n    ");
#nullable restore
#line 9 "D:\vscode2019\Core_Proje\Core_Proje\Views\Dashboard\Index.cshtml"
Write(await Component.InvokeAsync("FeatureStatistics"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div class=""row"">
        <div class=""col-md-4 grid-margin stretch-card"">
            <div class=""card"">
                <div class=""card-body"">
                    <h4 class=""card-title"">Bütçe Geçmişi</h4>
                    <canvas id=""transaction-history"" class=""transaction-chart""></canvas>
                    <div class=""bg-gray-dark d-flex d-md-block d-xl-flex flex-row py-3 px-4 px-md-3 px-xl-4 rounded mt-3"">
                        <div class=""text-md-center text-xl-left"">
                            <h6 class=""mb-1"">Proje Ödemeleri</h6>
                            <p class=""text-muted mb-0"">07 Aralık 2021, 09:36</p>
                        </div>
                        <div class=""align-self-center flex-grow text-right text-md-center text-xl-right py-md-2 py-xl-0"">
                            <h6 class=""font-weight-bold mb-0"">₺12450</h6>
                        </div>
                    </div>
                    <div class=""bg-gray-dark d-flex d-md-block d-xl-flex flex-row py-3");
            WriteLiteral(@" px-4 px-md-3 px-xl-4 rounded mt-3"">
                        <div class=""text-md-center text-xl-left"">
                            <h6 class=""mb-1"">Reklam Grafikleri</h6>
                            <p class=""text-muted mb-0"">1 Aralık 2021, 16:30</p>
                        </div>
                        <div class=""align-self-center flex-grow text-right text-md-center text-xl-right py-md-2 py-xl-0"">
                            <h6 class=""font-weight-bold mb-0"">$1687</h6>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        ");
#nullable restore
#line 37 "D:\vscode2019\Core_Proje\Core_Proje\Views\Dashboard\Index.cshtml"
   Write(await Component.InvokeAsync("Last5Projects"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    ");
#nullable restore
#line 39 "D:\vscode2019\Core_Proje\Core_Proje\Views\Dashboard\Index.cshtml"
Write(await Component.InvokeAsync("StatisticsDashboard2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 40 "D:\vscode2019\Core_Proje\Core_Proje\Views\Dashboard\Index.cshtml"
Write(await Component.InvokeAsync("ProjectList"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <div class=\"row\">\r\n        ");
#nullable restore
#line 43 "D:\vscode2019\Core_Proje\Core_Proje\Views\Dashboard\Index.cshtml"
   Write(await Component.InvokeAsync("MessageList"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        ");
#nullable restore
#line 45 "D:\vscode2019\Core_Proje\Core_Proje\Views\Dashboard\Index.cshtml"
   Write(await Component.InvokeAsync("SlideList"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 46 "D:\vscode2019\Core_Proje\Core_Proje\Views\Dashboard\Index.cshtml"
   Write(await Component.InvokeAsync("ToDoListPanel"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    ");
#nullable restore
#line 48 "D:\vscode2019\Core_Proje\Core_Proje\Views\Dashboard\Index.cshtml"
Write(await Component.InvokeAsync("VisitorsMap"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n             ");
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
