#pragma checksum "E:\A_NewProjects\01\Woorj\Pages\TESTS\L22\DataBiding.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac2f36055ecfabe08d44971b0db2ab8efaafdc57"
// <auto-generated/>
#pragma warning disable 1591
namespace Woorj.Pages.TESTS.L22
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/TESTS/L22/DataBiding")]
    public partial class DataBiding : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>DataBiding</h3>\r\n");
            __builder.AddMarkupContent(1, "<p class=\"test-header\"> Displaying the Data</p>\r\n");
            __builder.OpenElement(2, "p");
            __builder.AddMarkupContent(3, "\r\n    Name: ");
            __builder.AddContent(4, 
#nullable restore
#line 7 "E:\A_NewProjects\01\Woorj\Pages\TESTS\L22\DataBiding.razor"
           person.Salesperson

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n");
            __builder.OpenElement(6, "p");
            __builder.AddMarkupContent(7, "\r\n    Amount : ");
            __builder.AddContent(8, 
#nullable restore
#line 10 "E:\A_NewProjects\01\Woorj\Pages\TESTS\L22\DataBiding.razor"
              person.Amount.ToString("c")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n");
            __builder.AddMarkupContent(10, "<p class=\"test-header\">  Change the value in textChange event on inputBox</p>\r\n");
            __builder.OpenElement(11, "p");
            __builder.OpenElement(12, "input");
            __builder.AddAttribute(13, "type", "number");
            __builder.AddAttribute(14, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "E:\A_NewProjects\01\Woorj\Pages\TESTS\L22\DataBiding.razor"
                        person.Amount

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(15, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => person.Amount = __value, person.Amount, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n\r\n<br>\r\n");
            __builder.AddMarkupContent(17, "<p class=\"test-header\">  checkbox</p>\r\n");
            __builder.OpenElement(18, "p");
            __builder.OpenElement(19, "label");
            __builder.OpenElement(20, "input");
            __builder.AddAttribute(21, "type", "checkbox");
            __builder.AddAttribute(22, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "E:\A_NewProjects\01\Woorj\Pages\TESTS\L22\DataBiding.razor"
                            person.isActive

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => person.isActive = __value, person.isActive));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n        &nbsp;Is Active\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n\r\n    <br>\r\n    Is Active: ");
            __builder.AddContent(26, 
#nullable restore
#line 30 "E:\A_NewProjects\01\Woorj\Pages\TESTS\L22\DataBiding.razor"
                person.isActive

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n");
            __builder.AddMarkupContent(28, "<p class=\"test-header\">  RadioButton</p>\r\n\r\n");
            __builder.OpenElement(29, "p");
            __builder.OpenElement(30, "label");
            __builder.OpenElement(31, "input");
            __builder.AddAttribute(32, "type", "radio");
            __builder.AddAttribute(33, "value", "l");
            __builder.AddAttribute(34, "name", "group");
            __builder.AddAttribute(35, "checked", 
#nullable restore
#line 37 "E:\A_NewProjects\01\Woorj\Pages\TESTS\L22\DataBiding.razor"
                                                              selectedGroup==1

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "E:\A_NewProjects\01\Woorj\Pages\TESTS\L22\DataBiding.razor"
                                                                                             ()=>selectedGroup=1

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "1\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n    ");
            __builder.OpenElement(39, "label");
            __builder.OpenElement(40, "input");
            __builder.AddAttribute(41, "type", "radio");
            __builder.AddAttribute(42, "value", "2");
            __builder.AddAttribute(43, "name", "group");
            __builder.AddAttribute(44, "checked", 
#nullable restore
#line 40 "E:\A_NewProjects\01\Woorj\Pages\TESTS\L22\DataBiding.razor"
                                                              selectedGroup==2

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(45, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "E:\A_NewProjects\01\Woorj\Pages\TESTS\L22\DataBiding.razor"
                                                                                             ()=>selectedGroup=2

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "2\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n    <br>\r\n    ");
            __builder.AddContent(48, 
#nullable restore
#line 43 "E:\A_NewProjects\01\Woorj\Pages\TESTS\L22\DataBiding.razor"
     selectedGroup

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n");
            __builder.AddMarkupContent(50, "<p class=\"test-header\">  Select from DropDownList</p>\r\n");
            __builder.OpenElement(51, "p");
            __builder.OpenElement(52, "select");
            __builder.AddAttribute(53, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 48 "E:\A_NewProjects\01\Woorj\Pages\TESTS\L22\DataBiding.razor"
                   selectedLocationId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(54, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => selectedLocationId = __value, selectedLocationId));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(55, "option");
            __builder.AddAttribute(56, "value", "0");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "/option>\r\n");
#nullable restore
#line 50 "E:\A_NewProjects\01\Woorj\Pages\TESTS\L22\DataBiding.razor"
         foreach (var loc in person.Locations)
        {


#line default
#line hidden
#nullable disable
            __builder.OpenElement(58, "option");
            __builder.AddAttribute(59, "value", 
#nullable restore
#line 53 "E:\A_NewProjects\01\Woorj\Pages\TESTS\L22\DataBiding.razor"
                            loc.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(60, 
#nullable restore
#line 53 "E:\A_NewProjects\01\Woorj\Pages\TESTS\L22\DataBiding.razor"
                                     loc.City

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 54 "E:\A_NewProjects\01\Woorj\Pages\TESTS\L22\DataBiding.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n    <br>\r\n    ");
            __builder.AddContent(62, 
#nullable restore
#line 57 "E:\A_NewProjects\01\Woorj\Pages\TESTS\L22\DataBiding.razor"
     selectedLocationId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n");
            __builder.AddMarkupContent(64, "<p class=\"test-header\"> Showing the list</p>\r\n");
            __builder.OpenElement(65, "p");
            __builder.OpenElement(66, "ul");
#nullable restore
#line 64 "E:\A_NewProjects\01\Woorj\Pages\TESTS\L22\DataBiding.razor"
         foreach (var loc in person.Locations)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(67, "li");
            __builder.AddContent(68, 
#nullable restore
#line 66 "E:\A_NewProjects\01\Woorj\Pages\TESTS\L22\DataBiding.razor"
                 loc.City

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(69, ", ");
            __builder.AddContent(70, 
#nullable restore
#line 66 "E:\A_NewProjects\01\Woorj\Pages\TESTS\L22\DataBiding.razor"
                            loc.ProvState

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(71, ", ");
            __builder.AddContent(72, 
#nullable restore
#line 66 "E:\A_NewProjects\01\Woorj\Pages\TESTS\L22\DataBiding.razor"
                                            loc.Country

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 67 "E:\A_NewProjects\01\Woorj\Pages\TESTS\L22\DataBiding.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n");
            __builder.AddMarkupContent(74, "<p class=\"test-header\"> Table with Editable column</p>\r\n");
            __builder.OpenElement(75, "p");
            __builder.OpenElement(76, "table");
            __builder.AddAttribute(77, "class", "table");
#nullable restore
#line 75 "E:\A_NewProjects\01\Woorj\Pages\TESTS\L22\DataBiding.razor"
         foreach (var loc in person.Locations)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(78, "tr");
            __builder.OpenElement(79, "td");
            __builder.AddContent(80, 
#nullable restore
#line 78 "E:\A_NewProjects\01\Woorj\Pages\TESTS\L22\DataBiding.razor"
                     loc.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n                ");
            __builder.OpenElement(82, "td");
            __builder.OpenElement(83, "input");
            __builder.AddAttribute(84, "type", "text");
            __builder.AddAttribute(85, "class", "form-control");
            __builder.AddAttribute(86, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 82 "E:\A_NewProjects\01\Woorj\Pages\TESTS\L22\DataBiding.razor"
                                         loc.City

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(87, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => loc.City = __value, loc.City));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n                ");
            __builder.OpenElement(89, "td");
            __builder.OpenElement(90, "input");
            __builder.AddAttribute(91, "type", "text");
            __builder.AddAttribute(92, "class", "form-control");
            __builder.AddAttribute(93, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 88 "E:\A_NewProjects\01\Woorj\Pages\TESTS\L22\DataBiding.razor"
                                         loc.ProvState

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(94, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => loc.ProvState = __value, loc.ProvState));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n                ");
            __builder.OpenElement(96, "td");
            __builder.AddContent(97, 
#nullable restore
#line 91 "E:\A_NewProjects\01\Woorj\Pages\TESTS\L22\DataBiding.razor"
                     loc.Country

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 94 "E:\A_NewProjects\01\Woorj\Pages\TESTS\L22\DataBiding.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n<br>");
        }
        #pragma warning restore 1998
#nullable restore
#line 100 "E:\A_NewProjects\01\Woorj\Pages\TESTS\L22\DataBiding.razor"
       

    IndexViewModel person = null;
    int selectedGroup = 1;
    int selectedLocationId = 0;

    protected override void OnInitialized()
    {
        base.OnInitialized();
        person = new IndexViewModel
        {
            Salesperson = "Alex",
            Amount = 15000,
            Locations = new List<Location> {
                new Location { Id=1, City = "Toronto", ProvState="Ontario", Country="Canada"},
                new Location { Id = 2, City = "Montreal", ProvState="Quebec", Country="Canada" } }
        };
    }


    #region "View Model"
    class IndexViewModel
    {
        public string Salesperson { get; set; }
        public double Amount { get; set; }
        public bool isActive { get; set; }
        public List<Location> Locations;
    }
    class Location
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string ProvState { get; set; }
        public string Country { get; set; }
    }
    #endregion


#line default
#line hidden
#nullable disable
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
