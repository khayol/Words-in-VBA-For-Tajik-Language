#pragma checksum "E:\A_NewProjects\01\Woorj\Pages\Dir\Gender\ViewStd.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "738bff9ac1aa534dd6876575da5d57a557592ed0"
// <auto-generated/>
#pragma warning disable 1591
namespace Woorj.Pages.Dir.Gender
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
#line 12 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Toolbelt.Blazor.HeadElement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Blazored.Menu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Blazored.FluentValidation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.Data.WrComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.Data.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.Data.Adm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.Data.Dir;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.Data.IndOrg;

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.CtrServerSide.Adm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.CtrServerSide.Dir;

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.CtrServerSide.IndOrg;

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.Pages.WrComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.Pages.TESTS.L22;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Dir/Gender/ViewStd/{Id}")]
    public partial class ViewStd : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Woorj.Pages.WrComponents.WrAuth>(0);
            __builder.AddAttribute(1, "PageName", "GenderViewStd");
            __builder.AddAttribute(2, "MainContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __Blazor.Woorj.Pages.Dir.Gender.ViewStd.TypeInference.CreateWrDataGrid_0(__builder2, 3, 4, 
#nullable restore
#line 6 "E:\A_NewProjects\01\Woorj\Pages\Dir\Gender\ViewStd.razor"
                             list

#line default
#line hidden
#nullable disable
                , 5, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 7 "E:\A_NewProjects\01\Woorj\Pages\Dir\Gender\ViewStd.razor"
                               SelectedRowMeth

#line default
#line hidden
#nullable disable
                ), 6, 
#nullable restore
#line 8 "E:\A_NewProjects\01\Woorj\Pages\Dir\Gender\ViewStd.razor"
                            MainController.columns

#line default
#line hidden
#nullable disable
                , 7, "Id", 8, "Id", 9, "GenderViewStd::Dir", 10, "/MainMenu", 11, 
