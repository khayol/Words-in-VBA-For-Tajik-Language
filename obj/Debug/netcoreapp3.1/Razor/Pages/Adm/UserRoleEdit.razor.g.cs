#pragma checksum "E:\A_NewProjects\01\Woorj\Pages\Adm\UserRoleEdit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa6584b19fb990f7c60b32b5c2ece6ac6b317527"
// <auto-generated/>
#pragma warning disable 1591
namespace Woorj.Pages.Adm
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Adm/UserRoleEdit/{CurrentID}")]
    public partial class UserRoleEdit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 10 "E:\A_NewProjects\01\Woorj\Pages\Adm\UserRoleEdit.razor"
 if (VGetUserRole_List == null)
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<p><em>Loading...</em></p>");
#nullable restore
#line 13 "E:\A_NewProjects\01\Woorj\Pages\Adm\UserRoleEdit.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "fix-possition");
            __builder.OpenComponent<Woorj.Pages.GeneralComponents.PanelElemens>(3);
            __builder.AddAttribute(4, "ControlQuickAccess", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(5, "input");
                __builder2.AddAttribute(6, "type", "button");
                __builder2.AddAttribute(7, "class", "btn bnt-style-general");
                __builder2.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "E:\A_NewProjects\01\Woorj\Pages\Adm\UserRoleEdit.razor"
                                                                                  UpdateRoles

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "value", 
#nullable restore
#line 19 "E:\A_NewProjects\01\Woorj\Pages\Adm\UserRoleEdit.razor"
                                                                                                       trs.GetTranslation("Update",@AppData.ActiveUser,"General")

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(10, "\r\n                    ");
                __builder2.OpenElement(11, "input");
                __builder2.AddAttribute(12, "type", "button");
                __builder2.AddAttribute(13, "class", "btn btn bnt-style-general");
                __builder2.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "E:\A_NewProjects\01\Woorj\Pages\Adm\UserRoleEdit.razor"
                                                                                      Cancel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "value", 
#nullable restore
#line 20 "E:\A_NewProjects\01\Woorj\Pages\Adm\UserRoleEdit.razor"
                                                                                                      trs.GetTranslation("Cancel",@AppData.ActiveUser,"General")

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\r\n                        ");
                __builder2.OpenElement(17, "label");
                __builder2.AddAttribute(18, "for", "Code");
                __builder2.AddAttribute(19, "class", "control-lable");
                __builder2.AddMarkupContent(20, "\r\n                        &nbsp;&nbsp; &nbsp;&nbsp; ");
                __builder2.AddContent(21, 
#nullable restore
#line 22 "E:\A_NewProjects\01\Woorj\Pages\Adm\UserRoleEdit.razor"
                                                   trs.GetTranslation("TheGroupsOfThisUser ",@AppData.ActiveUser,"Adm")

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(22, " :  ");
                __builder2.AddContent(23, 
#nullable restore
#line 22 "E:\A_NewProjects\01\Woorj\Pages\Adm\UserRoleEdit.razor"
                                                                                                                                     objUser.Code

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(24, "    ");
                __builder2.AddContent(25, 
#nullable restore
#line 22 "E:\A_NewProjects\01\Woorj\Pages\Adm\UserRoleEdit.razor"
                                                                                                                                                                objUser.UserName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(26, "    ");
                __builder2.AddContent(27, 
#nullable restore
#line 22 "E:\A_NewProjects\01\Woorj\Pages\Adm\UserRoleEdit.razor"
                                                                                                                                                                                               objUser.FirstName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(28, "   ");
                __builder2.AddContent(29, 
#nullable restore
#line 22 "E:\A_NewProjects\01\Woorj\Pages\Adm\UserRoleEdit.razor"
                                                                                                                                                                                                                         objUser.SecondName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 27 "E:\A_NewProjects\01\Woorj\Pages\Adm\UserRoleEdit.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "under-cls");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "form-group");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "row-pnl-layout");
#nullable restore
#line 34 "E:\A_NewProjects\01\Woorj\Pages\Adm\UserRoleEdit.razor"
               if (VGetUserRole_List == null)
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(36, "<p><em>Loading...</em></p>");
#nullable restore
#line 37 "E:\A_NewProjects\01\Woorj\Pages\Adm\UserRoleEdit.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "column-pnl-layout ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "nav-pnl-layout");
            __builder.AddContent(41, "                               ");
            __builder.AddContent(42, 
#nullable restore
#line 43 "E:\A_NewProjects\01\Woorj\Pages\Adm\UserRoleEdit.razor"
                                          trs.GetTranslation("GrantedAccess",@AppData.ActiveUser,"Adm")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n            \r\n               \r\n                    ");
            __Blazor.Woorj.Pages.Adm.UserRoleEdit.TypeInference.CreateDataGridComp_0(__builder, 44, 45, 
#nullable restore
#line 48 "E:\A_NewProjects\01\Woorj\Pages\Adm\UserRoleEdit.razor"
                                           VGetUserRole_List

#line default
#line hidden
#nullable disable
            , 46, 
#nullable restore
#line 49 "E:\A_NewProjects\01\Woorj\Pages\Adm\UserRoleEdit.razor"
                                          SrvRole.clmDef_VGetUserRole

#line default
#line hidden
#nullable disable
            , 47, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 50 "E:\A_NewProjects\01\Woorj\Pages\Adm\UserRoleEdit.razor"
                                             SelectedRowMeth

#line default
#line hidden
#nullable disable
            ), 48, "RoleId", 49, "RoleId,RoleName,Description", 50, 
#nullable restore
#line 53 "E:\A_NewProjects\01\Woorj\Pages\Adm\UserRoleEdit.razor"
                                          new PagingConfig
                                            {
                                                Enabled = true,
                                                CustomPager = false,
                                                PageSize = @AppData.rowNumMid
                                            }

#line default
#line hidden
#nullable disable
            , 51, (__builder2) => {
                __builder2.OpenComponent<Woorj.Pages.GeneralComponents.DGridColumnComp>(52);
                __builder2.AddAttribute(53, "OnSearchTextChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.ChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 60 "E:\A_NewProjects\01\Woorj\Pages\Adm\UserRoleEdit.razor"
                                                                   VGetUserRole_SchTxt

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
            }
            , 54, (__value) => {
#nullable restore
#line 47 "E:\A_NewProjects\01\Woorj\Pages\Adm\UserRoleEdit.razor"
                                        grid_VGetUserRole = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseElement();
#nullable restore
#line 66 "E:\A_NewProjects\01\Woorj\Pages\Adm\UserRoleEdit.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(55, @"<div class=""column-pnl-layout"" style="" width: 60px; text-align: center;""><br><br><br><br><br>
            <button class=""btn bnt-style-general"" data-toggle=""tooltip"" title=""GrantSelectedAccesses""><span class=""fa fa-backward"" aria-hidden=""true""></span></button>
            <br><br>
            <button class=""btn bnt-style-general"" data-toggle=""tooltip"" title=""DeleteSelectedAccesses""><span class=""fa fa-forward"" aria-hidden=""true""></span></button>
            <br><br><br>
            <button class=""btn bnt-style-general"" data-toggle=""tooltip"" title=""GrantAllAccesses""><span class=""fa fa-fast-backward"" aria-hidden=""true""></span></button>
            <br><br>
            <button class=""btn bnt-style-general"" data-toggle=""tooltip"" title=""DeleteAllAccesses""><span class=""fa fa-fast-forward"" aria-hidden=""true""></span></button></div>
        
        ");
            __builder.OpenElement(56, "div");
            __builder.AddAttribute(57, "class", "column-pnl-layout");
            __builder.OpenElement(58, "div");
            __builder.AddAttribute(59, "class", "nav-pnl-layout");
            __builder.AddMarkupContent(60, "\r\n                    &nbsp;&nbsp; ");
            __builder.AddContent(61, 
#nullable restore
#line 80 "E:\A_NewProjects\01\Woorj\Pages\Adm\UserRoleEdit.razor"
                                  trs.GetTranslation("NotGrantedAccess",@AppData.ActiveUser,"Adm")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 82 "E:\A_NewProjects\01\Woorj\Pages\Adm\UserRoleEdit.razor"
                 if (DiffRoleList == null)
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(62, "<p><em>Loading...</em></p>");
#nullable restore
#line 85 "E:\A_NewProjects\01\Woorj\Pages\Adm\UserRoleEdit.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
            __Blazor.Woorj.Pages.Adm.UserRoleEdit.TypeInference.CreateDataGridComp_1(__builder, 63, 64, 
#nullable restore
#line 89 "E:\A_NewProjects\01\Woorj\Pages\Adm\UserRoleEdit.razor"
                                           DiffRoleList

#line default
#line hidden
#nullable disable
            , 65, 
#nullable restore
#line 90 "E:\A_NewProjects\01\Woorj\Pages\Adm\UserRoleEdit.razor"
                                          SrvRole.clmDef_Role

#line default
#line hidden
#nullable disable
            , 66, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 91 "E:\A_NewProjects\01\Woorj\Pages\Adm\UserRoleEdit.razor"
                                             SelectedRowMeth

#line default
#line hidden
#nullable disable
            ), 67, "Id", 68, "Id,Name", 69, 
#nullable restore
#line 94 "E:\A_NewProjects\01\Woorj\Pages\Adm\UserRoleEdit.razor"
                                          new PagingConfig
                                            {
                                                Enabled = true,
                                                CustomPager = false,
                                                PageSize = @AppData.rowNumMid
                                            }

#line default
#line hidden
#nullable disable
            , 70, (__builder2) => {
                __builder2.OpenComponent<Woorj.Pages.GeneralComponents.DGridColumnComp>(71);
                __builder2.AddAttribute(72, "OnSearchTextChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.ChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 101 "E:\A_NewProjects\01\Woorj\Pages\Adm\UserRoleEdit.razor"
                                                                   DiffRoleList_SrchTxt

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
            }
            , 73, (__value) => {
#nullable restore
#line 88 "E:\A_NewProjects\01\Woorj\Pages\Adm\UserRoleEdit.razor"
                                        grid_DiffRoleList = __value;

#line default
#line hidden
#nullable disable
            }
            );
#nullable restore
#line 104 "E:\A_NewProjects\01\Woorj\Pages\Adm\UserRoleEdit.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 114 "E:\A_NewProjects\01\Woorj\Pages\Adm\UserRoleEdit.razor"
      

    #region  Declare
        [Parameter]
        public string CurrentID { get; set; }
        private string selectedRow { get; set; } = "";
        private List<VGetUserRole> VGetUserRole_List;       
        private List<ApplicationRole> ApplicationRole_List; 
        private List<ApplicationRole> DiffRoleList;  
        private DataGridComp<ApplicationRole> grid_DiffRoleList;      
        private DataGridComp<VGetUserRole> grid_VGetUserRole; 
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AppData AppData { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpContextAccessor hca { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdmService admSer { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICoreService serv { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICustomTranslator trs { get; set; }
    }
}
namespace __Blazor.Woorj.Pages.Adm.UserRoleEdit
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateDataGridComp_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.List<TItem> __arg0, int __seq1, global::System.Collections.Generic.List<global::Woorj.Data.GeneralComponents.ColumnDefinition> __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<global::System.String> __arg2, int __seq3, global::System.String __arg3, int __seq4, global::System.String __arg4, int __seq5, global::Woorj.Data.GeneralComponents.PagingConfig __arg5, int __seq6, global::Microsoft.AspNetCore.Components.RenderFragment __arg6, int __seq7, global::System.Action<global::Woorj.Pages.GeneralComponents.DataGridComp<TItem>> __arg7)
        {
        __builder.OpenComponent<global::Woorj.Pages.GeneralComponents.DataGridComp<TItem>>(seq);
        __builder.AddAttribute(__seq0, "DataItems", __arg0);
        __builder.AddAttribute(__seq1, "Columns", __arg1);
        __builder.AddAttribute(__seq2, "SelectedRow", __arg2);
        __builder.AddAttribute(__seq3, "UniqIdOfRecord", __arg3);
        __builder.AddAttribute(__seq4, "ColumnsToExcludeCSV", __arg4);
        __builder.AddAttribute(__seq5, "Paging", __arg5);
        __builder.AddAttribute(__seq6, "ControlQuickAccess", __arg6);
        __builder.AddComponentReferenceCapture(__seq7, (__value) => { __arg7((global::Woorj.Pages.GeneralComponents.DataGridComp<TItem>)__value); });
        __builder.CloseComponent();
        }
        public static void CreateDataGridComp_1<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.List<TItem> __arg0, int __seq1, global::System.Collections.Generic.List<global::Woorj.Data.GeneralComponents.ColumnDefinition> __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<global::System.String> __arg2, int __seq3, global::System.String __arg3, int __seq4, global::System.String __arg4, int __seq5, global::Woorj.Data.GeneralComponents.PagingConfig __arg5, int __seq6, global::Microsoft.AspNetCore.Components.RenderFragment __arg6, int __seq7, global::System.Action<global::Woorj.Pages.GeneralComponents.DataGridComp<TItem>> __arg7)
        {
        __builder.OpenComponent<global::Woorj.Pages.GeneralComponents.DataGridComp<TItem>>(seq);
        __builder.AddAttribute(__seq0, "DataItems", __arg0);
        __builder.AddAttribute(__seq1, "Columns", __arg1);
        __builder.AddAttribute(__seq2, "SelectedRow", __arg2);
        __builder.AddAttribute(__seq3, "UniqIdOfRecord", __arg3);
        __builder.AddAttribute(__seq4, "ColumnsToExcludeCSV", __arg4);
        __builder.AddAttribute(__seq5, "Paging", __arg5);
        __builder.AddAttribute(__seq6, "ControlQuickAccess", __arg6);
        __builder.AddComponentReferenceCapture(__seq7, (__value) => { __arg7((global::Woorj.Pages.GeneralComponents.DataGridComp<TItem>)__value); });
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
