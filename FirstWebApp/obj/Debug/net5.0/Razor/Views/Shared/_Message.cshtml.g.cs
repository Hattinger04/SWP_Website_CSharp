#pragma checksum "C:\Users\s8gre\Documents\Simon\HTL\4BHWII\SWP\C\animewebsite\SWP_Website_CSharp\FirstWebApp\Views\Shared\_Message.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "510ae95cafa045e335fc6f5993762e49d4d25b17"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Message), @"mvc.1.0.view", @"/Views/Shared/_Message.cshtml")]
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
#line 1 "C:\Users\s8gre\Documents\Simon\HTL\4BHWII\SWP\C\animewebsite\SWP_Website_CSharp\FirstWebApp\Views\_ViewImports.cshtml"
using FirstWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\s8gre\Documents\Simon\HTL\4BHWII\SWP\C\animewebsite\SWP_Website_CSharp\FirstWebApp\Views\_ViewImports.cshtml"
using FirstWebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"510ae95cafa045e335fc6f5993762e49d4d25b17", @"/Views/Shared/_Message.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0aab4a04b943c8dcbe6141628e2ec3b7816526d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Message : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FirstWebApp.Models.Message>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h3>");
#nullable restore
#line 3 "C:\Users\s8gre\Documents\Simon\HTL\4BHWII\SWP\C\animewebsite\SWP_Website_CSharp\FirstWebApp\Views\Shared\_Message.cshtml"
Write(Model.Header);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<p>\r\n    <b>Meldung</b>\r\n    ");
#nullable restore
#line 6 "C:\Users\s8gre\Documents\Simon\HTL\4BHWII\SWP\C\animewebsite\SWP_Website_CSharp\FirstWebApp\Views\Shared\_Message.cshtml"
Write(Model.MessageText);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\s8gre\Documents\Simon\HTL\4BHWII\SWP\C\animewebsite\SWP_Website_CSharp\FirstWebApp\Views\Shared\_Message.cshtml"
 if (Model.Solution != null && Model.Solution.Trim().Length >= 1)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        <b>Lösung</b>\r\n        ");
#nullable restore
#line 13 "C:\Users\s8gre\Documents\Simon\HTL\4BHWII\SWP\C\animewebsite\SWP_Website_CSharp\FirstWebApp\Views\Shared\_Message.cshtml"
   Write(Model.Solution);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n");
#nullable restore
#line 15 "C:\Users\s8gre\Documents\Simon\HTL\4BHWII\SWP\C\animewebsite\SWP_Website_CSharp\FirstWebApp\Views\Shared\_Message.cshtml"

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FirstWebApp.Models.Message> Html { get; private set; }
    }
}
#pragma warning restore 1591