#pragma checksum "C:\Users\SEYFULLAH\Desktop\csharpdemos\AspNet_Project\AspNet_Project\Views\Job\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "bd201b96e40b4346ea289aa633bf70834f05dd9008a27e2b7df7efdd6e93b11a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Job_Index), @"mvc.1.0.view", @"/Views/Job/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\SEYFULLAH\Desktop\csharpdemos\AspNet_Project\AspNet_Project\Views\_ViewImports.cshtml"
using AspNet_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SEYFULLAH\Desktop\csharpdemos\AspNet_Project\AspNet_Project\Views\_ViewImports.cshtml"
using AspNet_Project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\SEYFULLAH\Desktop\csharpdemos\AspNet_Project\AspNet_Project\Views\Job\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"bd201b96e40b4346ea289aa633bf70834f05dd9008a27e2b7df7efdd6e93b11a", @"/Views/Job/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"966ae505af9897d5bb10573a66e24121f09eb17fa6c65ea5d8c894507371a160", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Job_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Job>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\SEYFULLAH\Desktop\csharpdemos\AspNet_Project\AspNet_Project\Views\Job\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_UILayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Meslek Adı</th>\r\n        <th>Sil</th>\r\n        <th>Güncelle</th>\r\n        <th>Detaylar</th>\r\n\r\n    </tr>\r\n");
#nullable restore
#line 17 "C:\Users\SEYFULLAH\Desktop\csharpdemos\AspNet_Project\AspNet_Project\Views\Job\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 20 "C:\Users\SEYFULLAH\Desktop\csharpdemos\AspNet_Project\AspNet_Project\Views\Job\Index.cshtml"
           Write(item.JobID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\SEYFULLAH\Desktop\csharpdemos\AspNet_Project\AspNet_Project\Views\Job\Index.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 467, "\"", 500, 2);
            WriteAttributeValue("", 474, "/Job/DeleteJob/", 474, 15, true);
#nullable restore
#line 23 "C:\Users\SEYFULLAH\Desktop\csharpdemos\AspNet_Project\AspNet_Project\Views\Job\Index.cshtml"
WriteAttributeValue("", 489, item.JobID, 489, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 565, "\"", 598, 2);
            WriteAttributeValue("", 572, "/Job/UpdateJob/", 572, 15, true);
#nullable restore
#line 24 "C:\Users\SEYFULLAH\Desktop\csharpdemos\AspNet_Project\AspNet_Project\Views\Job\Index.cshtml"
WriteAttributeValue("", 587, item.JobID, 587, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Güncelle</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 669, "\"", 703, 2);
            WriteAttributeValue("", 676, "/Job/DetailsJob/", 676, 16, true);
#nullable restore
#line 25 "C:\Users\SEYFULLAH\Desktop\csharpdemos\AspNet_Project\AspNet_Project\Views\Job\Index.cshtml"
WriteAttributeValue("", 692, item.JobID, 692, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-primary\">Detaylar</a></td>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 28 "C:\Users\SEYFULLAH\Desktop\csharpdemos\AspNet_Project\AspNet_Project\Views\Job\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Job>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
