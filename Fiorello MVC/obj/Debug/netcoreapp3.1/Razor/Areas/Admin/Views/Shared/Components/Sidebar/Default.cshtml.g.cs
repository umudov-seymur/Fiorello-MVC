#pragma checksum "C:\laragon\www\Fiorello MVC\Fiorello MVC\Areas\Admin\Views\Shared\Components\Sidebar\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7ee45259193e2b3ba1822a5d120af72709b2515"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared_Components_Sidebar_Default), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/Components/Sidebar/Default.cshtml")]
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
#line 1 "C:\laragon\www\Fiorello MVC\Fiorello MVC\Areas\Admin\Views\_ViewImports.cshtml"
using Fiorello_MVC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\laragon\www\Fiorello MVC\Fiorello MVC\Areas\Admin\Views\_ViewImports.cshtml"
using Fiorello_MVC.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\laragon\www\Fiorello MVC\Fiorello MVC\Areas\Admin\Views\_ViewImports.cshtml"
using Fiorello_MVC.Areas.Admin.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\laragon\www\Fiorello MVC\Fiorello MVC\Areas\Admin\Views\Shared\Components\Sidebar\Default.cshtml"
using Microsoft.AspNetCore.Routing;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7ee45259193e2b3ba1822a5d120af72709b2515", @"/Areas/Admin/Views/Shared/Components/Sidebar/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a19d334c4cd856de4d9bf1eecbf4a1fa9af993df", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared_Components_Sidebar_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MenuViewModel>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\laragon\www\Fiorello MVC\Fiorello MVC\Areas\Admin\Views\Shared\Components\Sidebar\Default.cshtml"
  
    var currentController = ViewContext.RouteData.Values["controller"].ToString();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Sidebar Menu -->\r\n<nav class=\"mt-2\">\r\n    <ul class=\"nav nav-pills nav-sidebar flex-column\" data-widget=\"treeview\" role=\"menu\" data-accordion=\"false\">\r\n");
#nullable restore
#line 11 "C:\laragon\www\Fiorello MVC\Fiorello MVC\Areas\Admin\Views\Shared\Components\Sidebar\Default.cshtml"
         foreach (var menu in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"nav-item\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7ee45259193e2b3ba1822a5d120af72709b25154480", async() => {
                WriteLiteral("\r\n                    <i");
                BeginWriteAttribute("class", " class=\"", 627, "\"", 657, 2);
                WriteAttributeValue("", 635, "navnav-icon", 635, 11, true);
#nullable restore
#line 17 "C:\laragon\www\Fiorello MVC\Fiorello MVC\Areas\Admin\Views\Shared\Components\Sidebar\Default.cshtml"
WriteAttributeValue(" ", 646, menu.Icon, 647, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></i>\r\n                    <p>\r\n                        ");
#nullable restore
#line 19 "C:\laragon\www\Fiorello MVC\Fiorello MVC\Areas\Admin\Views\Shared\Components\Sidebar\Default.cshtml"
                   Write(menu.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </p>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 14 "C:\laragon\www\Fiorello MVC\Fiorello MVC\Areas\Admin\Views\Shared\Components\Sidebar\Default.cshtml"
                       WriteLiteral(menu.Controller);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-controller", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 15 "C:\laragon\www\Fiorello MVC\Fiorello MVC\Areas\Admin\Views\Shared\Components\Sidebar\Default.cshtml"
                   WriteLiteral(menu.Action);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-action", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 527, "nav-link", 527, 8, true);
#nullable restore
#line 16 "C:\laragon\www\Fiorello MVC\Fiorello MVC\Areas\Admin\Views\Shared\Components\Sidebar\Default.cshtml"
AddHtmlAttributeValue(" ", 535, currentController == menu.Controller ? "active" : String.Empty, 536, 65, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </li>\r\n");
#nullable restore
#line 23 "C:\laragon\www\Fiorello MVC\Fiorello MVC\Areas\Admin\Views\Shared\Components\Sidebar\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n</nav>\r\n<!-- /.sidebar-menu -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<MenuViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
