#pragma checksum "C:\Users\Abubakar Emmanuel\source\repos\Shop\Shop.UI\Pages\Components\Cart\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38f5fc45d6b6c06d5204e28293ba04ba4a62302f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Shop.UI.Pages.Components.Cart.Pages_Components_Cart_Default), @"mvc.1.0.view", @"/Pages/Components/Cart/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Pages/Components/Cart/Default.cshtml", typeof(Shop.UI.Pages.Components.Cart.Pages_Components_Cart_Default))]
namespace Shop.UI.Pages.Components.Cart
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Abubakar Emmanuel\source\repos\Shop\Shop.UI\Pages\_ViewImports.cshtml"
using Shop.UI;

#line default
#line hidden
#line 2 "C:\Users\Abubakar Emmanuel\source\repos\Shop\Shop.UI\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38f5fc45d6b6c06d5204e28293ba04ba4a62302f", @"/Pages/Components/Cart/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29e0c920645c7bc6af12b05eaabdc8fb9fc041bf", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Components_Cart_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Shop.Application.Cart.GetCart.Response>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(70, 44, true);
            WriteLiteral("\r\n\r\n<div>\r\n    <h2>Big Cart Component</h2>\r\n");
            EndContext();
#line 9 "C:\Users\Abubakar Emmanuel\source\repos\Shop\Shop.UI\Pages\Components\Cart\Default.cshtml"
     foreach (var product in Model)
    {

#line default
#line hidden
            BeginContext(158, 11, true);
            WriteLiteral("        <p>");
            EndContext();
            BeginContext(170, 12, false);
#line 11 "C:\Users\Abubakar Emmanuel\source\repos\Shop\Shop.UI\Pages\Components\Cart\Default.cshtml"
      Write(product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(182, 17, true);
            WriteLiteral("</p>\r\n        <p>");
            EndContext();
            BeginContext(200, 13, false);
#line 12 "C:\Users\Abubakar Emmanuel\source\repos\Shop\Shop.UI\Pages\Components\Cart\Default.cshtml"
      Write(product.Value);

#line default
#line hidden
            EndContext();
            BeginContext(213, 17, true);
            WriteLiteral("</p>\r\n        <p>");
            EndContext();
            BeginContext(231, 11, false);
#line 13 "C:\Users\Abubakar Emmanuel\source\repos\Shop\Shop.UI\Pages\Components\Cart\Default.cshtml"
      Write(product.Qty);

#line default
#line hidden
            EndContext();
            BeginContext(242, 17, true);
            WriteLiteral("</p>\r\n        <p>");
            EndContext();
            BeginContext(260, 15, false);
#line 14 "C:\Users\Abubakar Emmanuel\source\repos\Shop\Shop.UI\Pages\Components\Cart\Default.cshtml"
      Write(product.StockId);

#line default
#line hidden
            EndContext();
            BeginContext(275, 22, true);
            WriteLiteral("</p>\r\n        <hr />\r\n");
            EndContext();
#line 16 "C:\Users\Abubakar Emmanuel\source\repos\Shop\Shop.UI\Pages\Components\Cart\Default.cshtml"
    }

#line default
#line hidden
            BeginContext(304, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Shop.Application.Cart.GetCart.Response>> Html { get; private set; }
    }
}
#pragma warning restore 1591
