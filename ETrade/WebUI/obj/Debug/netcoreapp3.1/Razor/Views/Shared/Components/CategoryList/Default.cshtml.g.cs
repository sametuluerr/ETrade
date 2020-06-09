#pragma checksum "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Shared\Components\CategoryList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4433fb20cab7b66531ad5f3b7d9079f3c10d9665"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CategoryList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CategoryList/Default.cshtml")]
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
#line 1 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Shared\Components\CategoryList\Default.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Shared\Components\CategoryList\Default.cshtml"
using Business.Abstract;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Shared\Components\CategoryList\Default.cshtml"
using Business.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Shared\Components\CategoryList\Default.cshtml"
using DataAccess.Concrete.EntityFramework;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4433fb20cab7b66531ad5f3b7d9079f3c10d9665", @"/Views/Shared/Components/CategoryList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43d8308283e147aceb640f85e77cb8c039e61219", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CategoryList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CategoryListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"list-group\">\r\n");
#nullable restore
#line 9 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Shared\Components\CategoryList\Default.cshtml"
     foreach (var category in Model.Categories)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"dropdown\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 333, "\"", 386, 2);
            WriteAttributeValue("", 340, "/Product/Index?categoryId=", 340, 26, true);
#nullable restore
#line 12 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Shared\Components\CategoryList\Default.cshtml"
WriteAttributeValue("", 366, category.CategoryId, 366, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"dropbtn list-group-item list-group-item-action\">");
#nullable restore
#line 12 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Shared\Components\CategoryList\Default.cshtml"
                                                                                                                       Write(category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            <div class=\"dropdown-content\">\r\n");
#nullable restore
#line 14 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Shared\Components\CategoryList\Default.cshtml"
                  
                    var subs = _categoryService.GetSubCategories(@category.CategoryId);
                    if (subs.Success)
                    {
                        foreach (var sub in subs.Data)
                        {
                            if (_categoryService.IsEndCategory(sub.CategoryId))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a");
            BeginWriteAttribute("href", " href=\"", 915, "\"", 963, 2);
            WriteAttributeValue("", 922, "/Product/Index?categoryId=", 922, 26, true);
#nullable restore
#line 22 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Shared\Components\CategoryList\Default.cshtml"
WriteAttributeValue("", 948, sub.CategoryId, 948, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 22 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Shared\Components\CategoryList\Default.cshtml"
                                                                               Write(sub.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 23 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Shared\Components\CategoryList\Default.cshtml"
                            }
                            else
                            {
                                var subsubs = _categoryService.GetSubCategories(sub.CategoryId);

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"dropdown2\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1277, "\"", 1325, 2);
            WriteAttributeValue("", 1284, "/Product/Index?categoryId=", 1284, 26, true);
#nullable restore
#line 28 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Shared\Components\CategoryList\Default.cshtml"
WriteAttributeValue("", 1310, sub.CategoryId, 1310, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 28 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Shared\Components\CategoryList\Default.cshtml"
                                                                                   Write(sub.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <strong>></strong></a>\r\n                                    <div class=\"dropdown-content2\">\r\n");
#nullable restore
#line 30 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Shared\Components\CategoryList\Default.cshtml"
                                         foreach (var subsub in subsubs.Data)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <a");
            BeginWriteAttribute("href", " href=\"", 1606, "\"", 1657, 2);
            WriteAttributeValue("", 1613, "/Product/Index?categoryId=", 1613, 26, true);
#nullable restore
#line 32 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Shared\Components\CategoryList\Default.cshtml"
WriteAttributeValue("", 1639, subsub.CategoryId, 1639, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 32 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Shared\Components\CategoryList\Default.cshtml"
                                                                                              Write(subsub.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 33 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Shared\Components\CategoryList\Default.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 36 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Shared\Components\CategoryList\Default.cshtml"
                            }
                        }
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n");
#nullable restore
#line 42 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Shared\Components\CategoryList\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>

<style>
    /* Dropdown Button */
    .dropbtn {
        /*   background-color: #4CAF50;
        color: white;
        padding: 16px;
        font-size: 16px;
        border: none;*/
    }

    /* The container <div> - needed to position the dropdown content */
    .dropdown {
        position: relative;
        display: inline-block;
    }

    .dropdown2 {
        position: relative;
        display: inline-block;
    }


    /* Dropdown Content (Hidden by Default) */
    .dropdown-content {
        display: none;
        position: absolute;
        left: 90%;
        top: 0;
        background-color: #f1f1f1;
        min-width: 170px;
        box-shadow: 0px 8px 16px 0px rgba(0,0,0,0.2);
        z-index: 1;
    }

    .dropdown-content2 {
        display: none;
        position: absolute;
        left: 95%;
        top: 0;
        background-color: #f1f1f1;
        min-width: 170px;
        box-shadow: 0px 8px 16px 0px rgba(0,0,0,0.2);
        z-index: 2;");
            WriteLiteral(@"
    }

    /* Links inside the dropdown */
    .dropdown-content a {
        color: black;
        padding: 12px 16px;
        text-decoration: none;
        display: block;
    }

    .dropbtn .dropdown-content a {
        color: black;
        padding: 12px 16px;
        text-decoration: none;
        display: block;
    }

    /* Change color of dropdown links on hover */
    .dropdown-content a:hover {
        background-color: #cccccc;
    }

    /* Show the dropdown menu on hover */
    .dropdown:hover .dropdown-content {
        display: block;
    }

    .dropdown2:hover .dropdown-content2 {
        display: block;
    }


    /* Change the background color of the dropdown button when the dropdown content is shown */
    .dropdown:hover .dropbtn {
        background-color: #cccccc;
    }
</style>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ICategoryService _categoryService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CategoryListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
