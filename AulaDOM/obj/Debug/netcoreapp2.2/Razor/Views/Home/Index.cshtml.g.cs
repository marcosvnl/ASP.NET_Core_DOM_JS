#pragma checksum "C:\Programacao\CSharp\Estudos C# - .NET\Tudo que você deve saber para ser um desenvolvedor C# Web\Parte - 2 Java script\AulaDOM\AulaDOM\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f7a342a47010307ddbe727806eb215a9aa42517"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Programacao\CSharp\Estudos C# - .NET\Tudo que você deve saber para ser um desenvolvedor C# Web\Parte - 2 Java script\AulaDOM\AulaDOM\Views\_ViewImports.cshtml"
using AulaDOM;

#line default
#line hidden
#line 2 "C:\Programacao\CSharp\Estudos C# - .NET\Tudo que você deve saber para ser um desenvolvedor C# Web\Parte - 2 Java script\AulaDOM\AulaDOM\Views\_ViewImports.cshtml"
using AulaDOM.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f7a342a47010307ddbe727806eb215a9aa42517", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"163bf7fceee65d66addb524d32054de6e0eb542b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/numerosCampo.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Programacao\CSharp\Estudos C# - .NET\Tudo que você deve saber para ser um desenvolvedor C# Web\Parte - 2 Java script\AulaDOM\AulaDOM\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 143, true);
            WriteLiteral("<!--DOM - Hieraquia de paginas\r\n    onkeypress verifica se alguma tecla esta sendo precionada\r\n    onkeyup é o evento quando solta a tecla-->\r\n");
            EndContext();
            BeginContext(188, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f7a342a47010307ddbe727806eb215a9aa425174182", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(232, 1587, true);
            WriteLiteral(@"
<div class=""container"">
    <div class=""col-md-4"">
        <div class=""form-group"">
            <label class=""control-label"">Só números DOM</label>
            <input class=""form-control"" maxlength=""14"" onkeypress=""return Enum(event);""
                   onfocus=""ChangeColorFocus(this, event);"" onblur=""ChangeColorFocus(this, event);"" />
        </div>
    </div>
    <div class=""col-md-4"">
        <div class=""form-group"">
            <label class=""control-label"">CPF DOM</label>
            <input class=""form-control"" maxlength=""14"" onkeypress=""return Enum(event);""
                   onkeyup=""MascaraCPF(this, event);""
                   onfocus=""ChangeColorFocus(this, event);"" onblur=""ChangeColorFocus(this, event);"" />
        </div>
    </div>
    <div class=""col-md-4"">
        <div class=""form-group"">
            <label class=""control-label"">Telefone DOM</label>
            <input class=""form-control"" maxlength=""13"" onkeypress=""return Enum(event);""
                   onkeyup=""MascaraTele");
            WriteLiteral(@"fone(this, event);""
                   onfocus=""ChangeColorFocus(this, event);"" onblur=""ChangeColorFocus(this, event);"" />
        </div>
    </div>
    <div class=""col-md-4"">
        <div class=""form-group"">
            <label class=""control-label"">Celular DOM</label>
            <input class=""form-control"" maxlength=""14"" onkeypress=""return Enum(event);""
                   onkeyup=""MascaraCelular(this, event);""
                   onfocus=""ChangeColorFocus(this, event);"" onblur=""ChangeColorFocus(this, event);"" />
        </div>
    </div>
</div>");
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
