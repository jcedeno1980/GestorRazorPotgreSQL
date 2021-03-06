// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace GestorRazorPostgreSQL.Client.Pages.Entidades
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
#line 2 "C:\Users\jcedeno\Documents\desarrollos\pruebas\GestorRazorPostgreSQL\GestorRazorPostgreSQL\Client\Pages\Entidades\ListaEntidades.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jcedeno\Documents\desarrollos\pruebas\GestorRazorPostgreSQL\GestorRazorPostgreSQL\Client\Pages\Entidades\ListaEntidades.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jcedeno\Documents\desarrollos\pruebas\GestorRazorPostgreSQL\GestorRazorPostgreSQL\Client\Pages\Entidades\ListaEntidades.razor"
using GestorPostgreSQL.Shared.Modelos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jcedeno\Documents\desarrollos\pruebas\GestorRazorPostgreSQL\GestorRazorPostgreSQL\Client\Pages\Entidades\ListaEntidades.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/entidades")]
    public partial class ListaEntidades : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 133 "C:\Users\jcedeno\Documents\desarrollos\pruebas\GestorRazorPostgreSQL\GestorRazorPostgreSQL\Client\Pages\Entidades\ListaEntidades.razor"
       

    private List<Entidad> _totalemps;
    private List<Empleado> _emps;
    private List<Entidad> _ents;
    private string codigoentidadactual;
    private string selectedvalueEmpleado = "10766499";

    protected override async Task OnInitializedAsync()
    {

        try
        {
            _ents = await Http.GetFromJsonAsync<List<Entidad>>("/api/Entidades");
            _totalemps = await Http.GetFromJsonAsync<List<Entidad>>("/api/Empleados");

        }
        catch (AccessTokenNotAvailableException exception)
        {
            exception.Redirect();
        }

    }

    void OnSelect(ChangeEventArgs e)
    {
        selectedvalueEmpleado = e.Value.ToString();
        //Console.WriteLine("The selected country is : " + selectedString);
    }


    private async Task Delete(string Codigo)
    {
        await Http.DeleteAsync($"api/Entidades/{Codigo}");
        _ents = await Http.GetFromJsonAsync<List<Entidad>>("api/Entidades");
        StateHasChanged();
    }

    private async Task AgregarEmpleado(string codigoentidad, string codigoempleado )
    {
        await Http.PostAsJsonAsync<Entidad>($"api/Entidad/Empleado/{codigoentidad}/{codigoempleado}", null);
        await RowClick(codigoentidad);

    }

    private async Task DeleteEmpleado(string codigoentidad, string codigoempleado)
    {
        await Http.DeleteAsync($"api/Entidad/Empleado/{codigoentidad}/{codigoempleado}");

        await RowClick(codigoentidad);

    }


    private void Edit(string Codigo)
    {
        Navigation.NavigateTo($"/Entidad/edit/{Codigo}");
    }

    private void Create()
    {
        Navigation.NavigateTo("/entidad/create");
    }


    private async Task RowClick(string CodigoEntidad)
    {

        try
        {
            codigoentidadactual = CodigoEntidad;

            Entidad ent;

            ent = await Http.GetFromJsonAsync<Entidad>($"/api/Entidades/{CodigoEntidad}");

            _emps = ent.empleados;

        }
        catch (AccessTokenNotAvailableException exception)
        {

            exception.Redirect();
        }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
