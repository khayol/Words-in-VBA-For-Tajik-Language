#pragma checksum "E:\NewProjects\01\Woorj\Pages\IndOrg\ViewStdSimpleTable.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b9c3fa4de24bef4e68890fb9a68f6d9704f2a67"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Woorj.Pages.IndOrg
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/IndOrg/ViewStdSimpleTable")]
    public partial class ViewStdSimpleTable : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "E:\NewProjects\01\Woorj\Pages\IndOrg\ViewStdSimpleTable.razor"
      
    List<Individual> individualList;

    private string selectedRow { get; set; } = "";

    private void SelectedRowMeth(string pSelectedRow)
    {
        selectedRow = pSelectedRow;
    }

    protected override async Task OnInitializedAsync()
    {
        individualList = await Task.Run(() => IndividualController.GetIndividual());

    }

    protected void AddNew(string pNavLink)
    {
        NavigationManager.NavigateTo(pNavLink);
        // Console.WriteLine("The C# Console runned");
        // JSRuntime.InvokeVoidAsync("console_write", "The JS Console Logging22 "+ selectedRow);
    }

    protected void Edit(string pNavLink, string p_selectedRow)
    {
        if (string.IsNullOrEmpty(p_selectedRow)) //String.IsNullOrEmpty(p_selectedRow)
        {
            JSRuntime.InvokeVoidAsync("msgbox", "Please, choose the record before running the command");
        }
        else
        {
            NavigationManager.NavigateTo(pNavLink + p_selectedRow);
        }
    }
    protected void Delete(string pNavLink, string p_selectedRow)
    {
        if (string.IsNullOrEmpty(p_selectedRow)) //String.IsNullOrEmpty(p_selectedRow)
        {
            JSRuntime.InvokeVoidAsync("msgbox", "Please, choose the record before running the command");
        }
        else
        {
            NavigationManager.NavigateTo(pNavLink + p_selectedRow);
        }

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IndividualController IndividualController { get; set; }
    }
}
#pragma warning restore 1591
