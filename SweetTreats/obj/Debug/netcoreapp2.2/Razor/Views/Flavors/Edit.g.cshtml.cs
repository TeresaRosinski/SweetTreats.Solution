#pragma checksum "/Users/teresarosinski/Desktop/SweetTreats.Solution/SweetTreats/Views/Flavors/Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be44fa75ee75ba4967382183caf86d78f9aa5d05"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Flavors_Edit), @"mvc.1.0.view", @"/Views/Flavors/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Flavors/Edit.cshtml", typeof(AspNetCore.Views_Flavors_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be44fa75ee75ba4967382183caf86d78f9aa5d05", @"/Views/Flavors/Edit.cshtml")]
    public class Views_Flavors_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SweetTreats.Models.Flavor>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/teresarosinski/Desktop/SweetTreats.Solution/SweetTreats/Views/Flavors/Edit.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(61, 38, true);
            WriteLiteral("\n<h2>Edit</h2>\n\n<h4>Edit this flavor: ");
            EndContext();
            BeginContext(100, 42, false);
#line 9 "/Users/teresarosinski/Desktop/SweetTreats.Solution/SweetTreats/Views/Flavors/Edit.cshtml"
                 Write(Html.DisplayFor(model => model.FlavorName));

#line default
#line hidden
            EndContext();
            BeginContext(142, 7, true);
            WriteLiteral("</h4>\n\n");
            EndContext();
#line 11 "/Users/teresarosinski/Desktop/SweetTreats.Solution/SweetTreats/Views/Flavors/Edit.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(182, 39, false);
#line 13 "/Users/teresarosinski/Desktop/SweetTreats.Solution/SweetTreats/Views/Flavors/Edit.cshtml"
Write(Html.HiddenFor(model => model.FlavorId));

#line default
#line hidden
            EndContext();
            BeginContext(228, 40, false);
#line 15 "/Users/teresarosinski/Desktop/SweetTreats.Solution/SweetTreats/Views/Flavors/Edit.cshtml"
Write(Html.LabelFor(model => model.FlavorName));

#line default
#line hidden
            EndContext();
            BeginContext(274, 41, false);
#line 16 "/Users/teresarosinski/Desktop/SweetTreats.Solution/SweetTreats/Views/Flavors/Edit.cshtml"
Write(Html.EditorFor(model => model.FlavorName));

#line default
#line hidden
            EndContext();
            BeginContext(322, 26, false);
#line 18 "/Users/teresarosinski/Desktop/SweetTreats.Solution/SweetTreats/Views/Flavors/Edit.cshtml"
Write(Html.Label("Select treat"));

#line default
#line hidden
            EndContext();
            BeginContext(354, 28, false);
#line 19 "/Users/teresarosinski/Desktop/SweetTreats.Solution/SweetTreats/Views/Flavors/Edit.cshtml"
Write(Html.DropDownList("TreatId"));

#line default
#line hidden
            EndContext();
            BeginContext(384, 41, true);
            WriteLiteral("    <input type=\"submit\" value=\"Save\" />\n");
            EndContext();
#line 22 "/Users/teresarosinski/Desktop/SweetTreats.Solution/SweetTreats/Views/Flavors/Edit.cshtml"
}

#line default
#line hidden
            BeginContext(427, 4, true);
            WriteLiteral("\n<p>");
            EndContext();
            BeginContext(432, 43, false);
#line 24 "/Users/teresarosinski/Desktop/SweetTreats.Solution/SweetTreats/Views/Flavors/Edit.cshtml"
Write(Html.ActionLink("Back to flavors", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(475, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SweetTreats.Models.Flavor> Html { get; private set; }
    }
}
#pragma warning restore 1591
