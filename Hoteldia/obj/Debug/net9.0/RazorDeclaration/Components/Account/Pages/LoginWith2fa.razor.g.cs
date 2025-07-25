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
#line (3,2)-(3,45) "C:\Users\srrex\Desktop\Proyecto\HoteldiaServer\Hoteldia\Components\Account\Pages\LoginWith2fa.razor"
using System.ComponentModel.DataAnnotations

#nullable disable
    ;
#nullable restore
#line (4,2)-(4,37) "C:\Users\srrex\Desktop\Proyecto\HoteldiaServer\Hoteldia\Components\Account\Pages\LoginWith2fa.razor"
using Microsoft.AspNetCore.Identity

#nullable disable
    ;
#nullable restore
#line (5,2)-(5,21) "C:\Users\srrex\Desktop\Proyecto\HoteldiaServer\Hoteldia\Components\Account\Pages\LoginWith2fa.razor"
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
#line (1,7)-(1,30) "C:\Users\srrex\Desktop\Proyecto\HoteldiaServer\Hoteldia\Components\Account\Pages\LoginWith2fa.razor"
"/Account/LoginWith2fa"

#line default
#line hidden
#nullable disable
    )]
    #nullable restore
    public partial class LoginWith2fa : global::Microsoft.AspNetCore.Components.ComponentBase
    #nullable disable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line (47,8)-(101,1) "C:\Users\srrex\Desktop\Proyecto\HoteldiaServer\Hoteldia\Components\Account\Pages\LoginWith2fa.razor"

    private string? message;
    private ApplicationUser user = default!;

    [SupplyParameterFromForm]
    private InputModel Input { get; set; } = new();

    [SupplyParameterFromQuery]
    private string? ReturnUrl { get; set; }

    [SupplyParameterFromQuery]
    private bool RememberMe { get; set; }

    protected override async Task OnInitializedAsync()
    {
        // Ensure the user has gone through the username & password screen first
        user = await SignInManager.GetTwoFactorAuthenticationUserAsync() ??
            throw new InvalidOperationException("Unable to load two-factor authentication user.");
    }

    private async Task OnValidSubmitAsync()
    {
        var authenticatorCode = Input.TwoFactorCode!.Replace(" ", string.Empty).Replace("-", string.Empty);
        var result = await SignInManager.TwoFactorAuthenticatorSignInAsync(authenticatorCode, RememberMe, Input.RememberMachine);
        var userId = await UserManager.GetUserIdAsync(user);

        if (result.Succeeded)
        {
            Logger.LogInformation("User with ID '{UserId}' logged in with 2fa.", userId);
            RedirectManager.RedirectTo(ReturnUrl);
        }
        else if (result.IsLockedOut)
        {
            Logger.LogWarning("User with ID '{UserId}' account locked out.", userId);
            RedirectManager.RedirectTo("Account/Lockout");
        }
        else
        {
            Logger.LogWarning("Invalid authenticator code entered for user with ID '{UserId}'.", userId);
            message = "Error: Invalid authenticator code.";
        }
    }

    private sealed class InputModel
    {
        [Required]
        [StringLength(7, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Text)]
        [Display(Name = "Authenticator code")]
        public string? TwoFactorCode { get; set; }

        [Display(Name = "Remember this machine")]
        public bool RememberMachine { get; set; }
    }

#line default
#line hidden
#nullable disable

        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line (10,9)-(10,30) "C:\Users\srrex\Desktop\Proyecto\HoteldiaServer\Hoteldia\Components\Account\Pages\LoginWith2fa.razor"
ILogger<LoginWith2fa>

#line default
#line hidden
#nullable disable
         
#nullable restore
#line (10,31)-(10,37) "C:\Users\srrex\Desktop\Proyecto\HoteldiaServer\Hoteldia\Components\Account\Pages\LoginWith2fa.razor"
Logger

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line (9,9)-(9,32) "C:\Users\srrex\Desktop\Proyecto\HoteldiaServer\Hoteldia\Components\Account\Pages\LoginWith2fa.razor"
IdentityRedirectManager

#line default
#line hidden
#nullable disable
         
#nullable restore
#line (9,33)-(9,48) "C:\Users\srrex\Desktop\Proyecto\HoteldiaServer\Hoteldia\Components\Account\Pages\LoginWith2fa.razor"
RedirectManager

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line (8,9)-(8,37) "C:\Users\srrex\Desktop\Proyecto\HoteldiaServer\Hoteldia\Components\Account\Pages\LoginWith2fa.razor"
UserManager<ApplicationUser>

#line default
#line hidden
#nullable disable
         
#nullable restore
#line (8,38)-(8,49) "C:\Users\srrex\Desktop\Proyecto\HoteldiaServer\Hoteldia\Components\Account\Pages\LoginWith2fa.razor"
UserManager

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line (7,9)-(7,39) "C:\Users\srrex\Desktop\Proyecto\HoteldiaServer\Hoteldia\Components\Account\Pages\LoginWith2fa.razor"
SignInManager<ApplicationUser>

#line default
#line hidden
#nullable disable
         
#nullable restore
#line (7,40)-(7,53) "C:\Users\srrex\Desktop\Proyecto\HoteldiaServer\Hoteldia\Components\Account\Pages\LoginWith2fa.razor"
SignInManager

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
    }
}
#pragma warning restore 1591
