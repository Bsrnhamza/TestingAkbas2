#pragma checksum "C:\Users\hp\source\repos\TestingAkbas2\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1de11d27109858a93b6c0f4dd6ee55ca9cdc297"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1de11d27109858a93b6c0f4dd6ee55ca9cdc297", @"/Views/Fabrics/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8166deb52fe4bcac3690b2461d128444deaf1f7", @"/Views/_ViewImports.cshtml")]
    public class Views_Fabrics_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TestingAkbas.Models.Fabric>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/custom.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\hp\source\repos\TestingAkbas2\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
   ViewData["Title"] = ""; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b1de11d27109858a93b6c0f4dd6ee55ca9cdc2974590", async() => {
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
            WriteLiteral(@"<div class=""currency-info-wrapper"">
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
                    <label for=""fabricCodeFilter"" class=""sr-only"">Filter by Fabric Code</label>
                    <select id=""fabricCodeFilter"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1de11d27109858a93b6c0f4dd6ee55ca9cdc2976545", async() => {
                WriteLiteral("All");
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
            WriteLiteral("\n");
#nullable restore
#line 23 "C:\Users\hp\source\repos\TestingAkbas2\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
                         foreach (var item in Model.Select(x => x.FabricCode).Distinct())
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1de11d27109858a93b6c0f4dd6ee55ca9cdc2978031", async() => {
#nullable restore
#line 25 "C:\Users\hp\source\repos\TestingAkbas2\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
                             Write(item);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 25 "C:\Users\hp\source\repos\TestingAkbas2\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
               WriteLiteral(item);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
#nullable restore
#line 25 "C:\Users\hp\source\repos\TestingAkbas2\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </select>
                </div>
            </th>
            <th>Qualities</th>
            <th>
                Quality Name
                <div class=""filter-section"">
                    <label for=""qualityNameFilter"" class=""sr-only"">Filter by Quality Name</label>
                    <select id=""qualityNameFilter"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1de11d27109858a93b6c0f4dd6ee55ca9cdc29710410", async() => {
                WriteLiteral("All");
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
            WriteLiteral("\n");
#nullable restore
#line 36 "C:\Users\hp\source\repos\TestingAkbas2\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
                         foreach (var item in Model.Select(x => x.QualityName).Distinct())
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1de11d27109858a93b6c0f4dd6ee55ca9cdc29711898", async() => {
#nullable restore
#line 38 "C:\Users\hp\source\repos\TestingAkbas2\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
                             Write(item);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 38 "C:\Users\hp\source\repos\TestingAkbas2\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
               WriteLiteral(item);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
#nullable restore
#line 38 "C:\Users\hp\source\repos\TestingAkbas2\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </select>
                </div>
            </th>
            <th>
                Quality Group
                <div class=""filter-section"">
                    <label for=""qualityGroupFilter"" class=""sr-only"">Filter by Quality Group</label>
                    <select id=""qualityGroupFilter"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1de11d27109858a93b6c0f4dd6ee55ca9cdc29714251", async() => {
                WriteLiteral("All");
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
            WriteLiteral("\n");
#nullable restore
#line 48 "C:\Users\hp\source\repos\TestingAkbas2\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
                         foreach (var item in Model.Select(x => x.QualityGroup).Distinct())
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1de11d27109858a93b6c0f4dd6ee55ca9cdc29715740", async() => {
#nullable restore
#line 50 "C:\Users\hp\source\repos\TestingAkbas2\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
                             Write(item);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 50 "C:\Users\hp\source\repos\TestingAkbas2\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
               WriteLiteral(item);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
#nullable restore
#line 50 "C:\Users\hp\source\repos\TestingAkbas2\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </select>
                </div>
            </th>
            <th>Quality Composition</th>
            <th>Pattern Type</th>
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
                    <label for=""minWeight"" class=""sr-only"">Min Weight</label>
                    <input type=""number"" id=""minWeight"" placeholder=""Min""><br />
                    <label for=""maxWeight"" class=""sr-only"">Max Weight</label>
                    <input type=""number"" id=""maxWeight"" placeholder=""Max"">
                </div>
            </th>
         ");
            WriteLiteral("   <th>Raw Fabric Price</th>\n            <th>Domestic Price</th>\n            <th>Export Price</th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 80 "C:\Users\hp\source\repos\TestingAkbas2\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr data-fabric-code=\"");
#nullable restore
#line 82 "C:\Users\hp\source\repos\TestingAkbas2\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
                 Write(item.FabricCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-quality-name=\"");
#nullable restore
#line 82 "C:\Users\hp\source\repos\TestingAkbas2\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
                                                      Write(item.QualityName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-quality-group=\"");
#nullable restore
#line 82 "C:\Users\hp\source\repos\TestingAkbas2\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
                                                                                             Write(item.QualityGroup);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\n    <td");
            BeginWriteAttribute("class", " class=\"", 3490, "\"", 3541, 1);
#nullable restore
#line 83 "C:\Users\hp\source\repos\TestingAkbas2\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
WriteAttributeValue("", 3498, GetQualityClassCssClass(item.QualityClass), 3498, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n        ");
#nullable restore
#line 84 "C:\Users\hp\source\repos\TestingAkbas2\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.QualityClass));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td");
            BeginWriteAttribute("class", " class=\"", 3618, "\"", 3663, 1);
#nullable restore
#line 86 "C:\Users\hp\source\repos\TestingAkbas2\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
WriteAttributeValue("", 3626, GetQualitiesCssClass(item.Qualities), 3626, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n        ");
#nullable restore
#line 87 "C:\Users\hp\source\repos\TestingAkbas2\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.FabricCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td");
            BeginWriteAttribute("class", " class=\"", 3738, "\"", 3783, 1);
#nullable restore
#line 89 "C:\Users\hp\source\repos\TestingAkbas2\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
WriteAttributeValue("", 3746, GetQualitiesCssClass(item.Qualities), 3746, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n    ");
#nullable restore
#line 90 "C:\Users\hp\source\repos\TestingAkbas2\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
Write(Html.DisplayFor(modelItem => item.Qualities));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td");
            BeginWriteAttribute("class", " class=\"", 3853, "\"", 3898, 1);
#nullable restore
#line 92 "C:\Users\hp\source\repos\TestingAkbas2\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
WriteAttributeValue("", 3861, GetQualitiesCssClass(item.Qualities), 3861, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n        ");
#nullable restore
#line 93 "C:\Users\hp\source\repos\TestingAkbas2\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.QualityName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </td>\n    <td");
            BeginWriteAttribute("class", " class=\"", 3978, "\"", 4023, 1);
#nullable restore
#line 95 "C:\Users\hp\source\repos\TestingAkbas2\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
WriteAttributeValue("", 3986, GetQualitiesCssClass(item.Qualities), 3986, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n        ");
#nullable restore
#line 96 "C:\Users\hp\source\repos\TestingAkbas2\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.QualityGroup));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td");
            BeginWriteAttribute("class", " class=\"", 4100, "\"", 4145, 1);
#nullable restore
#line 98 "C:\Users\hp\source\repos\TestingAkbas2\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
WriteAttributeValue("", 4108, GetQualitiesCssClass(item.Qualities), 4108, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n        ");
#nullable restore
#line 99 "C:\Users\hp\source\repos\TestingAkbas2\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.QualityComposition));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td");
            BeginWriteAttribute("class", " class=\"", 4228, "\"", 4273, 1);
#nullable restore
#line 101 "C:\Users\hp\source\repos\TestingAkbas2\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
WriteAttributeValue("", 4236, GetQualitiesCssClass(item.Qualities), 4236, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n        ");
#nullable restore
#line 102 "C:\Users\hp\source\repos\TestingAkbas2\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.PatternType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td");
            BeginWriteAttribute("class", " class=\"", 4349, "\"", 4394, 1);
#nullable restore
#line 104 "C:\Users\hp\source\repos\TestingAkbas2\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
WriteAttributeValue("", 4357, GetQualitiesCssClass(item.Qualities), 4357, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n        ");
#nullable restore
#line 105 "C:\Users\hp\source\repos\TestingAkbas2\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.Width));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td");
            BeginWriteAttribute("class", " class=\"", 4464, "\"", 4509, 1);
#nullable restore
#line 107 "C:\Users\hp\source\repos\TestingAkbas2\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
WriteAttributeValue("", 4472, GetQualitiesCssClass(item.Qualities), 4472, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n        ");
#nullable restore
#line 108 "C:\Users\hp\source\repos\TestingAkbas2\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.Weight));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td");
            BeginWriteAttribute("class", " class=\"", 4580, "\"", 4625, 1);
#nullable restore
#line 110 "C:\Users\hp\source\repos\TestingAkbas2\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
WriteAttributeValue("", 4588, GetQualitiesCssClass(item.Qualities), 4588, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n        ");
#nullable restore
#line 111 "C:\Users\hp\source\repos\TestingAkbas2\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.RawFabricPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td");
            BeginWriteAttribute("class", " class=\"", 4704, "\"", 4749, 1);
#nullable restore
#line 113 "C:\Users\hp\source\repos\TestingAkbas2\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
WriteAttributeValue("", 4712, GetQualitiesCssClass(item.Qualities), 4712, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n        ");
#nullable restore
#line 114 "C:\Users\hp\source\repos\TestingAkbas2\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.DomesticPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td");
            BeginWriteAttribute("class", " class=\"", 4827, "\"", 4872, 1);
#nullable restore
#line 116 "C:\Users\hp\source\repos\TestingAkbas2\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
WriteAttributeValue("", 4835, GetQualitiesCssClass(item.Qualities), 4835, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n        ");
#nullable restore
#line 117 "C:\Users\hp\source\repos\TestingAkbas2\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.ExportPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n</tr>");
#nullable restore
#line 119 "C:\Users\hp\source\repos\TestingAkbas2\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>
<script>
    $(document).ready(function () {
        function filterTable() {
            var fabricCode = $('#fabricCodeFilter').val().toLowerCase();
            var qualityName = $('#qualityNameFilter').val().toLowerCase();
            var qualityGroup = $('#qualityGroupFilter').val().toLowerCase();
            var minWidth = parseFloat($('#minWidth').val()) || -Infinity;
            var maxWidth = parseFloat($('#maxWidth').val()) || Infinity;
            var minWeight = parseFloat($('#minWeight').val()) || -Infinity;
            var maxWeight = parseFloat($('#maxWeight').val()) || Infinity;

            $('#fabricTable tbody tr').each(function () {
                var row = $(this);
                var rowFabricCode = row.data('fabric-code').toLowerCase();
                var rowQualityName = row.data('quality-name').toLowerCase();
                var rowQualityGroup = row.data('quality-group').toLowerCase();
                var rowWidth = parseFloat(row.find('td').eq(7).text()) || 0;");
            WriteLiteral(@"
                var rowWeight = parseFloat(row.find('td').eq(8).text()) || 0;

                var isWidthInRange = (rowWidth >= minWidth) && (rowWidth <= maxWidth);
                var isWeightInRange = (rowWeight >= minWeight) && (rowWeight <= maxWeight);

                if ((fabricCode === """" || rowFabricCode === fabricCode) &&
                    (qualityName === """" || rowQualityName === qualityName) &&
                    (qualityGroup === """" || rowQualityGroup === qualityGroup) &&
                    isWidthInRange &&
                    isWeightInRange) {
                    row.show();
                } else {
                    row.hide();
                }
            });
        }

        function updateColumnVisibility() {
            var filterType = $('input[name=""filterType""]:checked').val();
            var exportPriceColIndex = 11; // 12. sütun (index 11)
            var domesticPriceColIndex = 10; // 11. sütun (index 10)

            // Başlıkların görünürlüğünü güncelle
            $('#");
            WriteLiteral(@"fabricTable thead th').each(function (index) {
                if (filterType === 'Domestic') {
                    $(this).toggle(index !== exportPriceColIndex);
                } else if (filterType === 'Export') {
                    $(this).toggle(index !== domesticPriceColIndex);
                } else {
                    $(this).show(); // Her şey görünür
                }
            });

            // Hücrelerin görünürlüğünü güncelle
            $('#fabricTable tbody tr').each(function () {
                var row = $(this);
                row.find('td').each(function (index) {
                    if (filterType === 'Domestic') {
                        $(this).toggle(index !== exportPriceColIndex);
                    } else if (filterType === 'Export') {
                        $(this).toggle(index !== domesticPriceColIndex);
                    } else {
                        $(this).show(); // Her şey görünür
                    }
                });
            });
        }

        // Ola");
            WriteLiteral(@"y dinleyicileri
        $('#fabricCodeFilter, #qualityNameFilter, #qualityGroupFilter, #minWidth, #maxWidth, #minWeight, #maxWeight').on('change', function () {
            filterTable();
            updateColumnVisibility();
        });

        $('input[name=""filterType""]').on('change', function () {
            filterTable();
            updateColumnVisibility();
        });

        // Sayfa yüklendiğinde uygun sütunları göster/gizle
        filterTable();
        updateColumnVisibility();
    });
</script>


");
        }
        #pragma warning restore 1998
#nullable restore
#line 205 "C:\Users\hp\source\repos\TestingAkbas2\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
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
