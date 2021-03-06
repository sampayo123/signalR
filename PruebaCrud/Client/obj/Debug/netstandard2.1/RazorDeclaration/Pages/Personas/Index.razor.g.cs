#pragma checksum "C:\Users\Owner\source\repos\PruebaCrud-signalR\PruebaCrud\Client\Pages\Personas\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce747dde27426c4d84b17828447c7e43ec0cea94"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace PruebaCrud.Client.Pages.Personas
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/indice-personas")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 64 "C:\Users\Owner\source\repos\PruebaCrud-signalR\PruebaCrud\Client\Pages\Personas\Index.razor"
       


    Persona[] personas { get; set; }

    protected override async Task OnInitializedAsync()
    {
        await CargarPersonas();
    }

    async Task CargarPersonas()
    {
        personas = await Http.GetJsonAsync<Persona[]>("personas");


              /* personas = new Persona[]
         {
              new Persona(){id=1, nombre="Israel"},
              new Persona(){id=2, nombre="Pedro"}
         };*/
    }



    async Task BorrarPersona(int idPersona)
    {

        var personaSeleccionada = personas.First(x => x.id == idPersona);
        string confirmacion = $"Deseas borrar a la persona {personaSeleccionada.nombre }?";
        if (await JS.InvokeAsync<bool>("confirm", confirmacion))
        {
            await Http.DeleteAsync($"personas/{idPersona}");
            await CargarPersonas();


        }









    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
