#pragma checksum "/Users/amysayso/Desktop/CIDM3312/Midterm2/Views/Math/ShowCalculationResults.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1918afd9f1783afe8c5bed6166becaa0787b2bda"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Math_ShowCalculationResults), @"mvc.1.0.view", @"/Views/Math/ShowCalculationResults.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Math/ShowCalculationResults.cshtml", typeof(AspNetCore.Views_Math_ShowCalculationResults))]
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
#line 1 "/Users/amysayso/Desktop/CIDM3312/Midterm2/Views/_ViewImports.cshtml"
using Midterm2;

#line default
#line hidden
#line 2 "/Users/amysayso/Desktop/CIDM3312/Midterm2/Views/_ViewImports.cshtml"
using Midterm2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1918afd9f1783afe8c5bed6166becaa0787b2bda", @"/Views/Math/ShowCalculationResults.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a14cfd6ca6e2463f9470bdf888568056e4358c3", @"/Views/_ViewImports.cshtml")]
    public class Views_Math_ShowCalculationResults : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MathOperation>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(21, 26, true);
            WriteLiteral("\n<h1>Results</h1>\n<p>\n    ");
            EndContext();
            BeginContext(48, 17, false);
#line 5 "/Users/amysayso/Desktop/CIDM3312/Midterm2/Views/Math/ShowCalculationResults.cshtml"
Write(Model.LeftOperand);

#line default
#line hidden
            EndContext();
            BeginContext(65, 6, true);
            WriteLiteral(" \n    ");
            EndContext();
            BeginContext(72, 14, false);
#line 6 "/Users/amysayso/Desktop/CIDM3312/Midterm2/Views/Math/ShowCalculationResults.cshtml"
Write(Model.Operator);

#line default
#line hidden
            EndContext();
            BeginContext(86, 6, true);
            WriteLiteral(" \n    ");
            EndContext();
            BeginContext(93, 18, false);
#line 7 "/Users/amysayso/Desktop/CIDM3312/Midterm2/Views/Math/ShowCalculationResults.cshtml"
Write(Model.RightOperand);

#line default
#line hidden
            EndContext();
            BeginContext(111, 12, true);
            WriteLiteral(" =\n    \n    ");
            EndContext();
            BeginContext(124, 12, false);
#line 9 "/Users/amysayso/Desktop/CIDM3312/Midterm2/Views/Math/ShowCalculationResults.cshtml"
Write(Model.Result);

#line default
#line hidden
            EndContext();
            BeginContext(136, 7, true);
            WriteLiteral(" \n\n</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MathOperation> Html { get; private set; }
    }
}
#pragma warning restore 1591
