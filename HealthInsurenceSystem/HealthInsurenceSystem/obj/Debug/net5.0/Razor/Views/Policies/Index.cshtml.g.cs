#pragma checksum "C:\Users\Peter Parker\source\repos\HealthInsurenceSystem\HealthInsurenceSystem\Views\Policies\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aab5975385818dbaaeb4c8f6c7187147ac1afe9f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Policies_Index), @"mvc.1.0.view", @"/Views/Policies/Index.cshtml")]
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
#line 1 "C:\Users\Peter Parker\source\repos\HealthInsurenceSystem\HealthInsurenceSystem\Views\_ViewImports.cshtml"
using HealthInsurenceSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Peter Parker\source\repos\HealthInsurenceSystem\HealthInsurenceSystem\Views\_ViewImports.cshtml"
using HealthInsurenceSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aab5975385818dbaaeb4c8f6c7187147ac1afe9f", @"/Views/Policies/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2e2e8eff2f278ec56cd155b82857607914793b4", @"/Views/_ViewImports.cshtml")]
    public class Views_Policies_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HealthInsurenceSystem.Models.Policy>>
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aab5975385818dbaaeb4c8f6c7187147ac1afe9f3227", async() => {
                WriteLiteral("\r\n\r\n    <title>\r\n        Policy Recommendation Page\r\n    </title>\r\n");
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
            WriteLiteral(@"

<div class=""container p-3"">
    <div class=""row pt-4"">
        <div class=""col-6"">
            <h2 class=""text-primary""> Policies List</h2>
        </div>
        <div class=""col-6"">
            Buy Policy
        </div>
    </div>

    <br/> <br/>

");
#nullable restore
#line 22 "C:\Users\Peter Parker\source\repos\HealthInsurenceSystem\HealthInsurenceSystem\Views\Policies\Index.cshtml"
     if (Model.Count() > 0)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table class=""table table-bordered table-striped"" style=""width:100%"">

            <thead>
                <tr>
                    <th>
                        Policy Type
                    </th>
                    <th>
                        Minimum Age
                    </th>
                    <th>
                        Maximum Age
                    </th>
                    <th>
                        Month Premium
                    </th>
                    <th>
                        Duration
                    </th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 48 "C:\Users\Peter Parker\source\repos\HealthInsurenceSystem\HealthInsurenceSystem\Views\Policies\Index.cshtml"
                 foreach(var obj in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td width=\"50%\">");
#nullable restore
#line 51 "C:\Users\Peter Parker\source\repos\HealthInsurenceSystem\HealthInsurenceSystem\Views\Policies\Index.cshtml"
                               Write(obj.Ptype);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td width=\"50%\">");
#nullable restore
#line 52 "C:\Users\Peter Parker\source\repos\HealthInsurenceSystem\HealthInsurenceSystem\Views\Policies\Index.cshtml"
                               Write(obj.MinAge);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td width=\"50%\">");
#nullable restore
#line 53 "C:\Users\Peter Parker\source\repos\HealthInsurenceSystem\HealthInsurenceSystem\Views\Policies\Index.cshtml"
                               Write(obj.MaxAge);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td width=\"50%\">");
#nullable restore
#line 54 "C:\Users\Peter Parker\source\repos\HealthInsurenceSystem\HealthInsurenceSystem\Views\Policies\Index.cshtml"
                               Write(obj.MonthPremium);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td width=\"50%\">");
#nullable restore
#line 55 "C:\Users\Peter Parker\source\repos\HealthInsurenceSystem\HealthInsurenceSystem\Views\Policies\Index.cshtml"
                               Write(obj.Duration);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td></td>\r\n                </tr>\r\n");
#nullable restore
#line 58 "C:\Users\Peter Parker\source\repos\HealthInsurenceSystem\HealthInsurenceSystem\Views\Policies\Index.cshtml"


                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 63 "C:\Users\Peter Parker\source\repos\HealthInsurenceSystem\HealthInsurenceSystem\Views\Policies\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p> No new Policy exists</p>\r\n");
#nullable restore
#line 67 "C:\Users\Peter Parker\source\repos\HealthInsurenceSystem\HealthInsurenceSystem\Views\Policies\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HealthInsurenceSystem.Models.Policy>> Html { get; private set; }
    }
}
#pragma warning restore 1591
