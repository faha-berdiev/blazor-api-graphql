#pragma checksum "E:\Faridun's Projects\Faridun's\Back-End\Blazor\SampleDashboard\SampleBlazorDashboard\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9140f3e856fb3a4215af541ead1c1bb87a6c5db0"
// <auto-generated/>
#pragma warning disable 1591
namespace SampleBlazorDashboard.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Faridun's Projects\Faridun's\Back-End\Blazor\SampleDashboard\SampleBlazorDashboard\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Faridun's Projects\Faridun's\Back-End\Blazor\SampleDashboard\SampleBlazorDashboard\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Faridun's Projects\Faridun's\Back-End\Blazor\SampleDashboard\SampleBlazorDashboard\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Faridun's Projects\Faridun's\Back-End\Blazor\SampleDashboard\SampleBlazorDashboard\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Faridun's Projects\Faridun's\Back-End\Blazor\SampleDashboard\SampleBlazorDashboard\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Faridun's Projects\Faridun's\Back-End\Blazor\SampleDashboard\SampleBlazorDashboard\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Faridun's Projects\Faridun's\Back-End\Blazor\SampleDashboard\SampleBlazorDashboard\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Faridun's Projects\Faridun's\Back-End\Blazor\SampleDashboard\SampleBlazorDashboard\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Faridun's Projects\Faridun's\Back-End\Blazor\SampleDashboard\SampleBlazorDashboard\_Imports.razor"
using SampleBlazorDashboard;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Faridun's Projects\Faridun's\Back-End\Blazor\SampleDashboard\SampleBlazorDashboard\_Imports.razor"
using SampleBlazorDashboard.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-4xi1anc4la");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-4xi1anc4la");
            __builder.OpenComponent<SampleBlazorDashboard.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddAttribute(10, "b-4xi1anc4la");
            __builder.AddMarkupContent(11, "<div class=\"top-row px-4\" b-4xi1anc4la><a href=\"http://blazor.net\" target=\"_blank\" class=\"ml-md-auto\" b-4xi1anc4la>About</a></div>\r\n\r\n        ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "content px-4");
            __builder.AddAttribute(14, "b-4xi1anc4la");
            __builder.AddContent(15, 
#nullable restore
#line 14 "E:\Faridun's Projects\Faridun's\Back-End\Blazor\SampleDashboard\SampleBlazorDashboard\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
