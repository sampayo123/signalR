#pragma checksum "C:\Users\Owner\source\repos\PruebaCrud-signalR\PruebaCrud\Client\Pages\Personas\FormularioPersonas.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45abba47c3262364126770038b194b0440f9ef8f"
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
    public partial class FormularioPersonas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 1 "C:\Users\Owner\source\repos\PruebaCrud-signalR\PruebaCrud\Client\Pages\Personas\FormularioPersonas.razor"
                  persona

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 1 "C:\Users\Owner\source\repos\PruebaCrud-signalR\PruebaCrud\Client\Pages\Personas\FormularioPersonas.razor"
                                           OnValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n    ");
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "form-field");
                __builder2.AddMarkupContent(7, "\r\n\r\n        ");
                __builder2.AddMarkupContent(8, "<label>Nombre:</label>\r\n        ");
                __builder2.OpenElement(9, "div");
                __builder2.AddMarkupContent(10, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(11);
                __builder2.AddAttribute(12, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 6 "C:\Users\Owner\source\repos\PruebaCrud-signalR\PruebaCrud\Client\Pages\Personas\FormularioPersonas.razor"
                                     persona.nombre

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => persona.nombre = __value, persona.nombre))));
                __builder2.AddAttribute(14, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => persona.nombre));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n            ");
                __Blazor.PruebaCrud.Client.Pages.Personas.FormularioPersonas.TypeInference.CreateValidationMessage_0(__builder2, 16, 17, 
#nullable restore
#line 7 "C:\Users\Owner\source\repos\PruebaCrud-signalR\PruebaCrud\Client\Pages\Personas\FormularioPersonas.razor"
                                      ()=> persona.nombre

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(18, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n\r\n\r\n    ");
                __builder2.OpenElement(21, "button");
                __builder2.AddAttribute(22, "type", "submit");
                __builder2.AddAttribute(23, "class", "btn btn-success");
                __builder2.AddContent(24, 
#nullable restore
#line 12 "C:\Users\Owner\source\repos\PruebaCrud-signalR\PruebaCrud\Client\Pages\Personas\FormularioPersonas.razor"
                                                   TextoBoton

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(26);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\r\n\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "C:\Users\Owner\source\repos\PruebaCrud-signalR\PruebaCrud\Client\Pages\Personas\FormularioPersonas.razor"
       

    [Parameter] public Persona persona { get; set; } = new Persona();
    [Parameter] public String TextoBoton { get; set; } = "Guardar cambios";
    [Parameter] public EventCallback OnValidSubmit { get; set; }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.PruebaCrud.Client.Pages.Personas.FormularioPersonas
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
