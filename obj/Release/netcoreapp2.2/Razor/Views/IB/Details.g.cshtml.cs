#pragma checksum "/home/roby/Documents/Kuliah/Semester_8/PABSER/Projek/AdminIB/Views/IB/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51aa725fdec2040039ba10d68d5ab2a3f3988691"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_IB_Details), @"mvc.1.0.view", @"/Views/IB/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/IB/Details.cshtml", typeof(AspNetCore.Views_IB_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51aa725fdec2040039ba10d68d5ab2a3f3988691", @"/Views/IB/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d28cd1836bf0419d19290341b96040cfa7eb6cf", @"/Views/_ViewImports.cshtml")]
    public class Views_IB_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AdminIB.Models.Request>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "/home/roby/Documents/Kuliah/Semester_8/PABSER/Projek/AdminIB/Views/IB/Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(76, 130, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Request</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(207, 44, false);
#line 14 "/home/roby/Documents/Kuliah/Semester_8/PABSER/Projek/AdminIB/Views/IB/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ClientId));

#line default
#line hidden
            EndContext();
            BeginContext(251, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(315, 40, false);
#line 17 "/home/roby/Documents/Kuliah/Semester_8/PABSER/Projek/AdminIB/Views/IB/Details.cshtml"
       Write(Html.DisplayFor(model => model.ClientId));

#line default
#line hidden
            EndContext();
            BeginContext(355, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(418, 49, false);
#line 20 "/home/roby/Documents/Kuliah/Semester_8/PABSER/Projek/AdminIB/Views/IB/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NamaMahasiswa));

#line default
#line hidden
            EndContext();
            BeginContext(467, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(531, 45, false);
#line 23 "/home/roby/Documents/Kuliah/Semester_8/PABSER/Projek/AdminIB/Views/IB/Details.cshtml"
       Write(Html.DisplayFor(model => model.NamaMahasiswa));

#line default
#line hidden
            EndContext();
            BeginContext(576, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(639, 48, false);
#line 26 "/home/roby/Documents/Kuliah/Semester_8/PABSER/Projek/AdminIB/Views/IB/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NIMMahasiswa));

#line default
#line hidden
            EndContext();
            BeginContext(687, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(751, 44, false);
#line 29 "/home/roby/Documents/Kuliah/Semester_8/PABSER/Projek/AdminIB/Views/IB/Details.cshtml"
       Write(Html.DisplayFor(model => model.NIMMahasiswa));

#line default
#line hidden
            EndContext();
            BeginContext(795, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(858, 49, false);
#line 32 "/home/roby/Documents/Kuliah/Semester_8/PABSER/Projek/AdminIB/Views/IB/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DepartureDate));

#line default
#line hidden
            EndContext();
            BeginContext(907, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(971, 45, false);
#line 35 "/home/roby/Documents/Kuliah/Semester_8/PABSER/Projek/AdminIB/Views/IB/Details.cshtml"
       Write(Html.DisplayFor(model => model.DepartureDate));

#line default
#line hidden
            EndContext();
            BeginContext(1016, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1079, 46, false);
#line 38 "/home/roby/Documents/Kuliah/Semester_8/PABSER/Projek/AdminIB/Views/IB/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ReturnDate));

#line default
#line hidden
            EndContext();
            BeginContext(1125, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1189, 42, false);
#line 41 "/home/roby/Documents/Kuliah/Semester_8/PABSER/Projek/AdminIB/Views/IB/Details.cshtml"
       Write(Html.DisplayFor(model => model.ReturnDate));

#line default
#line hidden
            EndContext();
            BeginContext(1231, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1294, 42, false);
#line 44 "/home/roby/Documents/Kuliah/Semester_8/PABSER/Projek/AdminIB/Views/IB/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Reason));

#line default
#line hidden
            EndContext();
            BeginContext(1336, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1400, 38, false);
#line 47 "/home/roby/Documents/Kuliah/Semester_8/PABSER/Projek/AdminIB/Views/IB/Details.cshtml"
       Write(Html.DisplayFor(model => model.Reason));

#line default
#line hidden
            EndContext();
            BeginContext(1438, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1501, 47, false);
#line 50 "/home/roby/Documents/Kuliah/Semester_8/PABSER/Projek/AdminIB/Views/IB/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Destination));

#line default
#line hidden
            EndContext();
            BeginContext(1548, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1612, 43, false);
#line 53 "/home/roby/Documents/Kuliah/Semester_8/PABSER/Projek/AdminIB/Views/IB/Details.cshtml"
       Write(Html.DisplayFor(model => model.Destination));

#line default
#line hidden
            EndContext();
            BeginContext(1655, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1718, 42, false);
#line 56 "/home/roby/Documents/Kuliah/Semester_8/PABSER/Projek/AdminIB/Views/IB/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1760, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1824, 38, false);
#line 59 "/home/roby/Documents/Kuliah/Semester_8/PABSER/Projek/AdminIB/Views/IB/Details.cshtml"
       Write(Html.DisplayFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1862, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1909, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51aa725fdec2040039ba10d68d5ab2a3f398869110864", async() => {
                BeginContext(1955, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 64 "/home/roby/Documents/Kuliah/Semester_8/PABSER/Projek/AdminIB/Views/IB/Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1963, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1971, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51aa725fdec2040039ba10d68d5ab2a3f398869113156", async() => {
                BeginContext(1993, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2009, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AdminIB.Models.Request> Html { get; private set; }
    }
}
#pragma warning restore 1591
