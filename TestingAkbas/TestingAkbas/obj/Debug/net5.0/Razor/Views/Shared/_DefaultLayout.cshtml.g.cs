#pragma checksum "C:\Users\hp\source\repos\TestingAkbas2\TestingAkbas\TestingAkbas\Views\Shared\_DefaultLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0b34edac02a17625bda4a980d869cc3e0e041dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__DefaultLayout), @"mvc.1.0.view", @"/Views/Shared/_DefaultLayout.cshtml")]
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
#line 1 "C:\Users\hp\source\repos\TestingAkbas2\TestingAkbas\TestingAkbas\Views\_ViewImports.cshtml"
using TestingAkbas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hp\source\repos\TestingAkbas2\TestingAkbas\TestingAkbas\Views\_ViewImports.cshtml"
using TestingAkbas.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0b34edac02a17625bda4a980d869cc3e0e041dd", @"/Views/Shared/_DefaultLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8166deb52fe4bcac3690b2461d128444deaf1f7", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__DefaultLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0b34edac02a17625bda4a980d869cc3e0e041dd3334", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"" />
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0-beta3/css/all.min.css"" />
    <style>
        body {
            margin: 0;
            padding: 0;
            font-family: Arial, sans-serif;
        }

        .main-content {
            padding: 20px;
            margin-left: 80px; /* Sidebar genişliğine göre içerik alanını kaydırın */
        }

        .sidebar {
            position: fixed;
            top: 0;
            left: 0; /* Sidebar solda kalacak şekilde konumlandırıldı */
            height: 100%;
            width: 50px; /* Sidebar genişliği */
            background-color: #f8f9fa;
            border-right: 1px solid #dee2e6;
            display: flex;
            flex-direction: column;
            align-items: center;
            padding: 20px 0; /* Üst ve alt padding */
            box-sizing: border-box;
        }

        .button-container ");
                WriteLiteral(@"{
            display: flex;
            flex-direction: column;
            justify-content: center; /* Butonları ortada hizalama */
            height: calc(100% - 40px); /* Üst ve alt paddingleri çıkarma */
            width: 100%;
            align-items: center; /* Butonları yatayda ortalama */
            gap: 80px; /* Butonlar arasındaki boşluk */
        }

        .sidebar button {
            width: 40px; /* Buton genişliği */
            height: 40px; /* Buton yüksekliği */
            text-align: center;
            line-height: 40px; /* Metnin dikey ortalanması */
            border: 2px solid #000; /* Siyah renkte sınır */
            background-color: transparent; /* Arka planı şeffaf yapma */
            color: #000; /* Metin rengi siyah */
            border-radius: 4px; /* Kare butonlar */
            cursor: pointer;
            transition: background-color 0.3s, color 0.3s; /* Renk geçişi */
        }

            .sidebar button:hover {
                background-color: #000; /* Hover efe");
                WriteLiteral(@"kti arka plan rengi siyah */
                color: #fff; /* Hover efekti metin rengi beyaz */
            }

        .offcanvas {
            position: fixed;
            top: 0;
            left: 50px; /* Sidebar genişliği */
            width: 200px;
            height: 100vh; /* Tam ekran yüksekliği */
            background-color: #fff;
            border-left: 1px solid #dee2e6;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            transform: translateX(-100%); /* Başlangıçta gizli */
            transition: transform 0.3s ease, opacity 0.3s ease; /* Geçiş efekti */
            z-index: 1050; /* Menülerin butonlardan üstte olması için */
            opacity: 0; /* Başlangıçta şeffaf */
            display: none; /* Başlangıçta gizli */
        }

            .offcanvas.show {
                transform: translateX(0); /* Menü görünür yap */
                opacity: 1; /* Menü görünür yap */
                display: block; /* Menü görünür yap */
            }

        .offcanvas-header {
      ");
                WriteLiteral(@"      padding: 10px;
            border-bottom: 1px solid #dee2e6;
        }

        .offcanvas-body {
            padding: 20px;
        }

        .offcanvas-close {
            background: none;
            border: none;
            font-size: 1.25rem;
            cursor: pointer;
        }
    </style>
");
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
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0b34edac02a17625bda4a980d869cc3e0e041dd7794", async() => {
                WriteLiteral(@"
    <div class=""sidebar"">
        <div class=""button-container"">
            <button type=""button"" onclick=""toggleOffcanvas('offcanvas1')""><i class=""fas fa-user""></i></button> <!-- Kafa iconu -->
            <button type=""button"" onclick=""toggleOffcanvas('offcanvas2')""><i class=""fas fa-industry""></i></button> <!-- Fabrika iconu -->
            <button type=""button"" onclick=""toggleOffcanvas('offcanvas3')""><i class=""fas fa-cog""></i></button> <!-- Ayarlar iconu -->
            <button type=""button"" onclick=""toggleOffcanvas('offcanvas4')""><i class=""fas fa-question""></i></button> <!-- Soru işareti iconu -->
            <button type=""button"" onclick=""toggleOffcanvas('offcanvas5')""><i class=""fas fa-sign-out-alt""></i></button> <!-- Çıkış iconu -->
        </div>
    </div>
    <div id=""mainContent"" class=""main-content"">
        ");
#nullable restore
#line 112 "C:\Users\hp\source\repos\TestingAkbas2\TestingAkbas\TestingAkbas\Views\Shared\_DefaultLayout.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    </div>

    <!-- Offcanvas Menüler -->
    <div class=""offcanvas"" id=""offcanvas1"">
        <div class=""offcanvas-header"">
            <h5>Offcanvas 1</h5>
            <button type=""button"" class=""offcanvas-close"" onclick=""toggleOffcanvas('offcanvas1')"">&times;</button>
        </div>
        <div class=""offcanvas-body"">
            İçerik 1
        </div>
    </div>

    <div class=""offcanvas"" id=""offcanvas2"">
        <div class=""offcanvas-header"">
            <h5>Offcanvas 2</h5>
            <button type=""button"" class=""offcanvas-close"" onclick=""toggleOffcanvas('offcanvas2')"">&times;</button>
        </div>
        <div class=""offcanvas-body"">
            İçerik 2
        </div>
    </div>

    <div class=""offcanvas"" id=""offcanvas3"">
        <div class=""offcanvas-header"">
            <h5>Offcanvas 3</h5>
            <button type=""button"" class=""offcanvas-close"" onclick=""toggleOffcanvas('offcanvas3')"">&times;</button>
        </div>
        <div class=""offcanvas-body"">
            İçerik 3
        </div>");
                WriteLiteral(@"
    </div>

    <div class=""offcanvas"" id=""offcanvas4"">
        <div class=""offcanvas-header"">
            <h5>Offcanvas 4</h5>
            <button type=""button"" class=""offcanvas-close"" onclick=""toggleOffcanvas('offcanvas4')"">&times;</button>
        </div>
        <div class=""offcanvas-body"">
            İçerik 4
        </div>
    </div>

    <div class=""offcanvas"" id=""offcanvas5"">
        <div class=""offcanvas-header"">
            <h5>Offcanvas 5</h5>
            <button type=""button"" class=""offcanvas-close"" onclick=""toggleOffcanvas('offcanvas5')"">&times;</button>
        </div>
        <div class=""offcanvas-body"">
            İçerik 5
        </div>
    </div>

    <script>
        function toggleOffcanvas(id) {
            const offcanvas = document.getElementById(id);
            const allOffcanvases = document.querySelectorAll('.offcanvas');
            allOffcanvases.forEach(el => {
                if (el !== offcanvas) {
                    el.classList.remove('show');
                }
            ");
                WriteLiteral("});\n            if (offcanvas.classList.contains(\'show\')) {\n                offcanvas.classList.remove(\'show\');\n            } else {\n                offcanvas.classList.add(\'show\');\n            }\n        }\n    </script>\n");
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
            WriteLiteral("\n</html>");
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
