// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Hoteldia.Components.Account.Pages
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line (1,2)-(1,23) "C:\Users\srrex\Desktop\Proyecto\HoteldiaServer\Hoteldia\Components\_Imports.razor"
using System.Net.Http

#nullable disable
    ;
#nullable restore
#line (2,2)-(2,28) "C:\Users\srrex\Desktop\Proyecto\HoteldiaServer\Hoteldia\Components\_Imports.razor"
using System.Net.Http.Json

#nullable disable
    ;
#nullable restore
#line (3,2)-(3,53) "C:\Users\srrex\Desktop\Proyecto\HoteldiaServer\Hoteldia\Components\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization

#nullable disable
    ;
#nullable restore
#line (4,2)-(4,45) "C:\Users\srrex\Desktop\Proyecto\HoteldiaServer\Hoteldia\Components\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms

#nullable disable
    ;
#nullable restore
#line (5,2)-(5,47) "C:\Users\srrex\Desktop\Proyecto\HoteldiaServer\Hoteldia\Components\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing

#nullable disable
    ;
#nullable restore
#line (6,2)-(6,43) "C:\Users\srrex\Desktop\Proyecto\HoteldiaServer\Hoteldia\Components\_Imports.razor"
using Microsoft.AspNetCore.Components.Web

#nullable disable
    ;
#nullable restore
#line (7,2)-(7,61) "C:\Users\srrex\Desktop\Proyecto\HoteldiaServer\Hoteldia\Components\_Imports.razor"
using static Microsoft.AspNetCore.Components.Web.RenderMode

#nullable disable
    ;
#nullable restore
#line (8,2)-(8,58) "C:\Users\srrex\Desktop\Proyecto\HoteldiaServer\Hoteldia\Components\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization

#nullable disable
    ;
#nullable restore
#line (9,2)-(9,27) "C:\Users\srrex\Desktop\Proyecto\HoteldiaServer\Hoteldia\Components\_Imports.razor"
using Microsoft.JSInterop

#nullable disable
    ;
#nullable restore
#line (10,2)-(10,16) "C:\Users\srrex\Desktop\Proyecto\HoteldiaServer\Hoteldia\Components\_Imports.razor"
using Hoteldia

#nullable disable
    ;
#nullable restore
#line (11,2)-(11,27) "C:\Users\srrex\Desktop\Proyecto\HoteldiaServer\Hoteldia\Components\_Imports.razor"
using Hoteldia.Components

#nullable disable
    ;
#nullable restore
#line (12,2)-(12,26) "C:\Users\srrex\Desktop\Proyecto\HoteldiaServer\Hoteldia\Components\_Imports.razor"
using Hoteldia.Servicios

#nullable disable
    ;
#nullable restore
#line (1,2)-(1,42) "C:\Users\srrex\Desktop\Proyecto\HoteldiaServer\Hoteldia\Components\Account\Pages\_Imports.razor"
using Hoteldia.Components.Account.Shared

#nullable disable
    ;
#nullable restore
#line (3,2)-(3,45) "C:\Users\srrex\Desktop\Proyecto\HoteldiaServer\Hoteldia\Components\Account\Pages\Login.razor"
using System.ComponentModel.DataAnnotations

#nullable disable
    ;
#nullable restore
#line (4,2)-(4,43) "C:\Users\srrex\Desktop\Proyecto\HoteldiaServer\Hoteldia\Components\Account\Pages\Login.razor"
using Microsoft.AspNetCore.Authentication

#nullable disable
    ;
#nullable restore
#line (5,2)-(5,37) "C:\Users\srrex\Desktop\Proyecto\HoteldiaServer\Hoteldia\Components\Account\Pages\Login.razor"
using Microsoft.AspNetCore.Identity

#nullable disable
    ;
#nullable restore
#line (6,2)-(6,21) "C:\Users\srrex\Desktop\Proyecto\HoteldiaServer\Hoteldia\Components\Account\Pages\Login.razor"
using Hoteldia.Data

#nullable disable
    ;
    #line default
    #line hidden
#nullable restore
#line (2,12)-(2,43) "C:\Users\srrex\Desktop\Proyecto\HoteldiaServer\Hoteldia\Components\Account\Pages\_Imports.razor"
[ExcludeFromInteractiveRouting]

