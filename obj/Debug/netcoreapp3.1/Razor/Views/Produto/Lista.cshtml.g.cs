#pragma checksum "F:\Edinaldo\CursoInformática_Senac\Módulo_2\UC08 - Projeto Integrador II\PI-II-Etapa6\Views\Produto\Lista.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b51af4380938af82c04520b193256b92eddd750a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Lista), @"mvc.1.0.view", @"/Views/Produto/Lista.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b51af4380938af82c04520b193256b92eddd750a", @"/Views/Produto/Lista.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67c92274be6482569944b3c77a973621760cca79", @"/Views/_ViewImports.cshtml")]
    public class Views_Produto_Lista : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Produto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\Edinaldo\CursoInformática_Senac\Módulo_2\UC08 - Projeto Integrador II\PI-II-Etapa6\Views\Produto\Lista.cshtml"
  
    ViewData["Title"] = "Listagem de Produtos Porta Jóia";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2 class=""row justify-content-md-center"" id=""h2-1"">Lista de Protudos Cadastrados</h2>
<!--<table class=""table table-success table-striped-columns"">-->
<table class=""table table-striped""> 
    <thead>
        <tr>
            <th>CÓDIGO</th>
            <th>PRODUTO</th>
            <th>UNIDADE</th>
            <th>ESTOQUE</th>
            <th>PPREÇO</th>
            <th>OPERAÇÕES</th>
        </tr>
    </thead>
    <tbody>

");
#nullable restore
#line 22 "F:\Edinaldo\CursoInformática_Senac\Módulo_2\UC08 - Projeto Integrador II\PI-II-Etapa6\Views\Produto\Lista.cshtml"
         foreach (Produto p in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 25 "F:\Edinaldo\CursoInformática_Senac\Módulo_2\UC08 - Projeto Integrador II\PI-II-Etapa6\Views\Produto\Lista.cshtml"
               Write(p.IdProduto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "F:\Edinaldo\CursoInformática_Senac\Módulo_2\UC08 - Projeto Integrador II\PI-II-Etapa6\Views\Produto\Lista.cshtml"
               Write(p.NomeProduto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "F:\Edinaldo\CursoInformática_Senac\Módulo_2\UC08 - Projeto Integrador II\PI-II-Etapa6\Views\Produto\Lista.cshtml"
               Write(p.Unidade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "F:\Edinaldo\CursoInformática_Senac\Módulo_2\UC08 - Projeto Integrador II\PI-II-Etapa6\Views\Produto\Lista.cshtml"
               Write(p.Quantidade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "F:\Edinaldo\CursoInformática_Senac\Módulo_2\UC08 - Projeto Integrador II\PI-II-Etapa6\Views\Produto\Lista.cshtml"
               Write(p.PrecoProduto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 847, "\"", 886, 2);
            WriteAttributeValue("", 854, "/Produto/Alterar?Id=", 854, 20, true);
#nullable restore
#line 31 "F:\Edinaldo\CursoInformática_Senac\Módulo_2\UC08 - Projeto Integrador II\PI-II-Etapa6\Views\Produto\Lista.cshtml"
WriteAttributeValue("", 874, p.IdProduto, 874, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Alterar</a>\r\n\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 925, "\"", 964, 2);
            WriteAttributeValue("", 932, "/Produto/Excluir?Id=", 932, 20, true);
#nullable restore
#line 33 "F:\Edinaldo\CursoInformática_Senac\Módulo_2\UC08 - Projeto Integrador II\PI-II-Etapa6\Views\Produto\Lista.cshtml"
WriteAttributeValue("", 952, p.IdProduto, 952, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Excluir</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 36 "F:\Edinaldo\CursoInformática_Senac\Módulo_2\UC08 - Projeto Integrador II\PI-II-Etapa6\Views\Produto\Lista.cshtml"
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
