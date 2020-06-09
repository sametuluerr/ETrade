#pragma checksum "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Order\GetByEmail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98677d68995128902e67fec20cb97fd8046a0e16"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_GetByEmail), @"mvc.1.0.view", @"/Views/Order/GetByEmail.cshtml")]
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
#line 1 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\_ViewImports.cshtml"
using WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\_ViewImports.cshtml"
using WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Order\GetByEmail.cshtml"
using Business.Constants;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98677d68995128902e67fec20cb97fd8046a0e16", @"/Views/Order/GetByEmail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43d8308283e147aceb640f85e77cb8c039e61219", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_GetByEmail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrderListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "OrderDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Order\GetByEmail.cshtml"
  
    Layout = "_ManageAccount";
    ViewBag.Title = "Siparişlerim";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Siparişlerim</h2>\r\n\r\n");
#nullable restore
#line 11 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Order\GetByEmail.cshtml"
 if (Model.Orders == null)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Order\GetByEmail.cshtml"
     if (TempData[TempDataTypes.ThereIsNoOrder] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span class=\"text-danger\">");
#nullable restore
#line 15 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Order\GetByEmail.cshtml"
                             Write(TempData[TempDataTypes.ThereIsNoOrder].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 16 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Order\GetByEmail.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Order\GetByEmail.cshtml"
     
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table table-responsive"">
        <thead class=""thead-dark"">
            <tr>
                <th>Sipariş Numarası</th>
                <th>Sipariş Tarihi</th>
                <th>Kargo Takip Numarası</th>
                <th>Kargoya Veriliş Tarihi</th>
                <th>Teslim Durumu</th>
                <th>Sipariş Tutarı</th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 33 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Order\GetByEmail.cshtml"
             foreach (var order in Model.Orders)
            {
                var css = "";
                if (order.Delivered)
                {
                    css = "table-success";
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr");
            BeginWriteAttribute("class", " class=\"", 1042, "\"", 1054, 1);
#nullable restore
#line 40 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Order\GetByEmail.cshtml"
WriteAttributeValue("", 1050, css, 1050, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <td>");
#nullable restore
#line 41 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Order\GetByEmail.cshtml"
                   Write(order.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 42 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Order\GetByEmail.cshtml"
                   Write(order.OrderDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 43 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Order\GetByEmail.cshtml"
                   Write(order.TrackingNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 44 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Order\GetByEmail.cshtml"
                   Write(order.ShippedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 45 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Order\GetByEmail.cshtml"
                         if (order.Delivered)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            WriteLiteral("Teslim Edildi\r\n");
#nullable restore
#line 48 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Order\GetByEmail.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            WriteLiteral("Teslim Edilmedi\r\n");
#nullable restore
#line 52 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Order\GetByEmail.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td>₺");
#nullable restore
#line 54 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Order\GetByEmail.cshtml"
                    Write(order.Price.ToString("#.##"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98677d68995128902e67fec20cb97fd8046a0e169085", async() => {
                WriteLiteral("Detay");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-orderId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 55 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Order\GetByEmail.cshtml"
                                                                                                               WriteLiteral(order.OrderId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["orderId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-orderId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["orderId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 57 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Order\GetByEmail.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 60 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Order\GetByEmail.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrderListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
