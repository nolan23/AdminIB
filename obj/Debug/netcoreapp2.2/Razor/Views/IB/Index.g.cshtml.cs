#pragma checksum "/home/roby/Documents/Kuliah/Semester_8/PABSER/Projek/AdminIB/Views/IB/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24ea30f5e160165d4b962c09432a3d185182bbf5"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24ea30f5e160165d4b962c09432a3d185182bbf5", @"/Views/IB/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d28cd1836bf0419d19290341b96040cfa7eb6cf", @"/Views/_ViewImports.cshtml")]
    public class Views_IB_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AdminIB.Models.Request>>
    {
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
            BeginContext(262, 514, true);
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
<table  class=""table table-bordered table-hover"">
    <thead>
        <tr>
            <th>
                NO
            </th>
            <th>
                ");
            EndContext();
            BeginContext(777, 49, false);
#line 31 "/home/roby/Documents/Kuliah/Semester_8/PABSER/Projek/AdminIB/Views/IB/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NamaMahasiswa));

#line default
#line hidden
            EndContext();
            BeginContext(826, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(882, 48, false);
#line 34 "/home/roby/Documents/Kuliah/Semester_8/PABSER/Projek/AdminIB/Views/IB/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NIMMahasiswa));

#line default
#line hidden
            EndContext();
            BeginContext(930, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(986, 49, false);
#line 37 "/home/roby/Documents/Kuliah/Semester_8/PABSER/Projek/AdminIB/Views/IB/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DepartureDate));

#line default
#line hidden
            EndContext();
            BeginContext(1035, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1091, 46, false);
#line 40 "/home/roby/Documents/Kuliah/Semester_8/PABSER/Projek/AdminIB/Views/IB/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ReturnDate));

#line default
#line hidden
            EndContext();
            BeginContext(1137, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1193, 42, false);
#line 43 "/home/roby/Documents/Kuliah/Semester_8/PABSER/Projek/AdminIB/Views/IB/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Reason));

#line default
#line hidden
            EndContext();
            BeginContext(1235, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1291, 47, false);
#line 46 "/home/roby/Documents/Kuliah/Semester_8/PABSER/Projek/AdminIB/Views/IB/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Destination));

#line default
#line hidden
            EndContext();
            BeginContext(1338, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1394, 42, false);
#line 49 "/home/roby/Documents/Kuliah/Semester_8/PABSER/Projek/AdminIB/Views/IB/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1436, 217, true);
            WriteLiteral("\r\n            </th>\r\n            <th>Aksi</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody id=\"table\">\r\n\r\n    </tbody>\r\n    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1670, 1779, true);
                WriteLiteral(@"
<script>  
    function convertDate(date){
        var d = new Date(date)
        return d.toDateString()
    }
        $(document).ready(function () {  
            $.ajax({  
                type: ""GET"",  
                url: ""https://localhost:5001/api/request"",  
                contentType: ""application/json; charset=utf-8"",  
                dataType: ""json"",  
                success: function (data) {  
                    //alert(JSON.stringify(data));                  
                    
                    $.each(data, function (i, item) {  
                        var rows = ""<tr>"" +  
                            ""<td"" + i+""</td>""+
                            ""<td>"" + item.namaMahasiswa + ""</td>"" +
                            ""<td>"" + item.nimMahasiswa + ""</td>"" +    
                            ""<td>"" + convertDate(item.departureDate) + ""</td>"" +  
                             ""<td>"" + convertDate(item.returnDate) + ""</td>"" +
                             ""<td>"" + item.re");
                WriteLiteral(@"ason + ""</td>"" +
                             ""<td>"" + item.destination + ""</td>"" +  
                            ""<td>"" + item.status + ""</td>"" +  
                            ""</tr>"";  
                        $('#table').append(rows);  
                    }); //End of foreach Loop   
                    console.log(data);  
                }, //End of AJAX Success function  
      
                failure: function (data) {  
                    alert(data.responseText);  
                }, //End of AJAX failure function  
                error: function (data) {  
                    alert(data.responseText);  
                } //End of AJAX error function  
      
            });         
        });  
    </script>  
");
                EndContext();
            }
            );
            BeginContext(3452, 2, true);
            WriteLiteral("\r\n");
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
