#pragma checksum "C:\Users\MIT\Desktop\Recent\HIS\HealthInsurenceSystem\Views\Policy\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd641cb3d4960206ff6daa463bda8ee3c132df07"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Policy_Index), @"mvc.1.0.view", @"/Views/Policy/Index.cshtml")]
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
#nullable restore
#line 2 "C:\Users\MIT\Desktop\Recent\HIS\HealthInsurenceSystem\Views\Policy\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd641cb3d4960206ff6daa463bda8ee3c132df07", @"/Views/Policy/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2e2e8eff2f278ec56cd155b82857607914793b4", @"/Views/_ViewImports.cshtml")]
    public class Views_Policy_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HealthInsurenceSystem.Models.Customer>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Payment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PaymentPage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<div class=\"container p-3\">\r\n    <div class=\"row pt-4\">\r\n        <div class=\"col-6\">\r\n            <h2 class=\"text-primary\">Purchased Policy List</h2>\r\n        </div>\r\n    </div>\r\n\r\n    <br /><br />\r\n\r\n");
#nullable restore
#line 12 "C:\Users\MIT\Desktop\Recent\HIS\HealthInsurenceSystem\Views\Policy\Index.cshtml"
     if (Model.Count() > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table class=""table table-bordered table-striped"">
            <thead>
                <tr>
                    <th>
                        Policy Type
                    </th>
                    <th>
                        Policy number
                    </th>
                    <th>
                        Policy Purchased Name
                    </th>
                    <th>
                        Premium Amount
                    </th>
                    <th>
                        Last Payment Date
                    </th>
                    <th>
                        Remaining Payment Duration
                    </th>
                    <th>
                        Payment Status
                    </th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 41 "C:\Users\MIT\Desktop\Recent\HIS\HealthInsurenceSystem\Views\Policy\Index.cshtml"
                 foreach (var obj in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td width=\"50%\">");
#nullable restore
#line 44 "C:\Users\MIT\Desktop\Recent\HIS\HealthInsurenceSystem\Views\Policy\Index.cshtml"
                                   Write(obj.Ptype);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td width=\"30%\">");
#nullable restore
#line 45 "C:\Users\MIT\Desktop\Recent\HIS\HealthInsurenceSystem\Views\Policy\Index.cshtml"
                                   Write(obj.Pnumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td width=\"50%\">");
#nullable restore
#line 46 "C:\Users\MIT\Desktop\Recent\HIS\HealthInsurenceSystem\Views\Policy\Index.cshtml"
                                   Write(obj.Purchaseddate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td width=\"30%\">");
#nullable restore
#line 47 "C:\Users\MIT\Desktop\Recent\HIS\HealthInsurenceSystem\Views\Policy\Index.cshtml"
                                   Write(obj.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td width=\"50%\">");
#nullable restore
#line 48 "C:\Users\MIT\Desktop\Recent\HIS\HealthInsurenceSystem\Views\Policy\Index.cshtml"
                                   Write(obj.Lastpayment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td width=\"30%\">");
#nullable restore
#line 49 "C:\Users\MIT\Desktop\Recent\HIS\HealthInsurenceSystem\Views\Policy\Index.cshtml"
                                   Write(obj.Duration);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n");
#nullable restore
#line 51 "C:\Users\MIT\Desktop\Recent\HIS\HealthInsurenceSystem\Views\Policy\Index.cshtml"
                             if (obj.Lastpayment == null)
                            {
                                DateTime pd = (DateTime)obj.Purchaseddate;
                                DateTime now = DateTime.Today;
                                int p = obj.Amount*(now.Month - pd.Month);
                                Context.Session.SetString("Amount", p.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("                                 ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd641cb3d4960206ff6daa463bda8ee3c132df078322", async() => {
                WriteLiteral(" Pay Now");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 58 "C:\Users\MIT\Desktop\Recent\HIS\HealthInsurenceSystem\Views\Policy\Index.cshtml"
                            }
                            else
                            {
                                DateTime now = DateTime.Today;
                                DateTime lp = (DateTime)obj.Lastpayment;
                                if (now.Month - lp.Month > 0)
                                {
                                    int p = obj.Amount * (now.Month - lp.Month);
                                    Context.Session.SetString("Amount", p.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("                                 ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd641cb3d4960206ff6daa463bda8ee3c132df0710495", async() => {
                WriteLiteral(" Pay Now ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 68 "C:\Users\MIT\Desktop\Recent\HIS\HealthInsurenceSystem\Views\Policy\Index.cshtml"
                                }
                               else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <a> Paid </a>\r\n");
#nullable restore
#line 72 "C:\Users\MIT\Desktop\Recent\HIS\HealthInsurenceSystem\Views\Policy\Index.cshtml"
                                }

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 77 "C:\Users\MIT\Desktop\Recent\HIS\HealthInsurenceSystem\Views\Policy\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 80 "C:\Users\MIT\Desktop\Recent\HIS\HealthInsurenceSystem\Views\Policy\Index.cshtml"
            }
            else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p> Buy New Policy.</p>\r\n");
#nullable restore
#line 84 "C:\Users\MIT\Desktop\Recent\HIS\HealthInsurenceSystem\Views\Policy\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HealthInsurenceSystem.Models.Customer>> Html { get; private set; }
    }
}
#pragma warning restore 1591
