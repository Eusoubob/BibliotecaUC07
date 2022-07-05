#pragma checksum "C:\Users\alyss\Desktop\Técnico em Informática para Internet\Módulo02\UC07\Biblioteca\Views\Usuarios\listaDeUsuarios.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1f830cebd8a79c40289f6d54c470fbbae686f73"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuarios_listaDeUsuarios), @"mvc.1.0.view", @"/Views/Usuarios/listaDeUsuarios.cshtml")]
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
#line 1 "C:\Users\alyss\Desktop\Técnico em Informática para Internet\Módulo02\UC07\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\alyss\Desktop\Técnico em Informática para Internet\Módulo02\UC07\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1f830cebd8a79c40289f6d54c470fbbae686f73", @"/Views/Usuarios/listaDeUsuarios.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ea07f0214da259abc315dec5bc842518e8ae187", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuarios_listaDeUsuarios : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Usuario>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Usuários cadastrados no sistema</h1>\r\n\r\n<p class=\"text-danger\">");
#nullable restore
#line 5 "C:\Users\alyss\Desktop\Técnico em Informática para Internet\Módulo02\UC07\Biblioteca\Views\Usuarios\listaDeUsuarios.cshtml"
                  Write(ViewData["Mensagem"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<table>\r\n    <thead>\r\n        <tr>\r\n            <th scope=\"row\">Nome</th>\r\n            <th scope=\"row\">Login</th>\r\n            <th scope=\"row\">Tipo</th>\r\n        </tr>\r\n    </thead>\r\n\r\n    <tbody>\r\n");
#nullable restore
#line 17 "C:\Users\alyss\Desktop\Técnico em Informática para Internet\Módulo02\UC07\Biblioteca\Views\Usuarios\listaDeUsuarios.cshtml"
         foreach (Usuario u in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 20 "C:\Users\alyss\Desktop\Técnico em Informática para Internet\Módulo02\UC07\Biblioteca\Views\Usuarios\listaDeUsuarios.cshtml"
               Write(u.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\alyss\Desktop\Técnico em Informática para Internet\Módulo02\UC07\Biblioteca\Views\Usuarios\listaDeUsuarios.cshtml"
               Write(u.Login);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 22 "C:\Users\alyss\Desktop\Técnico em Informática para Internet\Módulo02\UC07\Biblioteca\Views\Usuarios\listaDeUsuarios.cshtml"
                 if(u.Tipo==Usuario.ADMIN)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>Administrador</td>\r\n");
#nullable restore
#line 25 "C:\Users\alyss\Desktop\Técnico em Informática para Internet\Módulo02\UC07\Biblioteca\Views\Usuarios\listaDeUsuarios.cshtml"
                } 
                else 
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>Padrão</td>\r\n");
#nullable restore
#line 29 "C:\Users\alyss\Desktop\Técnico em Informática para Internet\Módulo02\UC07\Biblioteca\Views\Usuarios\listaDeUsuarios.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 704, "\"", 733, 2);
            WriteAttributeValue("", 711, "editarUsuario?id=", 711, 17, true);
#nullable restore
#line 31 "C:\Users\alyss\Desktop\Técnico em Informática para Internet\Módulo02\UC07\Biblioteca\Views\Usuarios\listaDeUsuarios.cshtml"
WriteAttributeValue("", 728, u.Id, 728, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">editar</a></td>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 774, "\"", 804, 2);
            WriteAttributeValue("", 781, "excluirUsuario?id=", 781, 18, true);
#nullable restore
#line 32 "C:\Users\alyss\Desktop\Técnico em Informática para Internet\Módulo02\UC07\Biblioteca\Views\Usuarios\listaDeUsuarios.cshtml"
WriteAttributeValue("", 799, u.Id, 799, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">excluir</a></td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 35 "C:\Users\alyss\Desktop\Técnico em Informática para Internet\Módulo02\UC07\Biblioteca\Views\Usuarios\listaDeUsuarios.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<a href=\"registrarUsuarios\">Registrar novo usuário</a>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
