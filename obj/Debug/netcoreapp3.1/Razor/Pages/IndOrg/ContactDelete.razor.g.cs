#pragma checksum "E:\A_NewProjects\01\Woorj\Pages\IndOrg\ContactDelete.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4cae12ca2583ce28c428c00f292caea325959f13"
// <auto-generated/>
#pragma warning disable 1591
namespace Woorj.Pages.IndOrg
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/IndOrg/ContactDelete/{CurrentID}")]
    public partial class ContactDelete : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Roles", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 4 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\ContactDelete.razor"
                       admSer.GetRolesList("ContactDelete")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((authContext) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(3);
                __builder2.AddAttribute(4, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 7 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\ContactDelete.razor"
                  objContact

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(5, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 7 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\ContactDelete.razor"
                                              Delete

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(6, "OnInvalidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 7 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\ContactDelete.razor"
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
                        __builder4.AddAttribute(12, "TypeInput", "submit");
                        __builder4.AddAttribute(13, "Txt", "Delete");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(14, "\r\n             ");
                        __builder4.OpenComponent<Woorj.Pages.WrComponents.WrOper>(15);
                        __builder4.AddAttribute(16, "Category", "EditForm");
                        __builder4.AddAttribute(17, "TypeInput", "button");
                        __builder4.AddAttribute(18, "Txt", "Cancel");
                        __builder4.AddAttribute(19, "OnClickCallback", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\ContactDelete.razor"
                                                                                           Cancel

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(20, "\r\n\r\n    ");
                    __builder3.OpenComponent<Woorj.Pages.WrComponents.WrFormBody>(21);
                    __builder3.AddAttribute(22, "FormElements", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Woorj.Pages.WrComponents.WrQuestOrMsg>(23);
                        __builder4.AddAttribute(24, "Txt", "AreYouSureToDeteteRow");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(25, "\r\n              \r\n             ");
                        __builder4.OpenComponent<Woorj.Pages.WrComponents.WrFieldInt>(26);
                        __builder4.AddAttribute(27, "TransEntity", "Individual");
                        __builder4.AddAttribute(28, "FieldCaption", "Code");
                        __builder4.AddAttribute(29, "ReadonlyOpt", "readonlyMain1");
                        __builder4.AddAttribute(30, "Val", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 21 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\ContactDelete.razor"
                                                objContact.Code

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(31, "\r\n\r\n            ");
                        __builder4.OpenComponent<Woorj.Pages.WrComponents.WrFieldStr>(32);
                        __builder4.AddAttribute(33, "ReadonlyThis", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 23 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\ContactDelete.razor"
                                      readonlyMain1

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(34, "FieldCaption", "Name");
                        __builder4.AddAttribute(35, "TransEntity", "Individual");
                        __builder4.AddAttribute(36, "BindingValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\ContactDelete.razor"
                                                            objContact.Name

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(37, "BindingValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => objContact.Name = __value, objContact.Name))));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(38, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((authContext) => (__builder2) => {
                __builder2.OpenComponent<Woorj.Pages.WrComponents.WrPageNotFound>(39);
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\ContactDelete.razor"
      
   [Parameter]
   public string CurrentID {get;set;}
    Contact objContact= new Contact();
       private bool readonlyMain1 {get;set;}=false;

       protected override void OnInitialized()
    {
      readonlyMain1=AppData.readonlyMain1;
      objContact = objContactController.GetContactById(Convert.ToInt32(CurrentID));       
    }
    
    protected void Delete(){

        objContactController.DeleteContact(objContact);
        NavManager.NavigateTo("/IndOrg/ContactViewStd/"+AppData.Individual_IdSelect);
    }
    void Cancel(){
        NavManager.NavigateTo("/IndOrg/ContactViewStd/"+AppData.Individual_IdSelect);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ContactController objContactController { get; set; }
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
