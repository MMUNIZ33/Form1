#pragma checksum "C:\Users\Matheus Muniz\Desktop\FrmBlazor\BlazorApp\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f22eab4191ae762438e48905fb9f3042d2c55d0c"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Matheus Muniz\Desktop\FrmBlazor\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Matheus Muniz\Desktop\FrmBlazor\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Matheus Muniz\Desktop\FrmBlazor\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Matheus Muniz\Desktop\FrmBlazor\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Matheus Muniz\Desktop\FrmBlazor\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Matheus Muniz\Desktop\FrmBlazor\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Matheus Muniz\Desktop\FrmBlazor\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Matheus Muniz\Desktop\FrmBlazor\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Matheus Muniz\Desktop\FrmBlazor\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Matheus Muniz\Desktop\FrmBlazor\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Bem-vindo</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>Vamos realizar seu Pre-Cadastro</p>\r\n\r\n");
            __builder.AddMarkupContent(2, "<h5>Dados básicos:</h5>\r\n");
            __builder.AddMarkupContent(3, @"<table><tr><td>CNPJ:</td>
   <td><input type=""text"" name=""cnpj"" size=""8""> - <input type=""text"" name=""cnpj2"" size=""5"">  <br></td></tr>
 <tr><td>Inscrição Estadual:</td>
   <td><input type=""text"" name=""inscricaoEstadual"" size=""30""> <br></td></tr>
  <tr><td>Inscrição Municipal:</td>
   <td><input type=""text"" name=""inscricaoMunicipal"" size=""30"" value=""Não declarado""> <br></td></tr>
 <tr><td>Regime Tributário:</td>
    <td><input type=""text"" name=""regimeTributario"" size=""30"" value=""Simples Nacional""> <br></td></tr>
 <tr><td>Contribuinte:</td>
    <td><input type=""text"" name=""contribuinte"" size=""30"" placeholder=""Contribuinte ICMS""> <br></td></tr>
 <tr><td>Razão Social:</td>
    <td><input type=""text"" name=""RazaoSocial"" size=""60""> <br></td></tr>
  <tr><td>Nome Fantasia:</td>
    <td><input type=""text"" name=""nomeFantasia"" size=""60""> <br></td></tr></table>
");
            __builder.AddMarkupContent(4, "<p><h5>Logradouro:</h5></p>\r\n\r\n");
            __builder.AddMarkupContent(5, @"<table><tr><td>Rua:</td>
        <td><input type=""text"" name=""Rua"" size=""40""> Número: <input type=""text"" name=""cnpj2"" size=""5"">  <br></td></tr>
    <tr><td>Bairro:</td>
        <td><input type=""text"" name=""Bairro"" size=""40""><br></td></tr>
    <tr><td>CEP:</td>
        <td><input type=""text"" name=""Bairro"" size=""20""><br></td></tr></table>
<p></p>
");
            __builder.OpenComponent<BlazorApp.Pages.Todo>(6);
            __builder.CloseComponent();
            __builder.AddMarkupContent(7, "\r\n\r\n\r\n");
            __builder.OpenComponent<BlazorApp.Shared.SurveyPrompt>(8);
            __builder.AddAttribute(9, "Title", "How is Blazor working for you?");
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
