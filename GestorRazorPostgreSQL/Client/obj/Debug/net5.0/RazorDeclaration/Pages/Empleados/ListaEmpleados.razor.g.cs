// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "C:\Users\jcedeno\Documents\desarrollos\pruebas\GestorRazorPostgreSQL\GestorRazorPostgreSQL\Client\Pages\Empleados\ListaEmpleados.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jcedeno\Documents\desarrollos\pruebas\GestorRazorPostgreSQL\GestorRazorPostgreSQL\Client\Pages\Empleados\ListaEmpleados.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jcedeno\Documents\desarrollos\pruebas\GestorRazorPostgreSQL\GestorRazorPostgreSQL\Client\Pages\Empleados\ListaEmpleados.razor"
using GestorPostgreSQL.Shared.Modelos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jcedeno\Documents\desarrollos\pruebas\GestorRazorPostgreSQL\GestorRazorPostgreSQL\Client\Pages\Empleados\ListaEmpleados.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/empleados")]
    public partial class ListaEmpleados : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 131 "C:\Users\jcedeno\Documents\desarrollos\pruebas\GestorRazorPostgreSQL\GestorRazorPostgreSQL\Client\Pages\Empleados\ListaEmpleados.razor"
       

    private List<Entidad> _totalents;
    private List<Empleado> _emps;
    private List<Entidad> _ents;
    private string codigoempleadoactual;
    private string selectedvalueEntidad = "80040045";

    protected override async Task OnInitializedAsync()
    {

        try
        {
            _emps = await Http.GetFromJsonAsync<List<Empleado>>("/api/Empleados");
            _totalents = await Http.GetFromJsonAsync<List<Entidad>>("/api/Entidades");

        }
        catch (AccessTokenNotAvailableException exception)
        {
            exception.Redirect();
        }

    }

    void OnSelect(ChangeEventArgs e)
    {
        selectedvalueEntidad = e.Value.ToString();
        //Console.WriteLine("The selected country is : " + selectedString);
    }


    private async Task Delete(string Codigo)
    {
        await Http.DeleteAsync($"api/Empleados/{Codigo}");
        _emps = await Http.GetFromJsonAsync<List<Empleado>>("api/Empleados");
        StateHasChanged();
    }

    private async Task AgregarEntidad(string codigoempleado, string codigoentidad)
    {
        await Http.PostAsJsonAsync<Empleado>($"api/Empleados/Empresa/{codigoempleado}/{codigoentidad}", null);
        await RowClick(codigoempleado);

    }

    private async Task DeleteEntidad(string codigoempleado, string codigoentidad)
    {
        await Http.DeleteAsync($"api/Empleados/Empresa/{codigoempleado}/{codigoentidad}");

        await RowClick(codigoempleado);

    }


    private void Edit(string Codigo)
    {
        Navigation.NavigateTo($"/Empleados/edit/{Codigo}");
    }

    private void Create()
    {
        Navigation.NavigateTo("/empleados/create");
    }


    private async Task RowClick(string CodigoEmpleado)
    {

        try
        {
            codigoempleadoactual = CodigoEmpleado;

            Empleado emp;

            emp = await Http.GetFromJsonAsync<Empleado>($"/api/Empleados/{CodigoEmpleado}");

            _ents = emp.entidades;

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
