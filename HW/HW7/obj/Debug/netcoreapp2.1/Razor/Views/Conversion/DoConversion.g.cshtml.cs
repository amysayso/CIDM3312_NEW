#pragma checksum "/Users/amysayso/Desktop/CIDM3312/HW/HW7/Views/Conversion/DoConversion.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b3db78e9a47a262d1f86d7ab9ef8fe05c61b2d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Conversion_DoConversion), @"mvc.1.0.view", @"/Views/Conversion/DoConversion.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Conversion/DoConversion.cshtml", typeof(AspNetCore.Views_Conversion_DoConversion))]
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
#line 1 "/Users/amysayso/Desktop/CIDM3312/HW/HW7/Views/_ViewImports.cshtml"
using HW7;

#line default
#line hidden
#line 2 "/Users/amysayso/Desktop/CIDM3312/HW/HW7/Views/_ViewImports.cshtml"
using HW7.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b3db78e9a47a262d1f86d7ab9ef8fe05c61b2d2", @"/Views/Conversion/DoConversion.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e54152fe7a8f2e4eb21e424bd142100544f95cf", @"/Views/_ViewImports.cshtml")]
    public class Views_Conversion_DoConversion : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ConverterViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(26, 26, true);
            WriteLiteral("\n<h1>Results</h1>\n<p>\n    ");
            EndContext();
            BeginContext(53, 20, false);
#line 5 "/Users/amysayso/Desktop/CIDM3312/HW/HW7/Views/Conversion/DoConversion.cshtml"
Write(Model.ValueToConvert);

#line default
#line hidden
            EndContext();
            BeginContext(73, 11, true);
            WriteLiteral(" <br/>\n    ");
            EndContext();
            BeginContext(85, 20, false);
#line 6 "/Users/amysayso/Desktop/CIDM3312/HW/HW7/Views/Conversion/DoConversion.cshtml"
Write(Model.ConversionType);

#line default
#line hidden
            EndContext();
            BeginContext(105, 11, true);
            WriteLiteral(" <br/>\n    ");
            EndContext();
            BeginContext(117, 20, false);
#line 7 "/Users/amysayso/Desktop/CIDM3312/HW/HW7/Views/Conversion/DoConversion.cshtml"
Write(Model.ConvertedValue);

#line default
#line hidden
            EndContext();
            BeginContext(137, 13, true);
            WriteLiteral(" <br/>\n\n</p>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ConverterViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591