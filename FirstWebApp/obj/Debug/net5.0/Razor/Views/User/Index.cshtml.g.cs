#pragma checksum "C:\Users\s8gre\source\repos\Grundlagen\FirstWebApp\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28c87b07de5fef087f07e69768f9b61a3a272aa4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28c87b07de5fef087f07e69768f9b61a3a272aa4", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fc1a0b76c8f2efc669dd491635ed73649a67b76", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FirstWebApp.Models.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\s8gre\source\repos\Grundlagen\FirstWebApp\Views\User\Index.cshtml"
  
    ViewData["Title"] = "Index";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>Index</h3>\r\n\r\n<div>\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 21 "C:\Users\s8gre\source\repos\Grundlagen\FirstWebApp\Views\User\Index.cshtml"
     if(Model != null){

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>\r\n            ");
#nullable restore
#line 23 "C:\Users\s8gre\source\repos\Grundlagen\FirstWebApp\Views\User\Index.cshtml"
       Write(Model.UserID);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n            ");
#nullable restore
#line 24 "C:\Users\s8gre\source\repos\Grundlagen\FirstWebApp\Views\User\Index.cshtml"
       Write(Model.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />   \r\n            ");
#nullable restore
#line 25 "C:\Users\s8gre\source\repos\Grundlagen\FirstWebApp\Views\User\Index.cshtml"
       Write(Model.Password);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n        </p>\r\n");
#nullable restore
#line 27 "C:\Users\s8gre\source\repos\Grundlagen\FirstWebApp\Views\User\Index.cshtml"
    } else {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>\r\n            Keine Userdaten vorhanden\r\n        </p>\r\n");
#nullable restore
#line 31 "C:\Users\s8gre\source\repos\Grundlagen\FirstWebApp\Views\User\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    \r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FirstWebApp.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
