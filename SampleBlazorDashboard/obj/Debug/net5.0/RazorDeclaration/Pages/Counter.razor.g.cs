// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "E:\Faridun's Projects\Faridun's\Back-End\Blazor\SampleDashboard\SampleBlazorDashboard\Pages\Counter.razor"
       
    private int currentCount = 0;

    private void IncrementCount()
    {
        if(currentCount >= 100)
            return;
        currentCount++;
    }
    
    private void IncrementNegativeCount()
    {
        if(currentCount <= 0)
            return;
        currentCount--;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
