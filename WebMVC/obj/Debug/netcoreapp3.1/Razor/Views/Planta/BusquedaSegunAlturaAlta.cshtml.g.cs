#pragma checksum "C:\Users\Cardozo\Desktop\ATI\3 Semestre\Programacion 3\Obligatorio\ObligatorioP3Parte2\ObligatorioP3Parte2\WebMVC\Views\Planta\BusquedaSegunAlturaAlta.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74e4de2846dee0a152a3ddff6406243ea2aeaaa0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Planta_BusquedaSegunAlturaAlta), @"mvc.1.0.view", @"/Views/Planta/BusquedaSegunAlturaAlta.cshtml")]
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
#line 1 "C:\Users\Cardozo\Desktop\ATI\3 Semestre\Programacion 3\Obligatorio\ObligatorioP3Parte2\ObligatorioP3Parte2\WebMVC\Views\_ViewImports.cshtml"
using WebMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Cardozo\Desktop\ATI\3 Semestre\Programacion 3\Obligatorio\ObligatorioP3Parte2\ObligatorioP3Parte2\WebMVC\Views\_ViewImports.cshtml"
using WebMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74e4de2846dee0a152a3ddff6406243ea2aeaaa0", @"/Views/Planta/BusquedaSegunAlturaAlta.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c99be47512cc6193cb06f7267f1effa7a0bdfb2b", @"/Views/_ViewImports.cshtml")]
    public class Views_Planta_BusquedaSegunAlturaAlta : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ObligatorioP3.EntidadesNegocio.Planta>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formulario"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Planta/BusquedaSegunAlturaAlta"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BusquedaSegunAlturaBaja", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Cardozo\Desktop\ATI\3 Semestre\Programacion 3\Obligatorio\ObligatorioP3Parte2\ObligatorioP3Parte2\WebMVC\Views\Planta\BusquedaSegunAlturaAlta.cshtml"
  
    ViewData["Title"] = "Búsqueda por Altura alta";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
#nullable restore
#line 8 "C:\Users\Cardozo\Desktop\ATI\3 Semestre\Programacion 3\Obligatorio\ObligatorioP3Parte2\ObligatorioP3Parte2\WebMVC\Views\Planta\BusquedaSegunAlturaAlta.cshtml"
 if (ViewBag.MensajeError != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\" role=\"alert\">\n        ");
#nullable restore
#line 11 "C:\Users\Cardozo\Desktop\ATI\3 Semestre\Programacion 3\Obligatorio\ObligatorioP3Parte2\ObligatorioP3Parte2\WebMVC\Views\Planta\BusquedaSegunAlturaAlta.cshtml"
   Write(ViewBag.MensajeError);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n");
#nullable restore
#line 13 "C:\Users\Cardozo\Desktop\ATI\3 Semestre\Programacion 3\Obligatorio\ObligatorioP3Parte2\ObligatorioP3Parte2\WebMVC\Views\Planta\BusquedaSegunAlturaAlta.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 15 "C:\Users\Cardozo\Desktop\ATI\3 Semestre\Programacion 3\Obligatorio\ObligatorioP3Parte2\ObligatorioP3Parte2\WebMVC\Views\Planta\BusquedaSegunAlturaAlta.cshtml"
 if (ViewBag.ok != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success\" role=\"alert\">\n        ");
#nullable restore
#line 18 "C:\Users\Cardozo\Desktop\ATI\3 Semestre\Programacion 3\Obligatorio\ObligatorioP3Parte2\ObligatorioP3Parte2\WebMVC\Views\Planta\BusquedaSegunAlturaAlta.cshtml"
   Write(ViewBag.ok);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n");
#nullable restore
#line 20 "C:\Users\Cardozo\Desktop\ATI\3 Semestre\Programacion 3\Obligatorio\ObligatorioP3Parte2\ObligatorioP3Parte2\WebMVC\Views\Planta\BusquedaSegunAlturaAlta.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<h1>Búsqueda por Altura de Planta</h1>\n<br />\n<p><strong>Inserte una altura y se desplegarán todas las plantas de mayor o igual medida</strong></p>\n<hr />\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74e4de2846dee0a152a3ddff6406243ea2aeaaa07668", async() => {
                WriteLiteral("\n\n    <div class=\"mb-3\">\n        <label for=\"f2\" class=\"form-label\">Altura de la planta</label>\n        <input type=\"number\" class=\"form-control\" id=\"altura\" name=\"altura\"");
                BeginWriteAttribute("value", " value=\"", 754, "\"", 777, 1);
#nullable restore
#line 32 "C:\Users\Cardozo\Desktop\ATI\3 Semestre\Programacion 3\Obligatorio\ObligatorioP3Parte2\ObligatorioP3Parte2\WebMVC\Views\Planta\BusquedaSegunAlturaAlta.cshtml"
WriteAttributeValue("", 762, ViewBag.Altura, 762, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Ingrese la altura en centímetros\" required>\n    </div>\n\n    <div class=\"col-12\">\n        <button type=\"submit\" class=\"btn btn-primary\">Buscar</button>\n    </div>\n\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n<br />\n\n<div>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74e4de2846dee0a152a3ddff6406243ea2aeaaa010115", async() => {
                WriteLiteral("Búsqueda por Altura Baja");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n<br />\n\n<div>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74e4de2846dee0a152a3ddff6406243ea2aeaaa011316", async() => {
                WriteLiteral("Volver al Listado");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ObligatorioP3.EntidadesNegocio.Planta> Html { get; private set; }
    }
}
#pragma warning restore 1591
