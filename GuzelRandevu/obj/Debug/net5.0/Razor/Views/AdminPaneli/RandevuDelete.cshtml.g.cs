#pragma checksum "C:\Users\Yıldız\Downloads\GuzelRandevu-master (4)\GuzelRandevu-master\GuzelRandevu\Views\AdminPaneli\RandevuDelete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a46d8c0339434362adb5c039cd22164eb8c61cf2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminPaneli_RandevuDelete), @"mvc.1.0.view", @"/Views/AdminPaneli/RandevuDelete.cshtml")]
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
#line 1 "C:\Users\Yıldız\Downloads\GuzelRandevu-master (4)\GuzelRandevu-master\GuzelRandevu\Views\_ViewImports.cshtml"
using GuzelRandevu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Yıldız\Downloads\GuzelRandevu-master (4)\GuzelRandevu-master\GuzelRandevu\Views\_ViewImports.cshtml"
using GuzelRandevu.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Yıldız\Downloads\GuzelRandevu-master (4)\GuzelRandevu-master\GuzelRandevu\Views\AdminPaneli\_ViewImports.cshtml"
using GuzelRandevu.Areas.Identity.Pages.Account.Manage;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a46d8c0339434362adb5c039cd22164eb8c61cf2", @"/Views/AdminPaneli/RandevuDelete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"973b5a7d959bdac9150681ff0d62b66816ca39b8", @"/Views/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3f3795b9511dc80b90d6f2bd3a1b302c399e6a4", @"/Views/AdminPaneli/_ViewImports.cshtml")]
    public class Views_AdminPaneli_RandevuDelete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GuzelRandevu.Models.Randevu>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RandevuIndex", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RandevuDelete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Yıldız\Downloads\GuzelRandevu-master (4)\GuzelRandevu-master\GuzelRandevu\Views\AdminPaneli\RandevuDelete.cshtml"
  
    ViewData["Title"] = "Randevu Sil";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h5>Randevu Sil</h5>\n\n<h3></h3>\n<div>\n    <h4>Randevu</h4>\n    <hr />\n    <dl class=\"row\">\n        <dt class=\"col-sm-2\">\n            Müşteri Adı Soyadı\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 18 "C:\Users\Yıldız\Downloads\GuzelRandevu-master (4)\GuzelRandevu-master\GuzelRandevu\Views\AdminPaneli\RandevuDelete.cshtml"
       Write(Html.DisplayFor(model => model.uye.uyeAdi));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 18 "C:\Users\Yıldız\Downloads\GuzelRandevu-master (4)\GuzelRandevu-master\GuzelRandevu\Views\AdminPaneli\RandevuDelete.cshtml"
                                                   Write(Html.DisplayFor(model => model.uye.uyeSoyadi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            Güzellik Merkezi\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 24 "C:\Users\Yıldız\Downloads\GuzelRandevu-master (4)\GuzelRandevu-master\GuzelRandevu\Views\AdminPaneli\RandevuDelete.cshtml"
       Write(Html.DisplayFor(model => model.guzellikMerkezi.merkezAdi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 27 "C:\Users\Yıldız\Downloads\GuzelRandevu-master (4)\GuzelRandevu-master\GuzelRandevu\Views\AdminPaneli\RandevuDelete.cshtml"
       Write(Html.DisplayNameFor(model => model.randevuDegerlendirmesi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n");
#nullable restore
#line 29 "C:\Users\Yıldız\Downloads\GuzelRandevu-master (4)\GuzelRandevu-master\GuzelRandevu\Views\AdminPaneli\RandevuDelete.cshtml"
         if (DateTime.Now.Date < Model.randevuSaati)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dd class=\"col-sm-10\">\n                Gerçekleşmedi\n            </dd>\n");
#nullable restore
#line 34 "C:\Users\Yıldız\Downloads\GuzelRandevu-master (4)\GuzelRandevu-master\GuzelRandevu\Views\AdminPaneli\RandevuDelete.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 38 "C:\Users\Yıldız\Downloads\GuzelRandevu-master (4)\GuzelRandevu-master\GuzelRandevu\Views\AdminPaneli\RandevuDelete.cshtml"
           Write(Html.DisplayFor(model => model.randevuDegerlendirmesi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n");
#nullable restore
#line 40 "C:\Users\Yıldız\Downloads\GuzelRandevu-master (4)\GuzelRandevu-master\GuzelRandevu\Views\AdminPaneli\RandevuDelete.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 42 "C:\Users\Yıldız\Downloads\GuzelRandevu-master (4)\GuzelRandevu-master\GuzelRandevu\Views\AdminPaneli\RandevuDelete.cshtml"
       Write(Html.DisplayNameFor(model => model.randevuPuani));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n");
#nullable restore
#line 44 "C:\Users\Yıldız\Downloads\GuzelRandevu-master (4)\GuzelRandevu-master\GuzelRandevu\Views\AdminPaneli\RandevuDelete.cshtml"
         if (DateTime.Now.Date < Model.randevuSaati)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dd class=\"col-sm-10\">\n                Gerçekleşmedi\n            </dd>\n");
#nullable restore
#line 49 "C:\Users\Yıldız\Downloads\GuzelRandevu-master (4)\GuzelRandevu-master\GuzelRandevu\Views\AdminPaneli\RandevuDelete.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 53 "C:\Users\Yıldız\Downloads\GuzelRandevu-master (4)\GuzelRandevu-master\GuzelRandevu\Views\AdminPaneli\RandevuDelete.cshtml"
           Write(Html.DisplayFor(model => model.randevuPuani));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n");
#nullable restore
#line 55 "C:\Users\Yıldız\Downloads\GuzelRandevu-master (4)\GuzelRandevu-master\GuzelRandevu\Views\AdminPaneli\RandevuDelete.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 57 "C:\Users\Yıldız\Downloads\GuzelRandevu-master (4)\GuzelRandevu-master\GuzelRandevu\Views\AdminPaneli\RandevuDelete.cshtml"
       Write(Html.DisplayNameFor(model => model.randevuSaati));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 60 "C:\Users\Yıldız\Downloads\GuzelRandevu-master (4)\GuzelRandevu-master\GuzelRandevu\Views\AdminPaneli\RandevuDelete.cshtml"
       Write(Html.DisplayFor(model => model.randevuSaati));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 63 "C:\Users\Yıldız\Downloads\GuzelRandevu-master (4)\GuzelRandevu-master\GuzelRandevu\Views\AdminPaneli\RandevuDelete.cshtml"
       Write(Html.DisplayNameFor(model => model.randevuTuru));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 66 "C:\Users\Yıldız\Downloads\GuzelRandevu-master (4)\GuzelRandevu-master\GuzelRandevu\Views\AdminPaneli\RandevuDelete.cshtml"
       Write(Html.DisplayFor(model => model.randevuTuru));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n    </dl>\n    \n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a46d8c0339434362adb5c039cd22164eb8c61cf211343", async() => {
                WriteLiteral("\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a46d8c0339434362adb5c039cd22164eb8c61cf211608", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 71 "C:\Users\Yıldız\Downloads\GuzelRandevu-master (4)\GuzelRandevu-master\GuzelRandevu\Views\AdminPaneli\RandevuDelete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.uyeId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a46d8c0339434362adb5c039cd22164eb8c61cf213357", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 72 "C:\Users\Yıldız\Downloads\GuzelRandevu-master (4)\GuzelRandevu-master\GuzelRandevu\Views\AdminPaneli\RandevuDelete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.merkezId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n        <input type=\"submit\" value=\"Sil\" class=\"btn btn-danger\" /> |\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a46d8c0339434362adb5c039cd22164eb8c61cf215185", async() => {
                    WriteLiteral("Randevu Listesine Geri Dön");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GuzelRandevu.Models.Randevu> Html { get; private set; }
    }
}
#pragma warning restore 1591
