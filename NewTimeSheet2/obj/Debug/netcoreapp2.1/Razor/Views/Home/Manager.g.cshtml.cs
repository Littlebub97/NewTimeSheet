#pragma checksum "C:\Users\littlebub97\source\repos\NewTimeSheet2\NewTimeSheet2\Views\Home\Manager.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33d10d6bfd9dfe9332e58e71e780520f45f7d005"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Manager), @"mvc.1.0.view", @"/Views/Home/Manager.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Manager.cshtml", typeof(AspNetCore.Views_Home_Manager))]
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
#line 1 "C:\Users\littlebub97\source\repos\NewTimeSheet2\NewTimeSheet2\Views\_ViewImports.cshtml"
using NewTimeSheet2;

#line default
#line hidden
#line 2 "C:\Users\littlebub97\source\repos\NewTimeSheet2\NewTimeSheet2\Views\_ViewImports.cshtml"
using NewTimeSheet2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33d10d6bfd9dfe9332e58e71e780520f45f7d005", @"/Views/Home/Manager.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df1ac8d14ba5e4e3f3f5d09b389e0f066708c38b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Manager : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\littlebub97\source\repos\NewTimeSheet2\NewTimeSheet2\Views\Home\Manager.cshtml"
  
    ViewData["Title"] = "Manager";

#line default
#line hidden
            BeginContext(45, 4, true);
            WriteLiteral("<h1>");
            EndContext();
            BeginContext(50, 17, false);
#line 5 "C:\Users\littlebub97\source\repos\NewTimeSheet2\NewTimeSheet2\Views\Home\Manager.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(67, 645, true);
            WriteLiteral(@"</h1>

<table border=""5"" width=""100%"" cellpadding=""4"" cellspacing=""3"">
    <tr>
        <th colspan=""4""><br /><h3>Management</h3></th>
        </tr>
    <tr>
        <th>Name</th>
        <th>Id</th>
        <th>Date</th>
        <th>Role</th>
    </tr>
    <tr align=""center"">
        <td>John doe</td>
        <td>1</td>
        <td>12/4/2018</td>
        <td>Employee</td>
    </tr>
</table>



//Create or find role controller
<br />
//Assign one of our users a role
<br />
//lock an action to only managers
<br />
//Finish the manager View
<br />
//Lock manager role
<br />
//Create a TimeSheet Approval view");
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