#pragma checksum "C:\Users\jcedeno\Documents\desarrollos\pruebas\GestorRazorPostgreSQL\GestorRazorPostgreSQL\Client\Pages\Empleados\CrearEmpleado.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a29399aa98e8aaeb1a2adcd91044ecf691749e8a"
// <auto-generated/>
#pragma warning disable 1591
namespace GestorRazorPostgreSQL.Client.Pages.Empleados
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\jcedeno\Documents\desarrollos\pruebas\GestorRazorPostgreSQL\GestorRazorPostgreSQL\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jcedeno\Documents\desarrollos\pruebas\GestorRazorPostgreSQL\GestorRazorPostgreSQL\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jcedeno\Documents\desarrollos\pruebas\GestorRazorPostgreSQL\GestorRazorPostgreSQL\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jcedeno\Documents\desarrollos\pruebas\GestorRazorPostgreSQL\GestorRazorPostgreSQL\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jcedeno\Documents\desarrollos\pruebas\GestorRazorPostgreSQL\GestorRazorPostgreSQL\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\jcedeno\Documents\desarrollos\pruebas\GestorRazorPostgreSQL\GestorRazorPostgreSQL\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\jcedeno\Documents\desarrollos\pruebas\GestorRazorPostgreSQL\GestorRazorPostgreSQL\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\jcedeno\Documents\desarrollos\pruebas\GestorRazorPostgreSQL\GestorRazorPostgreSQL\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\jcedeno\Documents\desarrollos\pruebas\GestorRazorPostgreSQL\GestorRazorPostgreSQL\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\jcedeno\Documents\desarrollos\pruebas\GestorRazorPostgreSQL\GestorRazorPostgreSQL\Client\_Imports.razor"
using GestorRazorPostgreSQL.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\jcedeno\Documents\desarrollos\pruebas\GestorRazorPostgreSQL\GestorRazorPostgreSQL\Client\_Imports.razor"
using GestorRazorPostgreSQL.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jcedeno\Documents\desarrollos\pruebas\GestorRazorPostgreSQL\GestorRazorPostgreSQL\Client\Pages\Empleados\CrearEmpleado.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jcedeno\Documents\desarrollos\pruebas\GestorRazorPostgreSQL\GestorRazorPostgreSQL\Client\Pages\Empleados\CrearEmpleado.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jcedeno\Documents\desarrollos\pruebas\GestorRazorPostgreSQL\GestorRazorPostgreSQL\Client\Pages\Empleados\CrearEmpleado.razor"
using GestorPostgreSQL.Shared.Modelos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jcedeno\Documents\desarrollos\pruebas\GestorRazorPostgreSQL\GestorRazorPostgreSQL\Client\Pages\Empleados\CrearEmpleado.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/empleados/create")]
    public partial class CrearEmpleado : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Crear Empleado</h3>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 12 "C:\Users\jcedeno\Documents\desarrollos\pruebas\GestorRazorPostgreSQL\GestorRazorPostgreSQL\Client\Pages\Empleados\CrearEmpleado.razor"
                  _emp

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 12 "C:\Users\jcedeno\Documents\desarrollos\pruebas\GestorRazorPostgreSQL\GestorRazorPostgreSQL\Client\Pages\Empleados\CrearEmpleado.razor"
                                       Post

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(5, "table");
                __builder2.AddAttribute(6, "class", "table");
                __builder2.OpenElement(7, "tr");
                __builder2.AddMarkupContent(8, "<td>Codigo:</td>\r\n            ");
                __builder2.OpenElement(9, "td");
                __builder2.OpenElement(10, "input");
                __builder2.AddAttribute(11, "type", "text");
                __builder2.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "C:\Users\jcedeno\Documents\desarrollos\pruebas\GestorRazorPostgreSQL\GestorRazorPostgreSQL\Client\Pages\Empleados\CrearEmpleado.razor"
                                          _emp.codigo

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _emp.codigo = __value, _emp.codigo));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(14, "\r\n        ");
                __builder2.OpenElement(15, "tr");
                __builder2.AddMarkupContent(16, "<td>Nombre:</td>\r\n            ");
                __builder2.OpenElement(17, "td");
                __builder2.OpenElement(18, "input");
                __builder2.AddAttribute(19, "type", "text");
                __builder2.AddAttribute(20, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "C:\Users\jcedeno\Documents\desarrollos\pruebas\GestorRazorPostgreSQL\GestorRazorPostgreSQL\Client\Pages\Empleados\CrearEmpleado.razor"
                                          _emp.nombre

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _emp.nombre = __value, _emp.nombre));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n        ");
                __builder2.OpenElement(23, "tr");
                __builder2.AddMarkupContent(24, "<td>Dirección:</td>\r\n            ");
                __builder2.OpenElement(25, "td");
                __builder2.OpenElement(26, "input");
                __builder2.AddAttribute(27, "type", "text");
                __builder2.AddAttribute(28, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "C:\Users\jcedeno\Documents\desarrollos\pruebas\GestorRazorPostgreSQL\GestorRazorPostgreSQL\Client\Pages\Empleados\CrearEmpleado.razor"
                                          _emp.direccion

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _emp.direccion = __value, _emp.direccion));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n        ");
                __builder2.OpenElement(31, "tr");
                __builder2.AddMarkupContent(32, "<td>Estudios:</td>\r\n            ");
                __builder2.OpenElement(33, "td");
                __builder2.OpenElement(34, "input");
                __builder2.AddAttribute(35, "type", "text");
                __builder2.AddAttribute(36, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 29 "C:\Users\jcedeno\Documents\desarrollos\pruebas\GestorRazorPostgreSQL\GestorRazorPostgreSQL\Client\Pages\Empleados\CrearEmpleado.razor"
                                          _emp.estudios

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(37, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _emp.estudios = __value, _emp.estudios));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n        ");
                __builder2.OpenElement(39, "tr");
                __builder2.AddMarkupContent(40, "<td>Fecha nacimiento:</td>\r\n            ");
                __builder2.OpenElement(41, "td");
                __builder2.OpenElement(42, "input");
                __builder2.AddAttribute(43, "type", "text");
                __builder2.AddAttribute(44, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 33 "C:\Users\jcedeno\Documents\desarrollos\pruebas\GestorRazorPostgreSQL\GestorRazorPostgreSQL\Client\Pages\Empleados\CrearEmpleado.razor"
                                          _emp.fechanacimiento

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(45, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _emp.fechanacimiento = __value, _emp.fechanacimiento));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n\r\n        ");
                __builder2.OpenElement(47, "tr");
                __builder2.OpenElement(48, "td");
                __builder2.AddAttribute(49, "colspan", "2");
                __builder2.AddAttribute(50, "style", "text-align:center");
                __builder2.AddMarkupContent(51, "<input type=\"submit\" class=\"btn btn-success\" value=\"Guardar\">\r\n                ");
                __builder2.OpenElement(52, "input");
                __builder2.AddAttribute(53, "type", "button");
                __builder2.AddAttribute(54, "class", "btn btn-dark");
                __builder2.AddAttribute(55, "value", "Cancelar");
                __builder2.AddAttribute(56, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "C:\Users\jcedeno\Documents\desarrollos\pruebas\GestorRazorPostgreSQL\GestorRazorPostgreSQL\Client\Pages\Empleados\CrearEmpleado.razor"
                                                                                     Cancelar

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "C:\Users\jcedeno\Documents\desarrollos\pruebas\GestorRazorPostgreSQL\GestorRazorPostgreSQL\Client\Pages\Empleados\CrearEmpleado.razor"
       
    private Empleado _emp = new();

    private async Task Post()
    {
        try
        {
            await Http.PostAsJsonAsync<Empleado>("/api/Empleados", _emp);
            Navigation.NavigateTo("/empleados");

        }
        catch (Exception ex)
        {

            await JsRuntime.InvokeVoidAsync("alert", "Error al crear un empleado" + @"\r\n" + ex.Message ); // Alert

        }

    }

    protected void Cancelar()
    {
        Navigation.NavigateTo("/empleados");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
