#pragma checksum "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationUser\Delete.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9e2f853e1930db7377a29aedae23f4e88a4678b"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Adm/ApplicationUser/Delete/{CurrentID}")]
    public partial class Delete : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Woorj.Pages.WrComponents.WrAuth>(0);
            __builder.AddAttribute(1, "PageName", "ApplicationUserDelete");
            __builder.AddAttribute(2, "MainContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(3);
                __builder2.AddAttribute(4, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 6 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationUser\Delete.razor"
                  objMain

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(5, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 6 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationUser\Delete.razor"
                                           DeleteRow

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(6, "OnInvalidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 6 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationUser\Delete.razor"
                                                                        Cancel

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((formContext) => (__builder3) => {
                    __builder3.OpenComponent<Woorj.Pages.WrComponents.WrPnlElm>(8);
                    __builder3.AddAttribute(9, "ControlQuickAccess", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Woorj.Pages.WrComponents.WrOper>(10);
                        __builder4.AddAttribute(11, "Category", "EditForm");
                        __builder4.AddAttribute(12, "TypeInput", "button");
                        __builder4.AddAttribute(13, "Txt", "Cancel");
                        __builder4.AddAttribute(14, "OnClickCallback", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationUser\Delete.razor"
                                                                                           Cancel

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(15, "\r\n             ");
                        __builder4.OpenComponent<Woorj.Pages.WrComponents.WrOper>(16);
                        __builder4.AddAttribute(17, "Category", "EditForm");
                        __builder4.AddAttribute(18, "TypeInput", "submit");
                        __builder4.AddAttribute(19, "Txt", "Delete");
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(20, "\r\n\r\n    ");
                    __builder3.OpenComponent<Woorj.Pages.WrComponents.WrFormBody>(21);
                    __builder3.AddAttribute(22, "FormElements", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Woorj.Pages.WrComponents.WrQuestOrMsg>(23);
                        __builder4.AddAttribute(24, "Txt", "AreYouSureToDeteteRow");
                        __builder4.AddAttribute(25, "Color", "Black");
                        __builder4.AddAttribute(26, "BackgroundColor", "yellow");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(27, "\r\n           \r\n            ");
                        __builder4.OpenComponent<Woorj.Pages.WrComponents.WrFieldInt>(28);
                        __builder4.AddAttribute(29, "TransEntity", "General");
                        __builder4.AddAttribute(30, "FieldCaption", "Code");
                        __builder4.AddAttribute(31, "ReadonlyOpt", "true");
                        __builder4.AddAttribute(32, "Val", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 20 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationUser\Delete.razor"
                                     objMain.Code

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(33, "\r\n            \r\n             ");
                        __builder4.OpenComponent<Woorj.Pages.WrComponents.WrFieldStr>(34);
                        __builder4.AddAttribute(35, "FieldCaption", "UserName");
                        __builder4.AddAttribute(36, "ReadonlyThis", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 22 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationUser\Delete.razor"
                                                                true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(37, "TransEntity", "General");
                        __builder4.AddAttribute(38, "BindingValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationUser\Delete.razor"
                                                         objMain.UserName

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(39, "BindingValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => objMain.UserName = __value, objMain.UserName))));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(40, " \r\n\r\n            ");
                        __builder4.OpenComponent<Woorj.Pages.WrComponents.WrFieldStr>(41);
                        __builder4.AddAttribute(42, "FieldCaption", "FirstName");
                        __builder4.AddAttribute(43, "ReadonlyThis", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 25 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationUser\Delete.razor"
                                                               true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(44, "TransEntity", "General");
                        __builder4.AddAttribute(45, "BindingValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationUser\Delete.razor"
                                                         objMain.FirstName

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(46, "BindingValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => objMain.FirstName = __value, objMain.FirstName))));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(47, "\r\n\r\n            ");
                        __builder4.OpenComponent<Woorj.Pages.WrComponents.WrFieldStr>(48);
                        __builder4.AddAttribute(49, "FieldCaption", "SecondName");
                        __builder4.AddAttribute(50, "ReadonlyThis", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 28 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationUser\Delete.razor"
                                                                 true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(51, "TransEntity", "General");
                        __builder4.AddAttribute(52, "BindingValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 29 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationUser\Delete.razor"
                                                         objMain.SecondName

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(53, "BindingValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => objMain.SecondName = __value, objMain.SecondName))));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(54, "\r\n\r\n            ");
                        __builder4.OpenComponent<Woorj.Pages.WrComponents.WrFieldStr>(55);
                        __builder4.AddAttribute(56, "FieldCaption", "LastName");
                        __builder4.AddAttribute(57, "ReadonlyThis", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 31 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationUser\Delete.razor"
                                                               true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(58, "TransEntity", "General");
                        __builder4.AddAttribute(59, "BindingValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 32 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationUser\Delete.razor"
                                                         objMain.LastName

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(60, "BindingValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => objMain.LastName = __value, objMain.LastName))));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationUser\Delete.razor"
      
    [Parameter] public string CurrentID { get; set; }
    ApplicationUser objMain = new ApplicationUser();  

    protected override void OnInitialized()
    {
        objMain = MainController.GetById_FirstOrDefault(CurrentID);
    }

    protected void DeleteRow()
    {
        MainController.Delete(objMain);
        NavManager.NavigateTo("/Adm/ApplicationUser/ViewStd/0");
    }
    void Cancel()
    {
        NavManager.NavigateTo("/Adm/ApplicationUser/ViewStd/0");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ApplicationUserController MainController { get; set; }
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
