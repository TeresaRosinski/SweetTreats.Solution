#pragma checksum "/Users/teresarosinski/Desktop/SweetTreats.Solution/SweetTreats/Views/Treats/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a848bc861a08cd92d65d62e9b6318975d546fa7e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Treats_Create), @"mvc.1.0.view", @"/Views/Treats/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Treats/Create.cshtml", typeof(AspNetCore.Views_Treats_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a848bc861a08cd92d65d62e9b6318975d546fa7e", @"/Views/Treats/Create.cshtml")]
    public class Views_Treats_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SweetTreats.Models.Treat>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/teresarosinski/Desktop/SweetTreats.Solution/SweetTreats/Views/Treats/Create.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(60, 27, true);
            WriteLiteral("\n<h4>Add a new treat</h4>\n\n");
            EndContext();
#line 9 "/Users/teresarosinski/Desktop/SweetTreats.Solution/SweetTreats/Views/Treats/Create.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(120, 39, false);
#line 11 "/Users/teresarosinski/Desktop/SweetTreats.Solution/SweetTreats/Views/Treats/Create.cshtml"
Write(Html.LabelFor(model => model.TreatName));

#line default
#line hidden
            EndContext();
            BeginContext(165, 41, false);
#line 12 "/Users/teresarosinski/Desktop/SweetTreats.Solution/SweetTreats/Views/Treats/Create.cshtml"
Write(Html.TextBoxFor(model => model.TreatName));

#line default
#line hidden
            EndContext();
            BeginContext(213, 27, false);
#line 14 "/Users/teresarosinski/Desktop/SweetTreats.Solution/SweetTreats/Views/Treats/Create.cshtml"
Write(Html.Label("Select flavor"));

#line default
#line hidden
            EndContext();
            BeginContext(246, 29, false);
#line 15 "/Users/teresarosinski/Desktop/SweetTreats.Solution/SweetTreats/Views/Treats/Create.cshtml"
Write(Html.DropDownList("FlavorId"));

#line default
#line hidden
            EndContext();
            BeginContext(277, 75, true);
            WriteLiteral("    <input type=\"submit\" class=\"btn btn-primary\" value=\"add new treat\"  />\n");
            EndContext();
#line 18 "/Users/teresarosinski/Desktop/SweetTreats.Solution/SweetTreats/Views/Treats/Create.cshtml"
}

#line default
#line hidden
            BeginContext(354, 3, true);
            WriteLiteral("<p>");
            EndContext();
            BeginContext(358, 43, false);
#line 19 "/Users/teresarosinski/Desktop/SweetTreats.Solution/SweetTreats/Views/Treats/Create.cshtml"
Write(Html.ActionLink("Show all treats", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(401, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SweetTreats.Models.Treat> Html { get; private set; }
    }
}
#pragma warning restore 1591