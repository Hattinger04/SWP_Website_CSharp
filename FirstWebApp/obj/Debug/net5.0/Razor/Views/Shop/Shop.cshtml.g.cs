#pragma checksum "C:\Users\s8gre\source\repos\Grundlagen\FirstWebApp\Views\Shop\Shop.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d24587dd49728c142b9b020561942fcc7db886b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_Shop), @"mvc.1.0.view", @"/Views/Shop/Shop.cshtml")]
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
#line 1 "C:\Users\s8gre\source\repos\Grundlagen\FirstWebApp\Views\_ViewImports.cshtml"
using FirstWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\s8gre\source\repos\Grundlagen\FirstWebApp\Views\_ViewImports.cshtml"
using FirstWebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d24587dd49728c142b9b020561942fcc7db886b3", @"/Views/Shop/Shop.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0aab4a04b943c8dcbe6141628e2ec3b7816526d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_Shop : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<FirstWebApp.Models.Article>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\s8gre\source\repos\Grundlagen\FirstWebApp\Views\Shop\Shop.cshtml"
  
    ViewData["Title"] = "Shop";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Shop</h1>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\s8gre\source\repos\Grundlagen\FirstWebApp\Views\Shop\Shop.cshtml"
 if (Model != null && Model.Count >= 1)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table>
        <thead>
            <tr>
                <td>Artikelnummer</td>
                <td>Artikelname</td>
                <td>Hersteller</td>
                <td>Erscheinungsdatum</td>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 21 "C:\Users\s8gre\source\repos\Grundlagen\FirstWebApp\Views\Shop\Shop.cshtml"
             foreach (Article a in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 24 "C:\Users\s8gre\source\repos\Grundlagen\FirstWebApp\Views\Shop\Shop.cshtml"
                   Write(a.ArticleID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 25 "C:\Users\s8gre\source\repos\Grundlagen\FirstWebApp\Views\Shop\Shop.cshtml"
                   Write(a.ArticleName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 26 "C:\Users\s8gre\source\repos\Grundlagen\FirstWebApp\Views\Shop\Shop.cshtml"
                   Write(a.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 27 "C:\Users\s8gre\source\repos\Grundlagen\FirstWebApp\Views\Shop\Shop.cshtml"
                   Write(a.ReleaseDate.ToLongDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 29 "C:\Users\s8gre\source\repos\Grundlagen\FirstWebApp\Views\Shop\Shop.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n        <tfoot>\r\n            <tr>\r\n                <td colspan=\"4\">Unser Shopsortiment</td>\r\n            </tr>\r\n        </tfoot>\r\n    </table>\r\n");
#nullable restore
#line 37 "C:\Users\s8gre\source\repos\Grundlagen\FirstWebApp\Views\Shop\Shop.cshtml"
} else {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        keine Artikel vorhanden\r\n    </p>\r\n");
#nullable restore
#line 41 "C:\Users\s8gre\source\repos\Grundlagen\FirstWebApp\Views\Shop\Shop.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<FirstWebApp.Models.Article>> Html { get; private set; }
    }
}
#pragma warning restore 1591
