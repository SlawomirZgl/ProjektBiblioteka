#pragma checksum "C:\Users\Dawid\Desktop\szkolka\PK\ProjektBiblioteka\ProjektBiblioteka\ProjektBiblioteka\Views\Ksiazka\Ksiazki.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f7f8ad141b693f1d27026b76a926235bd3bb4f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ksiazka_Ksiazki), @"mvc.1.0.view", @"/Views/Ksiazka/Ksiazki.cshtml")]
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
#line 1 "C:\Users\Dawid\Desktop\szkolka\PK\ProjektBiblioteka\ProjektBiblioteka\ProjektBiblioteka\Views\_ViewImports.cshtml"
using ProjektBiblioteka;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dawid\Desktop\szkolka\PK\ProjektBiblioteka\ProjektBiblioteka\ProjektBiblioteka\Views\_ViewImports.cshtml"
using ProjektBiblioteka.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f7f8ad141b693f1d27026b76a926235bd3bb4f6", @"/Views/Ksiazka/Ksiazki.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59111b66a5640ba2e0b15e00b42ec48a54646b34", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Ksiazka_Ksiazki : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProjektBiblioteka.Models.Ksiazka>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Dawid\Desktop\szkolka\PK\ProjektBiblioteka\ProjektBiblioteka\ProjektBiblioteka\Views\Ksiazka\Ksiazki.cshtml"
  
    ViewData["Title"] = "Ksiazki";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Ksiazki</h1>
<style>
    a:link { color: black; text-decoration: none; }

    a:visited { color: black; text-decoration: none; }

    a:hover { color: black; text-decoration: none; }

    a:active { color: black; text-decoration: none; }
</style>

<div class=""row"">
");
#nullable restore
#line 19 "C:\Users\Dawid\Desktop\szkolka\PK\ProjektBiblioteka\ProjektBiblioteka\ProjektBiblioteka\Views\Ksiazka\Ksiazki.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f7f8ad141b693f1d27026b76a926235bd3bb4f64408", async() => {
                WriteLiteral(@"
        <div class=""col-sm card"" style=""width: 18rem; background-color:rgba(105, 240, 174, 0.8); border-width:thick"">
          <img class=""card-img-top"" src=""https://i.imgur.com/UIg7vKK.jpg"" alt=""Card image cap"">
          <div class=""card-body"">
            <h5 class=""card-title""> ");
#nullable restore
#line 24 "C:\Users\Dawid\Desktop\szkolka\PK\ProjektBiblioteka\ProjektBiblioteka\ProjektBiblioteka\Views\Ksiazka\Ksiazki.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Nazwa));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n            <p class=\"card-text\">");
#nullable restore
#line 25 "C:\Users\Dawid\Desktop\szkolka\PK\ProjektBiblioteka\ProjektBiblioteka\ProjektBiblioteka\Views\Ksiazka\Ksiazki.cshtml"
                            Write(Html.DisplayFor(modelItem => item.Ocena));

#line default
#line hidden
#nullable disable
                WriteLiteral(@" / 10
                <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-star-fill"" viewBox=""0 0 16 16"">
                  <path d=""M3.612 15.443c-.386.198-.824-.149-.746-.592l.83-4.73L.173 6.765c-.329-.314-.158-.888.283-.95l4.898-.696L7.538.792c.197-.39.73-.39.927 0l2.184 4.327 4.898.696c.441.062.612.636.282.95l-3.522 3.356.83 4.73c.078.443-.36.79-.746.592L8 13.187l-4.389 2.256z""/>
                </svg>
                <br>
                ");
#nullable restore
#line 30 "C:\Users\Dawid\Desktop\szkolka\PK\ProjektBiblioteka\ProjektBiblioteka\ProjektBiblioteka\Views\Ksiazka\Ksiazki.cshtml"
           Write(Html.DisplayFor(modelItem => item.Ilosc));

#line default
#line hidden
#nullable disable
                WriteLiteral("szt.\r\n            </p>\r\n          </div>\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 20 "C:\Users\Dawid\Desktop\szkolka\PK\ProjektBiblioteka\ProjektBiblioteka\ProjektBiblioteka\Views\Ksiazka\Ksiazki.cshtml"
                              WriteLiteral(item.KsiazkaID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("            \r\n");
#nullable restore
#line 35 "C:\Users\Dawid\Desktop\szkolka\PK\ProjektBiblioteka\ProjektBiblioteka\ProjektBiblioteka\Views\Ksiazka\Ksiazki.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProjektBiblioteka.Models.Ksiazka>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
