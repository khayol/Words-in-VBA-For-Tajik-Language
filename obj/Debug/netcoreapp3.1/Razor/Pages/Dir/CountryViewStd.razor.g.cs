#pragma checksum "E:\A_NewProjects\01\Woorj\Pages\Dir\CountryViewStd.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b234d767cda9b3208188b5321b8d8d36fab4f34d"
// <auto-generated/>
#pragma warning disable 1591
namespace Woorj.Pages.Dir
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Toolbelt.Blazor.HeadElement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Blazored.Menu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Blazored.FluentValidation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.Data.GeneralComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.Data.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.Data.Adm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.Data.Dir;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.Data.IndOrg;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.CtrServerSide.Adm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.CtrServerSide.Dir;

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.CtrServerSide.IndOrg;

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.Pages.GeneralComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.Pages.TESTS.L22;

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.Pages.TESTS.GeneralComponents;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Dir/CountryViewStd/{Id}")]
    public partial class CountryViewStd : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Roles", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 6 "E:\A_NewProjects\01\Woorj\Pages\Dir\CountryViewStd.razor"
                       admSer.GetAccessRights("CountryViewStd")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
#nullable restore
#line 8 "E:\A_NewProjects\01\Woorj\Pages\Dir\CountryViewStd.razor"
 if (CountryList == null)
{

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(3, "<p><em>Loading...</em></p>");
#nullable restore
#line 11 "E:\A_NewProjects\01\Woorj\Pages\Dir\CountryViewStd.razor"
}
else
{ 

#line default
#line hidden
#nullable disable
                __Blazor.Woorj.Pages.Dir.CountryViewStd.TypeInference.CreateDataGridComp_0(__builder2, 4, 5, 
#nullable restore
#line 15 "E:\A_NewProjects\01\Woorj\Pages\Dir\CountryViewStd.razor"
                             CountryList

#line default
#line hidden
#nullable disable
                , 6, 
#nullable restore
#line 16 "E:\A_NewProjects\01\Woorj\Pages\Dir\CountryViewStd.razor"
                           columnsDefinition

#line default
#line hidden
#nullable disable
                , 7, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 17 "E:\A_NewProjects\01\Woorj\Pages\Dir\CountryViewStd.razor"
                               SelectedRowMeth

#line default
#line hidden
#nullable disable
                ), 8, "Id", 9, "Id", 10, 
#nullable restore
#line 20 "E:\A_NewProjects\01\Woorj\Pages\Dir\CountryViewStd.razor"
                                  trs.GetTranslation("CountryViewStd",@AppData.ActiveUser,"Dir")

#line default
#line hidden
#nullable disable
                , 11, 
#nullable restore
#line 21 "E:\A_NewProjects\01\Woorj\Pages\Dir\CountryViewStd.razor"
                            new PagingConfig
                            {
                                Enabled = true,
                                CustomPager = false,
                                PageSize = @AppData.rowNumMid
                            }

#line default
#line hidden
#nullable disable
                , 12, (__builder3) => {
                    __builder3.OpenElement(13, "a");
                    __builder3.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "E:\A_NewProjects\01\Woorj\Pages\Dir\CountryViewStd.razor"
                           args => AddNew("/Dir/CountryAdd")

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(15, "value", "Add");
                    __builder3.AddAttribute(16, "class", "menu-itms");
                    __builder3.AddContent(17, "Add");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(18, "\r\n            ");
                    __builder3.OpenElement(19, "a");
                    __builder3.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "E:\A_NewProjects\01\Woorj\Pages\Dir\CountryViewStd.razor"
                           args => ViewOrEdit("/Dir/CountryEdit/", selectedRow,"Edit")

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(21, "class", "menu-itms");
                    __builder3.AddContent(22, "Edit");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(23, "\r\n            ");
                    __builder3.OpenElement(24, "a");
                    __builder3.AddAttribute(25, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "E:\A_NewProjects\01\Woorj\Pages\Dir\CountryViewStd.razor"
                           args => Delete("/Dir/CountryDelete/", selectedRow)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(26, "class", "menu-itms");
                    __builder3.AddContent(27, "Delete");
                    __builder3.CloseElement();
                }
                , 28, (__builder3) => {
                    __builder3.AddMarkupContent(29, "\r\n            &nbsp &nbsp\r\n            ");
                    __builder3.OpenComponent<Woorj.Pages.GeneralComponents.DGridColumnComp>(30);
                    __builder3.AddAttribute(31, "OnSearchTextChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.ChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 37 "E:\A_NewProjects\01\Woorj\Pages\Dir\CountryViewStd.razor"
                                                   OnCountrySearchTextChanged

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(32, "\r\n            ");
                    __builder3.OpenElement(33, "button");
                    __builder3.AddAttribute(34, "class", "btn bnt-style-general");
                    __builder3.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "E:\A_NewProjects\01\Woorj\Pages\Dir\CountryViewStd.razor"
                                                              args => FindSelectedRec()

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(36, "data-toggle", "tooltip");
                    __builder3.AddAttribute(37, "title", "Search");
                    __builder3.AddMarkupContent(38, "<span class=\"fa fa-search\" aria-hidden=\"true\" id=\"search-input\"></span>");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(39, "\r\n            ");
                    __builder3.OpenElement(40, "button");
                    __builder3.AddAttribute(41, "class", "btn bnt-style-general");
                    __builder3.AddAttribute(42, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "E:\A_NewProjects\01\Woorj\Pages\Dir\CountryViewStd.razor"
                                                              args => CleanSearchBox()

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(43, "data-toggle", "tooltip");
                    __builder3.AddAttribute(44, "title", "Clean search box");
                    __builder3.AddMarkupContent(45, "<span class=\"fa fa-chevron-left\" aria-hidden=\"true\"></span>");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(46, "\r\n            &nbsp &nbsp\r\n\r\n            ");
                    __builder3.OpenElement(47, "button");
                    __builder3.AddAttribute(48, "class", "btn bnt-style-general");
                    __builder3.AddAttribute(49, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "E:\A_NewProjects\01\Woorj\Pages\Dir\CountryViewStd.razor"
                                                              args => NavManager.NavigateTo(AppData.BaseUrlUri)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(50, "data-toggle", "tooltip");
                    __builder3.AddAttribute(51, "title", "Beck");
                    __builder3.AddMarkupContent(52, "<span class=\"fa fa-backward\" aria-hidden=\"true\"></span> Beck");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(53, "\r\n            ");
                    __builder3.OpenElement(54, "button");
                    __builder3.AddAttribute(55, "class", "btn bnt-style-general");
                    __builder3.AddAttribute(56, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "E:\A_NewProjects\01\Woorj\Pages\Dir\CountryViewStd.razor"
                                                              args => AddNew("/Dir/CountryAdd")

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(57, "data-toggle", "tooltip");
                    __builder3.AddAttribute(58, "title", "Add");
                    __builder3.AddMarkupContent(59, "<span class=\"fa fa-plus\" aria-hidden=\"true\"></span>");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(60, "\r\n            ");
                    __builder3.OpenElement(61, "button");
                    __builder3.AddAttribute(62, "class", "btn bnt-style-general");
                    __builder3.AddAttribute(63, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "E:\A_NewProjects\01\Woorj\Pages\Dir\CountryViewStd.razor"
                                                              args => ViewOrEdit("/Dir/CountryEdit/", selectedRow,"View")

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(64, "data-toggle", "tooltip");
                    __builder3.AddAttribute(65, "title", "View");
                    __builder3.AddMarkupContent(66, "<span class=\"fa fa-file\" aria-hidden=\"true\"></span>");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(67, "\r\n            ");
                    __builder3.OpenElement(68, "button");
                    __builder3.AddAttribute(69, "class", "btn bnt-style-general");
                    __builder3.AddAttribute(70, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "E:\A_NewProjects\01\Woorj\Pages\Dir\CountryViewStd.razor"
                                                              args => ViewOrEdit("/Dir/CountryEdit/", selectedRow,"Edit")

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(71, "data-toggle", "tooltip");
                    __builder3.AddAttribute(72, "title", "Edit");
                    __builder3.AddMarkupContent(73, "<span class=\"fa fa-pencil\" aria-hidden=\"true\"></span>");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(74, "\r\n            ");
                    __builder3.OpenElement(75, "button");
                    __builder3.AddAttribute(76, "class", "btn bnt-style-general");
                    __builder3.AddAttribute(77, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 46 "E:\A_NewProjects\01\Woorj\Pages\Dir\CountryViewStd.razor"
                                                              args => Delete("/Dir/CountryDelete/", selectedRow)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(78, "data-toggle", "tooltip");
                    __builder3.AddAttribute(79, "title", "Delete");
                    __builder3.AddMarkupContent(80, "<span class=\"fa fa-trash\" aria-hidden=\"true\"></span>");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(81, "\r\n            ");
                    __builder3.OpenElement(82, "button");
                    __builder3.AddAttribute(83, "class", "btn bnt-style-general");
                    __builder3.AddAttribute(84, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "E:\A_NewProjects\01\Woorj\Pages\Dir\CountryViewStd.razor"
                                                              args => FilterData()

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(85, "data-toggle", "tooltip");
                    __builder3.AddAttribute(86, "title", "Filter");
                    __builder3.AddMarkupContent(87, "<span class=\"fa fa-filter\" aria-hidden=\"true\"></span>");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(88, "\r\n            ");
                    __builder3.OpenElement(89, "button");
                    __builder3.AddAttribute(90, "class", "btn bnt-style-general");
                    __builder3.AddAttribute(91, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "E:\A_NewProjects\01\Woorj\Pages\Dir\CountryViewStd.razor"
                                                              args => ExportToExcel()

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(92, "data-toggle", "tooltip");
                    __builder3.AddAttribute(93, "title", "Export to Excel");
                    __builder3.AddMarkupContent(94, "<span class=\"fa fa-file-excel-o\" aria-hidden=\"true\"></span>");
                    __builder3.CloseElement();
                }
                , 95, (__value) => {
#nullable restore
#line 14 "E:\A_NewProjects\01\Woorj\Pages\Dir\CountryViewStd.razor"
                        grid = __value;

#line default
#line hidden
#nullable disable
                }
                );
#nullable restore
#line 52 "E:\A_NewProjects\01\Woorj\Pages\Dir\CountryViewStd.razor"
 } 

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 57 "E:\A_NewProjects\01\Woorj\Pages\Dir\CountryViewStd.razor"
            

  


    [Parameter]
    public string Id { get; set; }
   // Country objEmp = new Country();
    private List<Country> CountryList;
    private List<Country> filteredCountryList { get; set; }
    private DataGridComp<Country> grid;
        
    private List<ColumnDefinition> columnsDefinition;

    private string selectedRow { get; set; } = "";

        private int CurrentPage { get; set; } = 1;
       


    private void OnCountrySearchTextChanged(ChangeEventArgs changeEventArgs)
    {
        string searchValue = changeEventArgs.Value.ToString();
        CountryList = CountryController.GetCountryByFiled(searchValue,int.Parse(Id));
        GoToFirstPage();
        GetCurrentPage();         
    }


    private void SelectedRowMeth(string pSelectedRow)
    {
        selectedRow = pSelectedRow;
        AppData.CountryIdSlcd= selectedRow;
        AppData.CountryCode = CountryController.GetCountryCodeById(int.Parse(selectedRow));
               //   AppData.CountryPageNum = grid.CurrentPage.ToString();
    }

    protected void FindSelectedRec()
    {
        //JSRuntime.InvokeVoidAsync("msgbox","Test");
        string searchValue = AppData.CountryCode;
        CountryList = CountryController.GetCountryByFiled(searchValue,int.Parse(Id));
        GoToFirstPage();
        GetCurrentPage();
        
    }

    protected void CleanSearchBox()
    {
        //JSRuntime.InvokeVoidAsync("msgbox","Test");
        string searchValue = AppData.CountryCode = "";
        CountryList = CountryController.GetCountryByFiled(searchValue,int.Parse(Id));
        GoToFirstPage();
        GetCurrentPage();
        selectedRow = "";
        
    }

    protected override void OnInitialized()
    {
        base.OnInitialized();
        Initilize();
        //  selectedRow = AppData.CountryIdSlcd;
        AppData.ActivePageName="View-Country";
        
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

                     new ColumnDefinition { DataField = "Code", Caption="Code" },
                    new ColumnDefinition { DataField = "Name", Caption="Name" },
                    new ColumnDefinition { DataField = "FullName", Caption="FullName" },
                    new ColumnDefinition { DataField = "English", Caption="InEnglish" },
                    new ColumnDefinition { DataField = "Alpha2", Caption="Alpha2" },
                    new ColumnDefinition { DataField = "Alpha3", Caption="Alpha3" },
                    new ColumnDefinition { DataField = "CreatedDate", Caption="CreatedDate" },
                   
                    }
            );
        }

        CountryList = CountryController.GetCountryById2(int.Parse(Id)).ToList();

    }
    private void GoToFirstPage()
    {
     grid.GoToFirstPage();
     CurrentPage=1;    
    }
    private void GetCurrentPage()
    {
        CurrentPage= grid.GetCurrentPage();        
    }

    private void ViewOrEditFlag(string pViewOrEdit)
    {
        if(pViewOrEdit.ToUpper()=="VIEW")
        {
            AppData.readonlyMain1=true;
            AppData.readonlyMain2=true;
            AppData.readonlyOther=true;
        }
        else if(pViewOrEdit.ToUpper()=="EDIT")
        {
            AppData.readonlyMain1=true;
            AppData.readonlyMain2=true;
            AppData.readonlyOther=false; 
        }
    }

    protected void NavigateTo(string pNavLink)
    {
        NavManager.NavigateTo(pNavLink);
    }
    protected void AddNew(string pNavLink)
    {
        ViewOrEditFlag("EDIT");
         NavManager.NavigateTo(pNavLink);
    }

    protected void ViewOrEdit(string pNavLink, string p_selectedRow, string pViewOrEdit)
    {
        ViewOrEditFlag(pViewOrEdit);

        if (string.IsNullOrEmpty(p_selectedRow)   || int.Parse(p_selectedRow)==0) //String.IsNullOrEmpty(p_selectedRow)
        {
            JSRuntime.InvokeVoidAsync("msgbox",GlobVarStat.rowNotChoosed_msg);
        }
        else
        {
            NavManager.NavigateTo(pNavLink + p_selectedRow);
        }
    }

    protected void Delete(string pNavLink, string p_selectedRow)
    {
        if (string.IsNullOrEmpty(p_selectedRow)) //String.IsNullOrEmpty(p_selectedRow)
        {
            JSRuntime.InvokeVoidAsync("msgbox",GlobVarStat.rowNotChoosed_msg);
        }
        else
        {
            NavManager.NavigateTo(pNavLink + p_selectedRow);
        }

    }

    protected void ExportToExcel()
    {
        // JSRuntime.InvokeVoidAsync("msgbox", "ExportToExcel");
        CountryController.GenerateExcel(JSRuntime,int.Parse(Id));
    }

    protected void FilterData()
    {
        JSRuntime.InvokeVoidAsync("msgbox", "FilterData");
        // CountryController.FilterData(JSRuntime);
    }

    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CountryController CountryController { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AppData AppData { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpContextAccessor hca { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdmService admSer { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICoreService serv { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICustomTranslator trs { get; set; }
    }
}
namespace __Blazor.Woorj.Pages.Dir.CountryViewStd
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateDataGridComp_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.List<TItem> __arg0, int __seq1, global::System.Collections.Generic.List<global::Woorj.Data.GeneralComponents.ColumnDefinition> __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<global::System.String> __arg2, int __seq3, global::System.String __arg3, int __seq4, global::System.String __arg4, int __seq5, global::System.String __arg5, int __seq6, global::Woorj.Data.GeneralComponents.PagingConfig __arg6, int __seq7, global::Microsoft.AspNetCore.Components.RenderFragment __arg7, int __seq8, global::Microsoft.AspNetCore.Components.RenderFragment __arg8, int __seq9, global::System.Action<global::Woorj.Pages.GeneralComponents.DataGridComp<TItem>> __arg9)
        {
        __builder.OpenComponent<global::Woorj.Pages.GeneralComponents.DataGridComp<TItem>>(seq);
        __builder.AddAttribute(__seq0, "DataItems", __arg0);
        __builder.AddAttribute(__seq1, "Columns", __arg1);
        __builder.AddAttribute(__seq2, "SelectedRow", __arg2);
        __builder.AddAttribute(__seq3, "UniqIdOfRecord", __arg3);
        __builder.AddAttribute(__seq4, "ColumnsToExcludeCSV", __arg4);
        __builder.AddAttribute(__seq5, "PageNameTitle", __arg5);
        __builder.AddAttribute(__seq6, "Paging", __arg6);
        __builder.AddAttribute(__seq7, "ControlMenu", __arg7);
        __builder.AddAttribute(__seq8, "ControlQuickAccess", __arg8);
        __builder.AddComponentReferenceCapture(__seq9, (__value) => { __arg9((global::Woorj.Pages.GeneralComponents.DataGridComp<TItem>)__value); });
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
