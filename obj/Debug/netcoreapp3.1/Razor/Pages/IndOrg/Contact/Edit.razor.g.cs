#pragma checksum "E:\A_NewProjects\01\Woorj\Pages\IndOrg\Contact\Edit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de39c65929545d1bb4b26a1d848b78275833228c"
// <auto-generated/>
#pragma warning disable 1591
namespace Woorj.Pages.IndOrg.Contact
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/IndOrg/Contact/Edit/{CurrentID}")]
    public partial class Edit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Woorj.Pages.WrComponents.WrAuth>(0);
            __builder.AddAttribute(1, "PageName", "ContactEdit");
            __builder.AddAttribute(2, "MainContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(3);
                __builder2.AddAttribute(4, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 6 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\Contact\Edit.razor"
                  objContact

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(5, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 6 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\Contact\Edit.razor"
                                              UpdateContact

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(6, "OnInvalidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 6 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\Contact\Edit.razor"
                                                                               Cancel

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((formContext) => (__builder3) => {
                    __builder3.OpenComponent<Blazored.FluentValidation.FluentValidationValidator>(8);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(9, " \r\n    ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(10);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(11, "\r\n    \r\n    ");
                    __builder3.OpenComponent<Woorj.Pages.WrComponents.WrPnlElm>(12);
                    __builder3.AddAttribute(13, "ControlQuickAccess", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Woorj.Pages.WrComponents.WrOper>(14);
                        __builder4.AddAttribute(15, "Category", "EditForm");
                        __builder4.AddAttribute(16, "EditOrView", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 12 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\Contact\Edit.razor"
                                                   true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(17, "ReadonlyOther", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 12 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\Contact\Edit.razor"
                                                                       false

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(18, "TypeInput", "button");
                        __builder4.AddAttribute(19, "Txt", "Cancel");
                        __builder4.AddAttribute(20, "OnClickCallback", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\Contact\Edit.razor"
                                                                                                                                Cancel

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(21, " \r\n            ");
                        __builder4.OpenComponent<Woorj.Pages.WrComponents.WrOper>(22);
                        __builder4.AddAttribute(23, "Category", "EditForm");
                        __builder4.AddAttribute(24, "EditOrView", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 13 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\Contact\Edit.razor"
                                                   true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(25, "ReadonlyOther", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 13 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\Contact\Edit.razor"
                                                                       false

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(26, "TypeInput", "submit");
                        __builder4.AddAttribute(27, "Txt", "Update");
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(28, "\r\n\r\n    ");
                    __builder3.OpenComponent<Woorj.Pages.WrComponents.WrFormBody>(29);
                    __builder3.AddAttribute(30, "FormElements", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Woorj.Pages.WrComponents.WrFieldInt>(31);
                        __builder4.AddAttribute(32, "TransEntity", "General");
                        __builder4.AddAttribute(33, "FieldCaption", "Code");
                        __builder4.AddAttribute(34, "ReadonlyOpt", "false");
                        __builder4.AddAttribute(35, "Val", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 21 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\Contact\Edit.razor"
                                      objContact.Code

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(36, "\r\n\r\n           ");
                        __builder4.OpenComponent<Woorj.Pages.WrComponents.WrFieldStr>(37);
                        __builder4.AddAttribute(38, "ReadonlyThis", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 23 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\Contact\Edit.razor"
                                     false

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(39, "FieldCaption", "Name");
                        __builder4.AddAttribute(40, "TransEntity", "General");
                        __builder4.AddAttribute(41, "BindingValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\Contact\Edit.razor"
                                                         objContact.Name

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(42, "BindingValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => objContact.Name = __value, objContact.Name))));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(43, " \r\n\r\n            ");
                        __builder4.OpenComponent<Woorj.Pages.WrComponents.WrFieldStr>(44);
                        __builder4.AddAttribute(45, "ReadonlyThis", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 26 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\Contact\Edit.razor"
                                      false

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(46, "FieldCaption", "Description");
                        __builder4.AddAttribute(47, "TransEntity", "General");
                        __builder4.AddAttribute(48, "BindingValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\Contact\Edit.razor"
                                                         objContact.Description

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(49, "BindingValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => objContact.Description = __value, objContact.Description))));
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
#line 35 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\Contact\Edit.razor"
      
    [Parameter] public string CurrentID { get; set; }
    Contact objContact = new Contact();
    private string  CancelOrBeckTxt { get; set; }




    protected override void OnInitialized()
    {
        objContact = objContactController.GetContactById(Convert.ToInt32(CurrentID));
   }

    protected void UpdateContact()
    {
        objContactController.UpdateContact(objContact);
        NavManager.NavigateTo("/IndOrg/Contact/ViewStd/"+AppData.Individual_IdSelect);
    }
    void Cancel()
    {
        NavManager.NavigateTo("/IndOrg/Contact/ViewStd/"+AppData.Individual_IdSelect);
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
