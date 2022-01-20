#pragma checksum "C:\Users\jcedeno\Documents\desarrollos\pruebas\GestorRazorPostgreSQL\GestorRazorPostgreSQL\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f5edad40412de6776a1f77dc0736ddde3fd6874"
// <auto-generated/>
#pragma warning disable 1591
namespace GestorRazorPostgreSQL.Client.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<h2>Prueba Técnica de Desarrollo</h2>
<br>

Desarrollo de Operaciones CRUD con Razor WebAssembly (Front End)
<br>
API RESt con ASP.NET Core 5.0 (Back End)
<br>
Servidor de Bases de datos (PostgreSQL)
<br>
ORM - Microsoft Entity Framework Core
<br>

<br>
");
            __builder.AddMarkupContent(1, "<h2>Generalidades</h2>\r\n");
            __builder.AddMarkupContent(2, @"<ul><li>
        Desarrolle una solución que permita administrar “Entidades”, y a estas entidades
        se le deben poder agregar muchos “Empleados”, implementando los métodos
        “Get, GetAll, Create, Update, Delete”.
    </li>

    <li>
        La solución debe tener un mecanismo de autenticación básico, basado en usuario y contraseña y solo las personas autenticadas podrán hacer uso del sistema.
    </li>

    <li>
        Los datos deben quedar almacenados en una base de datos postgres. En lo posible se debe utilizar el componente de Entity Frameword Core,
        o cualquier método que se le facilite para lograr la persistencia y administración de los datos.
    </li></ul>

");
            __builder.AddMarkupContent(3, "<h2>Criterios de Aceptación:</h2>\r\n");
            __builder.AddMarkupContent(4, @"<ul><li>Url del código fuente de la solución en Github.</li>
    <li>
        Hacer un video con la presentación de la solución, donde nos detalle el funcionamiento de la misma,
        haciendo énfasis en el diseño, código desarrollado e implementación de la base de datos.
        Este video debe montarlo a Youtube y enviar el enlace.
    </li></ul>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591