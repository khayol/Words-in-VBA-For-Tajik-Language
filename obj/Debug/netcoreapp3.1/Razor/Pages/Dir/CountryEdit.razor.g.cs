#pragma checksum "E:\A_NewProjects\01\Woorj\Pages\Dir\CountryEdit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "133c0e27179356f0a10c632fbb27048996ed2880"
// <auto-generated/>
#pragma warning disable 1591
namespace Woorj.Pages.Dir
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Dir/CountryEdit/{CurrentID}")]
    public partial class CountryEdit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Roles", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 8 "E:\A_NewProjects\01\Woorj\Pages\Dir\CountryEdit.razor"
                       admSer.GetAccessRights("CountryEdit")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(3, "div");
                __builder2.AddAttribute(4, "class", "fix-possition");
                __builder2.OpenComponent<Woorj.Pages.GeneralComponents.PanelElemens>(5);
                __builder2.AddAttribute(6, "ControlQuickAccess", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(7, "input");
                    __builder3.AddAttribute(8, "type", "button");
                    __builder3.AddAttribute(9, "class", "btn bnt-style-general");
                    __builder3.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "E:\A_NewProjects\01\Woorj\Pages\Dir\CountryEdit.razor"
                                                                            UpdateCountry

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(11, "value", "Update");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(12, "\r\n              ");
                    __builder3.OpenElement(13, "input");
                    __builder3.AddAttribute(14, "type", "button");
                    __builder3.AddAttribute(15, "class", "btn btn bnt-style-general");
                    __builder3.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "E:\A_NewProjects\01\Woorj\Pages\Dir\CountryEdit.razor"
                                                                                Cancel

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(17, "value", "Cancel");
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, " \r\n\r\n");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "under-cls");
                __builder2.OpenElement(21, "form");
                __builder2.OpenElement(22, "div");
                __builder2.AddAttribute(23, "class", "row");
                __builder2.OpenElement(24, "div");
                __builder2.AddAttribute(25, "class", "col-md-8  field-content");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "form-group");
                __builder2.OpenElement(28, "label");
                __builder2.AddAttribute(29, "for", "Code");
                __builder2.AddAttribute(30, "class", "control-lable");
                __builder2.AddContent(31, 
#nullable restore
#line 25 "E:\A_NewProjects\01\Woorj\Pages\Dir\CountryEdit.razor"
                                                         L["Code"]

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n                ");
                __builder2.OpenElement(33, "input");
                __builder2.AddAttribute(34, "readonly", 
#nullable restore
#line 26 "E:\A_NewProjects\01\Woorj\Pages\Dir\CountryEdit.razor"
                                  readonlyMain1

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(35, "form", "Code");
                __builder2.AddAttribute(36, "class", "form-control");
                __builder2.AddAttribute(37, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 26 "E:\A_NewProjects\01\Woorj\Pages\Dir\CountryEdit.razor"
                                                                                          objCountry.Code

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objCountry.Code = __value, objCountry.Code));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n            ");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "form-group");
                __builder2.OpenElement(42, "label");
                __builder2.AddAttribute(43, "for", "Name");
                __builder2.AddAttribute(44, "class", "control-lable");
                __builder2.AddContent(45, 
#nullable restore
#line 29 "E:\A_NewProjects\01\Woorj\Pages\Dir\CountryEdit.razor"
                                                         L["Name"]

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n                ");
                __builder2.OpenElement(47, "input");
                __builder2.AddAttribute(48, "readonly", 
#nullable restore
#line 30 "E:\A_NewProjects\01\Woorj\Pages\Dir\CountryEdit.razor"
                                  readonlyOther

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(49, "form", "Name");
                __builder2.AddAttribute(50, "class", "form-control");
                __builder2.AddAttribute(51, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 30 "E:\A_NewProjects\01\Woorj\Pages\Dir\CountryEdit.razor"
                                                                                          objCountry.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(52, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objCountry.Name = __value, objCountry.Name));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n            ");
                __builder2.OpenElement(54, "div");
                __builder2.AddAttribute(55, "class", "form-group");
                __builder2.OpenElement(56, "label");
                __builder2.AddAttribute(57, "for", "FullName");
                __builder2.AddAttribute(58, "class", "control-lable");
                __builder2.AddContent(59, 
#nullable restore
#line 33 "E:\A_NewProjects\01\Woorj\Pages\Dir\CountryEdit.razor"
                                                             L["FullName"]

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n                ");
                __builder2.OpenElement(61, "input");
                __builder2.AddAttribute(62, "readonly", 
#nullable restore
#line 34 "E:\A_NewProjects\01\Woorj\Pages\Dir\CountryEdit.razor"
                                  readonlyOther

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(63, "form", "FullName");
                __builder2.AddAttribute(64, "class", "form-control");
                __builder2.AddAttribute(65, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 34 "E:\A_NewProjects\01\Woorj\Pages\Dir\CountryEdit.razor"
                                                                                              objCountry.FullName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(66, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objCountry.FullName = __value, objCountry.FullName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\r\n            ");
                __builder2.OpenElement(68, "div");
                __builder2.AddAttribute(69, "class", "form-group");
                __builder2.OpenElement(70, "label");
                __builder2.AddAttribute(71, "for", "English");
                __builder2.AddAttribute(72, "class", "control-lable");
                __builder2.AddContent(73, 
#nullable restore
#line 37 "E:\A_NewProjects\01\Woorj\Pages\Dir\CountryEdit.razor"
                                                            L["English"]

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(74, "\r\n                ");
                __builder2.OpenElement(75, "input");
                __builder2.AddAttribute(76, "readonly", 
#nullable restore
#line 38 "E:\A_NewProjects\01\Woorj\Pages\Dir\CountryEdit.razor"
                                  readonlyOther

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(77, "form", "English");
                __builder2.AddAttribute(78, "class", "form-control");
                __builder2.AddAttribute(79, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 38 "E:\A_NewProjects\01\Woorj\Pages\Dir\CountryEdit.razor"
                                                                                             objCountry.English

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(80, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objCountry.English = __value, objCountry.English));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(81, "\r\n            ");
                __builder2.OpenElement(82, "div");
                __builder2.AddAttribute(83, "class", "form-group");
                __builder2.OpenElement(84, "label");
                __builder2.AddAttribute(85, "for", "Alpha2");
                __builder2.AddAttribute(86, "class", "control-lable");
                __builder2.AddContent(87, 
#nullable restore
#line 41 "E:\A_NewProjects\01\Woorj\Pages\Dir\CountryEdit.razor"
                                                           L["Alpha2"]

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(88, "\r\n                ");
                __builder2.OpenElement(89, "input");
                __builder2.AddAttribute(90, "readonly", 
#nullable restore
#line 42 "E:\A_NewProjects\01\Woorj\Pages\Dir\CountryEdit.razor"
                                  readonlyOther

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(91, "form", "Alpha2");
                __builder2.AddAttribute(92, "class", "form-control");
                __builder2.AddAttribute(93, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 42 "E:\A_NewProjects\01\Woorj\Pages\Dir\CountryEdit.razor"
                                                                                            objCountry.Alpha2

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(94, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objCountry.Alpha2 = __value, objCountry.Alpha2));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(95, "\r\n            ");
                __builder2.OpenElement(96, "div");
                __builder2.AddAttribute(97, "class", "form-group");
                __builder2.OpenElement(98, "label");
                __builder2.AddAttribute(99, "for", "Alpha3");
                __builder2.AddAttribute(100, "class", "control-lable");
                __builder2.AddContent(101, 
#nullable restore
#line 45 "E:\A_NewProjects\01\Woorj\Pages\Dir\CountryEdit.razor"
                                                           L["Alpha3"]

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(102, "\r\n                ");
                __builder2.OpenElement(103, "input");
                __builder2.AddAttribute(104, "readonly", 
#nullable restore
#line 46 "E:\A_NewProjects\01\Woorj\Pages\Dir\CountryEdit.razor"
                                  readonlyOther

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(105, "form", "Alpha3");
                __builder2.AddAttribute(106, "class", "form-control");
                __builder2.AddAttribute(107, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 46 "E:\A_NewProjects\01\Woorj\Pages\Dir\CountryEdit.razor"
                                                                                            objCountry.Alpha3

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(108, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objCountry.Alpha3 = __value, objCountry.Alpha3));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(109, "\r\n            ");
                __builder2.OpenElement(110, "div");
                __builder2.AddAttribute(111, "class", "form-group");
                __builder2.OpenElement(112, "label");
                __builder2.AddAttribute(113, "for", "Iso");
                __builder2.AddAttribute(114, "class", "control-lable");
                __builder2.AddContent(115, 
#nullable restore
#line 49 "E:\A_NewProjects\01\Woorj\Pages\Dir\CountryEdit.razor"
                                                        L["Iso"]

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(116, "\r\n                ");
                __builder2.OpenElement(117, "input");
                __builder2.AddAttribute(118, "readonly", 
#nullable restore
#line 50 "E:\A_NewProjects\01\Woorj\Pages\Dir\CountryEdit.razor"
                                  readonlyOther

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(119, "form", "Iso");
                __builder2.AddAttribute(120, "class", "form-control");
                __builder2.AddAttribute(121, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 50 "E:\A_NewProjects\01\Woorj\Pages\Dir\CountryEdit.razor"
                                                                                         objCountry.Iso

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(122, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objCountry.Iso = __value, objCountry.Iso));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(123, "\r\n            ");
                __builder2.OpenElement(124, "div");
                __builder2.AddAttribute(125, "class", "form-group");
                __builder2.OpenElement(126, "label");
                __builder2.AddAttribute(127, "for", "CreatedDate");
                __builder2.AddAttribute(128, "class", "control-lable");
                __builder2.AddContent(129, 
#nullable restore
#line 53 "E:\A_NewProjects\01\Woorj\Pages\Dir\CountryEdit.razor"
                                                                L["CreatedDate"]

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(130, "\r\n                ");
                __builder2.OpenElement(131, "input");
                __builder2.AddAttribute(132, "readonly", 
#nullable restore
#line 54 "E:\A_NewProjects\01\Woorj\Pages\Dir\CountryEdit.razor"
                                  readonlyMain1

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(133, "form", "AlpCreatedDateha3");
                __builder2.AddAttribute(134, "class", "form-control");
                __builder2.AddAttribute(135, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 54 "E:\A_NewProjects\01\Woorj\Pages\Dir\CountryEdit.razor"
                                                                                                        objCountry.CreatedDate

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(136, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objCountry.CreatedDate = __value, objCountry.CreatedDate));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
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
#line 63 "E:\A_NewProjects\01\Woorj\Pages\Dir\CountryEdit.razor"
      


    [Parameter]
    public string CurrentID { get; set; }
    Country objCountry = new Country();

    private bool readonlyMain1 {get;set;}=false;
    private bool readonlyMain2 {get;set;}=false;
    private bool readonlyOther {get;set;}=false;

    protected override void OnInitialized()
    {
        objCountry = objCountryController.GetCountryById(Convert.ToInt32(CurrentID));
        
        readonlyMain1=AppData.readonlyMain1;
        readonlyMain2=AppData.readonlyMain2;
        readonlyOther=AppData.readonlyOther;
    }

    protected void UpdateCountry()
    {
        objCountryController.UpdateCountry(objCountry);
       NavManager.NavigateTo("/Dir/CountryViewStd/"+CurrentID);
    }
    void Cancel()
    {
      NavManager.NavigateTo("/Dir/CountryViewStd/"+CurrentID);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStringLocalizer<CountryEdit> L { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CountryController objCountryController { get; set; }
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
#pragma warning restore 1591
