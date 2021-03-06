#pragma checksum "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Order\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "488da99bf8d0e06fefe87906c8186e31fa504529"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Index), @"mvc.1.0.view", @"/Views/Order/Index.cshtml")]
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
#line 1 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Order\Index.cshtml"
using Business.Constants;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"488da99bf8d0e06fefe87906c8186e31fa504529", @"/Views/Order/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43d8308283e147aceb640f85e77cb8c039e61219", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrderIndexViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Order\Index.cshtml"
  
    Layout = "_AdminLayout";
    ViewBag.Title = "Teslimatlar";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Teslimatlar</h1>\r\n");
#nullable restore
#line 9 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Order\Index.cshtml"
 if (TempData[TempDataTypes.OrderDelivered] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success\">");
#nullable restore
#line 11 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Order\Index.cshtml"
                                Write(TempData[TempDataTypes.OrderDelivered].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 12 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Order\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js""></script>
<script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.min.js""></script>
<input class=""form-control"" id=""search"" type=""text"" placeholder=""Ara.."">
<script>
    $(document).ready(function(){
        $(""#search"").on(""keyup"", function() {
            var value = $(this).val().toLowerCase();
            $(""#fields tr"").filter(function() {
                $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
            });
        });
    });
</script>
<table class=""table table-hover table-striped table-sm"">
    <thead class=""thead-dark"">
        <tr>
            <th><center>Sipariş Numarası</center></th>
            <th><center>Sipariş Tarihi</center></th>
            <th><center>Müşteri Numarası</center></th>
            <th><center>Teslim Durumu</center></th>
            <th><c");
            WriteLiteral("enter>Takip Numarası</center></th>\r\n");
#nullable restore
#line 35 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Order\Index.cshtml"
              
                var link = "/Order/Index?ship=true";
                var text = "Teslim Edilmeyenleri Göster";

                if (Model.Control == true)
                {
                    link = "/Order/Index";
                    text = "Tümünü Göster";
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <th style=\"width: 200px;\"><center><a");
            BeginWriteAttribute("href", " href=\"", 1721, "\"", 1733, 1);
#nullable restore
#line 44 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Order\Index.cshtml"
WriteAttributeValue("", 1728, link, 1728, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success btn-sm\">");
#nullable restore
#line 44 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Order\Index.cshtml"
                                                                                            Write(text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></center></th>\r\n");
            WriteLiteral("        </tr>\r\n    </thead>\r\n    <tbody id=\"fields\">\r\n\r\n");
#nullable restore
#line 50 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Order\Index.cshtml"
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
            WriteLiteral("            <tr");
            BeginWriteAttribute("class", " class=\"", 2065, "\"", 2077, 1);
#nullable restore
#line 57 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Order\Index.cshtml"
WriteAttributeValue("", 2073, css, 2073, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <td><center>");
#nullable restore
#line 58 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Order\Index.cshtml"
                       Write(order.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</center></td>\r\n                <td><center>");
#nullable restore
#line 59 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Order\Index.cshtml"
                       Write(order.OrderDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</center></td>\r\n                <td><center>");
#nullable restore
#line 60 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Order\Index.cshtml"
                       Write(order.CustomerId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</center></td>\r\n\r\n");
#nullable restore
#line 62 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Order\Index.cshtml"
                  
                    var deliver = "Teslim Edilmedi";

                    if (order.Delivered)
                    {
                        deliver = "Teslim Edildi";
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td><center>");
#nullable restore
#line 69 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Order\Index.cshtml"
                           Write(deliver);

#line default
#line hidden
#nullable disable
            WriteLiteral("</center></td>\r\n");
            WriteLiteral("                <td><center>");
#nullable restore
#line 71 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Order\Index.cshtml"
                       Write(order.TrackingNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</center></td>\r\n");
#nullable restore
#line 72 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Order\Index.cshtml"
                 if (!order.Delivered)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td><center><a");
            BeginWriteAttribute("href", " href=\"", 2711, "\"", 2755, 2);
            WriteAttributeValue("", 2718, "/Order/Deliver?orderId=", 2718, 23, true);
#nullable restore
#line 74 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Order\Index.cshtml"
WriteAttributeValue("", 2741, order.OrderId, 2741, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success btn-sm\">Teslim Et</a></center></td>\r\n");
#nullable restore
#line 75 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Order\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td class=\"text-dark\"><center>Teslim Edildi</center></td>\r\n");
#nullable restore
#line 79 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Order\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\r\n");
#nullable restore
#line 81 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Order\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrderIndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
