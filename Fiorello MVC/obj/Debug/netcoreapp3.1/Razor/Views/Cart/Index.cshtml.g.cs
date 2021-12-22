#pragma checksum "C:\laragon\www\Fiorello MVC\Fiorello MVC\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d003239e0f16464f46f2ab3edbc69d7d07e37a39"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
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
#nullable restore
#line 1 "C:\laragon\www\Fiorello MVC\Fiorello MVC\Views\_ViewImports.cshtml"
using Fiorello_MVC.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\laragon\www\Fiorello MVC\Fiorello MVC\Views\_ViewImports.cshtml"
using Fiorello_MVC.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\laragon\www\Fiorello MVC\Fiorello MVC\Views\_ViewImports.cshtml"
using Fiorello_MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d003239e0f16464f46f2ab3edbc69d7d07e37a39", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a59b34639ff12454ea3ef4c1fac742507356b829", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CartProductViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_PageHeaderPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\laragon\www\Fiorello MVC\Fiorello MVC\Views\Cart\Index.cshtml"
  
    ViewData["Title"] = "Cart";
    ViewData["SectionTitle"] = ViewData["Title"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d003239e0f16464f46f2ab3edbc69d7d07e37a393809", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 8 "C:\laragon\www\Fiorello MVC\Fiorello MVC\Views\Cart\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.ViewData = ViewData;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("view-data", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.ViewData, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"


<div class=""container"">
    <table class=""table my-5 border shadow-sm"">
        <thead>
            <tr>
                <th scope=""col"" class=""text-uppercase text-center border-top-0"">Product</th>
                <th scope=""col"" class=""text-uppercase text-center border-top-0"">Price</th>
                <th scope=""col"" class=""text-uppercase text-center border-top-0"">Quantity</th>
                <th scope=""col"" class=""text-uppercase text-center border-top-0"">Total</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 22 "C:\laragon\www\Fiorello MVC\Fiorello MVC\Views\Cart\Index.cshtml"
             if (Model.Count < 1)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td colspan=\"4\" class=\"text-center\">\r\n                        No products in the cart.\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 29 "C:\laragon\www\Fiorello MVC\Fiorello MVC\Views\Cart\Index.cshtml"
            }
            else
            {
                foreach (var product in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"shopping-cart-item\">\r\n                        <td class=\"p-3 align-middle shopping-cart-item-details\" data-product-id=\"");
#nullable restore
#line 35 "C:\laragon\www\Fiorello MVC\Fiorello MVC\Views\Cart\Index.cshtml"
                                                                                            Write(product.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
                            <div class=""d-flex align-items-center"">
                                <a href=""#"" class=""cart-remove"">
                                    <i class=""fas fa-times text-danger""></i>
                                </a>
                                <div class=""product-image mx-4"">
                                    <img width=""80""");
            BeginWriteAttribute("src", " src=\"", 1608, "\"", 1640, 2);
            WriteAttributeValue("", 1614, "/assets/img/", 1614, 12, true);
#nullable restore
#line 41 "C:\laragon\www\Fiorello MVC\Fiorello MVC\Views\Cart\Index.cshtml"
WriteAttributeValue("", 1626, product.Image, 1626, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1641, "\"", 1660, 1);
#nullable restore
#line 41 "C:\laragon\www\Fiorello MVC\Fiorello MVC\Views\Cart\Index.cshtml"
WriteAttributeValue("", 1647, product.Name, 1647, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                </div>\r\n                                <a href=\"#\">");
#nullable restore
#line 43 "C:\laragon\www\Fiorello MVC\Fiorello MVC\Views\Cart\Index.cshtml"
                                       Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            </div>\r\n                        </td>\r\n                        <td class=\"p-3 align-middle text-center\">\r\n                            <span class=\"price\">$");
#nullable restore
#line 47 "C:\laragon\www\Fiorello MVC\Fiorello MVC\Views\Cart\Index.cshtml"
                                            Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> \r\n                        </td>\r\n                        <td class=\"p-3 align-middle text-center\">");
#nullable restore
#line 49 "C:\laragon\www\Fiorello MVC\Fiorello MVC\Views\Cart\Index.cshtml"
                                                            Write(product.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"p-3 align-middle text-center\">");
#nullable restore
#line 50 "C:\laragon\www\Fiorello MVC\Fiorello MVC\Views\Cart\Index.cshtml"
                                                             Write(product.Quantity * product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 52 "C:\laragon\www\Fiorello MVC\Fiorello MVC\Views\Cart\Index.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CartProductViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
