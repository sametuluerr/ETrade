#pragma checksum "C:\Users\samet\Documents\GitHub\ETrade\ETrade\WebUI\Views\Cart\Completed.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1aa776195d29fa62d9057ef5485528035921841"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Completed), @"mvc.1.0.view", @"/Views/Cart/Completed.cshtml")]
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
#line 1 "C:\Users\samet\Documents\GitHub\ETrade\ETrade\WebUI\Views\_ViewImports.cshtml"
using WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\samet\Documents\GitHub\ETrade\ETrade\WebUI\Views\_ViewImports.cshtml"
using WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\samet\Documents\GitHub\ETrade\ETrade\WebUI\Views\Cart\Completed.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1aa776195d29fa62d9057ef5485528035921841", @"/Views/Cart/Completed.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43d8308283e147aceb640f85e77cb8c039e61219", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Completed : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\samet\Documents\GitHub\ETrade\ETrade\WebUI\Views\Cart\Completed.cshtml"
  
    Layout = "_ManageAccount";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h1>Siparişiniz Tamamlandı.</h1>\r\n<a class =\"btn btn-outline-info\"");
            BeginWriteAttribute("href", " href=\"", 140, "\"", 238, 2);
            WriteAttributeValue("", 147, "/Order/GetByEmail?email=", 147, 24, true);
#nullable restore
#line 8 "C:\Users\samet\Documents\GitHub\ETrade\ETrade\WebUI\Views\Cart\Completed.cshtml"
WriteAttributeValue("", 171, User.Claims.SingleOrDefault(c => c.Type == ClaimTypes.Email).Value, 171, 67, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Siparişlerimi Listele</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
