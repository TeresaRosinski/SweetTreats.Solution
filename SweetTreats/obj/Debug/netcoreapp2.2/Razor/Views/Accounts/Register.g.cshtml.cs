#pragma checksum "/Users/teresarosinski/Desktop/SweetTreats.Solution/SweetTreats/Views/Accounts/Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8dad082697b0636ee190a488848140bd03c53f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Accounts_Register), @"mvc.1.0.view", @"/Views/Accounts/Register.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Accounts/Register.cshtml", typeof(AspNetCore.Views_Accounts_Register))]
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
#line 5 "/Users/teresarosinski/Desktop/SweetTreats.Solution/SweetTreats/Views/Accounts/Register.cshtml"
using SweetTreats.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8dad082697b0636ee190a488848140bd03c53f3", @"/Views/Accounts/Register.cshtml")]
    public class Views_Accounts_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RegisterViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/teresarosinski/Desktop/SweetTreats.Solution/SweetTreats/Views/Accounts/Register.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(58, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(84, 37, true);
            WriteLiteral("\n<h2>Register a new user</h2>\n<hr />\n");
            EndContext();
#line 11 "/Users/teresarosinski/Desktop/SweetTreats.Solution/SweetTreats/Views/Accounts/Register.cshtml"
 using (Html.BeginForm("Register", "Account", FormMethod.Post))
{
    

#line default
#line hidden
            BeginContext(192, 33, false);
#line 13 "/Users/teresarosinski/Desktop/SweetTreats.Solution/SweetTreats/Views/Accounts/Register.cshtml"
Write(Html.LabelFor(user => user.Email));

#line default
#line hidden
            EndContext();
            BeginContext(231, 34, false);
#line 14 "/Users/teresarosinski/Desktop/SweetTreats.Solution/SweetTreats/Views/Accounts/Register.cshtml"
Write(Html.TextBoxFor(user=> user.Email));

#line default
#line hidden
            EndContext();
            BeginContext(272, 35, false);
#line 16 "/Users/teresarosinski/Desktop/SweetTreats.Solution/SweetTreats/Views/Accounts/Register.cshtml"
Write(Html.LabelFor(user=> user.Password));

#line default
#line hidden
            EndContext();
            BeginContext(313, 38, false);
#line 17 "/Users/teresarosinski/Desktop/SweetTreats.Solution/SweetTreats/Views/Accounts/Register.cshtml"
Write(Html.PasswordFor(user=> user.Password));

#line default
#line hidden
            EndContext();
            BeginContext(358, 42, false);
#line 19 "/Users/teresarosinski/Desktop/SweetTreats.Solution/SweetTreats/Views/Accounts/Register.cshtml"
Write(Html.LabelFor(user=> user.ConfirmPassword));

#line default
#line hidden
            EndContext();
            BeginContext(406, 45, false);
#line 20 "/Users/teresarosinski/Desktop/SweetTreats.Solution/SweetTreats/Views/Accounts/Register.cshtml"
Write(Html.PasswordFor(user=> user.ConfirmPassword));

#line default
#line hidden
            EndContext();
            BeginContext(453, 45, true);
            WriteLiteral("    <input type=\"submit\" value=\"Register\" />\n");
            EndContext();
#line 23 "/Users/teresarosinski/Desktop/SweetTreats.Solution/SweetTreats/Views/Accounts/Register.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegisterViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
