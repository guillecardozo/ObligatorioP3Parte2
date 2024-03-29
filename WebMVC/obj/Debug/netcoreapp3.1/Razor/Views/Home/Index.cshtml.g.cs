#pragma checksum "C:\Users\Cardozo\Desktop\ATI\3 Semestre\Programacion 3\Obligatorio\ObligatorioP3Parte2\ObligatorioP3Parte2\WebMVC\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2bb0b4d057893e31f98df3c2db10b1084ed271e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2bb0b4d057893e31f98df3c2db10b1084ed271e5", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c99be47512cc6193cb06f7267f1effa7a0bdfb2b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Cardozo\Desktop\ATI\3 Semestre\Programacion 3\Obligatorio\ObligatorioP3Parte2\ObligatorioP3Parte2\WebMVC\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<header>\n\n    <div class=\"text-center\">\n\n        <h1>BIENVENIDOS</h1>\n    </div>\n\n</header>\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2bb0b4d057893e31f98df3c2db10b1084ed271e53596", async() => {
                WriteLiteral(@"

    <div class=""row"">

        <div class=""col-3 text-center rounded "">
            <a href=""/Planta/Index""> <img src=""/Img/LogoTodasLasPlantas.jpg"" height=""150"" /> </a>
            <p>Todas las Plantas</p>
        </div>

        <div class=""col-3 text-center rounded "">
            <a href=""/FichaCuidados/Index""> <img src=""/Img/LogoCuidados.jpg"" height=""150"" /> </a>
            <p>Sección Fichas de Cuidados</p>
        </div>

        <div class=""col-3 text-center rounded "">
            <a href=""/Planta/Create""> <img src=""/Img/LogoIngresarPlanta.png"" height=""150"" /> </a>
            <p>Registrar una Planta</p>
        </div>

        <div class=""col-3 text-center rounded "">
            <a href=""/TipoPlanta/Index""> <img src=""/Img/LogoUnaPlanta.jpg"" height=""150"" /> </a>
            <p>Sección Tipos de Plantas</p>
        </div>
    </div>

    <hr />
    <h2 class=""text-center"">Búsquedas</h2>

    <div class=""row"">

        <div class="" text-center rounded col-2"">
            <a href=""/Planta/BusquedaPorNomb");
                WriteLiteral(@"re""> <img src=""/Img/LogoBusqueda.jpg"" height=""150"" /> </a>
            <p>Búsqueda por Nombre</p>
        </div>

        <div class="" text-center rounded col-2"">

            <a href=""/Planta/BusquedaSegunAlturaAlta""> <img src=""/Img/LogoBusqueda.jpg"" height=""150"" /> </a>
            <p>Búsqueda por Altura Alta</p>
        </div>

        <div class=""text-center rounded col-2"">

            <a href=""/Planta/BusquedaSegunAmbiente""> <img src=""/Img/LogoBusqueda.jpg"" height=""150"" /> </a>
            <p>Búsqueda por Ambiente</p>
        </div>

        <div class=""text-center rounded col-2"">
            <a href=""/Planta/BusquedaSegunTipoDePlanta""> <img src=""/Img/LogoBusqueda.jpg"" height=""150"" /> </a>
            <p>Búsqueda por Tipo</p>
        </div>

        <div class=""text-center rounded col-2"">

            <a href=""/TipoPlanta/BusquedaPorTipoNombre""> <img src=""/Img/LogoBusqueda.jpg"" height=""150"" /> </a>
            <p>Búsqueda por Nombre de Tipo Planta</p>
        </div>

        <div class=""text-center roun");
                WriteLiteral("ded col-2\">\n            <a href=\"/Planta/BusquedaSegunAlturaBaja\"> <img src=\"/Img/LogoBusqueda.jpg\" height=\"150\" /> </a>\n            <p>Búsqueda por Altura Baja</p>\n        </div>\n    </div>\n");
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
            WriteLiteral("\n");
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
