#pragma checksum "C:\Estudos Programação\SistemaConsulta\SistemaConsultaTI\Views\Shared\_Layout.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "94102e9dae0bdf369b8e5efaed846c3613f256ef3520b72f5a28705a72ffad82"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Estudos Programação\SistemaConsulta\SistemaConsultaTI\Views\_ViewImports.cshtml"
using SistemaConsultaTI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Estudos Programação\SistemaConsulta\SistemaConsultaTI\Views\_ViewImports.cshtml"
using SistemaConsultaTI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"94102e9dae0bdf369b8e5efaed846c3613f256ef3520b72f5a28705a72ffad82", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"78363611a29c3e99c556b13ca24d51598c7d0b2405c25a26042ca3ed2f37efa3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/js/bootstrap.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/site.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"pt-br\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "94102e9dae0bdf369b8e5efaed846c3613f256ef3520b72f5a28705a72ffad825896", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    <title>");
#nullable restore
#line 6 "C:\Estudos Programação\SistemaConsulta\SistemaConsultaTI\Views\Shared\_Layout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - Sistema Consulta TI</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "94102e9dae0bdf369b8e5efaed846c3613f256ef3520b72f5a28705a72ffad826578", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "94102e9dae0bdf369b8e5efaed846c3613f256ef3520b72f5a28705a72ffad827780", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "94102e9dae0bdf369b8e5efaed846c3613f256ef3520b72f5a28705a72ffad829686", async() => {
                WriteLiteral(@"
    asp-controller=""Home"" asp-action=""Index""

    <nav class=""navbar navbar-expand-lg navbar-light bg-light fixed-top"">
        <div class="" container-fluid"">
            <ul class=""navbar-nav mr-auto"">

                <!--Link Para Home-->
                <li class=""nav-item active"">
                    <a class=""nav-link"" href=""index""> Home <span class=""sr-only"">(página atual)</span></a>
                </li>

                <!--Menu C# Curso Udemy-->

                <li class=""nav-item dropdown"">
                    <a class=""nav-link dropdown-toggle"" href=""#"" id=""navbarDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                        C# Udemy Exercícios
                    </a>
                    <div class=""dropdown-menu"" aria-labelledby=""navbarDropdown"">
                        <a class=""dropdown-item""");
                BeginWriteAttribute("href", " href=\"", 1256, "\"", 1335, 1);
#nullable restore
#line 29 "C:\Estudos Programação\SistemaConsulta\SistemaConsultaTI\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1263, Url.Action("LeituraGeral", new { NomeArquivo = "LogicaRecapitulacao" }), 1263, 72, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Recapitulação Lógica</a>\r\n                        <a class=\"dropdown-item\"");
                BeginWriteAttribute("href", " href=\"", 1411, "\"", 1478, 1);
#nullable restore
#line 30 "C:\Estudos Programação\SistemaConsulta\SistemaConsultaTI\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1418, Url.Action("LeituraGeral", new { NomeArquivo = "Classes" }), 1418, 60, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Classes</a>\r\n                        <a class=\"dropdown-item\"");
                BeginWriteAttribute("href", " href=\"", 1541, "\"", 1626, 1);
#nullable restore
#line 31 "C:\Estudos Programação\SistemaConsulta\SistemaConsultaTI\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1548, Url.Action("LeituraGeral", new { NomeArquivo = "Sobrecarga Encapsulamento" }), 1548, 78, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Sobrecarga/Encapsulamento</a>\r\n                        <a class=\"dropdown-item\"");
                BeginWriteAttribute("href", " href=\"", 1707, "\"", 1790, 1);
#nullable restore
#line 32 "C:\Estudos Programação\SistemaConsulta\SistemaConsultaTI\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1714, Url.Action("LeituraGeral", new { NomeArquivo = "Vetores Listas Matrizes" }), 1714, 76, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Vetores Listas Matrizes</a>\r\n                        <a class=\"dropdown-item\"");
                BeginWriteAttribute("href", " href=\"", 1869, "\"", 1946, 1);
#nullable restore
#line 33 "C:\Estudos Programação\SistemaConsulta\SistemaConsultaTI\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1876, Url.Action("LeituraGeral", new { NomeArquivo = "Tópicos Especiais" }), 1876, 70, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Tópicos Especiais DateTime</a>\r\n                        <a class=\"dropdown-item\"");
                BeginWriteAttribute("href", " href=\"", 2028, "\"", 2110, 1);
#nullable restore
#line 34 "C:\Estudos Programação\SistemaConsulta\SistemaConsultaTI\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2035, Url.Action("LeituraGeral", new { NomeArquivo = "Enumerações Composição" }), 2035, 75, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Enumerações Composição</a>\r\n                        <a class=\"dropdown-item\"");
                BeginWriteAttribute("href", " href=\"", 2188, "\"", 2270, 1);
#nullable restore
#line 35 "C:\Estudos Programação\SistemaConsulta\SistemaConsultaTI\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2195, Url.Action("LeituraGeral", new { NomeArquivo = "Herança e Polimorfismo" }), 2195, 75, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Herança e Polimorfismo</a>\r\n                        <a class=\"dropdown-item\"");
                BeginWriteAttribute("href", " href=\"", 2348, "\"", 2417, 1);
#nullable restore
#line 36 "C:\Estudos Programação\SistemaConsulta\SistemaConsultaTI\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2355, Url.Action("LeituraGeral", new { NomeArquivo = "Excessões" }), 2355, 62, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Excessões</a>\r\n                        <a class=\"dropdown-item\"");
                BeginWriteAttribute("href", " href=\"", 2482, "\"", 2550, 1);
#nullable restore
#line 37 "C:\Estudos Programação\SistemaConsulta\SistemaConsultaTI\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2489, Url.Action("LeituraGeral", new { NomeArquivo = "Arquivos" }), 2489, 61, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Arquivos</a>\r\n                        <a class=\"dropdown-item\"");
                BeginWriteAttribute("href", " href=\"", 2614, "\"", 2683, 1);
#nullable restore
#line 38 "C:\Estudos Programação\SistemaConsulta\SistemaConsultaTI\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2621, Url.Action("LeituraGeral", new { NomeArquivo = "Interface" }), 2621, 62, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Interfaces</a>\r\n                        <a class=\"dropdown-item\"");
                BeginWriteAttribute("href", " href=\"", 2749, "\"", 2830, 1);
#nullable restore
#line 39 "C:\Estudos Programação\SistemaConsulta\SistemaConsultaTI\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2756, Url.Action("LeituraGeral", new { NomeArquivo = "Interface 2 Contratos" }), 2756, 74, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">Interfaces 2 Contrato</a>

                    </div>

                </li>

                <li class=""nav-item dropdown"">
                    <a class=""nav-link dropdown-toggle"" href=""#"" id=""navbarDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                        C# Udemy Apoio PDF
                    </a>
                    <div class=""dropdown-menu"" aria-labelledby=""navbarDropdown"">
                        <a class=""dropdown-item""");
                BeginWriteAttribute("href", " href=\"", 3331, "\"", 3431, 1);
