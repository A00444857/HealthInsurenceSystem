#pragma checksum "C:\Users\MIT\Desktop\Recent\HIS\HealthInsurenceSystem\Views\Payment\check.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "471373cfc642344ea0a40d445ed752cf9c70b211"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Payment_check), @"mvc.1.0.view", @"/Views/Payment/check.cshtml")]
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
#line 1 "C:\Users\MIT\Desktop\Recent\HIS\HealthInsurenceSystem\Views\_ViewImports.cshtml"
using HealthInsurenceSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MIT\Desktop\Recent\HIS\HealthInsurenceSystem\Views\_ViewImports.cshtml"
using HealthInsurenceSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"471373cfc642344ea0a40d445ed752cf9c70b211", @"/Views/Payment/check.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2e2e8eff2f278ec56cd155b82857607914793b4", @"/Views/_ViewImports.cshtml")]
    public class Views_Payment_check : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HealthInsurenceSystem.Models.Paymentlog>>
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "471373cfc642344ea0a40d445ed752cf9c70b2113155", async() => {
                WriteLiteral("\r\n\r\n        <title>\r\n            Payment Confirmation\r\n        </title>\r\n    ");
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
            WriteLiteral("\r\n    <div class=\"jumbotron text-center\">\r\n        <h1 class=\"display-3\">Thank You!</h1>\r\n\r\n        <p class=\"lead\"><h3> Your Transaction ID is # <b>");
#nullable restore
#line 12 "C:\Users\MIT\Desktop\Recent\HIS\HealthInsurenceSystem\Views\Payment\check.cshtml"
                                                    Write(Model.First().Paymentnumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h3></p>\r\n        <hr><br />\r\n        <h3>Payment Amount: $<b>");
#nullable restore
#line 14 "C:\Users\MIT\Desktop\Recent\HIS\HealthInsurenceSystem\Views\Payment\check.cshtml"
                           Write(TempData["data"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> </h3><br />\r\n        <p> Payment done for <strong>");
#nullable restore
#line 15 "C:\Users\MIT\Desktop\Recent\HIS\HealthInsurenceSystem\Views\Payment\check.cshtml"
                                Write(Model.First().Cemail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> for policy number <b>");
#nullable restore
#line 15 "C:\Users\MIT\Desktop\Recent\HIS\HealthInsurenceSystem\Views\Payment\check.cshtml"
                                                                                    Write(TempData["Policy number"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> which is fall under <strong> ");
#nullable restore
#line 15 "C:\Users\MIT\Desktop\Recent\HIS\HealthInsurenceSystem\Views\Payment\check.cshtml"
                                                                                                                                                Write(TempData["Policy type"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> type policy.</p>\r\n        <br />\r\n        <p>\r\n            Having trouble? <a");
            BeginWriteAttribute("href", " href=\"", 696, "\"", 703, 0);
            EndWriteAttribute();
            WriteLiteral(">Contact us</a>\r\n        </p>\r\n        <p class=\"lead\">\r\n            <a class=\"btn btn-primary btn-sm\" href=\"https://bootstrapcreative.com/\" role=\"button\">Continue to homepage</a>\r\n        </p>\r\n    </div>\r\n    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HealthInsurenceSystem.Models.Paymentlog>> Html { get; private set; }
    }
}
#pragma warning restore 1591
