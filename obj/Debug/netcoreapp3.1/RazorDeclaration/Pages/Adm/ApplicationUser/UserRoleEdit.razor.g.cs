// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#pragma warning restore 1591
