#pragma checksum "/home/roby/Documents/Kuliah/Semester_8/PABSER/Projek/AdminIB/Views/IB/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3322b67363f184450a26c07a357de58da936de64"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_IB_Index), @"mvc.1.0.view", @"/Views/IB/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/IB/Index.cshtml", typeof(AspNetCore.Views_IB_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3322b67363f184450a26c07a357de58da936de64", @"/Views/IB/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d28cd1836bf0419d19290341b96040cfa7eb6cf", @"/Views/_ViewImports.cshtml")]
    public class Views_IB_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AdminIB.Models.Request>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Accept", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Reject", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "/home/roby/Documents/Kuliah/Semester_8/PABSER/Projek/AdminIB/Views/IB/Index.cshtml"
  
    ViewData["Title"] = "Data IB";
    Layout = "~/Views/Shared/_Layout.cshtml";
    int no=0;

#line default
#line hidden
            BeginContext(151, 93, true);
            WriteLiteral("\r\n<!-- Content Header (Page header) -->\r\n<section class=\"content-header\">\r\n    <h1>\r\n        ");
            EndContext();
            BeginContext(245, 17, false);
#line 12 "/home/roby/Documents/Kuliah/Semester_8/PABSER/Projek/AdminIB/Views/IB/Index.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(262, 527, true);
            WriteLiteral(@"
    </h1>
</section>
<!-- Main content -->
<section class=""content container-fluid"">
    <div class=""row"">
        <div class=""col-xs-12"">
            <div class=""box"">
                <div class=""box-header"">
                    <h3 class=""box-title"">Admins Table</h3>
                </div>
                <div class=""box-body"">
<table id=""example2"" class=""table table-bordered table-hover"">
    <thead>
        <tr>
            <th>
                NO
            </th>
            <th>
                ");
            EndContext();
            BeginContext(790, 49, false);
#line 31 "/home/roby/Documents/Kuliah/Semester_8/PABSER/Projek/AdminIB/Views/IB/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NamaMahasiswa));

#line default
#line hidden
            EndContext();
            BeginContext(839, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(895, 48, false);
#line 34 "/home/roby/Documents/Kuliah/Semester_8/PABSER/Projek/AdminIB/Views/IB/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NIMMahasiswa));

#line default
#line hidden
            EndContext();
            BeginContext(943, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(999, 49, false);
#line 37 "/home/roby/Documents/Kuliah/Semester_8/PABSER/Projek/AdminIB/Views/IB/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DepartureDate));

#line default
#line hidden
            EndContext();
            BeginContext(1048, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1104, 46, false);
#line 40 "/home/roby/Documents/Kuliah/Semester_8/PABSER/Projek/AdminIB/Views/IB/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ReturnDate));

#line default
#line hidden
            EndContext();
            BeginContext(1150, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1206, 42, false);
#line 43 "/home/roby/Documents/Kuliah/Semester_8/PABSER/Projek/AdminIB/Views/IB/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Reason));

#line default
#line hidden
            EndContext();
            BeginContext(1248, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1304, 47, false);
#line 46 "/home/roby/Documents/Kuliah/Semester_8/PABSER/Projek/AdminIB/Views/IB/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Destination));

#line default
#line hidden
            EndContext();
            BeginContext(1351, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1407, 42, false);
#line 49 "/home/roby/Documents/Kuliah/Semester_8/PABSER/Projek/AdminIB/Views/IB/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1449, 90, true);
            WriteLiteral("\r\n            </th>\r\n            <th>Aksi</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 55 "/home/roby/Documents/Kuliah/Semester_8/PABSER/Projek/AdminIB/Views/IB/Index.cshtml"
 foreach (var item in Model) {
    {no++;}

#line default
#line hidden
            BeginContext(1584, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1634, 2, false);
#line 59 "/home/roby/Documents/Kuliah/Semester_8/PABSER/Projek/AdminIB/Views/IB/Index.cshtml"
            Write(no);

#line default
#line hidden
            EndContext();
            BeginContext(1637, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1693, 48, false);
#line 62 "/home/roby/Documents/Kuliah/Semester_8/PABSER/Projek/AdminIB/Views/IB/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NamaMahasiswa));

#line default
#line hidden
            EndContext();
            BeginContext(1741, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1797, 47, false);
#line 65 "/home/roby/Documents/Kuliah/Semester_8/PABSER/Projek/AdminIB/Views/IB/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NIMMahasiswa));

#line default
#line hidden
            EndContext();
            BeginContext(1844, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1900, 48, false);
#line 68 "/home/roby/Documents/Kuliah/Semester_8/PABSER/Projek/AdminIB/Views/IB/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DepartureDate));

#line default
#line hidden
            EndContext();
            BeginContext(1948, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2004, 45, false);
#line 71 "/home/roby/Documents/Kuliah/Semester_8/PABSER/Projek/AdminIB/Views/IB/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ReturnDate));

#line default
#line hidden
            EndContext();
            BeginContext(2049, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2105, 41, false);
#line 74 "/home/roby/Documents/Kuliah/Semester_8/PABSER/Projek/AdminIB/Views/IB/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Reason));

#line default
#line hidden
            EndContext();
            BeginContext(2146, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2202, 46, false);
#line 77 "/home/roby/Documents/Kuliah/Semester_8/PABSER/Projek/AdminIB/Views/IB/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Destination));

#line default
#line hidden
            EndContext();
            BeginContext(2248, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2304, 41, false);
#line 80 "/home/roby/Documents/Kuliah/Semester_8/PABSER/Projek/AdminIB/Views/IB/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
            EndContext();
            BeginContext(2345, 95, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <!-- <a asp-action=\"Edit\" asp-route-id=\"");
            EndContext();
            BeginContext(2441, 7, false);
#line 83 "/home/roby/Documents/Kuliah/Semester_8/PABSER/Projek/AdminIB/Views/IB/Index.cshtml"
                                                   Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2448, 34, true);
            WriteLiteral("\">Edit</a> | -->\r\n                ");
            EndContext();
            BeginContext(2482, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3322b67363f184450a26c07a357de58da936de6412007", async() => {
                BeginContext(2529, 7, true);
                WriteLiteral("Setujui");
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
#line 84 "/home/roby/Documents/Kuliah/Semester_8/PABSER/Projek/AdminIB/Views/IB/Index.cshtml"
                                         WriteLiteral(item.Id);

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
            BeginContext(2540, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2560, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3322b67363f184450a26c07a357de58da936de6414326", async() => {
                BeginContext(2607, 5, true);
                WriteLiteral("Tolak");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 85 "/home/roby/Documents/Kuliah/Semester_8/PABSER/Projek/AdminIB/Views/IB/Index.cshtml"
                                         WriteLiteral(item.Id);

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
            BeginContext(2616, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 88 "/home/roby/Documents/Kuliah/Semester_8/PABSER/Projek/AdminIB/Views/IB/Index.cshtml"
}

#line default
#line hidden
            BeginContext(2655, 370, true);
            WriteLiteral(@"    </tbody>
    </table>
                </div>
            </div>
        </div>
    </div>
</section>

<script>$(function () {
    $('#example2').DataTable({
      'paging'      : true,
      'lengthChange': false,
      'searching'   : false,
      'ordering'    : true,
      'info'        : true,
      'autoWidth'   : false
    })
  })</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AdminIB.Models.Request>> Html { get; private set; }
    }
}
#pragma warning restore 1591
