#pragma checksum "C:\Users\george.chkhaidze\source\repos\Homework 2\Week14\Views\Home\Booking.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "ea98b34e2b4211c3d2b5a8515921e927cf6260e7cf5cced858aa2ac10c68b9a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Booking), @"mvc.1.0.view", @"/Views/Home/Booking.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\george.chkhaidze\source\repos\Homework 2\Week14\Views\_ViewImports.cshtml"
using Week14;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\george.chkhaidze\source\repos\Homework 2\Week14\Views\_ViewImports.cshtml"
using Week14.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"ea98b34e2b4211c3d2b5a8515921e927cf6260e7cf5cced858aa2ac10c68b9a1", @"/Views/Home/Booking.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"6b788b0269f77ad6a70ff3b7b62c3c1820e69c9fa1df157c9215250a744081ac", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Booking : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Week14.Models.BookingModel>
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\george.chkhaidze\source\repos\Homework 2\Week14\Views\Home\Booking.cshtml"
  
    ViewData["Title"] = "Booking Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea98b34e2b4211c3d2b5a8515921e927cf6260e7cf5cced858aa2ac10c68b9a13693", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Index</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea98b34e2b4211c3d2b5a8515921e927cf6260e7cf5cced858aa2ac10c68b9a14776", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 15 "C:\Users\george.chkhaidze\source\repos\Homework 2\Week14\Views\Home\Booking.cshtml"
     using (Html.BeginForm("Index", "Home", FormMethod.Post))
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <table cellpadding=\"0\" cellspacing=\"0\">\r\n            <tr>\r\n                <th colspan=\"2\" align=\"center\">Person Details</th>\r\n            </tr>\r\n            <tr>\r\n                <td>First Name: </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 24 "C:\Users\george.chkhaidze\source\repos\Homework 2\Week14\Views\Home\Booking.cshtml"
               Write(Html.TextBoxFor(m => m.FirstName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td>Last Name: </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 30 "C:\Users\george.chkhaidze\source\repos\Homework 2\Week14\Views\Home\Booking.cshtml"
               Write(Html.TextBoxFor(m => m.LastName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n            </tr>\r\n           <tr>\r\n                <td>Doctor: </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 36 "C:\Users\george.chkhaidze\source\repos\Homework 2\Week14\Views\Home\Booking.cshtml"
               Write(Html.DropDownListFor(m => m.Doctor, new List<SelectListItem>
                { new SelectListItem{Text="Dentist", Value="D"},
                new SelectListItem{Text="Pediatrician", Value="P"},
                new SelectListItem{Text="Cardiologist", Value="C"}}, "Please select"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
                WriteLiteral("            <tr>\r\n                <td>Date: </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 51 "C:\Users\george.chkhaidze\source\repos\Homework 2\Week14\Views\Home\Booking.cshtml"
               Write(Html.EditorFor(m => m.Time, new { htmlAttributes = new { type = "date" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n            <tr>\r\n                <td>Time: </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 56 "C:\Users\george.chkhaidze\source\repos\Homework 2\Week14\Views\Home\Booking.cshtml"
               Write(Html.EditorFor(m => m.Time, new { htmlAttributes = new { type = "time" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            </tr>\r\n            <tr>\r\n                <td></td>\r\n                <td><input type=\"submit\" value=\"Submit\" /></td>\r\n            </tr>\r\n        </table>\r\n");
#nullable restore
#line 65 "C:\Users\george.chkhaidze\source\repos\Homework 2\Week14\Views\Home\Booking.cshtml"
    }

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Week14.Models.BookingModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591