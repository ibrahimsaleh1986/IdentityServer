#pragma checksum "D:\GitHub\IdentityServer-WebApp\IdentityServer\Views\Grants\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4b804845269353674b8cbe23b5a5bdc82f5b353"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Grants_Index), @"mvc.1.0.view", @"/Views/Grants/Index.cshtml")]
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
#line 1 "D:\GitHub\IdentityServer-WebApp\IdentityServer\Views\_ViewImports.cshtml"
using identityserver;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4b804845269353674b8cbe23b5a5bdc82f5b353", @"/Views/Grants/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6b328728112fcfcd8b2c4f58d0300ec824b44e7", @"/Views/_ViewImports.cshtml")]
    public class Views_Grants_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GrantsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Revoke", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""grants"">
    <div class=""row page-header"">
        <div class=""col-sm-10"">
            <h1>
                Client Application Access
            </h1>
            <div>Below is the list of applications you have given access to and the names of the resources they have access to.</div>
        </div>
    </div>

");
#nullable restore
#line 13 "D:\GitHub\IdentityServer-WebApp\IdentityServer\Views\Grants\Index.cshtml"
     if (Model.Grants.Any() == false)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\n            <div class=\"col-sm-8\">\n                <div class=\"alert alert-info\">\n                    You have not given access to any applications\n                </div>\n            </div>\n        </div>\n");
#nullable restore
#line 22 "D:\GitHub\IdentityServer-WebApp\IdentityServer\Views\Grants\Index.cshtml"
    }
    else
    {
        foreach (var grant in Model.Grants)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row grant\">\n                <div class=\"col-sm-2\">\n");
#nullable restore
#line 29 "D:\GitHub\IdentityServer-WebApp\IdentityServer\Views\Grants\Index.cshtml"
                     if (grant.ClientLogoUrl != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <img");
            BeginWriteAttribute("src", " src=\"", 878, "\"", 904, 1);
#nullable restore
#line 31 "D:\GitHub\IdentityServer-WebApp\IdentityServer\Views\Grants\Index.cshtml"
WriteAttributeValue("", 884, grant.ClientLogoUrl, 884, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n");
#nullable restore
#line 32 "D:\GitHub\IdentityServer-WebApp\IdentityServer\Views\Grants\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\n                <div class=\"col-sm-8\">\n                    <div class=\"clientname\">");
#nullable restore
#line 35 "D:\GitHub\IdentityServer-WebApp\IdentityServer\Views\Grants\Index.cshtml"
                                       Write(grant.ClientName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                    <div>\n                        <span class=\"created\">Created:</span> ");
#nullable restore
#line 37 "D:\GitHub\IdentityServer-WebApp\IdentityServer\Views\Grants\Index.cshtml"
                                                         Write(grant.Created.ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </div>\n");
#nullable restore
#line 39 "D:\GitHub\IdentityServer-WebApp\IdentityServer\Views\Grants\Index.cshtml"
                     if (grant.Expires.HasValue)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div>\n                            <span class=\"expires\">Expires:</span> ");
#nullable restore
#line 42 "D:\GitHub\IdentityServer-WebApp\IdentityServer\Views\Grants\Index.cshtml"
                                                             Write(grant.Expires.Value.ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </div>\n");
#nullable restore
#line 44 "D:\GitHub\IdentityServer-WebApp\IdentityServer\Views\Grants\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "D:\GitHub\IdentityServer-WebApp\IdentityServer\Views\Grants\Index.cshtml"
                     if (grant.IdentityGrantNames.Any())
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div>\n                            <div class=\"granttype\">Identity Grants</div>\n                            <ul>\n");
#nullable restore
#line 50 "D:\GitHub\IdentityServer-WebApp\IdentityServer\Views\Grants\Index.cshtml"
                                 foreach (var name in grant.IdentityGrantNames)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li>");
#nullable restore
#line 52 "D:\GitHub\IdentityServer-WebApp\IdentityServer\Views\Grants\Index.cshtml"
                                   Write(name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 53 "D:\GitHub\IdentityServer-WebApp\IdentityServer\Views\Grants\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </ul>\n                        </div>\n");
#nullable restore
#line 56 "D:\GitHub\IdentityServer-WebApp\IdentityServer\Views\Grants\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "D:\GitHub\IdentityServer-WebApp\IdentityServer\Views\Grants\Index.cshtml"
                     if (grant.ApiGrantNames.Any())
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div>\n                            <div class=\"granttype\">API Grants</div>\n                            <ul>\n");
#nullable restore
#line 62 "D:\GitHub\IdentityServer-WebApp\IdentityServer\Views\Grants\Index.cshtml"
                                 foreach (var name in grant.ApiGrantNames)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li>");
#nullable restore
#line 64 "D:\GitHub\IdentityServer-WebApp\IdentityServer\Views\Grants\Index.cshtml"
                                   Write(name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 65 "D:\GitHub\IdentityServer-WebApp\IdentityServer\Views\Grants\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </ul>\n                        </div>\n");
#nullable restore
#line 68 "D:\GitHub\IdentityServer-WebApp\IdentityServer\Views\Grants\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\n                <div class=\"col-sm-2\">\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4b804845269353674b8cbe23b5a5bdc82f5b3539964", async() => {
                WriteLiteral("\n                        <input type=\"hidden\" name=\"clientId\"");
                BeginWriteAttribute("value", " value=\"", 2624, "\"", 2647, 1);
#nullable restore
#line 72 "D:\GitHub\IdentityServer-WebApp\IdentityServer\Views\Grants\Index.cshtml"
WriteAttributeValue("", 2632, grant.ClientId, 2632, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                        <button class=\"btn btn-danger\">Revoke Access</button>\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </div>\n            </div>\n");
#nullable restore
#line 77 "D:\GitHub\IdentityServer-WebApp\IdentityServer\Views\Grants\Index.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GrantsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
