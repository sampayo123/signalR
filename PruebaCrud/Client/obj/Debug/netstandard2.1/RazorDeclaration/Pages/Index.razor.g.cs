#pragma checksum "C:\Users\Owner\source\repos\PruebaCrud-signalR\PruebaCrud\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9faaa8704677230a26a8106051aaf2a6fa4da52"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace PruebaCrud.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Owner\source\repos\PruebaCrud-signalR\PruebaCrud\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Owner\source\repos\PruebaCrud-signalR\PruebaCrud\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Owner\source\repos\PruebaCrud-signalR\PruebaCrud\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Owner\source\repos\PruebaCrud-signalR\PruebaCrud\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Owner\source\repos\PruebaCrud-signalR\PruebaCrud\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Owner\source\repos\PruebaCrud-signalR\PruebaCrud\Client\_Imports.razor"
using PruebaCrud.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Owner\source\repos\PruebaCrud-signalR\PruebaCrud\Client\_Imports.razor"
using PruebaCrud.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Owner\source\repos\PruebaCrud-signalR\PruebaCrud\Client\_Imports.razor"
using PruebaCrud.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Owner\source\repos\PruebaCrud-signalR\PruebaCrud\Client\_Imports.razor"
using PruebaCrud.Client.Services;

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
#line 14 "C:\Users\Owner\source\repos\PruebaCrud-signalR\PruebaCrud\Client\Pages\Index.razor"
      

    string askText = string.Empty;

    async Task pregunta()
    {
        var response = await JS.InvokeAsync<string>("createAsk", askText);
        await JS.InvokeVoidAsync("setElementTextById", "answerSpan", response);
    }


    async Task Show()
    {
        await JS.InvokeVoidAsync("createAlert");
        await JS.InvokeVoidAsync("test");
        await JS.InvokeVoidAsync("tests");

    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
    }
}
#pragma warning restore 1591
