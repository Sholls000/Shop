#pragma checksum "C:\Users\Abubakar Emmanuel\source\repos\Shop\Shop.UI\Pages\Order.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44fca580e5913c08209f3113063edb6172a22cf2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Shop.UI.Pages.Pages_Order), @"mvc.1.0.razor-page", @"/Pages/Order.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Order.cshtml", typeof(Shop.UI.Pages.Pages_Order), @"{reference}")]
namespace Shop.UI.Pages
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{reference}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44fca580e5913c08209f3113063edb6172a22cf2", @"/Pages/Order.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29e0c920645c7bc6af12b05eaabdc8fb9fc041bf", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Order : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(62, 27, true);
            WriteLiteral("\r\n<div>\r\n    <h1>\r\n        ");
            EndContext();
            BeginContext(90, 20, false);
#line 8 "C:\Users\Abubakar Emmanuel\source\repos\Shop\Shop.UI\Pages\Order.cshtml"
   Write(Model.Order.OrderRef);

#line default
#line hidden
            EndContext();
            BeginContext(110, 15, true);
            WriteLiteral("\r\n    </h1>\r\n\r\n");
            EndContext();
#line 11 "C:\Users\Abubakar Emmanuel\source\repos\Shop\Shop.UI\Pages\Order.cshtml"
     foreach (var product in Model.Order.Products)
    {

#line default
#line hidden
            BeginContext(184, 27, true);
            WriteLiteral("        <div>\r\n            ");
            EndContext();
            BeginContext(212, 12, false);
#line 14 "C:\Users\Abubakar Emmanuel\source\repos\Shop\Shop.UI\Pages\Order.cshtml"
       Write(product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(224, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(228, 19, false);
#line 14 "C:\Users\Abubakar Emmanuel\source\repos\Shop\Shop.UI\Pages\Order.cshtml"
                       Write(product.Description);

#line default
#line hidden
            EndContext();
            BeginContext(247, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(251, 11, false);
#line 14 "C:\Users\Abubakar Emmanuel\source\repos\Shop\Shop.UI\Pages\Order.cshtml"
                                              Write(product.Qty);

#line default
#line hidden
            EndContext();
            BeginContext(262, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(266, 13, false);
#line 14 "C:\Users\Abubakar Emmanuel\source\repos\Shop\Shop.UI\Pages\Order.cshtml"
                                                             Write(product.Value);

#line default
#line hidden
            EndContext();
            BeginContext(279, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
#line 16 "C:\Users\Abubakar Emmanuel\source\repos\Shop\Shop.UI\Pages\Order.cshtml"
    }

#line default
#line hidden
            BeginContext(304, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Shop.UI.Pages.OrderModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Shop.UI.Pages.OrderModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Shop.UI.Pages.OrderModel>)PageContext?.ViewData;
        public Shop.UI.Pages.OrderModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
