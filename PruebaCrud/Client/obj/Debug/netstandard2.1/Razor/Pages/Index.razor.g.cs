#pragma checksum "C:\Users\Owner\source\repos\PruebaCrud-signalR\PruebaCrud\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9faaa8704677230a26a8106051aaf2a6fa4da52"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<h1>Hello, world!</h1>\r\n\r\nWelcome to your new app.\r\n\r\n");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "class", "btn btn-success");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\Owner\source\repos\PruebaCrud-signalR\PruebaCrud\Client\Pages\Index.razor"
                                          Show

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(4, " ver");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenElement(6, "button");
            __builder.AddAttribute(7, "class", "btn btn-warning");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\Owner\source\repos\PruebaCrud-signalR\PruebaCrud\Client\Pages\Index.razor"
                                          pregunta

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(9, "Preguntar");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n\r\n");
            __builder.AddMarkupContent(11, "<div>\r\n    la pregunta es: <span id=\"answerSpan\"></span>\r\n</div>\r\n\r\n\r\n");
            __builder.OpenComponent<PruebaCrud.Client.Shared.SurveyPrompt>(12);
            __builder.AddAttribute(13, "Title", "How is Blazor working for you?");
            __builder.CloseComponent();
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