#nullable restore
#line 50 "C:\Estudos Programação\SistemaConsulta\SistemaConsultaTI\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3338, Url.Action("LeituraPDF", new { NomePDF = "01 --- 14 paginas  02-introducao-csharp-dotnet" }), 3338, 93, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Introdução C#</a>\r\n                        <a class=\"dropdown-item\"");
                BeginWriteAttribute("href", " href=\"", 3500, "\"", 3614, 1);
#nullable restore
#line 51 "C:\Estudos Programação\SistemaConsulta\SistemaConsultaTI\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3507, Url.Action("LeituraPDF", new { NomePDF = "02 --- 37 paginas  03-recapitulacao-de-logica-de-programacao" }), 3507, 107, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Recaptulação Lógica</a>\r\n                        <a class=\"dropdown-item\"");
                BeginWriteAttribute("href", " href=\"", 3689, "\"", 3796, 1);
#nullable restore
#line 52 "C:\Estudos Programação\SistemaConsulta\SistemaConsultaTI\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3696, Url.Action("LeituraPDF", new { NomePDF = "03 --- 24 paginas 04-classes-atributos-metodos-static" }), 3696, 100, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Classes Atributos Metodos Static</a>\r\n                        <a class=\"dropdown-item\"");
                BeginWriteAttribute("href", " href=\"", 3884, "\"", 4002, 1);
