#pragma checksum "C:\Users\hp\source\repos\TestingAkbas2\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77e992f546c9217b3e78ff08bd57f2ba4fc7a277"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Fabrics_Index), @"mvc.1.0.view", @"/Views/Fabrics/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77e992f546c9217b3e78ff08bd57f2ba4fc7a277", @"/Views/Fabrics/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8166deb52fe4bcac3690b2461d128444deaf1f7", @"/Views/_ViewImports.cshtml")]
    public class Views_Fabrics_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TestingAkbas.Models.Fabric>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/custom.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\hp\source\repos\TestingAkbas2\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
   ViewData["Title"] = "";
    Layout = "_FabricsLayout"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "77e992f546c9217b3e78ff08bd57f2ba4fc7a2774199", async() => {
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
                WriteLiteral("\n");
            }
            );
            WriteLiteral(@"
<button type=""button"" id=""exportButton"" class=""btn btn-outline-success"">Export to Excel</button>

<div class=""currency-info-wrapper"">
    <div class=""currency-info"">
        EURO: 34, 7000 TL&nbsp;&nbsp;&nbsp;&nbsp;USD: 32, 5000 TL&nbsp;&nbsp;&nbsp;&nbsp;GBP: 41, 9100 TL&nbsp;&nbsp;&nbsp;&nbsp;€/$: 1, 0677&nbsp;&nbsp;&nbsp;&nbsp;GBP/$: 1, 2700
    </div>
</div>

<script src=""https://code.jquery.com/jquery-3.6.0.min.js""></script>

<table class=""table table-hover"" id=""fabricTable"">
    <thead>
        <tr>
            <th>Quality Class</th>
            <th>
                Fabric Code
                <div class=""filter-section"">
                    <label for=""fabricCodeFilter"" class=""sr-only""></label>
                    <input type=""text"" id=""fabricCodeSearch"" placeholder=""Search Fabric Code"">
                </div>
            </th>
            <th>Qualities</th>
            <th>
                Quality Name
                <div class=""filter-section"">
                    <label for=""qualityNameFilter"" clas");
            WriteLiteral(@"s=""sr-only""></label>
                    <input type=""text"" id=""qualityNameSearch"" placeholder=""Search Quality Name"">
                </div>
            </th>
            <th>
                Quality Group
                <div class=""filter-section"">
                    <label for=""qualityGroupFilter"" class=""sr-only""></label>
                    <input type=""text"" id=""qualityGroupSearch"" placeholder=""Search Quality Group"">
                </div>
            </th>
            <th>
                Width
                <div class=""filter-section"">
                    <label for=""minWidth"" class=""sr-only"">Min Width</label>
                    <input type=""number"" id=""minWidth"" placeholder=""Min""><br />
                    <label for=""maxWidth"" class=""sr-only"">Max Width</label>
                    <input type=""number"" id=""maxWidth"" placeholder=""Max"">
                </div>
            </th>
            <th>
                Weight
                <div class=""filter-section"">
                    <label for=""minWeigh");
            WriteLiteral(@"t"" class=""sr-only"">Min Weight</label>
                    <input type=""number"" id=""minWeight"" placeholder=""Min""><br />
                    <label for=""maxWeight"" class=""sr-only"">Max Weight</label>
                    <input type=""number"" id=""maxWeight"" placeholder=""Max"">
                </div>
            </th>
            <th>Raw Fabric Price</th>
            <th>Domestic Price</th>
            <th>Export Price</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 69 "C:\Users\hp\source\repos\TestingAkbas2\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr data-fabric-code=\"");
#nullable restore
#line 71 "C:\Users\hp\source\repos\TestingAkbas2\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
                 Write(item.FabricCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-quality-name=\"");
#nullable restore
#line 71 "C:\Users\hp\source\repos\TestingAkbas2\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
                                                      Write(item.QualityName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-quality-group=\"");
#nullable restore
#line 71 "C:\Users\hp\source\repos\TestingAkbas2\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
                                                                                             Write(item.QualityGroup);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\n    <td");
            BeginWriteAttribute("class", " class=\"", 2863, "\"", 2914, 1);
#nullable restore
#line 72 "C:\Users\hp\source\repos\TestingAkbas2\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
WriteAttributeValue("", 2871, GetQualityClassCssClass(item.QualityClass), 2871, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n        ");
#nullable restore
#line 73 "C:\Users\hp\source\repos\TestingAkbas2\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.QualityClass));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td");
            BeginWriteAttribute("class", " class=\"", 2991, "\"", 3036, 1);
#nullable restore
#line 75 "C:\Users\hp\source\repos\TestingAkbas2\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
WriteAttributeValue("", 2999, GetQualitiesCssClass(item.Qualities), 2999, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n        ");
#nullable restore
#line 76 "C:\Users\hp\source\repos\TestingAkbas2\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.FabricCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td");
            BeginWriteAttribute("class", " class=\"", 3111, "\"", 3156, 1);
#nullable restore
#line 78 "C:\Users\hp\source\repos\TestingAkbas2\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
WriteAttributeValue("", 3119, GetQualitiesCssClass(item.Qualities), 3119, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n        ");
#nullable restore
#line 79 "C:\Users\hp\source\repos\TestingAkbas2\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.Qualities));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td");
            BeginWriteAttribute("class", " class=\"", 3230, "\"", 3275, 1);
#nullable restore
#line 81 "C:\Users\hp\source\repos\TestingAkbas2\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
WriteAttributeValue("", 3238, GetQualitiesCssClass(item.Qualities), 3238, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n        ");
#nullable restore
#line 82 "C:\Users\hp\source\repos\TestingAkbas2\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.QualityName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td");
            BeginWriteAttribute("class", " class=\"", 3351, "\"", 3396, 1);
#nullable restore
#line 84 "C:\Users\hp\source\repos\TestingAkbas2\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
WriteAttributeValue("", 3359, GetQualitiesCssClass(item.Qualities), 3359, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n        ");
#nullable restore
#line 85 "C:\Users\hp\source\repos\TestingAkbas2\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.QualityGroup));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td");
            BeginWriteAttribute("class", " class=\"", 3473, "\"", 3518, 1);
#nullable restore
#line 87 "C:\Users\hp\source\repos\TestingAkbas2\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
WriteAttributeValue("", 3481, GetQualitiesCssClass(item.Qualities), 3481, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n        ");
#nullable restore
#line 88 "C:\Users\hp\source\repos\TestingAkbas2\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.Width));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td");
            BeginWriteAttribute("class", " class=\"", 3588, "\"", 3633, 1);
#nullable restore
#line 90 "C:\Users\hp\source\repos\TestingAkbas2\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
WriteAttributeValue("", 3596, GetQualitiesCssClass(item.Qualities), 3596, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n        ");
#nullable restore
#line 91 "C:\Users\hp\source\repos\TestingAkbas2\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.Weight));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td");
            BeginWriteAttribute("class", " class=\"", 3704, "\"", 3749, 1);
#nullable restore
#line 93 "C:\Users\hp\source\repos\TestingAkbas2\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
WriteAttributeValue("", 3712, GetQualitiesCssClass(item.Qualities), 3712, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n        ");
#nullable restore
#line 94 "C:\Users\hp\source\repos\TestingAkbas2\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.RawFabricPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td");
            BeginWriteAttribute("class", " class=\"", 3828, "\"", 3873, 1);
#nullable restore
#line 96 "C:\Users\hp\source\repos\TestingAkbas2\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
WriteAttributeValue("", 3836, GetQualitiesCssClass(item.Qualities), 3836, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n        ");
#nullable restore
#line 97 "C:\Users\hp\source\repos\TestingAkbas2\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.DomesticPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td");
            BeginWriteAttribute("class", " class=\"", 3951, "\"", 3996, 1);
#nullable restore
#line 99 "C:\Users\hp\source\repos\TestingAkbas2\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
WriteAttributeValue("", 3959, GetQualitiesCssClass(item.Qualities), 3959, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n        ");
#nullable restore
#line 100 "C:\Users\hp\source\repos\TestingAkbas2\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.ExportPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n</tr>");
#nullable restore
#line 102 "C:\Users\hp\source\repos\TestingAkbas2\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>

<script>
    $(document).ready(function () {
        function filterTable() {
            var fabricCodeSearch = $('#fabricCodeSearch').val().toLowerCase();
            var qualityNameSearch = $('#qualityNameSearch').val().toLowerCase();
            var qualityGroupSearch = $('#qualityGroupSearch').val().toLowerCase();
            var minWidth = parseFloat($('#minWidth').val()) || -Infinity;
            var maxWidth = parseFloat($('#maxWidth').val()) || Infinity;
            var minWeight = parseFloat($('#minWeight').val()) || -Infinity;
            var maxWeight = parseFloat($('#maxWeight').val()) || Infinity;

            $('#fabricTable tbody tr').each(function () {
                var row = $(this);
                var rowFabricCode = row.find('td').eq(1).text().toLowerCase();
                var rowQualityName = row.find('td').eq(3).text().toLowerCase();
                var rowQualityGroup = row.find('td').eq(4).text().toLowerCase();
                var rowWidth = parseFloat(row.fi");
            WriteLiteral(@"nd('td').eq(5).text()) || 0;
                var rowWeight = parseFloat(row.find('td').eq(6).text()) || 0;

                var isWidthInRange = (rowWidth >= minWidth) && (rowWidth <= maxWidth);
                var isWeightInRange = (rowWeight >= minWeight) && (rowWeight <= maxWeight);

                var matchesFabricCode = (fabricCodeSearch === """" || rowFabricCode.includes(fabricCodeSearch));
                var matchesQualityName = (qualityNameSearch === """" || rowQualityName.includes(qualityNameSearch));
                var matchesQualityGroup = (qualityGroupSearch === """" || rowQualityGroup.includes(qualityGroupSearch));

                if (matchesFabricCode &&
                    matchesQualityName &&
                    matchesQualityGroup &&
                    isWidthInRange &&
                    isWeightInRange) {
                    row.show();
                } else {
                    row.hide();
                }
            });
        }
        function exportVisibleDataToExcel() {
        ");
            WriteLiteral(@"    // Filtrelenmiş verileri toplama
            var headers = [];
            var data = [];

            // Başlıkları toplama
            $('#fabricTable thead th').each(function () {
                headers.push($(this).text().trim());
            });

            // Satırları toplama
            $('#fabricTable tbody tr:visible').each(function () {
                var rowData = [];
                $(this).find('td').each(function () {
                    rowData.push($(this).text().trim());
                });
                data.push(rowData);
            });

            // Excel export işlemini gerçekleştiren API çağrısı
            $.ajax({
                type: 'POST',
                url: '/Fabrics/ExportVisibleToExcel', // API endpoint URL
                contentType: 'application/json',
                data: JSON.stringify({ Headers: headers, Data: data }),
                xhrFields: {
                    responseType: 'blob'
                },
                success: function (response) {
    ");
            WriteLiteral(@"                var url = window.URL.createObjectURL(new Blob([response], { type: 'application/vnd.openxmlformats-officedocument.spreadsheetml.sheet' }));
                    var a = document.createElement('a');
                    a.href = url;
                    a.download = 'VisibleFabrics.xlsx';
                    document.body.appendChild(a);
                    a.click();
                    window.URL.revokeObjectURL(url);
                },
                error: function (xhr, status, error) {
                    console.error('Export failed:', error);
                }
            });
        }

        // Olay dinleyicileri
        $('#fabricCodeSearch, #qualityNameSearch, #qualityGroupSearch, #minWidth, #maxWidth, #minWeight, #maxWeight').on('input', function () {
            filterTable();
        });

        // Sayfa yüklendiğinde filtreleme işlemini yap
        filterTable();

        // Export to Excel butonuna tıklama olayını yakala
        $('#exportButton').on('click', function () {
    ");
            WriteLiteral("        exportVisibleDataToExcel();\n        });\n    });\n\n</script>\n\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 202 "C:\Users\hp\source\repos\TestingAkbas2\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
             public string GetQualityClassCssClass(string qualityClass)
    {
        switch (qualityClass?.ToLower())
        {
            case "viscose":
                return "quality-class-viscose";
            case "rayon":
            case "rynsignart":
                return "quality-class-rayon";
            case "cotton":
                return "quality-class-cotton";
            case "nylon":
                return "quality-class-nylon";
            case "polyester":
            case "pesdouble":
                return "quality-class-polyester";
            case "tencel":
            case "modal":
                return "quality-class-tencel";
            case "linen":
                return "quality-class-linen";
            case "jacquard":
                return "quality-class-jacquard";
            case "mix":
            case "yarndyed":
                return "quality-class-mix";
            default:
                return "";
        }
    }

    public string GetQualitiesCssClass(string qualities)
    {
        switch (qualities?.ToLower())
        {
            case "m":
                return "qualities-m";
            case "a":
                return "qualities-a";
            case "n":
                return "qualities-n";
            default:
                return "";
        }
    } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TestingAkbas.Models.Fabric>> Html { get; private set; }
    }
}
#pragma warning restore 1591
