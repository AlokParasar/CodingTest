#pragma checksum "D:\QuoteSearch\QuoteSearch\Views\Quote\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "525520a4ce27f933610bf990283634f172c8d04e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Quote_Index), @"mvc.1.0.view", @"/Views/Quote/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Quote/Index.cshtml", typeof(AspNetCore.Views_Quote_Index))]
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
#line 1 "D:\QuoteSearch\QuoteSearch\Views\_ViewImports.cshtml"
using QuoteSearch;

#line default
#line hidden
#line 2 "D:\QuoteSearch\QuoteSearch\Views\_ViewImports.cshtml"
using QuoteSearch.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"525520a4ce27f933610bf990283634f172c8d04e", @"/Views/Quote/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f02683b567d0bc6c7a2bc910bd7c953834f9e1b", @"/Views/_ViewImports.cshtml")]
    public class Views_Quote_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 546, true);
            WriteLiteral(@"<nav class=""navbar navbar-inverse navbar-fixed-top"">
    <div class=""container"" style=""font-weight: bold; font-size:large; vertical-align:middle;padding-top:10px;"">
        Quote
    </div>
</nav>
<div id=""myCarousel"" class=""carousel slide"" data-ride=""carousel"" data-interval=""6000"">
    <table width=""100%"" border=""2"" style=""font-weight:normal;"">
        <tr>
            <td>Quote: <label>Q92348</label></td>
            <td>
                Status: <select data-val=""true"" id=""SelectStatus"" name=""SelectStatus"">
                    ");
            EndContext();
            BeginContext(546, 39, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b86d5c9c98043af960b6862d8e74061", async() => {
                BeginContext(563, 13, true);
                WriteLiteral("Select Status");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(585, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(607, 24, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6dffd125389744b2b26a52151aa6a8c5", async() => {
                BeginContext(615, 7, true);
                WriteLiteral("Pending");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(631, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(653, 23, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63c0bdaa35d3447fad9e59b7611c9711", async() => {
                BeginContext(661, 6, true);
                WriteLiteral("Issued");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(676, 318, true);
            WriteLiteral(@"
                </select>
            </td>
            <td>Applicant: <label>James Feather LLC</label></td>
        </tr>
        <tr>
            <td>Quote Date: <label>08/01/2020</label></td>
            <td>Effective Date: <label>08/06/2020</label></td>
            <td>
                Basic - $680.00: ");
            EndContext();
            BeginContext(995, 36, false);
#line 23 "D:\QuoteSearch\QuoteSearch\Views\Quote\Index.cshtml"
                            Write(Html.RadioButton("Premium", "Basic"));

#line default
#line hidden
            EndContext();
            BeginContext(1031, 23, true);
            WriteLiteral(" Preferred - $850.00\": ");
            EndContext();
            BeginContext(1055, 40, false);
#line 23 "D:\QuoteSearch\QuoteSearch\Views\Quote\Index.cshtml"
                                                                                        Write(Html.RadioButton("Premium", "Preferred"));

#line default
#line hidden
            EndContext();
            BeginContext(1095, 38, true);
            WriteLiteral("\r\n                Premier - $1050.00: ");
            EndContext();
            BeginContext(1134, 38, false);
#line 24 "D:\QuoteSearch\QuoteSearch\Views\Quote\Index.cshtml"
                               Write(Html.RadioButton("Premium", "Premier"));

#line default
#line hidden
            EndContext();
            BeginContext(1172, 112, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td></td>\r\n            <td>");
            EndContext();
            BeginContext(1285, 61, false);
#line 30 "D:\QuoteSearch\QuoteSearch\Views\Quote\Index.cshtml"
           Write(Html.ActionLink("Click here to navigate to Search", "Search"));

#line default
#line hidden
            EndContext();
            BeginContext(1346, 46, true);
            WriteLiteral("</td>\r\n        </tr>\r\n    </table>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
