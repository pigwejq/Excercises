#pragma checksum "C:\Users\szych\source\repos\pigwejq\Excercises\Serwis\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "567e819c0312b9a50f9603140ab47f9bcaeed678"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\szych\source\repos\pigwejq\Excercises\Serwis\Views\_ViewImports.cshtml"
using Serwis.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"567e819c0312b9a50f9603140ab47f9bcaeed678", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55344a2e22a5a4361c6416c52c6e4cbb07a4db62", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 8, true);
            WriteLiteral("\r\n<ul>\r\n");
            EndContext();
#line 4 "C:\Users\szych\source\repos\pigwejq\Excercises\Serwis\Views\Home\Index.cshtml"
     foreach (Product p in Model)
    {

#line default
#line hidden
            BeginContext(80, 12, true);
            WriteLiteral("        <h2>");
            EndContext();
            BeginContext(93, 6, false);
#line 6 "C:\Users\szych\source\repos\pigwejq\Excercises\Serwis\Views\Home\Index.cshtml"
       Write(p.Name);

#line default
#line hidden
            EndContext();
            BeginContext(99, 38, true);
            WriteLiteral("</h2>\r\n        <p>\r\n            Cena: ");
            EndContext();
            BeginContext(139, 15, false);
#line 8 "C:\Users\szych\source\repos\pigwejq\Excercises\Serwis\Views\Home\Index.cshtml"
              Write($"{p.Price:C2}");

#line default
#line hidden
            EndContext();
            BeginContext(155, 30, true);
            WriteLiteral("<br/>\r\n            Kategoria: ");
            EndContext();
            BeginContext(186, 10, false);
#line 9 "C:\Users\szych\source\repos\pigwejq\Excercises\Serwis\Views\Home\Index.cshtml"
                  Write(p.Category);

#line default
#line hidden
            EndContext();
            BeginContext(196, 25, true);
            WriteLiteral("<br/>\r\n            Opis: ");
            EndContext();
            BeginContext(222, 13, false);
#line 10 "C:\Users\szych\source\repos\pigwejq\Excercises\Serwis\Views\Home\Index.cshtml"
             Write(p.Description);

#line default
#line hidden
            EndContext();
            BeginContext(235, 27, true);
            WriteLiteral("<br/>\r\n            Stan: \r\n");
            EndContext();
#line 12 "C:\Users\szych\source\repos\pigwejq\Excercises\Serwis\Views\Home\Index.cshtml"
             if(ViewBag.StockLevel > 0)
            {

#line default
#line hidden
            BeginContext(318, 36, true);
            WriteLiteral("                <b>W magazynie</b>\r\n");
            EndContext();
#line 15 "C:\Users\szych\source\repos\pigwejq\Excercises\Serwis\Views\Home\Index.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(402, 29, true);
            WriteLiteral("                <b>Brak</b>\r\n");
            EndContext();
#line 19 "C:\Users\szych\source\repos\pigwejq\Excercises\Serwis\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(446, 14, true);
            WriteLiteral("        </p>\r\n");
            EndContext();
#line 21 "C:\Users\szych\source\repos\pigwejq\Excercises\Serwis\Views\Home\Index.cshtml"

    }

#line default
#line hidden
            BeginContext(469, 9, true);
            WriteLiteral("</ul>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
