#pragma checksum "C:\Users\refer\OneDrive\Desktop\New folder\webclient\WebClients\Views\Clients\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5444ff37b50573a8169809a48f749e94575de144"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clients_Details), @"mvc.1.0.view", @"/Views/Clients/Details.cshtml")]
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
#line 1 "C:\Users\refer\OneDrive\Desktop\New folder\webclient\WebClients\Views\_ViewImports.cshtml"
using WebClients;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\refer\OneDrive\Desktop\New folder\webclient\WebClients\Views\_ViewImports.cshtml"
using WebClients.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5444ff37b50573a8169809a48f749e94575de144", @"/Views/Clients/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68d71ac812415effd247b2c9b1762fa296c0d2d8", @"/Views/_ViewImports.cshtml")]
    public class Views_Clients_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebClients.Models.Client>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\refer\OneDrive\Desktop\New folder\webclient\WebClients\Views\Clients\Details.cshtml"
  
	ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Details</h1>\n\n<div>\n\t<h4>Client</h4>\n\t<hr />\n\t<dl class=\"row\">\n\t\t<dt class=\"col-sm-2\">\n\t\t\t");
#nullable restore
#line 14 "C:\Users\refer\OneDrive\Desktop\New folder\webclient\WebClients\Views\Clients\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\t\t</dt>\n\t\t<dd class=\"col-sm-10\">\n\t\t\t");
#nullable restore
#line 17 "C:\Users\refer\OneDrive\Desktop\New folder\webclient\WebClients\Views\Clients\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\t\t</dd>\n\t\t<dt class=\"col-sm-2\">\n\t\t\t");
#nullable restore
#line 20 "C:\Users\refer\OneDrive\Desktop\New folder\webclient\WebClients\Views\Clients\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\t\t</dt>\n\t\t<dd class=\"col-sm-10\">\n\t\t\t");
#nullable restore
#line 23 "C:\Users\refer\OneDrive\Desktop\New folder\webclient\WebClients\Views\Clients\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\t\t</dd>\n\t\t<dt class=\"col-sm-2\">\n\t\t\t");
#nullable restore
#line 26 "C:\Users\refer\OneDrive\Desktop\New folder\webclient\WebClients\Views\Clients\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\t\t</dt>\n\t\t<dd class=\"col-sm-10\">\n\t\t\t");
#nullable restore
#line 29 "C:\Users\refer\OneDrive\Desktop\New folder\webclient\WebClients\Views\Clients\Details.cshtml"
       Write(Html.DisplayFor(model => model.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\t\t</dd>\n\t</dl>\n</div>\n<h3>Addresses</h3>\n\n");
#nullable restore
#line 35 "C:\Users\refer\OneDrive\Desktop\New folder\webclient\WebClients\Views\Clients\Details.cshtml"
 if (ViewBag.addresses != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<table class=\"table\">\n\t\t<thead>\n\t\t\t<tr>\n\t\t\t\t<th>\n\t\t\t\t\tStreet\n\t\t\t\t</th>\n\t\t\t\t<th>\n\t\t\t\t\tNumber\n\t\t\t\t</th>\n\t\t\t\t<th>\n\t\t\t\t\tCity\n\t\t\t\t</th>\n\t\t\t\t<th>\n\t\t\t\t\tState\n\t\t\t\t</th>\n\t\t\t\t<th>\n\t\t\t\t\tCountry\n\t\t\t\t</th>\n\t\t\t\t<th></th>\n\t\t\t</tr>\n\t\t</thead>\n\t\t<tbody>\n");
#nullable restore
#line 59 "C:\Users\refer\OneDrive\Desktop\New folder\webclient\WebClients\Views\Clients\Details.cshtml"
             foreach (var item in ViewBag.addresses)
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<tr>\n\t\t\t\t\t<td>\n\t\t\t\t\t\t");
#nullable restore
#line 63 "C:\Users\refer\OneDrive\Desktop\New folder\webclient\WebClients\Views\Clients\Details.cshtml"
                   Write(item.Street);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\t\t\t\t\t</td>\n\t\t\t\t\t<td>\n\t\t\t\t\t\t");
#nullable restore
#line 66 "C:\Users\refer\OneDrive\Desktop\New folder\webclient\WebClients\Views\Clients\Details.cshtml"
                   Write(item.Number);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\t\t\t\t\t</td>\n\t\t\t\t\t<td>\n\t\t\t\t\t\t");
#nullable restore
#line 69 "C:\Users\refer\OneDrive\Desktop\New folder\webclient\WebClients\Views\Clients\Details.cshtml"
                   Write(item.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\t\t\t\t\t</td>\n\t\t\t\t\t<td>\n\t\t\t\t\t\t");
#nullable restore
#line 72 "C:\Users\refer\OneDrive\Desktop\New folder\webclient\WebClients\Views\Clients\Details.cshtml"
                   Write(item.State);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\t\t\t\t\t</td>\n\t\t\t\t\t<td>\n\t\t\t\t\t\t");
#nullable restore
#line 75 "C:\Users\refer\OneDrive\Desktop\New folder\webclient\WebClients\Views\Clients\Details.cshtml"
                   Write(item.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\t\t\t\t\t</td>\n\t\t\t\t\t<td>\n\t\t\t\t\t</td>\n\t\t\t\t</tr>\n");
#nullable restore
#line 80 "C:\Users\refer\OneDrive\Desktop\New folder\webclient\WebClients\Views\Clients\Details.cshtml"
			}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t</tbody>\n\t</table>\n");
#nullable restore
#line 83 "C:\Users\refer\OneDrive\Desktop\New folder\webclient\WebClients\Views\Clients\Details.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\n\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5444ff37b50573a8169809a48f749e94575de1448761", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 85 "C:\Users\refer\OneDrive\Desktop\New folder\webclient\WebClients\Views\Clients\Details.cshtml"
                           WriteLiteral(Model.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\n\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5444ff37b50573a8169809a48f749e94575de14410912", async() => {
                WriteLiteral("Back to List");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebClients.Models.Client> Html { get; private set; }
    }
}
#pragma warning restore 1591