#nullable restore
#line 53 "C:\Estudos Programação\SistemaConsulta\SistemaConsultaTI\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3891, Url.Action("LeituraPDF", new { NomePDF = "04 --- 23 paginas 05-construtores-this-sobrecarga-encapsulamento" }), 3891, 111, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Construtores This Sobrecarga Encapsulamento</a>\r\n                        <a class=\"dropdown-item\"");
                BeginWriteAttribute("href", " href=\"", 4101, "\"", 4197, 1);
#nullable restore
#line 54 "C:\Estudos Programação\SistemaConsulta\SistemaConsultaTI\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 4108, Url.Action("LeituraPDF", new { NomePDF = "05 --- 42 paginas 06-memoria-arrays-listas" }), 4108, 89, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Memoria Arrays Listas</a>\r\n                        <a class=\"dropdown-item\"");
                BeginWriteAttribute("href", " href=\"", 4274, "\"", 4373, 1);
#nullable restore
#line 55 "C:\Estudos Programação\SistemaConsulta\SistemaConsultaTI\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 4281, Url.Action("LeituraPDF", new { NomePDF = "06 --- 21 paginas 07-topicos-especiais-parte1" }), 4281, 92, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Topicos Especiais Parte1</a>\r\n                        <a class=\"dropdown-item\"");
                BeginWriteAttribute("href", " href=\"", 4453, "\"", 4567, 1);
#nullable restore
#line 56 "C:\Estudos Programação\SistemaConsulta\SistemaConsultaTI\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 4460, Url.Action("LeituraPDF", new { NomePDF = "07 --- 10 paginas 01 08 +Introdução+ao+Git+e+Github+(slides)" }), 4460, 107, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Introdução ao Git e Github</a>\r\n                        <a class=\"dropdown-item\"");
                BeginWriteAttribute("href", " href=\"", 4649, "\"", 4746, 1);
#nullable restore
#line 57 "C:\Estudos Programação\SistemaConsulta\SistemaConsultaTI\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 4656, Url.Action("LeituraPDF", new { NomePDF = "08 --- 14 paginas 09-enumeracoes-composicao" }), 4656, 90, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Enumeracões Composição</a>\r\n                        <a class=\"dropdown-item\"");
                BeginWriteAttribute("href", " href=\"", 4824, "\"", 4919, 1);
#nullable restore
#line 58 "C:\Estudos Programação\SistemaConsulta\SistemaConsultaTI\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 4831, Url.Action("LeituraPDF", new { NomePDF = "09 --- 25 paginas 10-heranca-polimorfismo" }), 4831, 88, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Heranca Polimorfismo</a>\r\n                        <a class=\"dropdown-item\"");
                BeginWriteAttribute("href", " href=\"", 4995, "\"", 5092, 1);
#nullable restore
#line 59 "C:\Estudos Programação\SistemaConsulta\SistemaConsultaTI\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 5002, Url.Action("LeituraPDF", new { NomePDF = "10 --- 13 paginas 11-tratamento-de-excecoes" }), 5002, 90, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Tratamento de Exceções</a>\r\n                        <a class=\"dropdown-item\"");
                BeginWriteAttribute("href", " href=\"", 5170, "\"", 5253, 1);
#nullable restore
#line 60 "C:\Estudos Programação\SistemaConsulta\SistemaConsultaTI\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 5177, Url.Action("LeituraPDF", new { NomePDF = "11 --- 14 paginas 13 arquivos" }), 5177, 76, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Trabalhando com Arquivos</a>\r\n                        <a class=\"dropdown-item\"");
                BeginWriteAttribute("href", " href=\"", 5333, "\"", 5418, 1);
#nullable restore
#line 61 "C:\Estudos Programação\SistemaConsulta\SistemaConsultaTI\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 5340, Url.Action("LeituraPDF", new { NomePDF = "12 --- 20 paginas 14 interfaces" }), 5340, 78, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Interfaces</a>\r\n                        <a class=\"dropdown-item\"");
                BeginWriteAttribute("href", " href=\"", 5484, "\"", 5582, 1);
#nullable restore
#line 62 "C:\Estudos Programação\SistemaConsulta\SistemaConsultaTI\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 5491, Url.Action("LeituraPDF", new { NomePDF = "13 --- 21 paginas 15-generics-set-dictionary" }), 5491, 91, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Generics Set Dictionary</a>\r\n                        <a class=\"dropdown-item\"");
                BeginWriteAttribute("href", " href=\"", 5661, "\"", 5759, 1);
