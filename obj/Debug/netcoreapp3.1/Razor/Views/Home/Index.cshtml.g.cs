#pragma checksum "C:\Users\dimko\source\repos\CurencyParcer\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "825bc3797529836b0e7137aed340413cac7eef14"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\dimko\source\repos\CurencyParcer\Views\_ViewImports.cshtml"
using CurencyParcer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dimko\source\repos\CurencyParcer\Views\_ViewImports.cshtml"
using CurencyParcer.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"825bc3797529836b0e7137aed340413cac7eef14", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d619b8d8e27faa066b8f211fb676fbaff0fb747", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CurencyConverter>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\dimko\source\repos\CurencyParcer\Views\Home\Index.cshtml"
   
    decimal priceUAH = 1000;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    ");
#nullable restore
#line 6 "C:\Users\dimko\source\repos\CurencyParcer\Views\Home\Index.cshtml"
Write($"Курс американского доллара: {Model.USD}. Цена в американских долларах: {Decimal.Round(Model.convertToUSD(priceUAH),2)}");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n<div>\r\n    ");
#nullable restore
#line 10 "C:\Users\dimko\source\repos\CurencyParcer\Views\Home\Index.cshtml"
Write($"Курс евро: {Model.EUR}. Цена в евро: {Decimal.Round(Model.convertToEUR(priceUAH),2)}");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n<div>\r\n    ");
#nullable restore
#line 14 "C:\Users\dimko\source\repos\CurencyParcer\Views\Home\Index.cshtml"
Write($"Курс австралийского доллара: {Model.AUD}. Цена в австралийских долларах: {Decimal.Round(Model.convertToAUD(priceUAH),2)}");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n<div>\r\n    ");
#nullable restore
#line 18 "C:\Users\dimko\source\repos\CurencyParcer\Views\Home\Index.cshtml"
Write($"Курс китайского юаня: {Model.CNY}. Цена в китайских юанях: {Decimal.Round(Model.convertToCNY(priceUAH),2)}");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n<div>\r\n    ");
#nullable restore
#line 22 "C:\Users\dimko\source\repos\CurencyParcer\Views\Home\Index.cshtml"
Write($"Курс шведской кроны: {Model.SEK}. Цена в шведских кронах: {Decimal.Round(Model.convertToSEK(priceUAH),2)}");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CurencyConverter> Html { get; private set; }
    }
}
#pragma warning restore 1591
