#pragma checksum "C:\Users\SEYFULLAH\Desktop\csharpdemos\AspNet_Project\AspNet_Project\Views\Product\AddProduct.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "db7c8a5e6b7c728644897a0fb88e9c99da222f919719a4e43628ce6e4e313cdc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_AddProduct), @"mvc.1.0.view", @"/Views/Product/AddProduct.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"db7c8a5e6b7c728644897a0fb88e9c99da222f919719a4e43628ce6e4e313cdc", @"/Views/Product/AddProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"966ae505af9897d5bb10573a66e24121f09eb17fa6c65ea5d8c894507371a160", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_AddProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Product>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\SEYFULLAH\Desktop\csharpdemos\AspNet_Project\AspNet_Project\Views\Product\AddProduct.cshtml"
  
    ViewData["Title"] = "AddProduct";
    Layout = "~/Views/Shared/_UILayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db7c8a5e6b7c728644897a0fb88e9c99da222f919719a4e43628ce6e4e313cdc4071", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 8 "C:\Users\SEYFULLAH\Desktop\csharpdemos\AspNet_Project\AspNet_Project\Views\Product\AddProduct.cshtml"
Write(Html.Label("Ürün Adı"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 9 "C:\Users\SEYFULLAH\Desktop\csharpdemos\AspNet_Project\AspNet_Project\Views\Product\AddProduct.cshtml"
Write(Html.TextBoxFor(x => x.Name, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 10 "C:\Users\SEYFULLAH\Desktop\csharpdemos\AspNet_Project\AspNet_Project\Views\Product\AddProduct.cshtml"
Write(Html.ValidationMessageFor(x => x.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <br />\r\n    ");
#nullable restore
#line 12 "C:\Users\SEYFULLAH\Desktop\csharpdemos\AspNet_Project\AspNet_Project\Views\Product\AddProduct.cshtml"
Write(Html.Label("Ürün Fiyatı"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 13 "C:\Users\SEYFULLAH\Desktop\csharpdemos\AspNet_Project\AspNet_Project\Views\Product\AddProduct.cshtml"
Write(Html.TextBoxFor(x => x.Price, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 14 "C:\Users\SEYFULLAH\Desktop\csharpdemos\AspNet_Project\AspNet_Project\Views\Product\AddProduct.cshtml"
Write(Html.ValidationMessageFor(x => x.Price));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <br />\r\n    ");
#nullable restore
#line 16 "C:\Users\SEYFULLAH\Desktop\csharpdemos\AspNet_Project\AspNet_Project\Views\Product\AddProduct.cshtml"
Write(Html.Label("Ürün Stok Sayısı"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 17 "C:\Users\SEYFULLAH\Desktop\csharpdemos\AspNet_Project\AspNet_Project\Views\Product\AddProduct.cshtml"
Write(Html.TextBoxFor(x => x.Name, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 18 "C:\Users\SEYFULLAH\Desktop\csharpdemos\AspNet_Project\AspNet_Project\Views\Product\AddProduct.cshtml"
Write(Html.ValidationMessageFor(x => x.Stock));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <br />\r\n    <button class=\"btn btn-primary\">Ürün Ekle</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Product> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
