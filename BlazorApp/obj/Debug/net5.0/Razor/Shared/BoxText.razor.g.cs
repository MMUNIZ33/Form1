#pragma checksum "C:\Users\Matheus Muniz\Source\Repos\MMUNIZ33\Form1\BlazorApp\Shared\BoxText.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9621ef55d5a751b56a3257b905d11d77bafbdec6"
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
    public partial class BoxText : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "form-group col");
            __builder.OpenElement(2, "label");
            __builder.OpenElement(3, "strong");
            __builder.AddContent(4, 
#nullable restore
#line 2 "C:\Users\Matheus Muniz\Source\Repos\MMUNIZ33\Form1\BlazorApp\Shared\BoxText.razor"
                    Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\t");
            __builder.OpenElement(6, "input");
            __builder.AddAttribute(7, "class", "form-control");
            __builder.AddAttribute(8, "type", "text");
            __builder.AddAttribute(9, "placeholder", 
#nullable restore
#line 3 "C:\Users\Matheus Muniz\Source\Repos\MMUNIZ33\Form1\BlazorApp\Shared\BoxText.razor"
                                                         Sub

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(10, "required");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "C:\Users\Matheus Muniz\Source\Repos\MMUNIZ33\Form1\BlazorApp\Shared\BoxText.razor"
       

	//[Parameter]
	//public RenderFragment ChildContent { get; set; }

	[Parameter]
	public string Title { get; set; }
	[Parameter]
	public string Sub { get; set; }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
