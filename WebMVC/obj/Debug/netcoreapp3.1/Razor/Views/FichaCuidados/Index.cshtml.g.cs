#pragma checksum "C:\Users\Cardozo\Desktop\ATI\3 Semestre\Programacion 3\Obligatorio\ObligatorioP3Parte2\ObligatorioP3Parte2\WebMVC\Views\FichaCuidados\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80cad3499ce76fbafc5f25e32bfd926932352e6c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FichaCuidados_Index), @"mvc.1.0.view", @"/Views/FichaCuidados/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80cad3499ce76fbafc5f25e32bfd926932352e6c", @"/Views/FichaCuidados/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c99be47512cc6193cb06f7267f1effa7a0bdfb2b", @"/Views/_ViewImports.cshtml")]
    public class Views_FichaCuidados_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ObligatorioP3.EntidadesNegocio.FichaCuidados>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Cardozo\Desktop\ATI\3 Semestre\Programacion 3\Obligatorio\ObligatorioP3Parte2\ObligatorioP3Parte2\WebMVC\Views\FichaCuidados\Index.cshtml"
  
    ViewData["Title"] = "Lista Tipos de Plantas";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
#nullable restore
#line 8 "C:\Users\Cardozo\Desktop\ATI\3 Semestre\Programacion 3\Obligatorio\ObligatorioP3Parte2\ObligatorioP3Parte2\WebMVC\Views\FichaCuidados\Index.cshtml"
 if (ViewBag.ok != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success\" role=\"alert\">\n        ");
#nullable restore
#line 11 "C:\Users\Cardozo\Desktop\ATI\3 Semestre\Programacion 3\Obligatorio\ObligatorioP3Parte2\ObligatorioP3Parte2\WebMVC\Views\FichaCuidados\Index.cshtml"
   Write(ViewBag.ok);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n");
#nullable restore
#line 13 "C:\Users\Cardozo\Desktop\ATI\3 Semestre\Programacion 3\Obligatorio\ObligatorioP3Parte2\ObligatorioP3Parte2\WebMVC\Views\FichaCuidados\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Fichas de Cuidados</h1>\n\n<p>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80cad3499ce76fbafc5f25e32bfd926932352e6c4890", async() => {
                WriteLiteral(@"
        <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-plus-circle"" viewBox=""0 0 16 16"">
            <path d=""M8 15A7 7 0 1 1 8 1a7 7 0 0 1 0 14zm0 1A8 8 0 1 0 8 0a8 8 0 0 0 0 16z"" />
            <path d=""M8 4a.5.5 0 0 1 .5.5v3h3a.5.5 0 0 1 0 1h-3v3a.5.5 0 0 1-1 0v-3h-3a.5.5 0 0 1 0-1h3v-3A.5.5 0 0 1 8 4z"" />
        </svg> Agregar Nueva Ficha
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</p>\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
#nullable restore
#line 29 "C:\Users\Cardozo\Desktop\ATI\3 Semestre\Programacion 3\Obligatorio\ObligatorioP3Parte2\ObligatorioP3Parte2\WebMVC\Views\FichaCuidados\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FrecuenciaRiego));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n\n            <th>\n                ");
#nullable restore
#line 33 "C:\Users\Cardozo\Desktop\ATI\3 Semestre\Programacion 3\Obligatorio\ObligatorioP3Parte2\ObligatorioP3Parte2\WebMVC\Views\FichaCuidados\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TipoIluminacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n\n            <th>\n                ");
#nullable restore
#line 37 "C:\Users\Cardozo\Desktop\ATI\3 Semestre\Programacion 3\Obligatorio\ObligatorioP3Parte2\ObligatorioP3Parte2\WebMVC\Views\FichaCuidados\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Temperatura));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 44 "C:\Users\Cardozo\Desktop\ATI\3 Semestre\Programacion 3\Obligatorio\ObligatorioP3Parte2\ObligatorioP3Parte2\WebMVC\Views\FichaCuidados\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n\n                <td>\n                    ");
#nullable restore
#line 49 "C:\Users\Cardozo\Desktop\ATI\3 Semestre\Programacion 3\Obligatorio\ObligatorioP3Parte2\ObligatorioP3Parte2\WebMVC\Views\FichaCuidados\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.FrecuenciaRiego));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 52 "C:\Users\Cardozo\Desktop\ATI\3 Semestre\Programacion 3\Obligatorio\ObligatorioP3Parte2\ObligatorioP3Parte2\WebMVC\Views\FichaCuidados\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.TipoIluminacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 55 "C:\Users\Cardozo\Desktop\ATI\3 Semestre\Programacion 3\Obligatorio\ObligatorioP3Parte2\ObligatorioP3Parte2\WebMVC\Views\FichaCuidados\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Temperatura));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 58 "C:\Users\Cardozo\Desktop\ATI\3 Semestre\Programacion 3\Obligatorio\ObligatorioP3Parte2\ObligatorioP3Parte2\WebMVC\Views\FichaCuidados\Index.cshtml"
               Write(Html.ActionLink("Eliminar", "Delete", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n            </tr>\n");
#nullable restore
#line 61 "C:\Users\Cardozo\Desktop\ATI\3 Semestre\Programacion 3\Obligatorio\ObligatorioP3Parte2\ObligatorioP3Parte2\WebMVC\Views\FichaCuidados\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n    </tbody>\n</table>\n        \n<div class=\"col-12\">\n    <a href=\"/Planta/Create\">Registrar una Planta</a>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ObligatorioP3.EntidadesNegocio.FichaCuidados>> Html { get; private set; }
    }
}
#pragma warning restore 1591
