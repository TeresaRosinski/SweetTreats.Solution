#pragma checksum "/Users/teresarosinski/Desktop/SweetTreats.Solution/SweetTreats/Views/Treats/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7035ba3c5ae4939302742722a6fd071a9fe3d191"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Treats_Index), @"mvc.1.0.view", @"/Views/Treats/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Treats/Index.cshtml", typeof(AspNetCore.Views_Treats_Index))]
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
#line 5 "/Users/teresarosinski/Desktop/SweetTreats.Solution/SweetTreats/Views/Treats/Index.cshtml"
using SweetTreats.Models;

#line default
#line hidden
#line 6 "/Users/teresarosinski/Desktop/SweetTreats.Solution/SweetTreats/Views/Treats/Index.cshtml"
using System.Security.Claims;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7035ba3c5ae4939302742722a6fd071a9fe3d191", @"/Views/Treats/Index.cshtml")]
    public class Views_Treats_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SweetTreats.Models.Treat>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/teresarosinski/Desktop/SweetTreats.Solution/SweetTreats/Views/Treats/Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(130, 16, true);
            WriteLiteral("\n<h1>Treats for ");
            EndContext();
            BeginContext(147, 18, false);
#line 9 "/Users/teresarosinski/Desktop/SweetTreats.Solution/SweetTreats/Views/Treats/Index.cshtml"
          Write(User.Identity.Name);

#line default
#line hidden
            EndContext();
            BeginContext(165, 7, true);
            WriteLiteral("</h1>\n\n");
            EndContext();
#line 11 "/Users/teresarosinski/Desktop/SweetTreats.Solution/SweetTreats/Views/Treats/Index.cshtml"
 if (Model.Any())
{

#line default
#line hidden
            BeginContext(192, 7, true);
            WriteLiteral("  <ul>\n");
            EndContext();
#line 14 "/Users/teresarosinski/Desktop/SweetTreats.Solution/SweetTreats/Views/Treats/Index.cshtml"
     foreach (Treat treat in Model)
    {

#line default
#line hidden
            BeginContext(241, 10, true);
            WriteLiteral("      <li>");
            EndContext();
            BeginContext(252, 76, false);
#line 16 "/Users/teresarosinski/Desktop/SweetTreats.Solution/SweetTreats/Views/Treats/Index.cshtml"
     Write(Html.ActionLink($"{treat.TreatName}", "Details", new { id = treat.TreatId }));

#line default
#line hidden
            EndContext();
            BeginContext(328, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 17 "/Users/teresarosinski/Desktop/SweetTreats.Solution/SweetTreats/Views/Treats/Index.cshtml"
    }

#line default
#line hidden
            BeginContext(340, 8, true);
            WriteLiteral("  </ul>\n");
            EndContext();
#line 19 "/Users/teresarosinski/Desktop/SweetTreats.Solution/SweetTreats/Views/Treats/Index.cshtml"
} 
else
{

#line default
#line hidden
            BeginContext(358, 41, true);
            WriteLiteral("  <h3>No treat have been added yet!</h3>\n");
            EndContext();
#line 23 "/Users/teresarosinski/Desktop/SweetTreats.Solution/SweetTreats/Views/Treats/Index.cshtml"
}

#line default
#line hidden
            BeginContext(401, 4, true);
            WriteLiteral("\n<p>");
            EndContext();
            BeginContext(406, 42, false);
#line 25 "/Users/teresarosinski/Desktop/SweetTreats.Solution/SweetTreats/Views/Treats/Index.cshtml"
Write(Html.ActionLink("Add new treat", "Create"));

#line default
#line hidden
            EndContext();
            BeginContext(448, 9, true);
            WriteLiteral("</p>\n\n<p>");
            EndContext();
            BeginContext(458, 40, false);
#line 27 "/Users/teresarosinski/Desktop/SweetTreats.Solution/SweetTreats/Views/Treats/Index.cshtml"
Write(Html.ActionLink("Home", "Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(498, 4, true);
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SweetTreats.Models.Treat>> Html { get; private set; }
    }
}
#pragma warning restore 1591
