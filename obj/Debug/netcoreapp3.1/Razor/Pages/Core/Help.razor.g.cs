#pragma checksum "E:\A_NewProjects\01\Woorj\Pages\Core\Help.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75049db6bbfbf981150ae681bab137eb1e5da6b6"
// <auto-generated/>
#pragma warning disable 1591
namespace Woorj.Pages.Core
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Core/Help")]
    public partial class Help : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "E:\A_NewProjects\01\Woorj\Pages\Core\Help.razor"
 if (LanguageList == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<p><em>Loading...</em></p>");
#nullable restore
#line 6 "E:\A_NewProjects\01\Woorj\Pages\Core\Help.razor"
}
else
{  
       

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<br><br>\r\n");
            __builder.OpenElement(2, "span");
            __builder.AddAttribute(3, "aria-hidden", "true");
            __builder.AddContent(4, 
#nullable restore
#line 11 "E:\A_NewProjects\01\Woorj\Pages\Core\Help.razor"
                            trs.GetTranslation("BrowserLangage",@AppData.ActiveUser,"Adm")

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(5, ": ");
            __builder.AddContent(6, 
#nullable restore
#line 11 "E:\A_NewProjects\01\Woorj\Pages\Core\Help.razor"
                                                                                             trs.GetLangNameByAlpha2(@AppData.BrowserIterfaceLang,"NativeName")

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(7, " (");
            __builder.AddContent(8, 
#nullable restore
#line 11 "E:\A_NewProjects\01\Woorj\Pages\Core\Help.razor"
                                                                                                                                                                  trs.GetTranslation("YouChangeBrowserSett",@AppData.ActiveUser,"Adm")

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(9, ")");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n<br><br>\r\n");
            __builder.OpenElement(11, "span");
            __builder.AddAttribute(12, "aria-hidden", "true");
            __builder.AddContent(13, 
#nullable restore
#line 13 "E:\A_NewProjects\01\Woorj\Pages\Core\Help.razor"
                            trs.GetTranslation("UserLangage",@AppData.ActiveUser,"Adm")

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(14, ": ");
            __builder.AddContent(15, 
#nullable restore
#line 13 "E:\A_NewProjects\01\Woorj\Pages\Core\Help.razor"
                                                                                          trs.GetActiveUserLang(@AppData.ActiveUser)

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(16, " (");
            __builder.AddContent(17, 
#nullable restore
#line 13 "E:\A_NewProjects\01\Woorj\Pages\Core\Help.razor"
                                                                                                                                       trs.GetTranslation("YouChangeUserSett",@AppData.ActiveUser,"Adm")

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(18, ")");
            __builder.CloseElement();
#nullable restore
#line 14 "E:\A_NewProjects\01\Woorj\Pages\Core\Help.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "E:\A_NewProjects\01\Woorj\Pages\Core\Help.razor"
        

      private string username = "";
       public List<Language> LanguageList;
   
 // protected override void OnInitialized()
    protected override async Task OnInitializedAsync()
    {
     await GetClaimsPrincipalData();
    }

     private async Task GetClaimsPrincipalData()
    {
         LanguageList =  LanguageController.GetLanguage();
        var authState = await AuthProvider.GetAuthenticationStateAsync();
        username = authState?.User?.Identity?.Name?.ToString() ?? ""  ?? "" ?? "" ?? "";
        AppData.ActiveUser=username;
        // For Blazor Web Assembly may be you can use this 
        //username= hca?.HttpContext?.User?.Identity?.Name?.ToString() ?? ""  ?? "" ?? "" ?? "" ?? "";
        AppData.BrowserIterfaceLang= @trs.GetTheBrowserIterfaceLang(System.Threading.Thread.CurrentThread.CurrentUICulture.ToString());
        AppData.ActiveUserLang=trs.GetActiveUserLang(username);
    }

    


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private LanguageController LanguageController { get; set; }
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
