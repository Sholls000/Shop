#pragma checksum "C:\Users\Abubakar Emmanuel\source\repos\Shop\Shop.UI\Pages\Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dcd97c00d429c2a5193a7c7cf7519c2f2da27762"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Shop.UI.Pages.Pages_Cart), @"mvc.1.0.razor-page", @"/Pages/Cart.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Cart.cshtml", typeof(Shop.UI.Pages.Pages_Cart), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dcd97c00d429c2a5193a7c7cf7519c2f2da27762", @"/Pages/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29e0c920645c7bc6af12b05eaabdc8fb9fc041bf", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Cart : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
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
        private global::Shop.UI.Pages.Pages_Cart.__Generated__CartViewComponentTagHelper __CartViewComponentTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 11, true);
            WriteLiteral("\r\n\r\n<div>\r\n");
            EndContext();
#line 8 "C:\Users\Abubakar Emmanuel\source\repos\Shop\Shop.UI\Pages\Cart.cshtml"
     foreach (var product in Model.Cart)
    { 

#line default
#line hidden
            BeginContext(107, 7, true);
            WriteLiteral("    <p>");
            EndContext();
            BeginContext(115, 12, false);
#line 10 "C:\Users\Abubakar Emmanuel\source\repos\Shop\Shop.UI\Pages\Cart.cshtml"
  Write(product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(127, 13, true);
            WriteLiteral("</p>\r\n    <p>");
            EndContext();
            BeginContext(141, 13, false);
#line 11 "C:\Users\Abubakar Emmanuel\source\repos\Shop\Shop.UI\Pages\Cart.cshtml"
  Write(product.Value);

#line default
#line hidden
            EndContext();
            BeginContext(154, 13, true);
            WriteLiteral("</p>\r\n    <p>");
            EndContext();
            BeginContext(168, 11, false);
#line 12 "C:\Users\Abubakar Emmanuel\source\repos\Shop\Shop.UI\Pages\Cart.cshtml"
  Write(product.Qty);

#line default
#line hidden
            EndContext();
            BeginContext(179, 13, true);
            WriteLiteral("</p>\r\n    <p>");
            EndContext();
            BeginContext(193, 15, false);
#line 13 "C:\Users\Abubakar Emmanuel\source\repos\Shop\Shop.UI\Pages\Cart.cshtml"
  Write(product.StockId);

#line default
#line hidden
            EndContext();
            BeginContext(208, 17, true);
            WriteLiteral("</p>\r\n    <hr/>\r\n");
            EndContext();
#line 15 "C:\Users\Abubakar Emmanuel\source\repos\Shop\Shop.UI\Pages\Cart.cshtml"
    }

#line default
#line hidden
            BeginContext(232, 12, true);
            WriteLiteral("</div>\r\n\r\n\r\n");
            EndContext();
            BeginContext(244, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:cart", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dcd97c00d429c2a5193a7c7cf7519c2f2da277624967", async() => {
            }
            );
            __CartViewComponentTagHelper = CreateTagHelper<global::Shop.UI.Pages.Pages_Cart.__Generated__CartViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__CartViewComponentTagHelper);
            BeginWriteTagHelperAttribute();
            WriteLiteral("Small");
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __CartViewComponentTagHelper.view = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("view", __CartViewComponentTagHelper.view, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Shop.UI.Pages.CartModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Shop.UI.Pages.CartModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Shop.UI.Pages.CartModel>)PageContext?.ViewData;
        public Shop.UI.Pages.CartModel Model => ViewData.Model;
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("vc:cart")]
        public class __Generated__CartViewComponentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
        {
            private readonly global::Microsoft.AspNetCore.Mvc.IViewComponentHelper _helper = null;
            public __Generated__CartViewComponentTagHelper(global::Microsoft.AspNetCore.Mvc.IViewComponentHelper helper)
            {
                _helper = helper;
            }
            [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute, global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
            public global::Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get; set; }
            public System.String view { get; set; }
            public override async global::System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput output)
            {
                (_helper as global::Microsoft.AspNetCore.Mvc.ViewFeatures.IViewContextAware)?.Contextualize(ViewContext);
                var content = await _helper.InvokeAsync("Cart", new { view });
                output.TagName = null;
                output.Content.SetHtmlContent(content);
            }
        }
    }
}
#pragma warning restore 1591
