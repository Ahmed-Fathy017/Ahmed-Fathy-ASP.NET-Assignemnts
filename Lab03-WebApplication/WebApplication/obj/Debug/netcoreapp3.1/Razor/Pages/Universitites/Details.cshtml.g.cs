#pragma checksum "F:\ITI Courses\Asp.net\Day03\Lab\WebApplication\WebApplication\Pages\Universitites\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a6f4a85492b33da768f2a00315938259ea43ff2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebApplication.Pages.Universitites.Pages_Universitites_Details), @"mvc.1.0.razor-page", @"/Pages/Universitites/Details.cshtml")]
namespace WebApplication.Pages.Universitites
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
#line 1 "F:\ITI Courses\Asp.net\Day03\Lab\WebApplication\WebApplication\Pages\_ViewImports.cshtml"
using WebApplication;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a6f4a85492b33da768f2a00315938259ea43ff2", @"/Pages/Universitites/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed418d440d938fb6141a3a9470c71231e3c986f7", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Universitites_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Universitites/List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 6 "F:\ITI Courses\Asp.net\Day03\Lab\WebApplication\WebApplication\Pages\Universitites\Details.cshtml"
Write(Model.University.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Details</h1>\r\n\r\n\r\n<h3 class=\"font-weight-bold\">Name: ");
#nullable restore
#line 9 "F:\ITI Courses\Asp.net\Day03\Lab\WebApplication\WebApplication\Pages\Universitites\Details.cshtml"
                              Write(Model.University.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h3>\r\n<h3 class=\"font-weight-bold\">Address:  ");
#nullable restore
#line 10 "F:\ITI Courses\Asp.net\Day03\Lab\WebApplication\WebApplication\Pages\Universitites\Details.cshtml"
                                  Write(Model.University.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h3 class=\"font-weight-bold\">ID: ");
#nullable restore
#line 11 "F:\ITI Courses\Asp.net\Day03\Lab\WebApplication\WebApplication\Pages\Universitites\Details.cshtml"
                            Write(Model.University.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a6f4a85492b33da768f2a00315938259ea43ff24538", async() => {
                WriteLiteral("Back to the Univerisities list");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication.Pages.Universitites.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApplication.Pages.Universitites.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApplication.Pages.Universitites.DetailsModel>)PageContext?.ViewData;
        public WebApplication.Pages.Universitites.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
