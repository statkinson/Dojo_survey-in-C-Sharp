#pragma checksum "C:\Users\steph\Google Drive\Coding Dojo\Projects\C#_Stack\asp_net_core_part2_projects\dojo_survey\Views\Home\results.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83f00f2e99831d747907e9dc81145bc8359a0421"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(dojo_survey.Home.Views_Home_results), @"mvc.1.0.view", @"/Views/Home/results.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/results.cshtml", typeof(dojo_survey.Home.Views_Home_results))]
namespace dojo_survey.Home
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 3 "C:\Users\steph\Google Drive\Coding Dojo\Projects\C#_Stack\asp_net_core_part2_projects\dojo_survey\Views\_ViewImports.cshtml"
using dojo_survey.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83f00f2e99831d747907e9dc81145bc8359a0421", @"/Views/Home/results.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ad67b165510b9b53a887f5d0d30c10c8882af36", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_results : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 35, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(35, 423, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83f00f2e99831d747907e9dc81145bc8359a04213329", async() => {
                BeginContext(41, 410, true);
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"">
    <title>Results</title>
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"" integrity=""sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T"" crossorigin=""anonymous"">
");
                EndContext();
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
            EndContext();
            BeginContext(458, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(473, 350, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83f00f2e99831d747907e9dc81145bc8359a04214936", async() => {
                BeginContext(479, 86, true);
                WriteLiteral("\r\n    <div class=\"container mt-5\">\r\n        <h3>Survey Results</h3>\r\n        <p>Name: ");
                EndContext();
                BeginContext(566, 15, false);
#line 14 "C:\Users\steph\Google Drive\Coding Dojo\Projects\C#_Stack\asp_net_core_part2_projects\dojo_survey\Views\Home\results.cshtml"
            Write(Model.nameField);

#line default
#line hidden
                EndContext();
                BeginContext(581, 23, true);
                WriteLiteral("</p>\r\n        <p>Dojo: ");
                EndContext();
                BeginContext(605, 20, false);
#line 15 "C:\Users\steph\Google Drive\Coding Dojo\Projects\C#_Stack\asp_net_core_part2_projects\dojo_survey\Views\Home\results.cshtml"
            Write(Model.selectLocation);

#line default
#line hidden
                EndContext();
                BeginContext(625, 27, true);
                WriteLiteral("</p>\r\n        <p>Language: ");
                EndContext();
                BeginContext(653, 19, false);
#line 16 "C:\Users\steph\Google Drive\Coding Dojo\Projects\C#_Stack\asp_net_core_part2_projects\dojo_survey\Views\Home\results.cshtml"
                Write(Model.favorLanguage);

#line default
#line hidden
                EndContext();
                BeginContext(672, 27, true);
                WriteLiteral(" </p>\r\n        <p>Comment: ");
                EndContext();
                BeginContext(700, 18, false);
#line 17 "C:\Users\steph\Google Drive\Coding Dojo\Projects\C#_Stack\asp_net_core_part2_projects\dojo_survey\Views\Home\results.cshtml"
               Write(Model.commentField);

#line default
#line hidden
                EndContext();
                BeginContext(718, 98, true);
                WriteLiteral("</p>\r\n        <br><br>\r\n        <a href=\"/\" class=\"btn btn-primary my-2\">Go back</a>\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(823, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591
