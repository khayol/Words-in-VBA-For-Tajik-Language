#pragma checksum "E:\A_NewProjects\01\Woorj\Pages\IndOrg\Individual\View.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f357f14cf9b130cd07d59313e13fc53ba7a006cb"
// <auto-generated/>
#pragma warning disable 1591
namespace Woorj.Pages.IndOrg.Individual
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/IndOrg/Individual/View/{CurrentID}")]
    public partial class View : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Woorj.Pages.WrComponents.WrAuth>(0);
            __builder.AddAttribute(1, "PageName", "IndividualEdit");
            __builder.AddAttribute(2, "MainContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(3);
                __builder2.AddAttribute(4, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 9 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\Individual\View.razor"
                  objMain

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(5, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 9 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\Individual\View.razor"
                                           Update

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((formContext) => (__builder3) => {
                    __builder3.OpenComponent<Blazored.FluentValidation.FluentValidationValidator>(7);
                    __builder3.CloseComponent();
                    __builder3.AddContent(8, "    ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(9);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(10, "\r\n    \r\n    ");
                    __builder3.OpenComponent<Woorj.Pages.WrComponents.WrPnlElm>(11);
                    __builder3.AddAttribute(12, "ControlQuickAccess", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Woorj.Pages.WrComponents.WrOper>(13);
                        __builder4.AddAttribute(14, "Category", "EditForm");
                        __builder4.AddAttribute(15, "EditOrView", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 15 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\Individual\View.razor"
                                                   true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(16, "TypeInput", "button");
                        __builder4.AddAttribute(17, "Txt", "back");
                        __builder4.AddAttribute(18, "OnClickCallback", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\Individual\View.razor"
                                                                                                         Cancel

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(19, "\r\n\r\n    ");
                    __builder3.OpenComponent<Woorj.Pages.WrComponents.WrFormBody>(20);
                    __builder3.AddAttribute(21, "FormElements", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Woorj.Pages.WrComponents.WrFieldInt>(22);
                        __builder4.AddAttribute(23, "TransEntity", "Individual");
                        __builder4.AddAttribute(24, "FieldCaption", "Code");
                        __builder4.AddAttribute(25, "ReadonlyOpt", "true");
                        __builder4.AddAttribute(26, "Val", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 22 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\Individual\View.razor"
                                     objMain.Code

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(27, "\r\n\r\n           ");
                        __builder4.OpenComponent<Woorj.Pages.WrComponents.WrFieldStr>(28);
                        __builder4.AddAttribute(29, "ReadonlyThis", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 24 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\Individual\View.razor"
                                     true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(30, "FieldCaption", "FirstName");
                        __builder4.AddAttribute(31, "TransEntity", "Individual");
                        __builder4.AddAttribute(32, "BindingValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\Individual\View.razor"
                                                            objMain.FirstName

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(33, "BindingValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => objMain.FirstName = __value, objMain.FirstName))));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(34, " \r\n\r\n            ");
                        __builder4.OpenComponent<Woorj.Pages.WrComponents.WrFieldStr>(35);
                        __builder4.AddAttribute(36, "ReadonlyThis", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 27 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\Individual\View.razor"
                                      true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(37, "FieldCaption", "SecondName");
                        __builder4.AddAttribute(38, "TransEntity", "Individual");
                        __builder4.AddAttribute(39, "BindingValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\Individual\View.razor"
                                                            objMain.SecondName

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(40, "BindingValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => objMain.SecondName = __value, objMain.SecondName))));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(41, "\r\n\r\n            ");
                        __builder4.OpenComponent<Woorj.Pages.WrComponents.WrFieldStr>(42);
                        __builder4.AddAttribute(43, "ReadonlyThis", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 30 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\Individual\View.razor"
                                      true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(44, "FieldCaption", "LastName");
                        __builder4.AddAttribute(45, "TransEntity", "Individual");
                        __builder4.AddAttribute(46, "BindingValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 31 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\Individual\View.razor"
                                                            objMain.LastName

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(47, "BindingValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => objMain.LastName = __value, objMain.LastName))));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(48, "\r\n\r\n            ");
                        __builder4.OpenComponent<Woorj.Pages.WrComponents.WrFieldStr>(49);
                        __builder4.AddAttribute(50, "ReadonlyThis", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 33 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\Individual\View.razor"
                                      true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(51, "FieldCaption", "FirstNameEN");
                        __builder4.AddAttribute(52, "TransEntity", "Individual");
                        __builder4.AddAttribute(53, "BindingValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 34 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\Individual\View.razor"
                                                            objMain.FirstNameEN

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(54, "BindingValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => objMain.FirstNameEN = __value, objMain.FirstNameEN))));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(55, "\r\n\r\n            ");
                        __builder4.OpenComponent<Woorj.Pages.WrComponents.WrFieldStr>(56);
                        __builder4.AddAttribute(57, "ReadonlyThis", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 36 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\Individual\View.razor"
                                      true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(58, "FieldCaption", "SecondNameEN");
                        __builder4.AddAttribute(59, "TransEntity", "Individual");
                        __builder4.AddAttribute(60, "BindingValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 37 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\Individual\View.razor"
                                                            objMain.SecondNameEN

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(61, "BindingValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => objMain.SecondNameEN = __value, objMain.SecondNameEN))));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(62, "\r\n\r\n            ");
                        __builder4.OpenComponent<Woorj.Pages.WrComponents.WrFieldStr>(63);
                        __builder4.AddAttribute(64, "ReadonlyThis", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 39 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\Individual\View.razor"
                                      true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(65, "FieldCaption", "LastNameEN");
                        __builder4.AddAttribute(66, "TransEntity", "Individual");
                        __builder4.AddAttribute(67, "BindingValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 40 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\Individual\View.razor"
                                                            objMain.LastNameEN

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(68, "BindingValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => objMain.LastNameEN = __value, objMain.LastNameEN))));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(69, "    \r\n           \r\n           ");
                        __builder4.OpenComponent<Woorj.Pages.WrComponents.WrFieldDateTime>(70);
                        __builder4.AddAttribute(71, "TransEntity", "Individual");
                        __builder4.AddAttribute(72, "FieldCaption", "BirthDay");
                        __builder4.AddAttribute(73, "RenderFrg", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __Blazor.Woorj.Pages.IndOrg.Individual.View.TypeInference.CreateInputDate_0(__builder5, 74, 75, 
#nullable restore
#line 44 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\Individual\View.razor"
                                         true

#line default
#line hidden
#nullable disable
                            , 76, "BirthDay", 77, "form-control", 78, 
#nullable restore
#line 44 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\Individual\View.razor"
                                                                                                     objMain.BirthDay

#line default
#line hidden
#nullable disable
                            , 79, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => objMain.BirthDay = __value, objMain.BirthDay)), 80, () => objMain.BirthDay);
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(81, "\r\n            \r\n            ");
                        __builder4.OpenComponent<Woorj.Pages.WrComponents.WrFieldStr>(82);
                        __builder4.AddAttribute(83, "ReadonlyThis", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 48 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\Individual\View.razor"
                                      true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(84, "FieldCaption", "Address");
                        __builder4.AddAttribute(85, "TransEntity", "Individual");
                        __builder4.AddAttribute(86, "BindingValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 49 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\Individual\View.razor"
                                                            objMain.Address

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(87, "BindingValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => objMain.Address = __value, objMain.Address))));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(88, "\r\n\r\n            ");
                        __builder4.OpenComponent<Woorj.Pages.WrComponents.WrFieldArray>(89);
                        __builder4.AddAttribute(90, "TransEntity", "Individual");
                        __builder4.AddAttribute(91, "FieldCaption", "Contact");
                        __builder4.AddAttribute(92, "RenderFrg", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenElement(93, "label");
                            __builder5.AddAttribute(94, "class", "control-clct");
                            __builder5.AddContent(95, 
#nullable restore
#line 53 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\Individual\View.razor"
                                              GnrSrv.ExistDataORNotFlag("Contact", "IndividualId", @CurrentID)

#line default
#line hidden
#nullable disable
                            );
                            __builder5.CloseElement();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(96, "\r\n\r\n            ");
                        __builder4.OpenComponent<Woorj.Pages.WrComponents.WrFieldStr>(97);
                        __builder4.AddAttribute(98, "ReadonlyThis", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 57 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\Individual\View.razor"
                                      true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(99, "FieldCaption", "PassSerial");
                        __builder4.AddAttribute(100, "TransEntity", "Individual");
                        __builder4.AddAttribute(101, "BindingValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 58 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\Individual\View.razor"
                                                            objMain.PassSerial

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(102, "BindingValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => objMain.PassSerial = __value, objMain.PassSerial))));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(103, "\r\n    \r\n            ");
                        __builder4.OpenComponent<Woorj.Pages.WrComponents.WrFieldStr>(104);
                        __builder4.AddAttribute(105, "ReadonlyThis", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 60 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\Individual\View.razor"
                                      true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(106, "FieldCaption", "PassCode");
                        __builder4.AddAttribute(107, "TransEntity", "Individual");
                        __builder4.AddAttribute(108, "BindingValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 61 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\Individual\View.razor"
                                                            objMain.PassCode

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(109, "BindingValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => objMain.PassCode = __value, objMain.PassCode))));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(110, "\r\n \r\n            ");
                        __builder4.OpenElement(111, "div");
                        __builder4.AddAttribute(112, "class", "form-group");
                        __builder4.OpenComponent<Woorj.Pages.WrComponents.WrLebel>(113);
                        __builder4.AddAttribute(114, "TransEntity", "Individual");
                        __builder4.AddAttribute(115, "FieldCaption", "Gender");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(116, "\r\n                          ");
                        __builder4.OpenElement(117, "select");
                        __builder4.AddAttribute(118, "disabled", 
#nullable restore
#line 65 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\Individual\View.razor"
                                             true

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddAttribute(119, "class", "form-control selectpicker");
                        __builder4.AddAttribute(120, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 65 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\Individual\View.razor"
                                                                                             objMain.GenderId

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(121, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objMain.GenderId = __value, objMain.GenderId));
                        __builder4.SetUpdatesAttributeName("value");
                        __builder4.OpenElement(122, "option");
                        __builder4.AddContent(123, "--select--");
                        __builder4.CloseElement();
#nullable restore
#line 67 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\Individual\View.razor"
                             foreach (var item in GenderList)
                            {

#line default
#line hidden
#nullable disable
                        __builder4.OpenElement(124, "option");
                        __builder4.AddAttribute(125, "value", 
#nullable restore
#line 69 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\Individual\View.razor"
                                            item.Id

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddContent(126, 
#nullable restore
#line 69 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\Individual\View.razor"
                                                      item.Name

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
#nullable restore
#line 69 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\Individual\View.razor"
                                                                         // Blazor needs to know what values it binds to!
                            }

#line default
#line hidden
#nullable disable
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(127, " \r\n                 \r\n               ");
                        __builder4.OpenElement(128, "div");
                        __builder4.AddAttribute(129, "class", "form-group");
                        __builder4.OpenComponent<Woorj.Pages.WrComponents.WrLebel>(130);
                        __builder4.AddAttribute(131, "TransEntity", "Individual");
                        __builder4.AddAttribute(132, "FieldCaption", "BirthPlace");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(133, "\r\n                    ");
                        __builder4.OpenElement(134, "input");
                        __builder4.AddAttribute(135, "readonly", "true");
                        __builder4.AddAttribute(136, "form", "BirthPlace");
                        __builder4.AddAttribute(137, "class", "form-control");
                        __builder4.AddAttribute(138, "value", 
#nullable restore
#line 76 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\Individual\View.razor"
                                                                                          GnrSrv.GetReleatedData("Country", "Name", @objMain.BirthPlace_CountryId.ToString())

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(139, "\r\n     \r\n                ");
                        __builder4.OpenElement(140, "div");
                        __builder4.AddAttribute(141, "class", "form-group");
                        __builder4.OpenComponent<Woorj.Pages.WrComponents.WrLebel>(142);
                        __builder4.AddAttribute(143, "TransEntity", "Individual");
                        __builder4.AddAttribute(144, "FieldCaption", "CreatedDate");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(145, "\r\n                    ");
                        __builder4.OpenElement(146, "input");
                        __builder4.AddAttribute(147, "readonly", "true");
                        __builder4.AddAttribute(148, "class", "form-control");
                        __builder4.AddAttribute(149, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 81 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\Individual\View.razor"
                                                                         objMain.CreatedDate

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(150, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objMain.CreatedDate = __value, objMain.CreatedDate));
                        __builder4.SetUpdatesAttributeName("value");
                        __builder4.CloseElement();
                        __builder4.CloseElement();
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
#line 90 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\Individual\View.razor"
      
   [Parameter] public string CurrentID { get; set; }
    Individual objMain = new Individual();
    
    private string  CancelOrBeckTxt { get; set; }
    private List<Country> CountryList;
    
    private List<Gender> GenderList;
    //private WrCombo<Gender> grid;    



    protected override void OnInitialized()
    {
        objMain = MainController.GetById_FirstOrDefault(Convert.ToInt32(CurrentID));
        GenderList =  GenderController.Get();
        CountryList =  CountryController.Get();


    }
    public void GoToCollection(string pLinkAddress,string pIdOfRecord)
    {           
      AppData.BaseUrlUri=NavManager.Uri;//"/IndOrg/IndividualEdit/"+pIdOfRecord;
      NavManager.NavigateTo(pLinkAddress+pIdOfRecord); // change "0" to the Contact Id in Individual Table
      AppData.flg_ChoosedRow=1;
      AppData.ChoosedRowId=int.Parse(pIdOfRecord);      
    }

    public void GoToCollection(string pLinkAddress,string pIdOfRecord,  string pChoosedEntityName, 
                               int pChoosedEntityId, string pChoosedEntityFK)
    {           
        AppData.BaseUrlUri=NavManager.Uri;
        NavManager.NavigateTo(pLinkAddress+"0");
        AppData.flg_ChoosedRow=1;

        if (!string.IsNullOrEmpty(pIdOfRecord)){
        AppData.ChoosedRowId=int.Parse(pIdOfRecord);
        } else
        {
          AppData.ChoosedRowId=1; // NeedUpdate (bad solution)
        }
        AppData.ChoosedEntityName=pChoosedEntityName; 
        AppData.ChoosedEntityId=pChoosedEntityId; 
        AppData.ChoosedEntityFK=pChoosedEntityFK;
      
    }

    protected void Update()
    {
        MainController.Update(objMain);
        NavManager.NavigateTo(AppData.IndividualLink);
    }
    void Cancel()
    {
        NavManager.NavigateTo(AppData.IndividualLink);
    }

  

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private GnrSrv GnrSrv { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CountryController CountryController { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private GenderController GenderController { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IndividualController MainController { get; set; }
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
namespace __Blazor.Woorj.Pages.IndOrg.Individual.View
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputDate_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "readonly", __arg0);
        __builder.AddAttribute(__seq1, "form", __arg1);
        __builder.AddAttribute(__seq2, "class", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
