#pragma checksum "E:\Faridun's Projects\Faridun's\Back-End\Blazor\SampleDashboard\SampleBlazorDashboard\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83a59eb9151aacdaf15bcb81960361e12cafb403"
// <auto-generated/>
#pragma warning disable 1591
namespace SampleBlazorDashboard.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Faridun's Projects\Faridun's\Back-End\Blazor\SampleDashboard\SampleBlazorDashboard\_Imports.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Faridun's Projects\Faridun's\Back-End\Blazor\SampleDashboard\SampleBlazorDashboard\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Faridun's Projects\Faridun's\Back-End\Blazor\SampleDashboard\SampleBlazorDashboard\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Faridun's Projects\Faridun's\Back-End\Blazor\SampleDashboard\SampleBlazorDashboard\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Faridun's Projects\Faridun's\Back-End\Blazor\SampleDashboard\SampleBlazorDashboard\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Faridun's Projects\Faridun's\Back-End\Blazor\SampleDashboard\SampleBlazorDashboard\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Faridun's Projects\Faridun's\Back-End\Blazor\SampleDashboard\SampleBlazorDashboard\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Faridun's Projects\Faridun's\Back-End\Blazor\SampleDashboard\SampleBlazorDashboard\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Faridun's Projects\Faridun's\Back-End\Blazor\SampleDashboard\SampleBlazorDashboard\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Faridun's Projects\Faridun's\Back-End\Blazor\SampleDashboard\SampleBlazorDashboard\_Imports.razor"
using SampleBlazorDashboard;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\Faridun's Projects\Faridun's\Back-End\Blazor\SampleDashboard\SampleBlazorDashboard\_Imports.razor"
using SampleBlazorDashboard.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Person Data</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>List of persons</p>");
#nullable restore
#line 8 "E:\Faridun's Projects\Faridun's\Back-End\Blazor\SampleDashboard\SampleBlazorDashboard\Pages\FetchData.razor"
 if (_persons == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>");
#nullable restore
#line 13 "E:\Faridun's Projects\Faridun's\Back-End\Blazor\SampleDashboard\SampleBlazorDashboard\Pages\FetchData.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table");
            __builder.AddMarkupContent(5, "<thead><tr><th>Id</th>\r\n            <th>Name</th>\r\n            <th>Surname</th></tr></thead>\r\n        ");
            __builder.OpenElement(6, "tbody");
#nullable restore
#line 25 "E:\Faridun's Projects\Faridun's\Back-End\Blazor\SampleDashboard\SampleBlazorDashboard\Pages\FetchData.razor"
         foreach (var person in _persons)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "tr");
            __builder.OpenElement(8, "td");
            __builder.AddContent(9, 
#nullable restore
#line 28 "E:\Faridun's Projects\Faridun's\Back-End\Blazor\SampleDashboard\SampleBlazorDashboard\Pages\FetchData.razor"
                     person.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n                ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 29 "E:\Faridun's Projects\Faridun's\Back-End\Blazor\SampleDashboard\SampleBlazorDashboard\Pages\FetchData.razor"
                     person.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 30 "E:\Faridun's Projects\Faridun's\Back-End\Blazor\SampleDashboard\SampleBlazorDashboard\Pages\FetchData.razor"
                     person.Surname

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 32 "E:\Faridun's Projects\Faridun's\Back-End\Blazor\SampleDashboard\SampleBlazorDashboard\Pages\FetchData.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 35 "E:\Faridun's Projects\Faridun's\Back-End\Blazor\SampleDashboard\SampleBlazorDashboard\Pages\FetchData.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
