#pragma checksum "C:\Users\s8gre\Documents\Simon\HTL\4BHWII\SWP\C\animewebsite\SWP_Website_CSharp\FirstWebApp\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3541a2860fd9b3d10946781c24139f5c4362e81"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3541a2860fd9b3d10946781c24139f5c4362e81", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0aab4a04b943c8dcbe6141628e2ec3b7816526d", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<FirstWebApp.Models.User>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\s8gre\Documents\Simon\HTL\4BHWII\SWP\C\animewebsite\SWP_Website_CSharp\FirstWebApp\Views\User\Index.cshtml"
  
    ViewData["Title"] = "Index";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>Index</h3>\r\n\r\n<div>\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 21 "C:\Users\s8gre\Documents\Simon\HTL\4BHWII\SWP\C\animewebsite\SWP_Website_CSharp\FirstWebApp\Views\User\Index.cshtml"
     if (Model == null || Model.Count < 1) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>\r\n            Keine Userdaten vorhanden\r\n        </p>\r\n");
#nullable restore
#line 25 "C:\Users\s8gre\Documents\Simon\HTL\4BHWII\SWP\C\animewebsite\SWP_Website_CSharp\FirstWebApp\Views\User\Index.cshtml"

    } else {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table>
            <thead>
                <tr>
                    <td colspan=""5"">User</td>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>UserID</td>
                    <td>Username</td>
                    <td>Birthdate</td>
                    <td>Email</td>
                    <td>Gender</td>
                </tr>
");
#nullable restore
#line 42 "C:\Users\s8gre\Documents\Simon\HTL\4BHWII\SWP\C\animewebsite\SWP_Website_CSharp\FirstWebApp\Views\User\Index.cshtml"
                 foreach (User user in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 44 "C:\Users\s8gre\Documents\Simon\HTL\4BHWII\SWP\C\animewebsite\SWP_Website_CSharp\FirstWebApp\Views\User\Index.cshtml"
                       Write(user.UserID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 45 "C:\Users\s8gre\Documents\Simon\HTL\4BHWII\SWP\C\animewebsite\SWP_Website_CSharp\FirstWebApp\Views\User\Index.cshtml"
                       Write(user.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 46 "C:\Users\s8gre\Documents\Simon\HTL\4BHWII\SWP\C\animewebsite\SWP_Website_CSharp\FirstWebApp\Views\User\Index.cshtml"
                       Write(user.Birthdate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 47 "C:\Users\s8gre\Documents\Simon\HTL\4BHWII\SWP\C\animewebsite\SWP_Website_CSharp\FirstWebApp\Views\User\Index.cshtml"
                       Write(user.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 48 "C:\Users\s8gre\Documents\Simon\HTL\4BHWII\SWP\C\animewebsite\SWP_Website_CSharp\FirstWebApp\Views\User\Index.cshtml"
                       Write(user.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 50 "C:\Users\s8gre\Documents\Simon\HTL\4BHWII\SWP\C\animewebsite\SWP_Website_CSharp\FirstWebApp\Views\User\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n\r\n            <tfoot>\r\n                <tr>\r\n                    <td colspan=\"5\">zur Aufbereitung der User</td>\r\n                </tr>\r\n            </tfoot>\r\n        </table>\r\n");
#nullable restore
#line 59 "C:\Users\s8gre\Documents\Simon\HTL\4BHWII\SWP\C\animewebsite\SWP_Website_CSharp\FirstWebApp\Views\User\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<FirstWebApp.Models.User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
