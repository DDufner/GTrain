#pragma checksum "C:\Users\Dominick\source\repos3\GTrain\Views\Login\Trainee.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "884f4e702771177caa2325a892c52a0009c0e742"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Trainee), @"mvc.1.0.view", @"/Views/Login/Trainee.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Login/Trainee.cshtml", typeof(AspNetCore.Views_Login_Trainee))]
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
#line 1 "C:\Users\Dominick\source\repos3\GTrain\Views\_ViewImports.cshtml"
using GTrain;

#line default
#line hidden
#line 2 "C:\Users\Dominick\source\repos3\GTrain\Views\_ViewImports.cshtml"
using GTrain.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"884f4e702771177caa2325a892c52a0009c0e742", @"/Views/Login/Trainee.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b33f08bab36f2df692bb3696aff6b1521f139955", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_Trainee : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GTrain.ViewModels.LoginViewModel>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Dominick\source\repos3\GTrain\Views\Login\Trainee.cshtml"
  
    ViewData["Title"] = "Trainee";

#line default
#line hidden
            BeginContext(86, 157, true);
            WriteLiteral("\r\n<h1>Trainee</h1>\r\n\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\"><b>Trainee Login</b></h1>\r\n</div>\r\n<!--for tags below may need to be adjusted-->\r\n");
            EndContext();
            BeginContext(243, 684, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "884f4e702771177caa2325a892c52a0009c0e7423734", async() => {
                BeginContext(249, 671, true);
                WriteLiteral(@"
    <div class=""container"">
        <label for=""UserName""><b>User Name</b></label>
        <input type=""text"" placeholder=""Enter Username"" name=""UserName"" required>

        <label for=""psw""><b>Password</b></label>
        <input type=""password"" placeholder=""Enter Password"" name=""psw"" required>

        <button type=""submit"">Login</button>
        <label>
            <input type=""radio"" name=""remember""> Remember me!
        </label>
    </div>

    <div class=""container"" style=""background-color:#f1f1f1"">
        <button type=""button"" class=""cancelbtn"">Cancel</button>
        <span class=""psw""> <a href=""#"">Forgot password?</a></span>
    </div>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(927, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GTrain.ViewModels.LoginViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591