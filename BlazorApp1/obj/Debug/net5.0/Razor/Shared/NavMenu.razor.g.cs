#pragma checksum "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\Shared\NavMenu.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "971b68d147527bb698c26dd7584537db81f366742f4d7082933323631809a7f6"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp1.Shared
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\_Imports.razor"
using System.Net.Http

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\_Imports.razor"
using System.Net.Http.Json

#nullable disable
    ;
#nullable restore
#line 3 "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms

#nullable disable
    ;
#nullable restore
#line 4 "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing

#nullable disable
    ;
#nullable restore
#line 5 "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web

#nullable disable
    ;
#nullable restore
#line 6 "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization

#nullable disable
    ;
#nullable restore
#line 7 "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http

#nullable disable
    ;
#nullable restore
#line 8 "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.JSInterop

#nullable disable
    ;
#nullable restore
#line 9 "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\_Imports.razor"
using BlazorApp1

#nullable disable
    ;
#nullable restore
#line 10 "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\_Imports.razor"
using BlazorApp1.Shared

#line default
#line hidden
#nullable disable
    ;
    #nullable restore
    public partial class NavMenu : global::Microsoft.AspNetCore.Components.ComponentBase
    #nullable disable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            __builder.AddAttribute(2, "b-b5wscdn8ts");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href b-b5wscdn8ts>Student Portal</a>\r\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "navbar-toggler");
            __builder.AddAttribute(6, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "b-b5wscdn8ts");
            __builder.AddMarkupContent(8, "<span class=\"navbar-toggler-icon\" b-b5wscdn8ts></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", 
#nullable restore
#line 8 "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\Shared\NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "b-b5wscdn8ts");
            __builder.AddMarkupContent(14, "<ul class=\"nav flex-column\" b-b5wscdn8ts></ul>");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\Users\Mohamed El-maghraby\source\repos\BlazorApp1\BlazorApp1\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable

    }
}
#pragma warning restore 1591
