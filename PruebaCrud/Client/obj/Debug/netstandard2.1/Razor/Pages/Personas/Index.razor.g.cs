#pragma checksum "C:\Users\Owner\source\repos\PruebaCrud-signalR\PruebaCrud\Client\Pages\Personas\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce747dde27426c4d84b17828447c7e43ec0cea94"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<h3>Personas</h3>\r\n\r\n");
            __builder.AddMarkupContent(1, "<div>\r\n    <a class=\"btn btn-success\" href=\"crear-persona\">Nueva Personas</a>\r\n</div>\r\n<br>\r\n");
#nullable restore
#line 10 "C:\Users\Owner\source\repos\PruebaCrud-signalR\PruebaCrud\Client\Pages\Personas\Index.razor"
 if (personas == null)
{
    

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, " Cargando...");
#nullable restore
#line 12 "C:\Users\Owner\source\repos\PruebaCrud-signalR\PruebaCrud\Client\Pages\Personas\Index.razor"
                             
}
else if (personas.Length == 0)
{
    

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, " No hay personas en la base de datos");
#nullable restore
#line 16 "C:\Users\Owner\source\repos\PruebaCrud-signalR\PruebaCrud\Client\Pages\Personas\Index.razor"
                                                     
}
else
{


#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", "table");
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.AddMarkupContent(7, "<thead>\r\n        <tr>\r\n            <th></th>\r\n            <th>Id</th>\r\n            <th>Nombre</th>\r\n        </tr>\r\n    </thead>\r\n    ");
            __builder.OpenElement(8, "tbody");
            __builder.AddMarkupContent(9, "\r\n");
#nullable restore
#line 30 "C:\Users\Owner\source\repos\PruebaCrud-signalR\PruebaCrud\Client\Pages\Personas\Index.razor"
         foreach (var persona in personas)
        {


#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "            ");
            __builder.OpenElement(11, "tr");
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenElement(13, "td");
            __builder.AddMarkupContent(14, "\r\n                    ");
            __builder.OpenElement(15, "a");
            __builder.AddAttribute(16, "class", "btn btn-success");
            __builder.AddAttribute(17, "href", "editar-persona/" + (
#nullable restore
#line 35 "C:\Users\Owner\source\repos\PruebaCrud-signalR\PruebaCrud\Client\Pages\Personas\Index.razor"
                                                                     persona.id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(18, "Editar");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "button");
            __builder.AddAttribute(21, "class", "btn btn-danger");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "C:\Users\Owner\source\repos\PruebaCrud-signalR\PruebaCrud\Client\Pages\Personas\Index.razor"
                                                               () => BorrarPersona(persona.id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(23, "Eliminar");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 38 "C:\Users\Owner\source\repos\PruebaCrud-signalR\PruebaCrud\Client\Pages\Personas\Index.razor"
                     persona.id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                ");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 39 "C:\Users\Owner\source\repos\PruebaCrud-signalR\PruebaCrud\Client\Pages\Personas\Index.razor"
                     persona.nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n");
#nullable restore
#line 41 "C:\Users\Owner\source\repos\PruebaCrud-signalR\PruebaCrud\Client\Pages\Personas\Index.razor"

        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(33, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n\r\n    ");
            __builder.AddMarkupContent(35, "<div class=\"row\">\r\n        <div class=\"col-6\"></div>\r\n        <div class=\"col-6\">\r\n            Accion:  <ul id=\"messagesList\">\r\n            </ul>\r\n        </div>\r\n        \r\n    </div>\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n");
#nullable restore
#line 55 "C:\Users\Owner\source\repos\PruebaCrud-signalR\PruebaCrud\Client\Pages\Personas\Index.razor"






}

#line default
#line hidden
#nullable disable
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