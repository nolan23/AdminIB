#pragma checksum "/home/roby/Documents/Kuliah/Semester_8/PABSER/Projek/AdminIB/Views/IB/Welcome.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff15f3c3c24468a00db994f27fb4db8fbfa58e50"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_IB_Welcome), @"mvc.1.0.view", @"/Views/IB/Welcome.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/IB/Welcome.cshtml", typeof(AspNetCore.Views_IB_Welcome))]
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
#line 1 "/home/roby/Documents/Kuliah/Semester_8/PABSER/Projek/AdminIB/Views/_ViewImports.cshtml"
using AdminIB;

#line default
#line hidden
#line 2 "/home/roby/Documents/Kuliah/Semester_8/PABSER/Projek/AdminIB/Views/_ViewImports.cshtml"
using AdminIB.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff15f3c3c24468a00db994f27fb4db8fbfa58e50", @"/Views/IB/Welcome.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d28cd1836bf0419d19290341b96040cfa7eb6cf", @"/Views/_ViewImports.cshtml")]
    public class Views_IB_Welcome : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/home/roby/Documents/Kuliah/Semester_8/PABSER/Projek/AdminIB/Views/IB/Welcome.cshtml"
  
    ViewData["Title"] = "Welcome";

#line default
#line hidden
            BeginContext(40, 24, true);
            WriteLiteral("\n<h2>Welcome</h2>\n\n<ul>\n");
            EndContext();
#line 8 "/home/roby/Documents/Kuliah/Semester_8/PABSER/Projek/AdminIB/Views/IB/Welcome.cshtml"
     for (int i = 0; i < (int)ViewData["NumTimes"]; i++)
    {

#line default
#line hidden
            BeginContext(127, 12, true);
            WriteLiteral("        <li>");
            EndContext();
            BeginContext(140, 19, false);
#line 10 "/home/roby/Documents/Kuliah/Semester_8/PABSER/Projek/AdminIB/Views/IB/Welcome.cshtml"
       Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(159, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 11 "/home/roby/Documents/Kuliah/Semester_8/PABSER/Projek/AdminIB/Views/IB/Welcome.cshtml"
    }

#line default
#line hidden
            BeginContext(171, 5, true);
            WriteLiteral("</ul>");
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
