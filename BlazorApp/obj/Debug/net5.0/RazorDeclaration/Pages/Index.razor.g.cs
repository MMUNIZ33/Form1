// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Matheus Muniz\source\repos\MMUNIZ33\Form1\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Matheus Muniz\source\repos\MMUNIZ33\Form1\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Matheus Muniz\source\repos\MMUNIZ33\Form1\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Matheus Muniz\source\repos\MMUNIZ33\Form1\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Matheus Muniz\source\repos\MMUNIZ33\Form1\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Matheus Muniz\source\repos\MMUNIZ33\Form1\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Matheus Muniz\source\repos\MMUNIZ33\Form1\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Matheus Muniz\source\repos\MMUNIZ33\Form1\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Matheus Muniz\source\repos\MMUNIZ33\Form1\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Matheus Muniz\source\repos\MMUNIZ33\Form1\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Matheus Muniz\source\repos\MMUNIZ33\Form1\BlazorApp\Pages\Index.razor"
using API.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 238 "C:\Users\Matheus Muniz\source\repos\MMUNIZ33\Form1\BlazorApp\Pages\Index.razor"
 

    public string txtName, txtTelefone, txtEmail;
    List<tbl_Clientes_PreCadastro_Contato> Contatos = new List<tbl_Clientes_PreCadastro_Contato>();
    public string habilitar = "disabled";

    private void ForTable()
    {
        var contato = new tbl_Clientes_PreCadastro_Contato();
        //if (!string.IsNullOrWhiteSpace(txtName))
        //{
        contato.Contato = txtName;
        contato.Telefone = txtTelefone;

        Contatos.Add(contato);
        //}
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
