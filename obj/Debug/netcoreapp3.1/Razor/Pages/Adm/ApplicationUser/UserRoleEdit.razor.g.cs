#pragma checksum "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationUser\UserRoleEdit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6556f188161d0f27936a21332c6c744a2e14c62c"
// <auto-generated/>
#pragma warning disable 1591
namespace Woorj.Pages.Adm.ApplicationUser
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Adm/ApplicationUser/UserRoleEdit/{CurrentID}")]
    public partial class UserRoleEdit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Woorj.Pages.WrComponents.WrAuth>(0);
            __builder.AddAttribute(1, "PageName", "ContactViewStd");
            __builder.AddAttribute(2, "MainContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
#nullable restore
#line 7 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationUser\UserRoleEdit.razor"
 if (VGetUserRole_List == null)
                {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(3, "<p><em>Loading...</em></p>");
#nullable restore
#line 10 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationUser\UserRoleEdit.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "fix-possition");
                __builder2.OpenComponent<Woorj.Pages.WrComponents.WrPnlElm>(6);
                __builder2.AddAttribute(7, "ControlQuickAccess", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(8, "input");
                    __builder3.AddAttribute(9, "type", "button");
                    __builder3.AddAttribute(10, "class", "btn bnt-style-general");
                    __builder3.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationUser\UserRoleEdit.razor"
                                                                                  UpdateRoles

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(12, "value", 
#nullable restore
#line 16 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationUser\UserRoleEdit.razor"
                                                                                                       trs.GetTranslation("Update",@AppData.ActiveUser,"General")

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(13, "\r\n                    ");
                    __builder3.OpenElement(14, "input");
                    __builder3.AddAttribute(15, "type", "button");
                    __builder3.AddAttribute(16, "class", "btn btn bnt-style-general");
                    __builder3.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationUser\UserRoleEdit.razor"
                                                                                      Cancel

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(18, "value", 
#nullable restore
#line 17 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationUser\UserRoleEdit.razor"
                                                                                                      trs.GetTranslation("Cancel",@AppData.ActiveUser,"General")

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(19, "\r\n                        ");
                    __builder3.OpenElement(20, "label");
                    __builder3.AddAttribute(21, "for", "Code");
                    __builder3.AddAttribute(22, "class", "control-lable");
                    __builder3.AddMarkupContent(23, "\r\n                        &nbsp;&nbsp; &nbsp;&nbsp; ");
                    __builder3.AddContent(24, 
#nullable restore
#line 19 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationUser\UserRoleEdit.razor"
                                                   trs.GetTranslation("TheGroupsOfThisUser ",@AppData.ActiveUser,"Adm")

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(25, " :  ");
                    __builder3.AddContent(26, 
#nullable restore
#line 19 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationUser\UserRoleEdit.razor"
                                                                                                                                     objUser.Code

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(27, "    ");
                    __builder3.AddContent(28, 
#nullable restore
#line 19 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationUser\UserRoleEdit.razor"
                                                                                                                                                                objUser.UserName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(29, "    ");
                    __builder3.AddContent(30, 
#nullable restore
#line 19 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationUser\UserRoleEdit.razor"
                                                                                                                                                                                               objUser.FirstName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(31, "   ");
                    __builder3.AddContent(32, 
#nullable restore
#line 19 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationUser\UserRoleEdit.razor"
                                                                                                                                                                                                                         objUser.SecondName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
#nullable restore
#line 24 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationUser\UserRoleEdit.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "under-cls");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "form-group");
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "class", "row-pnl-layout");
#nullable restore
#line 31 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationUser\UserRoleEdit.razor"
               if (VGetUserRole_List == null)
                {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(39, "<p><em>Loading...</em></p>");
#nullable restore
#line 34 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationUser\UserRoleEdit.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "column-pnl-layout ");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "nav-pnl-layout");
                __builder2.AddContent(44, "                               ");
                __builder2.AddContent(45, 
#nullable restore
#line 40 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationUser\UserRoleEdit.razor"
                                          trs.GetTranslation("GrantedAccess",@AppData.ActiveUser,"Adm")

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n            \r\n               \r\n                    ");
                __Blazor.Woorj.Pages.Adm.ApplicationUser.UserRoleEdit.TypeInference.CreateWrDataGrid_0(__builder2, 47, 48, 
#nullable restore
#line 45 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationUser\UserRoleEdit.razor"
                                           VGetUserRole_List

#line default
#line hidden
#nullable disable
                , 49, 
#nullable restore
#line 46 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationUser\UserRoleEdit.razor"
                                          SrvRole.clmDef_VGetUserRole

#line default
#line hidden
#nullable disable
                , 50, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 47 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationUser\UserRoleEdit.razor"
                                             SelectedRowMeth

#line default
#line hidden
#nullable disable
                ), 51, "RoleId", 52, "RoleId,RoleName,Description", 53, 
#nullable restore
#line 50 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationUser\UserRoleEdit.razor"
                                          new PagingConfig
                                            {
                                                Enabled = true,
                                                CustomPager = false,
                                                PageSize = @AppData.rowNumMid
                                            }

#line default
#line hidden
#nullable disable
                , 54, (__builder3) => {
                    __builder3.OpenComponent<Woorj.Pages.WrComponents.WrSrchDGrid>(55);
                    __builder3.AddAttribute(56, "OnSearchTextChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.ChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 57 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationUser\UserRoleEdit.razor"
                                                               VGetUserRole_SchTxt

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                }
                , 57, (__value) => {
#nullable restore
#line 44 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationUser\UserRoleEdit.razor"
                                      grid_VGetUserRole = __value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
#nullable restore
#line 63 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationUser\UserRoleEdit.razor"
}

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(58, @"<div class=""column-pnl-layout"" style="" width: 60px; text-align: center;""><br><br><br><br><br>
            <button class=""btn bnt-style-general"" data-toggle=""tooltip"" title=""GrantSelectedAccesses""><span class=""fa fa-backward"" aria-hidden=""true""></span></button>
            <br><br>
            <button class=""btn bnt-style-general"" data-toggle=""tooltip"" title=""DeleteSelectedAccesses""><span class=""fa fa-forward"" aria-hidden=""true""></span></button>
            <br><br><br>
            <button class=""btn bnt-style-general"" data-toggle=""tooltip"" title=""GrantAllAccesses""><span class=""fa fa-fast-backward"" aria-hidden=""true""></span></button>
            <br><br>
            <button class=""btn bnt-style-general"" data-toggle=""tooltip"" title=""DeleteAllAccesses""><span class=""fa fa-fast-forward"" aria-hidden=""true""></span></button></div>
        
        ");
                __builder2.OpenElement(59, "div");
                __builder2.AddAttribute(60, "class", "column-pnl-layout");
                __builder2.OpenElement(61, "div");
                __builder2.AddAttribute(62, "class", "nav-pnl-layout");
                __builder2.AddMarkupContent(63, "\r\n                    &nbsp;&nbsp; ");
                __builder2.AddContent(64, 
#nullable restore
#line 77 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationUser\UserRoleEdit.razor"
                                  trs.GetTranslation("NotGrantedAccess",@AppData.ActiveUser,"Adm")

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 79 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationUser\UserRoleEdit.razor"
                 if (DiffRoleList == null)
                {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(65, "<p><em>Loading...</em></p>");
#nullable restore
#line 82 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationUser\UserRoleEdit.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
                __Blazor.Woorj.Pages.Adm.ApplicationUser.UserRoleEdit.TypeInference.CreateWrDataGrid_1(__builder2, 66, 67, 
#nullable restore
#line 86 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationUser\UserRoleEdit.razor"
                                           DiffRoleList

#line default
#line hidden
#nullable disable
                , 68, 
#nullable restore
#line 87 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationUser\UserRoleEdit.razor"
                                          SrvRole.clmDef_Role

#line default
#line hidden
#nullable disable
                , 69, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 88 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationUser\UserRoleEdit.razor"
                                             SelectedRowMeth

#line default
#line hidden
#nullable disable
                ), 70, "Id", 71, "Id,Name", 72, 
#nullable restore
#line 91 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationUser\UserRoleEdit.razor"
                                          new PagingConfig
                                            {
                                                Enabled = true,
                                                CustomPager = false,
                                                PageSize = @AppData.rowNumMid
                                            }

#line default
#line hidden
#nullable disable
                , 73, (__builder3) => {
                    __builder3.OpenComponent<Woorj.Pages.WrComponents.WrSrchDGrid>(74);
                    __builder3.AddAttribute(75, "OnSearchTextChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.ChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 98 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationUser\UserRoleEdit.razor"
                                                               DiffRoleList_SrchTxt

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                }
                , 76, (__value) => {
#nullable restore
#line 85 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationUser\UserRoleEdit.razor"
                                      grid_DiffRoleList = __value;

#line default
#line hidden
#nullable disable
                }
                );
#nullable restore
#line 101 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationUser\UserRoleEdit.razor"
                }

#line default
#line hidden
#nullable disable
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
#line 111 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationUser\UserRoleEdit.razor"
      

    #region  Declare
        [Parameter] public string CurrentID { get; set; }
        private string selectedRow { get; set; } = "";
        private List<VGetUserRole> VGetUserRole_List;       
        private List<ApplicationRole> ApplicationRole_List; 
        private List<ApplicationRole> DiffRoleList;  
        private WrDataGrid<ApplicationRole> grid_DiffRoleList;      
        private WrDataGrid<VGetUserRole> grid_VGetUserRole; 
        private ApplicationUser objUser = new ApplicationUser(); 
    #endregion  Declare
    
    #region  BlazorMethods
        
         protected override void OnInitialized()
        //protected override async Task OnInitializedAsync()
        {
            SrvRole.Init_UserRoleEdit();
          //  objUser = await Task.Run(() => SrvUser.GetApplicationUserById(CurrentID));
            objUser = SrvUser.GetApplicationUserById(CurrentID);
            VGetUserRole_List = SrvUser.GetUserRoleById(CurrentID).ToList();
            ApplicationRole_List=SrvRole.GetApplicationRole().ToList();
            DiffRoleList   = ApplicationRole_List.Where(x => !VGetUserRole_List.Any(y => x.Id == y.RoleId)).ToList();
        } 

    #endregion  BlazorMethods

    #region  Event

        private void DiffRoleList_SrchTxt(ChangeEventArgs changeEventArgs)
        {
            string searchValue = changeEventArgs.Value.ToString();
            DiffRoleList = SrvRole.GetApplicationRoleByFiled(searchValue); 
            grid_DiffRoleList.GoToFirstPage();       
        }
        private void VGetUserRole_SchTxt(ChangeEventArgs changeEventArgs)
        {
            string searchValue = changeEventArgs.Value.ToString();
            VGetUserRole_List = SrvRole.GetVGetUserRoleByFiled(searchValue, @objUser.Id);      
            grid_VGetUserRole.GoToFirstPage();  
        }
        private void SelectedRowMeth(string pSelectedRow)
        {
            selectedRow = pSelectedRow;
            AppData.UserRoleEditRoleIdSlcd = selectedRow;
            AppData.UserRoleEditRoleCode = SrvRole.GetApplicationRoleCodeById(selectedRow);
        }
        protected void UpdateRoles()
        {
          //  SrvUser.UpdateRoles(objUser);
            NavManager.NavigateTo("/Adm/ApplicationUserViewStd/"+CurrentID);
        }
        void Cancel()
        {
            NavManager.NavigateTo("/Adm/ApplicationUserViewStd/"+CurrentID);
        }
    #endregion  Event


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ApplicationRoleController SrvRole { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ApplicationUserController SrvUser { get; set; }
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
namespace __Blazor.Woorj.Pages.Adm.ApplicationUser.UserRoleEdit
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateWrDataGrid_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.List<TItem> __arg0, int __seq1, global::System.Collections.Generic.List<global::Woorj.Data.WrComponents.ColumnDefinition> __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<global::System.String> __arg2, int __seq3, global::System.String __arg3, int __seq4, global::System.String __arg4, int __seq5, global::Woorj.Data.WrComponents.PagingConfig __arg5, int __seq6, global::Microsoft.AspNetCore.Components.RenderFragment __arg6, int __seq7, global::System.Action<global::Woorj.Pages.WrComponents.WrDataGrid<TItem>> __arg7)
        {
        __builder.OpenComponent<global::Woorj.Pages.WrComponents.WrDataGrid<TItem>>(seq);
        __builder.AddAttribute(__seq0, "DataItems", __arg0);
        __builder.AddAttribute(__seq1, "Columns", __arg1);
        __builder.AddAttribute(__seq2, "SelectedRow", __arg2);
        __builder.AddAttribute(__seq3, "UniqIdOfRecord", __arg3);
        __builder.AddAttribute(__seq4, "ColumnsToExcludeCSV", __arg4);
        __builder.AddAttribute(__seq5, "Paging", __arg5);
        __builder.AddAttribute(__seq6, "ControlQuickAccess", __arg6);
        __builder.AddComponentReferenceCapture(__seq7, (__value) => { __arg7((global::Woorj.Pages.WrComponents.WrDataGrid<TItem>)__value); });
        __builder.CloseComponent();
        }
        public static void CreateWrDataGrid_1<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.List<TItem> __arg0, int __seq1, global::System.Collections.Generic.List<global::Woorj.Data.WrComponents.ColumnDefinition> __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<global::System.String> __arg2, int __seq3, global::System.String __arg3, int __seq4, global::System.String __arg4, int __seq5, global::Woorj.Data.WrComponents.PagingConfig __arg5, int __seq6, global::Microsoft.AspNetCore.Components.RenderFragment __arg6, int __seq7, global::System.Action<global::Woorj.Pages.WrComponents.WrDataGrid<TItem>> __arg7)
        {
        __builder.OpenComponent<global::Woorj.Pages.WrComponents.WrDataGrid<TItem>>(seq);
        __builder.AddAttribute(__seq0, "DataItems", __arg0);
        __builder.AddAttribute(__seq1, "Columns", __arg1);
        __builder.AddAttribute(__seq2, "SelectedRow", __arg2);
        __builder.AddAttribute(__seq3, "UniqIdOfRecord", __arg3);
        __builder.AddAttribute(__seq4, "ColumnsToExcludeCSV", __arg4);
        __builder.AddAttribute(__seq5, "Paging", __arg5);
        __builder.AddAttribute(__seq6, "ControlQuickAccess", __arg6);
        __builder.AddComponentReferenceCapture(__seq7, (__value) => { __arg7((global::Woorj.Pages.WrComponents.WrDataGrid<TItem>)__value); });
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
