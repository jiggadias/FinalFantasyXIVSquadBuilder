#pragma checksum "C:\Users\jigga\source\repos\jiggadias\FinalFantasyXIVSquadBuilder\FinalFantasyXIVSquadBuilder\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0f697f151e4a4dac08931acbaa06ae6e68fb4ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FinalFantasyXIVSquadBuilder.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(FinalFantasyXIVSquadBuilder.Pages.Pages_Index), null)]
namespace FinalFantasyXIVSquadBuilder.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\jigga\source\repos\jiggadias\FinalFantasyXIVSquadBuilder\FinalFantasyXIVSquadBuilder\Pages\_ViewImports.cshtml"
using FinalFantasyXIVSquadBuilder;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0f697f151e4a4dac08931acbaa06ae6e68fb4ee", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebb681a14341fb0d41ffdc305148d8ad05e7abfd", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\jigga\source\repos\jiggadias\FinalFantasyXIVSquadBuilder\FinalFantasyXIVSquadBuilder\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
            BeginContext(71, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Styles", async() => {
                BeginContext(91, 54, true);
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"/css/bundle.css\">\r\n");
                EndContext();
            }
            );
            BeginContext(148, 26, true);
            WriteLiteral("\r\n<div id=\"app\"></div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(193, 45, true);
                WriteLiteral("\r\n    <script src=\"/js/bundle.js\"></script>\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
