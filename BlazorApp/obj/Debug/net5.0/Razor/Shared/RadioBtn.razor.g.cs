#pragma checksum "C:\Users\Matheus Muniz\Source\Repos\MMUNIZ33\Form1\BlazorApp\Shared\RadioBtn.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47dfa166f30a2d8ab0f4ac78afa96114778c6c11"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Matheus Muniz\Source\Repos\MMUNIZ33\Form1\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Matheus Muniz\Source\Repos\MMUNIZ33\Form1\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Matheus Muniz\Source\Repos\MMUNIZ33\Form1\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Matheus Muniz\Source\Repos\MMUNIZ33\Form1\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Matheus Muniz\Source\Repos\MMUNIZ33\Form1\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Matheus Muniz\Source\Repos\MMUNIZ33\Form1\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Matheus Muniz\Source\Repos\MMUNIZ33\Form1\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Matheus Muniz\Source\Repos\MMUNIZ33\Form1\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Matheus Muniz\Source\Repos\MMUNIZ33\Form1\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Matheus Muniz\Source\Repos\MMUNIZ33\Form1\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
    public partial class RadioBtn : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "custom-control custom-radio custom-control-inline");
            __builder.OpenElement(2, "input");
            __builder.AddAttribute(3, "type", "radio");
            __builder.AddAttribute(4, "class", "custom-control-input");
            __builder.AddAttribute(5, "name", 
#nullable restore
#line 3 "C:\Users\Matheus Muniz\Source\Repos\MMUNIZ33\Form1\BlazorApp\Shared\RadioBtn.razor"
                                                           NameRadios

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(6, "required");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\t");
            __builder.OpenElement(8, "label");
            __builder.AddAttribute(9, "class", "custom-control-label");
            __builder.AddContent(10, 
#nullable restore
#line 4 "C:\Users\Matheus Muniz\Source\Repos\MMUNIZ33\Form1\BlazorApp\Shared\RadioBtn.razor"
                                         Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "C:\Users\Matheus Muniz\Source\Repos\MMUNIZ33\Form1\BlazorApp\Shared\RadioBtn.razor"
       
	[Parameter]
	public string NameRadios { get; set; }
	[Parameter]
	public string Title { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
