#pragma checksum "E:\A_NewProjects\01\Woorj\Pages\IndOrg\Gender\ViewStd.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c0d3bfc7e78d59e8132b9a9218dc92976a7679e"
// <auto-generated/>
#pragma warning disable 1591
namespace Woorj.Pages.IndOrg.Gender
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/IndOrg/Gender/ViewStd/{Id}")]
    public partial class ViewStd : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Woorj.Pages.WrComponents.WrAuth>(0);
            __builder.AddAttribute(1, "PageName", "GenderViewStd");
            __builder.AddAttribute(2, "MainContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __Blazor.Woorj.Pages.IndOrg.Gender.ViewStd.TypeInference.CreateWrDataGrid_0(__builder2, 3, 4, 
#nullable restore
#line 6 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\Gender\ViewStd.razor"
                             list

#line default
#line hidden
#nullable disable
                , 5, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 7 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\Gender\ViewStd.razor"
                               SelectedRowMeth

#line default
#line hidden
#nullable disable
                ), 6, 
#nullable restore
#line 8 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\Gender\ViewStd.razor"
                            MainController.columns

#line default
#line hidden
#nullable disable
                , 7, "Id", 8, "Id", 9, "GenderViewStd::Dir", 10, "/IndOrg/Individual/ViewStd/0", 11, 
#nullable restore
#line 13 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\Gender\ViewStd.razor"
                            new PagingConfig
                            {
                                Enabled = false,
                                CustomPager = false,
                                PageSize = @AppData.rowNumMid
                            }

#line default
#line hidden
#nullable disable
                , 12, (__builder3) => {
                }
                , 13, (__value) => {
#nullable restore
#line 5 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\Gender\ViewStd.razor"
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
#line 26 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\Gender\ViewStd.razor"
        


 #region     Declare
    [Parameter] public string Id { get; set; }
    private WrDataGrid<Gender> grid;
    private List<Gender> list;
    [Parameter] public string selectedId { get; set;}="0";    
 
 #endregion  Declare

 #region    BlazorMethods

    protected override void OnInitialized()
    {
        MainController.Initialized();
        list = MainController.GetById(int.Parse(Id)).ToList();         
    }

#endregion BlazorMethods

#region    Event

    private void SelectedRowMeth(string pSelectedRow)
    {
        selectedId = pSelectedRow;
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
namespace __Blazor.Woorj.Pages.IndOrg.Gender.ViewStd
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateWrDataGrid_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.List<TItem> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<global::System.String> __arg1, int __seq2, global::System.Collections.Generic.List<global::Woorj.Data.WrComponents.ColumnDefinition> __arg2, int __seq3, global::System.String __arg3, int __seq4, global::System.String __arg4, int __seq5, global::System.String __arg5, int __seq6, global::System.String __arg6, int __seq7, global::Woorj.Data.WrComponents.PagingConfig __arg7, int __seq8, global::Microsoft.AspNetCore.Components.RenderFragment __arg8, int __seq9, global::System.Action<global::Woorj.Pages.WrComponents.WrDataGrid<TItem>> __arg9)
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
        __builder.AddAttribute(__seq8, "ControlQuickAccess", __arg8);
        __builder.AddComponentReferenceCapture(__seq9, (__value) => { __arg9((global::Woorj.Pages.WrComponents.WrDataGrid<TItem>)__value); });
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