#nullable restore
#line 13 "E:\A_NewProjects\01\Woorj\Pages\Dir\Gender\ViewStd.razor"
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
                    __builder3.OpenComponent<Woorj.Pages.WrComponents.WrOper>(13);
                    __builder3.AddAttribute(14, "Design", "a");
                    __builder3.AddAttribute(15, "Type", "C");
                    __builder3.AddAttribute(16, "Link", "/Dir/Gender/Add");
                    __builder3.AddAttribute(17, "Txt", "Add");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(18, "\r\n            ");
                    __builder3.OpenComponent<Woorj.Pages.WrComponents.WrOper>(19);
                    __builder3.AddAttribute(20, "Design", "a");
                    __builder3.AddAttribute(21, "Type", "R");
                    __builder3.AddAttribute(22, "Link", "/Dir/Gender/View/");
                    __builder3.AddAttribute(23, "LinkId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "E:\A_NewProjects\01\Woorj\Pages\Dir\Gender\ViewStd.razor"
                                                                            AppData.Gender_IdSelect

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(24, "Txt", "View");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(25, "\r\n            ");
                    __builder3.OpenComponent<Woorj.Pages.WrComponents.WrOper>(26);
                    __builder3.AddAttribute(27, "Design", "a");
                    __builder3.AddAttribute(28, "Type", "U");
                    __builder3.AddAttribute(29, "Link", "/Dir/Gender/Edit/");
                    __builder3.AddAttribute(30, "LinkId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "E:\A_NewProjects\01\Woorj\Pages\Dir\Gender\ViewStd.razor"
                                                                            AppData.Gender_IdSelect

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(31, "Txt", "Edit");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(32, "\r\n            ");
                    __builder3.OpenComponent<Woorj.Pages.WrComponents.WrOper>(33);
                    __builder3.AddAttribute(34, "Design", "a");
                    __builder3.AddAttribute(35, "Type", "D");
                    __builder3.AddAttribute(36, "Link", "/Dir/Gender/Delete/");
                    __builder3.AddAttribute(37, "LinkId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "E:\A_NewProjects\01\Woorj\Pages\Dir\Gender\ViewStd.razor"
                                                                            AppData.Gender_IdSelect

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(38, "Txt", "Delete");
                    __builder3.CloseComponent();
                }
                , 39, (__builder3) => {
                    __builder3.OpenComponent<Woorj.Pages.WrComponents.WrSrchDGrid>(40);
                    __builder3.AddAttribute(41, "OnSearchTextChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.ChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 30 "E:\A_NewProjects\01\Woorj\Pages\Dir\Gender\ViewStd.razor"
                                              SearchTxt

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(42, "\r\n            ");
                    __builder3.OpenComponent<Woorj.Pages.WrComponents.WrSpace>(43);
                    __builder3.AddAttribute(44, "Length", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 31 "E:\A_NewProjects\01\Woorj\Pages\Dir\Gender\ViewStd.razor"
                            2

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(45, "\r\n            ");
                    __builder3.OpenComponent<Woorj.Pages.WrComponents.WrOper>(46);
                    __builder3.AddAttribute(47, "Category", "RunCmd");
                    __builder3.AddAttribute(48, "Design", "btn");
                    __builder3.AddAttribute(49, "Ico", "fa fa-angle-double-down");
                    __builder3.AddAttribute(50, "OnClickCallback", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "E:\A_NewProjects\01\Woorj\Pages\Dir\Gender\ViewStd.razor"
                                                                                                   CleanSearchBox

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(51, "TxtToolTip", "ShowMoreRecords");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(52, "\r\n            ");
                    __builder3.OpenComponent<Woorj.Pages.WrComponents.WrOper>(53);
                    __builder3.AddAttribute(54, "Category", "RunCmd");
                    __builder3.AddAttribute(55, "Design", "btn");
                    __builder3.AddAttribute(56, "Ico", "fa fa-hand-pointer-o");
                    __builder3.AddAttribute(57, "OnClickCallback", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "E:\A_NewProjects\01\Woorj\Pages\Dir\Gender\ViewStd.razor"
                                                                                                FindSelectedRec

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(58, "TxtToolTip", "Choose");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(59, "\r\n            ");
                    __builder3.OpenComponent<Woorj.Pages.WrComponents.WrSpace>(60);
                    __builder3.AddAttribute(61, "Length", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 34 "E:\A_NewProjects\01\Woorj\Pages\Dir\Gender\ViewStd.razor"
                            2

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(62, "\r\n            ");
                    __builder3.OpenComponent<Woorj.Pages.WrComponents.WrOper>(63);
                    __builder3.AddAttribute(64, "Design", "btn");
                    __builder3.AddAttribute(65, "Type", "C");
                    __builder3.AddAttribute(66, "Ico", "fa fa-plus");
                    __builder3.AddAttribute(67, "Link", "/Dir/Gender/Add");
                    __builder3.AddAttribute(68, "TxtToolTip", "Add");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(69, "\r\n            ");
                    __builder3.OpenComponent<Woorj.Pages.WrComponents.WrOper>(70);
                    __builder3.AddAttribute(71, "Design", "btn");
                    __builder3.AddAttribute(72, "Type", "R");
                    __builder3.AddAttribute(73, "Ico", "fa fa-file");
                    __builder3.AddAttribute(74, "Link", "/Dir/Gender/View/");
                    __builder3.AddAttribute(75, "LinkId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 36 "E:\A_NewProjects\01\Woorj\Pages\Dir\Gender\ViewStd.razor"
                                                                                                AppData.Gender_IdSelect

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(76, "TxtToolTip", "View");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(77, "\r\n            ");
                    __builder3.OpenComponent<Woorj.Pages.WrComponents.WrOper>(78);
                    __builder3.AddAttribute(79, "Design", "btn");
                    __builder3.AddAttribute(80, "Type", "U");
                    __builder3.AddAttribute(81, "Ico", "fa fa-pencil");
                    __builder3.AddAttribute(82, "Link", "/Dir/Gender/Edit/");
                    __builder3.AddAttribute(83, "LinkId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 37 "E:\A_NewProjects\01\Woorj\Pages\Dir\Gender\ViewStd.razor"
                                                                                                AppData.Gender_IdSelect

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(84, "TxtToolTip", "Edit");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(85, "\r\n            ");
                    __builder3.OpenComponent<Woorj.Pages.WrComponents.WrOper>(86);
                    __builder3.AddAttribute(87, "Design", "btn");
                    __builder3.AddAttribute(88, "Type", "D");
                    __builder3.AddAttribute(89, "Ico", "fa fa-trash");
                    __builder3.AddAttribute(90, "Link", "/Dir/Gender/Delete/");
                    __builder3.AddAttribute(91, "LinkId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 38 "E:\A_NewProjects\01\Woorj\Pages\Dir\Gender\ViewStd.razor"
                                                                                                AppData.Gender_IdSelect

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(92, "TxtToolTip", "Delete");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(93, "\r\n            ");
                    __builder3.OpenComponent<Woorj.Pages.WrComponents.WrSpace>(94);
                    __builder3.AddAttribute(95, "Length", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 39 "E:\A_NewProjects\01\Woorj\Pages\Dir\Gender\ViewStd.razor"
                            2

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(96, "\r\n            ");
                    __builder3.OpenComponent<Woorj.Pages.WrComponents.WrOper>(97);
                    __builder3.AddAttribute(98, "Category", "RunCmd");
                    __builder3.AddAttribute(99, "Design", "btn");
                    __builder3.AddAttribute(100, "Ico", "fa fa-filter");
                    __builder3.AddAttribute(101, "OnClickCallback", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "E:\A_NewProjects\01\Woorj\Pages\Dir\Gender\ViewStd.razor"
                                                                                        FilterData

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(102, "TxtToolTip", "Filter");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(103, "\r\n            ");
                    __builder3.OpenComponent<Woorj.Pages.WrComponents.WrOper>(104);
                    __builder3.AddAttribute(105, "Category", "RunCmd");
                    __builder3.AddAttribute(106, "Design", "btn");
                    __builder3.AddAttribute(107, "Ico", "fa fa-file-excel-o");
                    __builder3.AddAttribute(108, "OnClickCallback", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "E:\A_NewProjects\01\Woorj\Pages\Dir\Gender\ViewStd.razor"
                                                                                              ExportToExcel

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(109, "TxtToolTip", "ExportToExcel");
                    __builder3.CloseComponent();
                }
                , 110, (__value) => {
#nullable restore
#line 5 "E:\A_NewProjects\01\Woorj\Pages\Dir\Gender\ViewStd.razor"
                      grid = __value;

#line default
#line hidden
#nullable disable
                }
                );
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "E:\A_NewProjects\01\Woorj\Pages\Dir\Gender\ViewStd.razor"
        


 #region     Declare
    [Parameter]
    public string Id { get; set; }
    private WrDataGrid<Gender> grid;
    private List<Gender> list;
    private string searchValue   { get; set; }
 
 #endregion  Declare

 #region    BlazorMethods

    protected override void OnInitialized()
    {
        MainController.Initialized();
        list = MainController.GetById(int.Parse(Id)).ToList();         
    }

#endregion BlazorMethods

#region    Event

    private void SearchTxt(ChangeEventArgs changeEventArgs)
    {
        searchValue = changeEventArgs.Value.ToString();
        list = MainController.GetSearchByField(searchValue);
        grid.GoToFirstPage();
    }
    private void SelectedRowMeth(string pSelectedRow)
    {
        AppData.Gender_IdSelect = pSelectedRow;
    }
    protected void FindSelectedRec()
    {
        grid.GoToFirstPage();
        list = MainController.GetById(int.Parse(AppData.Gender_IdSelect));
    }
    protected void CleanSearchBox()
    {
        grid.GoToFirstPage();
        list = MainController.GetSearchByField("");
        AppData.Gender_IdSelect = "0";
    }
    protected void ExportToExcel()
    {
       // MainController.GenerateExcel(JSRuntime);
    }
    protected void FilterData()
    {
        JSRuntime.InvokeVoidAsync("msgbox", "FilterData");
    }
 #endregion Event


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private GenderController MainController { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavMeths NavMeths { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AppData AppData { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpContextAccessor hca { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdmService admSer { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICoreService serv { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICustomTranslator trs { get; set; }
    }
}
namespace __Blazor.Woorj.Pages.Dir.Gender.ViewStd
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateWrDataGrid_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.List<TItem> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<global::System.String> __arg1, int __seq2, global::System.Collections.Generic.List<global::Woorj.Data.WrComponents.ColumnDefinition> __arg2, int __seq3, global::System.String __arg3, int __seq4, global::System.String __arg4, int __seq5, global::System.String __arg5, int __seq6, global::System.String __arg6, int __seq7, global::Woorj.Data.WrComponents.PagingConfig __arg7, int __seq8, global::Microsoft.AspNetCore.Components.RenderFragment __arg8, int __seq9, global::Microsoft.AspNetCore.Components.RenderFragment __arg9, int __seq10, global::System.Action<global::Woorj.Pages.WrComponents.WrDataGrid<TItem>> __arg10)
        {
        __builder.OpenComponent<global::Woorj.Pages.WrComponents.WrDataGrid<TItem>>(seq);
        __builder.AddAttribute(__seq0, "DataItems", __arg0);
        __builder.AddAttribute(__seq1, "SelectedRow", __arg1);
        __builder.AddAttribute(__seq2, "Columns", __arg2);
        __builder.AddAttribute(__seq3, "UniqIdOfRecord", __arg3);
        __builder.AddAttribute(__seq4, "ColumnsToExcludeCSV", __arg4);
        __builder.AddAttribute(__seq5, "PageNameTitle", __arg5);
        __builder.AddAttribute(__seq6, "BackLink", __arg6);
        __builder.AddAttribute(__seq7, "Paging", __arg7);
        __builder.AddAttribute(__seq8, "ControlMenu", __arg8);
        __builder.AddAttribute(__seq9, "ControlQuickAccess", __arg9);
        __builder.AddComponentReferenceCapture(__seq10, (__value) => { __arg10((global::Woorj.Pages.WrComponents.WrDataGrid<TItem>)__value); });
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
