#pragma checksum "e:\NewProjects\01\Woorj\Pages\IndOrg\IndividualViewStd copy.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b01c0e92663957290b15a276ed32053fbc436820"
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
#line 1 "e:\NewProjects\01\Woorj\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "e:\NewProjects\01\Woorj\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "e:\NewProjects\01\Woorj\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "e:\NewProjects\01\Woorj\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "e:\NewProjects\01\Woorj\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "e:\NewProjects\01\Woorj\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "e:\NewProjects\01\Woorj\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "e:\NewProjects\01\Woorj\_Imports.razor"
using Woorj;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "e:\NewProjects\01\Woorj\_Imports.razor"
using Woorj.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "e:\NewProjects\01\Woorj\_Imports.razor"
using Toolbelt.Blazor.HeadElement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "e:\NewProjects\01\Woorj\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "e:\NewProjects\01\Woorj\_Imports.razor"
using Blazored.Menu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "e:\NewProjects\01\Woorj\_Imports.razor"
using Woorj.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "e:\NewProjects\01\Woorj\_Imports.razor"
using Woorj.Data.GeneralComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "e:\NewProjects\01\Woorj\_Imports.razor"
using Woorj.Pages.GeneralComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "e:\NewProjects\01\Woorj\_Imports.razor"
using Woorj.Data.IndOrg;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "e:\NewProjects\01\Woorj\_Imports.razor"
using Woorj.Data.Dir;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "e:\NewProjects\01\Woorj\_Imports.razor"
using Woorj.Pages.TESTS.L22;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "e:\NewProjects\01\Woorj\_Imports.razor"
using Woorj.Pages.TESTS.GeneralComponents;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/IndOrg/IndividualViewStd")]
    public partial class IndividualViewStd_copy : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 91 "e:\NewProjects\01\Woorj\Pages\IndOrg\IndividualViewStd copy.razor"
            
    private List<Individual> individualList;
    private List<Individual> filteredIndividualList { get; set; }
    private DataGridComp<Individual> grid;
    private List<ColumnDefinition> columnsDefinition;

   private string selectedRow { get; set; } = "";
    private  string BaseUrlUri { get; set; } = "";
    private int CurrentPage { get; set; } = 1;

    private void OnIndividualSearchTextChanged(ChangeEventArgs changeEventArgs)
    {
        string searchValue = changeEventArgs.Value.ToString();
        individualList = IndividualController.GetIndividualByFiled(searchValue);
        GoToFirstPage();
        GetCurrentPage();
         JSRuntime.InvokeVoidAsync("ResetSelectedRowColorChange");
    }


    private void SelectedRowMeth(string pSelectedRow)
    {
        selectedRow = pSelectedRow;
        AppData.Individual_IdSelect = selectedRow;
        AppData.IndividualCode = IndividualController.GetIndividualCodeById(int.Parse(selectedRow));
       // AppData.IndividualPageNum = grid.CurrentPage.ToString();
    }

    protected void FindSelectedRec()
    {
        //JSRuntime.InvokeVoidAsync("msgbox","Test");
        string searchValue = AppData.IndividualCode;
        individualList = IndividualController.GetIndividualByFiled(searchValue);
        GoToFirstPage();
        GetCurrentPage();
        JSRuntime.InvokeVoidAsync("ResetSelectedRowColorChange");
    }

    protected void CleanSearchBox()
    {
        //JSRuntime.InvokeVoidAsync("msgbox","Test");
        string searchValue = AppData.IndividualCode = "";
        individualList = IndividualController.GetIndividualByFiled(searchValue);
        GoToFirstPage();
        GetCurrentPage();
        selectedRow = "";
        JSRuntime.InvokeVoidAsync("ResetSelectedRowColorChange");
    }

    protected override void OnInitialized()
    {
        base.OnInitialized();
        Initilize();
        selectedRow = AppData.Individual_IdSelect;
        BaseUrlUri=NavigationManager.Uri.ToString(); 
        AppData.ActivePageName="View-Individual";
    }

    protected override void OnAfterRender(bool firstRender)
    {
        base.OnAfterRender(firstRender);
    }

    protected override void OnParametersSet()
    {
        base.OnParametersSet();

    }

    private void Initilize()
    {
        if (columnsDefinition == null)
        {
            columnsDefinition = new List<ColumnDefinition>();
            columnsDefinition.AddRange(
                new ColumnDefinition[] {

                    new ColumnDefinition { DataField = "Id", Caption="Id" },
                    new ColumnDefinition { DataField = "Code", Caption="Code"},
                    /*
                    new ColumnDefinition { DataField = "FirstName", Caption="First Name" },
                    new ColumnDefinition { DataField = "SecondName", Caption="Second Name" },
                    new ColumnDefinition { DataField = "LastName", Caption="Last Name" },
                  */
                    new ColumnDefinition { DataField = "FullName", Caption="Full Name" , SortDirection = SortDirection.Asc },
                    /*
                    new ColumnDefinition { DataField = "FirstNameEN", Caption="First Name English" },
                    new ColumnDefinition { DataField = "SecondNameEN", Caption="Second Name English" },
                    new ColumnDefinition { DataField = "LastNameEN", Caption="Last Name English" },
                    */
                    new ColumnDefinition { DataField = "FullNameEN", Caption="Full Name English" },
                    new ColumnDefinition { DataField = "BirthDay", Caption="Birth Day", Format = "dd.MM.yyyy", DataType = DataType.Date },

                    new ColumnDefinition { DataField = "TaxCode", Caption="Tax Code" },
                    new ColumnDefinition { DataField = "PassSerial", Caption="Pass Serial" },
                    new ColumnDefinition { DataField = "PassCode", Caption="Pass Code" },
                    new ColumnDefinition { DataField = "DocDate", Caption="Doc Date", Format = "dd-MM-yyyy", DataType = DataType.Date },
                    new ColumnDefinition { DataField = "DocDateEnd", Caption="Doc Date End", Format = "dd.MM.yyyy", DataType = DataType.Date },
                    new ColumnDefinition { DataField = "PassOrg", Caption="Pass Org" },
                    new ColumnDefinition { DataField = "Address", Caption="Address"},
            new ColumnDefinition { DataField = "Contact", Caption="Contact" ,DataType=DataType.List , LinkAddress="IndOrg/ContactViewStd/" },
            new ColumnDefinition { DataField = "Gender", Caption="Gender" , DataType=DataType.RelatedData,SelectedField="Name",SelectedFieldKey="GenderId"},
                    new ColumnDefinition { DataField = "CreatedDate", Caption="Created Date",Format = "dd.MM.yyyy hh:mm:ss", DataType = DataType.Date  },
           
                        //new ColumnDefinition { DataField = "Salary", Caption="Annual Salary", DataType = DataType.Currency, Alignment = Alignment.Right, Format="c", SortDirection = SortDirection.Desc },


                    }
            );
        }

        individualList = IndividualController.GetIndividual().ToList();

    }

    private void GoToFirstPage()
    {
        grid.GoToFirstPage();
        CurrentPage=1;
        JSRuntime.InvokeVoidAsync("ResetSelectedRowColorChange");
    }
    private void PrevPage()
    {
        grid.GoToPrevPage();
        GetCurrentPage();
        JSRuntime.InvokeVoidAsync("ResetSelectedRowColorChange");
    }
    
    private void NextPage()
    {
        grid.GoToNextPage();
        GetCurrentPage();
        JSRuntime.InvokeVoidAsync("ResetSelectedRowColorChange");
    }

    private void GetCurrentPage()
    {
        CurrentPage= grid.GetCurrentPage();        
    }


    protected void AddNew(string pNavLink)
    {
        NavigationManager.NavigateTo(pNavLink);
    }

GlobVar globVar= new GlobVar();

    protected void Edit(string pNavLink, string p_selectedRow)
    {
        if (string.IsNullOrEmpty(p_selectedRow)) //String.IsNullOrEmpty(p_selectedRow)
        {
            JSRuntime.InvokeVoidAsync("msgbox",globVar.rowNotChoosed_msg);
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
            JSRuntime.InvokeVoidAsync("msgbox",globVar.rowNotChoosed_msg);
        }
        else
        {
            NavigationManager.NavigateTo(pNavLink + p_selectedRow);
        }

    }

    protected void ExportToExcel()
    {
        // JSRuntime.InvokeVoidAsync("msgbox", "ExportToExcel");
        IndividualController.GenerateExcel(JSRuntime);
    }

    protected void FilterData()
    {
        JSRuntime.InvokeVoidAsync("msgbox", "FilterData");
        // IndividualController.FilterData(JSRuntime);
    }

    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AppData AppData { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IndividualController IndividualController { get; set; }
    }
}
#pragma warning restore 1591
