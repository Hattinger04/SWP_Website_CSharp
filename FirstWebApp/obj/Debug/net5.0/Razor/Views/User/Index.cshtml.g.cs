#pragma checksum "C:\Users\s8gre\Documents\Simon\HTL\4BHWII\SWP\C\animewebsite\SWP_Website_CSharp\FirstWebApp\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "741934d9d68d7c9b2e3e52df52970b5509078fef"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"741934d9d68d7c9b2e3e52df52970b5509078fef", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0aab4a04b943c8dcbe6141628e2ec3b7816526d", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<FirstWebApp.Models.User>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
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
                    <td></td>
                    <td></td>
                </tr>
");
#nullable restore
#line 44 "C:\Users\s8gre\Documents\Simon\HTL\4BHWII\SWP\C\animewebsite\SWP_Website_CSharp\FirstWebApp\Views\User\Index.cshtml"
                 foreach (User user in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 46 "C:\Users\s8gre\Documents\Simon\HTL\4BHWII\SWP\C\animewebsite\SWP_Website_CSharp\FirstWebApp\Views\User\Index.cshtml"
               Write(user.UserID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 47 "C:\Users\s8gre\Documents\Simon\HTL\4BHWII\SWP\C\animewebsite\SWP_Website_CSharp\FirstWebApp\Views\User\Index.cshtml"
               Write(user.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 48 "C:\Users\s8gre\Documents\Simon\HTL\4BHWII\SWP\C\animewebsite\SWP_Website_CSharp\FirstWebApp\Views\User\Index.cshtml"
               Write(user.Birthdate.ToLongDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 49 "C:\Users\s8gre\Documents\Simon\HTL\4BHWII\SWP\C\animewebsite\SWP_Website_CSharp\FirstWebApp\Views\User\Index.cshtml"
               Write(user.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 50 "C:\Users\s8gre\Documents\Simon\HTL\4BHWII\SWP\C\animewebsite\SWP_Website_CSharp\FirstWebApp\Views\User\Index.cshtml"
               Write(user.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "741934d9d68d7c9b2e3e52df52970b5509078fef6912", async() => {
                WriteLiteral("\r\n                        <input type=\"submit\" value=\"L??schen\" />\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1266, "/user/delete/", 1266, 13, true);
#nullable restore
#line 52 "C:\Users\s8gre\Documents\Simon\HTL\4BHWII\SWP\C\animewebsite\SWP_Website_CSharp\FirstWebApp\Views\User\Index.cshtml"
AddHtmlAttributeValue("", 1279, user.UserID, 1279, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "741934d9d68d7c9b2e3e52df52970b5509078fef9080", async() => {
                WriteLiteral("\r\n                        <input type=\"submit\" value=\"??ndern\" />\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1481, "/user/update/", 1481, 13, true);
#nullable restore
#line 57 "C:\Users\s8gre\Documents\Simon\HTL\4BHWII\SWP\C\animewebsite\SWP_Website_CSharp\FirstWebApp\Views\User\Index.cshtml"
AddHtmlAttributeValue("", 1494, user.UserID, 1494, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 62 "C:\Users\s8gre\Documents\Simon\HTL\4BHWII\SWP\C\animewebsite\SWP_Website_CSharp\FirstWebApp\Views\User\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n\r\n            <tfoot>\r\n                <tr>\r\n                    <td colspan=\"5\">zur Aufbereitung der User</td>\r\n                </tr>\r\n            </tfoot>\r\n        </table>\r\n");
#nullable restore
#line 71 "C:\Users\s8gre\Documents\Simon\HTL\4BHWII\SWP\C\animewebsite\SWP_Website_CSharp\FirstWebApp\Views\User\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
