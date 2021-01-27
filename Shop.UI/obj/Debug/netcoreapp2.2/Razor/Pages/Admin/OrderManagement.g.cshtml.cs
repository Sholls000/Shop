#pragma checksum "C:\Users\Abubakar Emmanuel\source\repos\Shop\Shop.UI\Pages\Admin\OrderManagement.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8cdec338a0a64e39610c5cb03dd0dc0f12fc66b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Shop.UI.Pages.Admin.Pages_Admin_OrderManagement), @"mvc.1.0.razor-page", @"/Pages/Admin/OrderManagement.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Admin/OrderManagement.cshtml", typeof(Shop.UI.Pages.Admin.Pages_Admin_OrderManagement), null)]
namespace Shop.UI.Pages.Admin
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8cdec338a0a64e39610c5cb03dd0dc0f12fc66b5", @"/Pages/Admin/OrderManagement.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29e0c920645c7bc6af12b05eaabdc8fb9fc041bf", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_OrderManagement : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Admin/orders.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(34, 184, true);
            WriteLiteral("\r\n<div id=\"app\">\r\n    <div v-if=\"selectedOrder === null\">\r\n        <div class=\"tabs is-centered\">\r\n            <ul>\r\n                <li v-bind:class=\"{\'is-active\' : status === 0}\"><a ");
            EndContext();
            BeginContext(219, 105, true);
            WriteLiteral("@click=\"status = 0\">Pending</a></li>\r\n                <li v-bind:class=\"{\'is-active\' : status === 1}\"><a ");
            EndContext();
            BeginContext(325, 104, true);
            WriteLiteral("@click=\"status = 1\">Packed</a></li>\r\n                <li v-bind:class=\"{\'is-active\' : status === 2}\"><a ");
            EndContext();
            BeginContext(430, 173, true);
            WriteLiteral("@click=\"status = 2\">Shipped</a></li>\r\n            </ul>\r\n        </div>\r\n        <div v-if=\"orders.length > 0\">\r\n            <p v-for=\"order in orders\">\r\n                <a ");
            EndContext();
            BeginContext(604, 174, true);
            WriteLiteral("@click=\"selectOrder(order.id)\">{{order.orderRef}} - {{order.email}}</a>\r\n            </p>\r\n\r\n        </div>\r\n\r\n    </div>\r\n    <div v-else>\r\n        <p>\r\n            <button ");
            EndContext();
            BeginContext(779, 180, true);
            WriteLiteral("@click=\"exitOrder()\">Exit</button>\r\n        </p>\r\n        <p class=\"title\">{{selectedOrder.orderRef}}</p>\r\n        <p class=\"subtitle\">{{selectedOrder.email}}</p>\r\n        <button ");
            EndContext();
            BeginContext(960, 63, true);
            WriteLiteral("@click=\"updateOrder()\">Process</button>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(1040, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1046, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8cdec338a0a64e39610c5cb03dd0dc0f12fc66b55537", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1090, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrdersModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OrdersModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OrdersModel>)PageContext?.ViewData;
        public OrdersModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
