#pragma checksum "E:\NewProjects\01\Woorj\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d17095fc341f201625624e9b25e457758c7a767"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Woorj.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\NewProjects\01\Woorj\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\NewProjects\01\Woorj\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\NewProjects\01\Woorj\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\NewProjects\01\Woorj\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\NewProjects\01\Woorj\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\NewProjects\01\Woorj\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\NewProjects\01\Woorj\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\NewProjects\01\Woorj\_Imports.razor"
using Woorj;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\NewProjects\01\Woorj\_Imports.razor"
using Woorj.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\NewProjects\01\Woorj\_Imports.razor"
using Toolbelt.Blazor.HeadElement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\NewProjects\01\Woorj\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\NewProjects\01\Woorj\_Imports.razor"
using Blazored.Menu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\NewProjects\01\Woorj\_Imports.razor"
using Woorj.Pages.GeneralComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\NewProjects\01\Woorj\_Imports.razor"
using Woorj.Data.GeneralComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "E:\NewProjects\01\Woorj\_Imports.razor"
using Woorj.Data.IndOrg;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "E:\NewProjects\01\Woorj\_Imports.razor"
using Woorj.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "E:\NewProjects\01\Woorj\_Imports.razor"
using Woorj.Pages.TESTS.L22;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "E:\NewProjects\01\Woorj\_Imports.razor"
using Woorj.Pages.TESTS.GeneralComponents;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 121 "E:\NewProjects\01\Woorj\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }
    /*
    MenuBuilder menuBuilder = new MenuBuilder();

    protected override async Task OnInitializedAsync()
    {

        menuBuilder.AddItem(1, "Home", "/")
            .AddSubMenu(2, "SubMenu",
        new MenuBuilder()
        .AddItem(1, "Counter", "counter")
        .AddItem(2, "fetchData", "fetchdata"));
    }
    */


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
