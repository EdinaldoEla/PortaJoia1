#pragma checksum "F:\Edinaldo\CursoInformática_Senac\Módulo_2\UC08 - Projeto Integrador II\PI-II-Etapa6\Views\Produto\Listagem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24b179d1ff38cf04f677c0ba14a20595abb9a3ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Listagem), @"mvc.1.0.view", @"/Views/Produto/Listagem.cshtml")]
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
#line 1 "F:\Edinaldo\CursoInformática_Senac\Módulo_2\UC08 - Projeto Integrador II\PI-II-Etapa6\Views\_ViewImports.cshtml"
using Atv_4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Edinaldo\CursoInformática_Senac\Módulo_2\UC08 - Projeto Integrador II\PI-II-Etapa6\Views\_ViewImports.cshtml"
using Atv_4.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24b179d1ff38cf04f677c0ba14a20595abb9a3ca", @"/Views/Produto/Listagem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67c92274be6482569944b3c77a973621760cca79", @"/Views/_ViewImports.cshtml")]
    public class Views_Produto_Listagem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Produto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\Edinaldo\CursoInformática_Senac\Módulo_2\UC08 - Projeto Integrador II\PI-II-Etapa6\Views\Produto\Listagem.cshtml"
  
    ViewData["Title"] = "Listagem de Produtos Porta Jóia";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2 class=""text-center"" id=""h2-1"">Conheça nossos Protudos</h2>
<!--<table class=""table table-success table-striped-columns"">-->
<table class=""table table-striped""> 
    <thead>
        <tr>
            <th>CÓDIGO</th>
            <th>PRODUTO</th>
            <th>UNIDADE</th>
            <th>ESTOQUE</th>
            <th>PREÇO</th>
        </tr>
    </thead>
    <tbody>

");
#nullable restore
#line 21 "F:\Edinaldo\CursoInformática_Senac\Módulo_2\UC08 - Projeto Integrador II\PI-II-Etapa6\Views\Produto\Listagem.cshtml"
         foreach (Produto p in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 24 "F:\Edinaldo\CursoInformática_Senac\Módulo_2\UC08 - Projeto Integrador II\PI-II-Etapa6\Views\Produto\Listagem.cshtml"
               Write(p.IdProduto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "F:\Edinaldo\CursoInformática_Senac\Módulo_2\UC08 - Projeto Integrador II\PI-II-Etapa6\Views\Produto\Listagem.cshtml"
               Write(p.NomeProduto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "F:\Edinaldo\CursoInformática_Senac\Módulo_2\UC08 - Projeto Integrador II\PI-II-Etapa6\Views\Produto\Listagem.cshtml"
               Write(p.Unidade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "F:\Edinaldo\CursoInformática_Senac\Módulo_2\UC08 - Projeto Integrador II\PI-II-Etapa6\Views\Produto\Listagem.cshtml"
               Write(p.Quantidade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "F:\Edinaldo\CursoInformática_Senac\Módulo_2\UC08 - Projeto Integrador II\PI-II-Etapa6\Views\Produto\Listagem.cshtml"
               Write(p.PrecoProduto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n             </tr>\r\n");
#nullable restore
#line 31 "F:\Edinaldo\CursoInformática_Senac\Módulo_2\UC08 - Projeto Integrador II\PI-II-Etapa6\Views\Produto\Listagem.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<br>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Produto>> Html { get; private set; }
    }
}
#pragma warning restore 1591