#line default
#line hidden
#nullable disable

    [global::Microsoft.AspNetCore.Components.RouteAttribute(
    // language=Route,Component
#nullable restore
#line (1,7)-(1,23) "C:\Users\srrex\Desktop\Proyecto\HoteldiaServer\Hoteldia\Components\Account\Pages\Login.razor"
"/Account/Login"

#line default
#line hidden
#nullable disable
    )]
    #nullable restore
    public partial class Login : global::Microsoft.AspNetCore.Components.ComponentBase
    #nullable disable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line (64,8)-(125,1) "C:\Users\srrex\Desktop\Proyecto\HoteldiaServer\Hoteldia\Components\Account\Pages\Login.razor"

    private string? errorMessage;

    [CascadingParameter]
    private HttpContext HttpContext { get; set; } = default!;

    [SupplyParameterFromForm]
    private InputModel Input { get; set; } = new();

    [SupplyParameterFromQuery]
    private string? ReturnUrl { get; set; }

    protected override async Task OnInitializedAsync()
    {
        if (HttpMethods.IsGet(HttpContext.Request.Method))
        {
            // Limpiar cookie de login externo para asegurar un inicio de sesión limpio
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);
        }
    }

    public async Task LoginUser()
    {
        var result = await SignInManager.PasswordSignInAsync(Input.Email, Input.Password, Input.RememberMe, lockoutOnFailure: false);
        if (result.Succeeded)
        {
            Logger.LogInformation("El usuario inició sesión correctamente.");
            RedirectManager.RedirectTo(ReturnUrl);
        }
        else if (result.RequiresTwoFactor)
        {
            RedirectManager.RedirectTo(
                "Account/LoginWith2fa",
                new() { ["returnUrl"] = ReturnUrl, ["rememberMe"] = Input.RememberMe });
        }
        else if (result.IsLockedOut)
        {
            Logger.LogWarning("La cuenta del usuario está bloqueada.");
            RedirectManager.RedirectTo("Account/Lockout");
        }
        else
        {
            errorMessage = "Error: El intento de inicio de sesión no es válido.";
        }
    }

    private sealed class InputModel
    {
        [Required(ErrorMessage = "El correo electrónico es obligatorio.")]
        [EmailAddress(ErrorMessage = "El correo electrónico no tiene un formato válido.")]
        [Display(Name = "Correo electrónico")]
        public string Email { get; set; } = "";

        [Required(ErrorMessage = "La contraseña es obligatoria.")]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string Password { get; set; } = "";

        [Display(Name = "¿Recordarme?")]
        public bool RememberMe { get; set; }
    }

#line default
#line hidden
#nullable disable

        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line (11,9)-(11,32) "C:\Users\srrex\Desktop\Proyecto\HoteldiaServer\Hoteldia\Components\Account\Pages\Login.razor"
IdentityRedirectManager

#line default
#line hidden
#nullable disable
         
#nullable restore
#line (11,33)-(11,48) "C:\Users\srrex\Desktop\Proyecto\HoteldiaServer\Hoteldia\Components\Account\Pages\Login.razor"
RedirectManager

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line (10,9)-(10,26) "C:\Users\srrex\Desktop\Proyecto\HoteldiaServer\Hoteldia\Components\Account\Pages\Login.razor"
NavigationManager

#line default
#line hidden
#nullable disable
         
#nullable restore
#line (10,27)-(10,44) "C:\Users\srrex\Desktop\Proyecto\HoteldiaServer\Hoteldia\Components\Account\Pages\Login.razor"
NavigationManager

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line (9,9)-(9,23) "C:\Users\srrex\Desktop\Proyecto\HoteldiaServer\Hoteldia\Components\Account\Pages\Login.razor"
ILogger<Login>

#line default
#line hidden
#nullable disable
         
#nullable restore
#line (9,24)-(9,30) "C:\Users\srrex\Desktop\Proyecto\HoteldiaServer\Hoteldia\Components\Account\Pages\Login.razor"
Logger

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line (8,9)-(8,39) "C:\Users\srrex\Desktop\Proyecto\HoteldiaServer\Hoteldia\Components\Account\Pages\Login.razor"
SignInManager<ApplicationUser>

#line default
#line hidden
#nullable disable
         
#nullable restore
#line (8,40)-(8,53) "C:\Users\srrex\Desktop\Proyecto\HoteldiaServer\Hoteldia\Components\Account\Pages\Login.razor"
SignInManager

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
    }
}
#pragma warning restore 1591
