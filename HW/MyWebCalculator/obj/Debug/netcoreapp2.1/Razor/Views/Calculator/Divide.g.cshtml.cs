#pragma checksum "/Users/amysayso/Desktop/CIDM3312/HW/MyWebCalculator/Views/Calculator/Divide.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37d3428efd4285b77a9967f658a419db66342c3c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Calculator_Divide), @"mvc.1.0.view", @"/Views/Calculator/Divide.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Calculator/Divide.cshtml", typeof(AspNetCore.Views_Calculator_Divide))]
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
#line 1 "/Users/amysayso/Desktop/CIDM3312/HW/MyWebCalculator/Views/_ViewImports.cshtml"
using MyWebCalculator;

#line default
#line hidden
#line 2 "/Users/amysayso/Desktop/CIDM3312/HW/MyWebCalculator/Views/_ViewImports.cshtml"
using MyWebCalculator.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37d3428efd4285b77a9967f658a419db66342c3c", @"/Views/Calculator/Divide.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"723c93cf8501ee692a6dcd53c1cb5152db45382f", @"/Views/_ViewImports.cshtml")]
    public class Views_Calculator_Divide : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/amysayso/Desktop/CIDM3312/HW/MyWebCalculator/Views/Calculator/Divide.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(24, 32, true);
            WriteLiteral("\n<h1> The dividend is: </h1>\n<p>");
            EndContext();
            BeginContext(57, 24, false);
#line 6 "/Users/amysayso/Desktop/CIDM3312/HW/MyWebCalculator/Views/Calculator/Divide.cshtml"
Write(ViewData["DivideResult"]);

#line default
#line hidden
            EndContext();
            BeginContext(81, 6, true);
            WriteLiteral("</p>\n\n");
            EndContext();
#line 8 "/Users/amysayso/Desktop/CIDM3312/HW/MyWebCalculator/Views/Calculator/Divide.cshtml"
  
    int left = Convert.ToInt32(ViewData["Left"]);
    int right = Convert.ToInt32(ViewData["Right"]);
    int result = left / right;

#line default
#line hidden
            BeginContext(225, 4, true);
            WriteLiteral("\n<p>");
            EndContext();
            BeginContext(230, 6, false);
#line 14 "/Users/amysayso/Desktop/CIDM3312/HW/MyWebCalculator/Views/Calculator/Divide.cshtml"
Write(result);

#line default
#line hidden
            EndContext();
            BeginContext(236, 4, true);
            WriteLiteral("</p>");
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