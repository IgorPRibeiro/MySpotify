#pragma checksum "C:\Users\pinhe\Documents\Csharpzin\MySpotify\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d03b9071952edb5d88371d3d4b453d94503ca89"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\pinhe\Documents\Csharpzin\MySpotify\Views\_ViewImports.cshtml"
using MySpotify;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pinhe\Documents\Csharpzin\MySpotify\Views\_ViewImports.cshtml"
using MySpotify.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d03b9071952edb5d88371d3d4b453d94503ca89", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e383facfc0855a6624f336424137059392de16d6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link text-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Spotify", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "C:\Users\pinhe\Documents\Csharpzin\MySpotify\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""d-flex bd-highlight"">
  <div class=""vertical-nav p-2  p-2 bd-highlight"" id=""sidebar"">
    
    <div class=""logo"">
      <a class=""navbar-brand"" href=""#"" >
        MySpotify
      </a>
    </div>

    <div class=""itens-home"">
      <ul class=""nav flex-column mb-0"">
        <li class=""nav-item"">
          <a href=""#"" class=""nav-link text-light"">
            Inicio
          </a>
        </li>
        <li class=""nav-item"">
          <a href=""#"" class=""nav-link text-light"">
            Buscar
          </a>
        </li>
        <li class=""nav-item"">
          <a href=""#"" class=""nav-link text-light"">
            Suas playlist
          </a>
        </li>
        <li class=""nav-item"">
          ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d03b9071952edb5d88371d3d4b453d94503ca895259", async() => {
                WriteLiteral("Upload");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </li>
      </ul>
    </div>

  </div>

  <div class=""p-2 flex-grow-1 bd-highligh"">
    
    <div class=""d-flex justify-content-center"">
      <div class=""text-center"" id=""titulo"">
        <p>
          <h1>Minhas músicas</h1>
          <div class=""myMusics"">
              <ul class=""list-group"">
");
#nullable restore
#line 48 "C:\Users\pinhe\Documents\Csharpzin\MySpotify\Views\Home\Index.cshtml"
                 foreach(var m in ViewBag.musicas ){

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"list-group-item\">\r\n                    \r\n                  <div>\r\n                    <div class=\"column text-left\">\r\n                      <div");
            BeginWriteAttribute("class", " class=\"", 1434, "\"", 1442, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                          Gênero: ");
#nullable restore
#line 54 "C:\Users\pinhe\Documents\Csharpzin\MySpotify\Views\Home\Index.cshtml"
                             Write(m.Genero);

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n                        </div>\r\n                        <div");
            BeginWriteAttribute("class", " class=\"", 1553, "\"", 1561, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                          Album: ");
#nullable restore
#line 57 "C:\Users\pinhe\Documents\Csharpzin\MySpotify\Views\Home\Index.cshtml"
                            Write(m.Album);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div");
            BeginWriteAttribute("class", " class=\"", 1668, "\"", 1676, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                          Artista: ");
#nullable restore
#line 60 "C:\Users\pinhe\Documents\Csharpzin\MySpotify\Views\Home\Index.cshtml"
                              Write(m.Artista);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div");
            BeginWriteAttribute("class", " class=\"", 1787, "\"", 1795, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                          Titulo: ");
#nullable restore
#line 63 "C:\Users\pinhe\Documents\Csharpzin\MySpotify\Views\Home\Index.cshtml"
                             Write(m.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    </div>

                    <div class=""row d-block text-center"">
                      <div clas=""col-12"">
                        <audio controls autoplay>
      
                            <source");
            BeginWriteAttribute("src", " src= \"", 2102, "\"", 2155, 6);
            WriteAttributeValue("", 2109, "/musicas/Artista/", 2109, 17, true);
#nullable restore
#line 71 "C:\Users\pinhe\Documents\Csharpzin\MySpotify\Views\Home\Index.cshtml"
WriteAttributeValue("", 2126, m.Artista, 2126, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2136, "/", 2136, 1, true);
#nullable restore
#line 71 "C:\Users\pinhe\Documents\Csharpzin\MySpotify\Views\Home\Index.cshtml"
WriteAttributeValue("", 2137, m.Album, 2137, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2145, "/", 2145, 1, true);
#nullable restore
#line 71 "C:\Users\pinhe\Documents\Csharpzin\MySpotify\Views\Home\Index.cshtml"
WriteAttributeValue("", 2146, m.UrlStr, 2146, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"audio/mpeg\">\r\n                                Seu navegador não suporta audio.\r\n                        </audio>\r\n                      </div>\r\n                    </div>\r\n\r\n                  </div>\r\n                </li>\r\n");
#nullable restore
#line 79 "C:\Users\pinhe\Documents\Csharpzin\MySpotify\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("              </ul>\r\n          </div>\r\n          \r\n        </p>\r\n      </div>\r\n    </div>\r\n\r\n  </div>\r\n</div>\r\n\r\n\r\n\r\n");
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
