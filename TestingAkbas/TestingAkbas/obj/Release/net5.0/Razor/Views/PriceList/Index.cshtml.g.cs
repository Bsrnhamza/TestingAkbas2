#pragma checksum "C:\Users\hp\source\repos\TestingAkbas2\TestingAkbas\TestingAkbas\Views\PriceList\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e965d50277a3a2abf5a0d2009df539004e3cf7a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PriceList_Index), @"mvc.1.0.view", @"/Views/PriceList/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e965d50277a3a2abf5a0d2009df539004e3cf7a", @"/Views/PriceList/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8166deb52fe4bcac3690b2461d128444deaf1f7", @"/Views/_ViewImports.cshtml")]
    public class Views_PriceList_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/akbasFont.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("table-image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Pesin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "30gün", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "60gün", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "90gün", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e965d50277a3a2abf5a0d2009df539004e3cf7a5482", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0-beta3/css/all.min.css"">
    <title>Proforma Maliyet</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            font-size: 11px;
            margin: 0;
            padding: 0;
        }

        .container {
            width: 100%;
            margin: auto;
            padding: 20px;
            position: relative;
        }

        table {
            width: calc(100% - 120px);
            border-collapse: collapse;
            margin-top: 10px;
            font-size: 15px;
            position: relative;
        }

        th, td {
            padding: 4px;
            text-align: center;
        }

        th {
            background-color: #f2f2f2;
        }

        .left-align {
            text-align: left;
        }

        .right-align {
            text-align: right;
        ");
                WriteLiteral(@"}

        .center-align {
            text-align: center;
        }

        .summary {
            font-weight: bold;
        }

        .note {
            margin-top: 10px;
            font-size: 0.9em;
        }

        .pricing {
            font-size: 1em;
            margin-top: 10px;
            display: flex;
            justify-content: space-between;
        }

            .pricing div {
                width: 48%;
            }

            .pricing p {
                margin: 2px 0;
            }

        .checkbox {
            display: flex;
            align-items: center;
            margin-top: 5px;
        }

        .footer {
            margin-top: 20px;
            text-align: right;
        }

        .info-box {
            margin-bottom: 20px;
        }

        .details {
            position: absolute;
            bottom: 20px;
            right: 20px;
            font-size: 0.9em;
            padding-top: 10px;
            background-color: #f9f9f9;
            border: 1px solid ");
                WriteLiteral(@"#ddd;
            padding: 10px;
        }

            .details p {
                margin: 2px 0;
            }

                .details p.summary {
                    font-weight: bold;
                }

        .table-image {
            position: absolute;
            top: 40px;
            right: 210px;
            width: 100px;
            height: auto;
        }

        .print-button {
            margin-top: 20px;
            padding: 10px;
            font-size: 1em;
            background-color: #007bff;
            color: white;
            border: none;
            border-radius: 5px;
            cursor: pointer;
        }

            .print-button:hover {
                background-color: #0056b3;
            }

        .white-background {
            background-color: white;
        }

        .header-background {
            background-color: white;
        }
    </style>
    <script>
        function printPage() {
            window.print();
        }
    </script>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e965d50277a3a2abf5a0d2009df539004e3cf7a9575", async() => {
                WriteLiteral(@"
    <div class=""container"">
        <div class=""info-box"">
            <p>26.07.2024 16:59</p>
            <h6>PROFORMA MALİYET</h6>
            <h7>IMPI611 VISCOSE VOILE 80/1</h7>
            <p>Düz Boya Zemin: SİYAH</p>
            <p style=""font-size: 12px;"">20.03.2024 tarihindeki KURLAR: $ 32.50 € 34.70 €/$: 1.0677</p>
        </div>

        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7e965d50277a3a2abf5a0d2009df539004e3cf7a10186", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

        <table>
            <thead>
                <tr class=""header-background"">
                    <th class=""right-align header-background""></th>
                    <th class=""right-align header-background"">İç Piyasa</th>
                    <th class=""left-align header-background"">İhracat</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td class=""left-align"">Ham Kumaş Proforma Fiyatı</td>
                    <td class=""right-align"">1,25 $/mt</td>
                    <td class=""left-align"">1,25 $/mt</td>
                </tr>
                <tr>
                    <td class=""left-align"">Ham Kumaş Maliyeti</td>
                    <td style=""color:red"" class=""right-align"">1,25 $/mt</td>
                    <td style=""color:red"" class=""left-align"">1,25 $/mt</td>
                </tr>
            </tbody>
        </table>
        <table>
            <tr>
                <th class=""left-align"">Değişken Maliyetler</th>
                <th class");
                WriteLiteral(@"=""left-align"">Hız<br /> mt/dk</th>
                <th class=""left-align"">Genel Maliyet</th>
                <th class=""left-align"">Reçete Maliyet</th>
                <th class=""left-align"">İç Piyasa</th>
                <th class=""left-align"">İhracat</th>
                <th class=""left-align"">Fason Maliyet</th>
            </tr>
            <tr>
                <td class=""left-align"">HAM AÇMA</td>
                <td></td>
                <td>0.0373</td>
                <td></td>
                <td>0.04$/mt</td>
                <td>0.4$/mt</td>
                <td></td>
            </tr>
            <tr>
                <td class=""left-align"">GAZE (Combi)</td>
                <td></td>
                <td>0.0150</td>
                <td>0.02$/mt</td>
                <td>0.02$/mt</td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td class=""left-align"">BOYAMA (Jet)(600)</td>
                <td></td>
                <td>0.2363</td>
                <t");
                WriteLiteral(@"d>0.0499</td>
                <td>0.29$/mt</td>
                <td>0.29$/mt</td>
                <td></td>
            </tr>
            <tr>
                <td class=""left-align"">KURUTMA (Ram)</td>
                <td>30</td>
                <td>0.0425</td>
                <td>0.4$/mt</td>
                <td>0.4$/mt</td>
                <td>0.49$/mt</td>
                <td></td>
            </tr>
            <tr>
                <td class=""left-align"">FINISH APRE (Ram)</td>
                <td>25</td>
                <td>0.0510</td>
                <td>0.0200</td>
                <td>0.07$/mt</td>
                <td>0.07$/mt</td>
                <td></td>
            </tr>
            <tr>
                <td class=""left-align"">KALİTE KONTROL</td>
                <td></td>
                <td>0.0398</td>
                <td></td>
                <td>0.4$/mt</td>
                <td>0.4$/mt</td>
                <td style=""color: red;"">0.48$/mt</td>
            </tr>
            <tr>
                <td c");
                WriteLiteral(@"lass=""left-align"">DÜZ BOYA ÇEKME</td>
                <td></td>
                <td></td>
                <td></td>
                <td>0.18$/mt</td>
                <td>0.18$/mt</td>
                <td></td>
            </tr>
            <tr>
                <td class=""summary left-align"">DÜZ BOYA MALİYETİ</td>
                <td class=""summary""></td>
                <td class=""summary"">0.4219</td>
                <td class=""summary"">0.0699</td>
                <td style=""color: red;"">0.62$/mt</td>
                <td style=""color: red;"">0.60$/mt</td>
                <td></td>
            </tr>
            <tr>
                <td class=""left-align"">STOK + A1 + TOPBAŞI</td>
                <td></td>
                <td></td>
                <td></td>
                <td>0.03$/mt</td>
                <td>0.03$/mt</td>
                <td></td>
            </tr>
            <tr>
                <td class=""left-align"">KUMAŞ DAHİL DÜZ BOYA MALİYETİ</td>
                <td></td>
                <td></td>
     ");
                WriteLiteral(@"           <td></td>
                <td style=""color:red"">0.03$/mt</td>
                <td style=""color:red"">0.03$/mt</td>
                <td></td>
            </tr>
            <tr>
                <th class=""left-align"" colspan=""7"">SABİT MALİYETLER</th>
            </tr>
            <tr>
                <td class=""left-align"">HAZIRLIK GRUBU MALİYETİ</td>
                <td></td>
                <td></td>
                <td></td>
                <td>0.02$/mt</td>
                <td>0.02$/mt</td>
                <td></td>
            </tr>
            <tr>
                <td class=""left-align"">PAZARLAMA GİDERİ</td>
                <td>% 7,0</td>
                <td>% 7,0</td>
                <td></td>
                <td>0.03$/mt</td>
                <td>0.03$/mt</td>
                <td></td>
            </tr>
            <tr>
                <td class=""left-align"">GENEL YÖNETİM GİDERİ</td>
                <td>% 3,0</td>
                <td>% 3,0</td>
                <td></td>
                <td>0.01");
                WriteLiteral(@"$/mt</td>
                <td>0.01$/mt</td>
                <td></td>
            </tr>
            <tr>
                <td class=""summary left-align"">BİTMİŞ KUMAŞ MALİYETİ</td>
                <td></td>
                <td></td>
                <td></td>
                <td style=""color: red;"" class=""summary"">2.18 $/mt</td>
                <td style=""color: red;"" class=""summary"">2.18 $/mt</td>
                <td></td>
            </tr>
        </table>

        <div class=""note"">
            <p>Yurtiçi Nakliye Bed. 0.025 ₺/mt ilave edilmelidir. Uyulması gereken kurallar için <a href=""#"">tıklayınız...</a></p>
        </div>

        <div class=""pricing"">
            <div>
                <p class=""summary"">SATIŞ FİYATI [LİSTE]</p>
                <p style=""color: red;"">3.05 $/mt</p>
                <p style=""color: red;"">2.86 £/mt</p>
            </div>
            <div>
                <p class=""summary"">KAR ORANI [LİSTE]</p>
                <p style=""color: red;"">40.2 %</p>
                <p style=""color");
                WriteLiteral(": red;\">40.2 %</p>\n            </div>\n        </div>\n\n        <div class=\"pricing\">\n            <div>\n                <p>VADELİ FİYAT</p>\n                <select>\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e965d50277a3a2abf5a0d2009df539004e3cf7a18022", async() => {
                    WriteLiteral("Peşin");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e965d50277a3a2abf5a0d2009df539004e3cf7a19263", async() => {
                    WriteLiteral("30 Gün (1.5%)");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e965d50277a3a2abf5a0d2009df539004e3cf7a20512", async() => {
                    WriteLiteral("60 Gün (3.5%)");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e965d50277a3a2abf5a0d2009df539004e3cf7a21761", async() => {
                    WriteLiteral("90 Gün (4.5%)");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                </select>
            </div>

            <div>
                <p>Proforma Geçerlilik Tarihi: 26.07.2024</p>
                <p>Kullanıcı: hamza</p>
            </div>
        </div>

        <div class=""checkbox"">
            <input type=""checkbox"" id=""karOranBelirle"">
            <label for=""karOranBelirle"">Kar Oran Belirle</label>
        </div>

        <button class=""print-button"" onclick=""printPage()"">
            <i class=""fas fa-print""></i>
        </button>

    </div>
");
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
            WriteLiteral("\n</html>\n");
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
