#pragma checksum "C:\Users\nikol\OneDrive\Documents\GitHub\interdisciplinary\TournamentWeb\Views\PopUps\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dda2f5d74957691acfb941f9d642c6650be3bef8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PopUps_Error), @"mvc.1.0.view", @"/Views/PopUps/Error.cshtml")]
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
#line 1 "C:\Users\nikol\OneDrive\Documents\GitHub\interdisciplinary\TournamentWeb\Views\_ViewImports.cshtml"
using TournamentWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nikol\OneDrive\Documents\GitHub\interdisciplinary\TournamentWeb\Views\_ViewImports.cshtml"
using TournamentWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dda2f5d74957691acfb941f9d642c6650be3bef8", @"/Views/PopUps/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8cbd7db290a5ed2a2e70301dadeeaf346ef9804", @"/Views/_ViewImports.cshtml")]
    public class Views_PopUps_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"PopupBox\">\r\n    <p id=\"ErrorMsg\" data-error=\"");
#nullable restore
#line 3 "C:\Users\nikol\OneDrive\Documents\GitHub\interdisciplinary\TournamentWeb\Views\PopUps\Error.cshtml"
                            Write(TempData["ErrorMsg"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""></p>
</div>

<style>
    .PopupBox {
        height: 300px;
        width: 700px;
        border-radius: 24px;
        background: white;
        position: absolute;
        transform: translate(-50%, -50%);
        left: 50%;
        top: 50%;
    }
</style>

<script>
    let errorModel = new Object();
    errorModel.PlayerIsInTournament = ""You are allready part of a team in this tournament"";
    if ($('#ErrorMsg').length) {
        $(""#ErrorMsg"").ready(function () {
            console.log(errorModel[$(""#ErrorMsg"").data(""error"")], errorModel[""AddPlayer""])
            $(""#ErrorMsg"").html(errorModel[$(""#ErrorMsg"").data(""error"")]);
        })
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
