#pragma checksum "C:\Users\Admin\OneDrive\Desktop\FPT SUMMER 2022\PRN322\ASM_3w\New folder (4)\Ass03Solution_SE1625_SE150781\eStore\Views\OrderMember\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3191f1f1218c439fc11efa0c563fc5620bae41eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OrderMember_Details), @"mvc.1.0.view", @"/Views/OrderMember/Details.cshtml")]
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
#line 1 "C:\Users\Admin\OneDrive\Desktop\FPT SUMMER 2022\PRN322\ASM_3w\New folder (4)\Ass03Solution_SE1625_SE150781\eStore\Views\_ViewImports.cshtml"
using eStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\OneDrive\Desktop\FPT SUMMER 2022\PRN322\ASM_3w\New folder (4)\Ass03Solution_SE1625_SE150781\eStore\Views\_ViewImports.cshtml"
using eStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3191f1f1218c439fc11efa0c563fc5620bae41eb", @"/Views/OrderMember/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6a7cd37460f953b9787e736e6c4fe42df2fc1ad", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_OrderMember_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BusinessObject.Models.OrderList>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Admin\OneDrive\Desktop\FPT SUMMER 2022\PRN322\ASM_3w\New folder (4)\Ass03Solution_SE1625_SE150781\eStore\Views\OrderMember\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Member</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\Users\Admin\OneDrive\Desktop\FPT SUMMER 2022\PRN322\ASM_3w\New folder (4)\Ass03Solution_SE1625_SE150781\eStore\Views\OrderMember\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OrderId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\Users\Admin\OneDrive\Desktop\FPT SUMMER 2022\PRN322\ASM_3w\New folder (4)\Ass03Solution_SE1625_SE150781\eStore\Views\OrderMember\Details.cshtml"
       Write(Html.DisplayFor(model => model.OrderId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\Users\Admin\OneDrive\Desktop\FPT SUMMER 2022\PRN322\ASM_3w\New folder (4)\Ass03Solution_SE1625_SE150781\eStore\Views\OrderMember\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ProductId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\Users\Admin\OneDrive\Desktop\FPT SUMMER 2022\PRN322\ASM_3w\New folder (4)\Ass03Solution_SE1625_SE150781\eStore\Views\OrderMember\Details.cshtml"
       Write(Html.DisplayFor(model => model.ProductId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\Users\Admin\OneDrive\Desktop\FPT SUMMER 2022\PRN322\ASM_3w\New folder (4)\Ass03Solution_SE1625_SE150781\eStore\Views\OrderMember\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UnitPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\Users\Admin\OneDrive\Desktop\FPT SUMMER 2022\PRN322\ASM_3w\New folder (4)\Ass03Solution_SE1625_SE150781\eStore\Views\OrderMember\Details.cshtml"
       Write(Html.DisplayFor(model => model.UnitPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "C:\Users\Admin\OneDrive\Desktop\FPT SUMMER 2022\PRN322\ASM_3w\New folder (4)\Ass03Solution_SE1625_SE150781\eStore\Views\OrderMember\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "C:\Users\Admin\OneDrive\Desktop\FPT SUMMER 2022\PRN322\ASM_3w\New folder (4)\Ass03Solution_SE1625_SE150781\eStore\Views\OrderMember\Details.cshtml"
       Write(Html.DisplayFor(model => model.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "C:\Users\Admin\OneDrive\Desktop\FPT SUMMER 2022\PRN322\ASM_3w\New folder (4)\Ass03Solution_SE1625_SE150781\eStore\Views\OrderMember\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Discount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "C:\Users\Admin\OneDrive\Desktop\FPT SUMMER 2022\PRN322\ASM_3w\New folder (4)\Ass03Solution_SE1625_SE150781\eStore\Views\OrderMember\Details.cshtml"
       Write(Html.DisplayFor(model => model.Discount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n           <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 46 "C:\Users\Admin\OneDrive\Desktop\FPT SUMMER 2022\PRN322\ASM_3w\New folder (4)\Ass03Solution_SE1625_SE150781\eStore\Views\OrderMember\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MemberId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 49 "C:\Users\Admin\OneDrive\Desktop\FPT SUMMER 2022\PRN322\ASM_3w\New folder (4)\Ass03Solution_SE1625_SE150781\eStore\Views\OrderMember\Details.cshtml"
       Write(Html.DisplayFor(model => model.MemberId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 52 "C:\Users\Admin\OneDrive\Desktop\FPT SUMMER 2022\PRN322\ASM_3w\New folder (4)\Ass03Solution_SE1625_SE150781\eStore\Views\OrderMember\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OrderDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 55 "C:\Users\Admin\OneDrive\Desktop\FPT SUMMER 2022\PRN322\ASM_3w\New folder (4)\Ass03Solution_SE1625_SE150781\eStore\Views\OrderMember\Details.cshtml"
       Write(Html.DisplayFor(model => model.OrderDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 59 "C:\Users\Admin\OneDrive\Desktop\FPT SUMMER 2022\PRN322\ASM_3w\New folder (4)\Ass03Solution_SE1625_SE150781\eStore\Views\OrderMember\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RequiredDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 62 "C:\Users\Admin\OneDrive\Desktop\FPT SUMMER 2022\PRN322\ASM_3w\New folder (4)\Ass03Solution_SE1625_SE150781\eStore\Views\OrderMember\Details.cshtml"
       Write(Html.DisplayFor(model => model.RequiredDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 66 "C:\Users\Admin\OneDrive\Desktop\FPT SUMMER 2022\PRN322\ASM_3w\New folder (4)\Ass03Solution_SE1625_SE150781\eStore\Views\OrderMember\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ShippedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 69 "C:\Users\Admin\OneDrive\Desktop\FPT SUMMER 2022\PRN322\ASM_3w\New folder (4)\Ass03Solution_SE1625_SE150781\eStore\Views\OrderMember\Details.cshtml"
       Write(Html.DisplayFor(model => model.ShippedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n\r\n         <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 74 "C:\Users\Admin\OneDrive\Desktop\FPT SUMMER 2022\PRN322\ASM_3w\New folder (4)\Ass03Solution_SE1625_SE150781\eStore\Views\OrderMember\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Freight));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 77 "C:\Users\Admin\OneDrive\Desktop\FPT SUMMER 2022\PRN322\ASM_3w\New folder (4)\Ass03Solution_SE1625_SE150781\eStore\Views\OrderMember\Details.cshtml"
       Write(Html.DisplayFor(model => model.Freight));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BusinessObject.Models.OrderList> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
