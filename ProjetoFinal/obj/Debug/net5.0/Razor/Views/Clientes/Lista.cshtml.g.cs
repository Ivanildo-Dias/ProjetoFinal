#pragma checksum "C:\Users\ivani\source\repos\ProjetoFinal\ProjetoFinal\Views\Clientes\Lista.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c0a81e04799243cabc80b500642b2fbd55c2b06"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clientes_Lista), @"mvc.1.0.view", @"/Views/Clientes/Lista.cshtml")]
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
#line 1 "C:\Users\ivani\source\repos\ProjetoFinal\ProjetoFinal\Views\_ViewImports.cshtml"
using ProjetoFinal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ivani\source\repos\ProjetoFinal\ProjetoFinal\Views\_ViewImports.cshtml"
using ProjetoFinal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c0a81e04799243cabc80b500642b2fbd55c2b06", @"/Views/Clientes/Lista.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e0c9d640be634173df9fcea737cdae6910dcdad", @"/Views/_ViewImports.cshtml")]
    public class Views_Clientes_Lista : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<br>
<h2>Lista de clientes</h2>
<br>

<table class=""table table-sm table-hover"">
    <tr>
        <th scope=""col"">Nome</th>
        <th scope=""col"">CPF</th>
        <th scope=""col"">Telefone</th>
        <th scope=""col"">E-mail</th>
        <th scope=""col"">Operações</th>
    </tr> 
");
#nullable restore
#line 13 "C:\Users\ivani\source\repos\ProjetoFinal\ProjetoFinal\Views\Clientes\Lista.cshtml"
     foreach(Cliente cliente in ViewBag.Clientes)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr scope=\"row\">\r\n            <td>");
#nullable restore
#line 16 "C:\Users\ivani\source\repos\ProjetoFinal\ProjetoFinal\Views\Clientes\Lista.cshtml"
           Write(cliente.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 17 "C:\Users\ivani\source\repos\ProjetoFinal\ProjetoFinal\Views\Clientes\Lista.cshtml"
           Write(cliente.CPF);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 18 "C:\Users\ivani\source\repos\ProjetoFinal\ProjetoFinal\Views\Clientes\Lista.cshtml"
           Write(cliente.Telefone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 19 "C:\Users\ivani\source\repos\ProjetoFinal\ProjetoFinal\Views\Clientes\Lista.cshtml"
           Write(cliente.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                <a class=\"btn btn-warning\"");
            BeginWriteAttribute("href", " href=\"", 585, "\"", 612, 2);
            WriteAttributeValue("", 592, "/cliente/", 592, 9, true);
#nullable restore
#line 21 "C:\Users\ivani\source\repos\ProjetoFinal\ProjetoFinal\Views\Clientes\Lista.cshtml"
WriteAttributeValue("", 601, cliente.Id, 601, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a>\r\n                <a class=\"btn btn-danger\" href=\"#\"");
            BeginWriteAttribute("onclick", " onclick=\"", 676, "\"", 725, 3);
            WriteAttributeValue("", 686, "excluir(\'/cliente/", 686, 18, true);
#nullable restore
#line 22 "C:\Users\ivani\source\repos\ProjetoFinal\ProjetoFinal\Views\Clientes\Lista.cshtml"
WriteAttributeValue("", 704, cliente.Id, 704, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 715, "/excluir\')", 715, 10, true);
            EndWriteAttribute();
            WriteLiteral(">Excluir</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 25 "C:\Users\ivani\source\repos\ProjetoFinal\ProjetoFinal\Views\Clientes\Lista.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n<a class=\"btn btn-secondary\" href=\"/#\">Voltar</a>\r\n\r\n<script>\r\n    function excluir(url){\r\n        if(confirm(\"Deseja realmente excluir?\")){\r\n            window.location.href=url\r\n        }\r\n    }\r\n</script>\r\n\r\n\r\n");
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
