#pragma checksum "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationUser\Edit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b209d5be88f48944b26a7f384c7462f014eb707"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Adm/ApplicationUser/Edit/{CurrentID}")]
    public partial class Edit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Woorj.Pages.WrComponents.WrAuth>(0);
            __builder.AddAttribute(1, "PageName", "ApplicationUserEdit");
            __builder.AddAttribute(2, "MainContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(3);
                __builder2.AddAttribute(4, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 7 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationUser\Edit.razor"
                  objMain

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(5, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 7 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationUser\Edit.razor"
                                           Update

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(6, "OnInvalidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 7 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationUser\Edit.razor"
                                                                     Cancel

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((formContext) => (__builder3) => {
                    __builder3.OpenComponent<Blazored.FluentValidation.FluentValidationValidator>(8);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(9, "  \r\n    ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(10);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(11, "\r\n    \r\n    ");
                    __builder3.OpenComponent<Woorj.Pages.WrComponents.WrPnlElm>(12);
                    __builder3.AddAttribute(13, "ControlQuickAccess", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Woorj.Pages.WrComponents.WrOper>(14);
                        __builder4.AddAttribute(15, "Category", "EditForm");
                        __builder4.AddAttribute(16, "EditOrView", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 13 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationUser\Edit.razor"
                                                   true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(17, "TypeInput", "button");
                        __builder4.AddAttribute(18, "Txt", "Cancel");
                        __builder4.AddAttribute(19, "OnClickCallback", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationUser\Edit.razor"
                                                                                                          Cancel

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(20, " \r\n            ");
                        __builder4.OpenComponent<Woorj.Pages.WrComponents.WrOper>(21);
                        __builder4.AddAttribute(22, "Category", "EditForm");
                        __builder4.AddAttribute(23, "EditOrView", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 14 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationUser\Edit.razor"
                                                   true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(24, "TypeInput", "submit");
                        __builder4.AddAttribute(25, "Txt", "Update");
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(26, "\r\n\r\n    ");
                    __builder3.OpenComponent<Woorj.Pages.WrComponents.WrFormBody>(27);
                    __builder3.AddAttribute(28, "FormElements", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Woorj.Pages.WrComponents.WrFieldInt>(29);
                        __builder4.AddAttribute(30, "TransEntity", "General");
                        __builder4.AddAttribute(31, "FieldCaption", "Code");
                        __builder4.AddAttribute(32, "ReadonlyOpt", "true");
                        __builder4.AddAttribute(33, "Val", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 21 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationUser\Edit.razor"
                                     objMain.Code

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(34, "\r\n\r\n            ");
                        __builder4.OpenComponent<Woorj.Pages.WrComponents.WrFieldStr>(35);
                        __builder4.AddAttribute(36, "FieldCaption", "UserName");
                        __builder4.AddAttribute(37, "TransEntity", "General");
                        __builder4.AddAttribute(38, "BindingValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationUser\Edit.razor"
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
                        __builder4.AddAttribute(43, "TransEntity", "General");
                        __builder4.AddAttribute(44, "BindingValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationUser\Edit.razor"
                                                         objMain.FirstName

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(45, "BindingValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => objMain.FirstName = __value, objMain.FirstName))));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(46, "\r\n\r\n            ");
                        __builder4.OpenComponent<Woorj.Pages.WrComponents.WrFieldStr>(47);
                        __builder4.AddAttribute(48, "FieldCaption", "SecondName");
                        __builder4.AddAttribute(49, "TransEntity", "General");
                        __builder4.AddAttribute(50, "BindingValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 30 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationUser\Edit.razor"
                                                         objMain.SecondName

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(51, "BindingValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => objMain.SecondName = __value, objMain.SecondName))));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(52, "\r\n\r\n            ");
                        __builder4.OpenComponent<Woorj.Pages.WrComponents.WrFieldStr>(53);
                        __builder4.AddAttribute(54, "FieldCaption", "LastName");
                        __builder4.AddAttribute(55, "TransEntity", "General");
                        __builder4.AddAttribute(56, "BindingValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 33 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationUser\Edit.razor"
                                                         objMain.LastName

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(57, "BindingValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => objMain.LastName = __value, objMain.LastName))));
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
#line 41 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationUser\Edit.razor"
      
    [Parameter] public string CurrentID { get; set; }
    ApplicationUser objMain = new ApplicationUser();    
    private string  CancelOrBeckTxt { get; set; } 

    protected override void OnInitialized()
    {
        objMain = MainController.GetById_FirstOrDefault(CurrentID);
    }

    protected void Update()
    {
        MainController.Update(objMain);
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