#nullable restore
#line 63 "C:\Estudos Programação\SistemaConsulta\SistemaConsultaTI\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 5668, Url.Action("LeituraPDF", new { NomePDF = "14 --- 4 paginas 16 topicos-especiais-parte2" }), 5668, 91, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Topicos Especiais Parte2</a>\r\n                        <a class=\"dropdown-item\"");
                BeginWriteAttribute("href", " href=\"", 5839, "\"", 5935, 1);
#nullable restore
#line 64 "C:\Estudos Programação\SistemaConsulta\SistemaConsultaTI\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 5846, Url.Action("LeituraPDF", new { NomePDF = "15 --- 31 paginas 17-lambda-delegates-linq" }), 5846, 89, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Lambda Delegates Linq</a>\r\n                        <a class=\"dropdown-item\"");
                BeginWriteAttribute("href", " href=\"", 6012, "\"", 6118, 1);
#nullable restore
#line 65 "C:\Estudos Programação\SistemaConsulta\SistemaConsultaTI\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 6019, Url.Action("LeituraPDF", new { NomePDF = "16 --- 11 paginas  projeto-asp-net-core-mvc-ef_PT_BR" }), 6019, 99, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Projeto Asp Net Core mvc ef PT BR</a>\r\n                        <a class=\"dropdown-item\"");
                BeginWriteAttribute("href", " href=\"", 6207, "\"", 6310, 1);
#nullable restore
#line 66 "C:\Estudos Programação\SistemaConsulta\SistemaConsultaTI\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 6214, Url.Action("LeituraPDF", new { NomePDF = "16 --- 11 paginas  projeto-asp-net-core-mvc-ef_US" }), 6214, 96, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Projeto Asp Net Core mvc ef US</a>\r\n                        <a class=\"dropdown-item\"");
                BeginWriteAttribute("href", " href=\"", 6396, "\"", 6487, 1);
#nullable restore
#line 67 "C:\Estudos Programação\SistemaConsulta\SistemaConsultaTI\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 6403, Url.Action("LeituraPDF", new { NomePDF = "17 --- 5 paginas  entity-framework_US" }), 6403, 84, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">Entity Framework US</a>


                    </div>

                </li>


                <!--Menu GitHub-->

                <li class=""nav-item dropdown"">
                    <a class=""nav-link dropdown-toggle"" href=""#"" id=""navbarDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                        GitHub
                    </a>
                    <div class=""dropdown-menu"" aria-labelledby=""navbarDropdown"">
                        <a class=""dropdown-item""");
                BeginWriteAttribute("href", " href=\"", 7016, "\"", 7094, 1);
#nullable restore
#line 82 "C:\Estudos Programação\SistemaConsulta\SistemaConsultaTI\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 7023, Url.Action("LeituraGeral", new { NomeArquivo = "Fazer Comit Salvar" }), 7023, 71, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Fazer Commit/Salvar</a>\r\n\r\n                    </div>\r\n                </li>\r\n\r\n\r\n            </ul>\r\n\r\n        </div>\r\n\r\n    </nav>\r\n\r\n\r\n\r\n    <div class=\"container\">\r\n        <main role=\"main\" class=\"pb-3\">\r\n            ");
#nullable restore
#line 98 "C:\Estudos Programação\SistemaConsulta\SistemaConsultaTI\Views\Shared\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </main>\r\n    </div>\r\n\r\n\r\n    <footer class=\"border-top footer text-muted bg-light \">\r\n        <div class=\"container\">\r\n            &copy; 2023 - Sistema Consulta TI\r\n        </div>\r\n    </footer>\r\n\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "94102e9dae0bdf369b8e5efaed846c3613f256ef3520b72f5a28705a72ffad8228427", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "94102e9dae0bdf369b8e5efaed846c3613f256ef3520b72f5a28705a72ffad8229551", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "94102e9dae0bdf369b8e5efaed846c3613f256ef3520b72f5a28705a72ffad8230675", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
#nullable restore
#line 112 "C:\Estudos Programação\SistemaConsulta\SistemaConsultaTI\Views\Shared\_Layout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
#nullable restore
#line 113 "C:\Estudos Programação\SistemaConsulta\SistemaConsultaTI\Views\Shared\_Layout.cshtml"
Write(await RenderSectionAsync("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n</html>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
