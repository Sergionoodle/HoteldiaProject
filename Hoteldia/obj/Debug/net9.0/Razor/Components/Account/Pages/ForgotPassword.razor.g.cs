#pragma checksum "C:\Users\srrex\Desktop\Proyecto\HoteldiaServer\Hoteldia\Components\Account\Pages\ForgotPassword.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "942b1f077d4a8fdf14d2f25043eaaf3ecebcbaa064d9d0810a64bcb359a69f3f"
// <auto-generated/>
#pragma warning disable 1591
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
#line (3,2)-(3,45) "C:\Users\srrex\Desktop\Proyecto\HoteldiaServer\Hoteldia\Components\Account\Pages\ForgotPassword.razor"
using System.ComponentModel.DataAnnotations

#nullable disable
    ;
#nullable restore
#line (4,2)-(4,19) "C:\Users\srrex\Desktop\Proyecto\HoteldiaServer\Hoteldia\Components\Account\Pages\ForgotPassword.razor"
using System.Text

#nullable disable
    ;
#nullable restore
#line (5,2)-(5,33) "C:\Users\srrex\Desktop\Proyecto\HoteldiaServer\Hoteldia\Components\Account\Pages\ForgotPassword.razor"
using System.Text.Encodings.Web

#nullable disable
    ;
#nullable restore
#line (6,2)-(6,37) "C:\Users\srrex\Desktop\Proyecto\HoteldiaServer\Hoteldia\Components\Account\Pages\ForgotPassword.razor"
using Microsoft.AspNetCore.Identity

#nullable disable
    ;
#nullable restore
#line (7,2)-(7,41) "C:\Users\srrex\Desktop\Proyecto\HoteldiaServer\Hoteldia\Components\Account\Pages\ForgotPassword.razor"
using Microsoft.AspNetCore.WebUtilities

#nullable disable
    ;
#nullable restore
#line (8,2)-(8,21) "C:\Users\srrex\Desktop\Proyecto\HoteldiaServer\Hoteldia\Components\Account\Pages\ForgotPassword.razor"
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
#line (1,7)-(1,32) "C:\Users\srrex\Desktop\Proyecto\HoteldiaServer\Hoteldia\Components\Account\Pages\ForgotPassword.razor"
"/Account/ForgotPassword"

#line default
#line hidden
#nullable disable
    )]
    #nullable restore
    public partial class ForgotPassword : global::Microsoft.AspNetCore.Components.ComponentBase
    #nullable disable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Web.PageTitle>(0);
            __builder.AddAttribute(1, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(2, "Forgot your password?");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.AddMarkupContent(4, "<h1>Forgot your password?</h1>\r\n");
            __builder.AddMarkupContent(5, "<h2>Enter your email.</h2>\r\n<hr>\r\n");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "row");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "col-md-4");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.EditForm>(10);
            __builder.AddComponentParameter(11, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Object>(
#nullable restore
#line (22,26)-(22,31) "C:\Users\srrex\Desktop\Proyecto\HoteldiaServer\Hoteldia\Components\Account\Pages\ForgotPassword.razor"
Input

#line default
#line hidden
#nullable disable
            ));
            __builder.AddComponentParameter(12, "FormName", "forgot-password");
            __builder.AddComponentParameter(13, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Forms.EditContext>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line (22,75)-(22,93) "C:\Users\srrex\Desktop\Proyecto\HoteldiaServer\Hoteldia\Components\Account\Pages\ForgotPassword.razor"
OnValidSubmitAsync

#line default
#line hidden
#nullable disable
            )));
            __builder.AddComponentParameter(14, "method", "post");
            __builder.AddAttribute(15, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<global::Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(16);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n            ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationSummary>(18);
                __builder2.AddComponentParameter(19, "class", "text-danger");
                __builder2.AddComponentParameter(20, "role", "alert");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(21, "\r\n\r\n            ");
                __builder2.OpenElement(22, "div");
                __builder2.AddAttribute(23, "class", "form-floating mb-3");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(24);
                __builder2.AddComponentParameter(25, "id", "Input.Email");
                __builder2.AddComponentParameter(26, "class", "form-control");
                __builder2.AddComponentParameter(27, "autocomplete", "username");
                __builder2.AddComponentParameter(28, "aria-required", "true");
                __builder2.AddComponentParameter(29, "placeholder", "name@example.com");
                __builder2.AddComponentParameter(30, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line (27,41)-(27,52) "C:\Users\srrex\Desktop\Proyecto\HoteldiaServer\Hoteldia\Components\Account\Pages\ForgotPassword.razor"
Input.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddComponentParameter(31, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Input.Email = __value, Input.Email))));
                __builder2.AddComponentParameter(32, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<global::System.Func<global::System.String>>>(() => Input.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(33, "\r\n                ");
                __builder2.AddMarkupContent(34, "<label for=\"Input.Email\" class=\"form-label\">Email</label>\r\n                ");
                global::__Blazor.Hoteldia.Components.Account.Pages.ForgotPassword.TypeInference.CreateValidationMessage_0(__builder2, 35, 36, 
#nullable restore
#line (29,41)-(29,58) "C:\Users\srrex\Desktop\Proyecto\HoteldiaServer\Hoteldia\Components\Account\Pages\ForgotPassword.razor"
() => Input.Email

#line default
#line hidden
#nullable disable
                , 37, "text-danger");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n            ");
                __builder2.AddMarkupContent(39, "<button type=\"submit\" class=\"w-100 btn btn-lg btn-primary\">Reset password</button>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line (36,8)-(68,1) "C:\Users\srrex\Desktop\Proyecto\HoteldiaServer\Hoteldia\Components\Account\Pages\ForgotPassword.razor"

    [SupplyParameterFromForm]
    private InputModel Input { get; set; } = new();

    private async Task OnValidSubmitAsync()
    {
        var user = await UserManager.FindByEmailAsync(Input.Email);
        if (user is null || !(await UserManager.IsEmailConfirmedAsync(user)))
        {
            // Don't reveal that the user does not exist or is not confirmed
            RedirectManager.RedirectTo("Account/ForgotPasswordConfirmation");
        }

        // For more information on how to enable account confirmation and password reset please
        // visit https://go.microsoft.com/fwlink/?LinkID=532713
        var code = await UserManager.GeneratePasswordResetTokenAsync(user);
        code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
        var callbackUrl = NavigationManager.GetUriWithQueryParameters(
            NavigationManager.ToAbsoluteUri("Account/ResetPassword").AbsoluteUri,
            new Dictionary<string, object?> { ["code"] = code });

        await EmailSender.SendPasswordResetLinkAsync(user, Input.Email, HtmlEncoder.Default.Encode(callbackUrl));

        RedirectManager.RedirectTo("Account/ForgotPasswordConfirmation");
    }

    private sealed class InputModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; } = "";
    }

#line default
#line hidden
#nullable disable

        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line (13,9)-(13,32) "C:\Users\srrex\Desktop\Proyecto\HoteldiaServer\Hoteldia\Components\Account\Pages\ForgotPassword.razor"
IdentityRedirectManager

#line default
#line hidden
#nullable disable
         
#nullable restore
#line (13,33)-(13,48) "C:\Users\srrex\Desktop\Proyecto\HoteldiaServer\Hoteldia\Components\Account\Pages\ForgotPassword.razor"
RedirectManager

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line (12,9)-(12,26) "C:\Users\srrex\Desktop\Proyecto\HoteldiaServer\Hoteldia\Components\Account\Pages\ForgotPassword.razor"
NavigationManager

#line default
#line hidden
#nullable disable
         
#nullable restore
#line (12,27)-(12,44) "C:\Users\srrex\Desktop\Proyecto\HoteldiaServer\Hoteldia\Components\Account\Pages\ForgotPassword.razor"
NavigationManager

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line (11,9)-(11,38) "C:\Users\srrex\Desktop\Proyecto\HoteldiaServer\Hoteldia\Components\Account\Pages\ForgotPassword.razor"
IEmailSender<ApplicationUser>

#line default
#line hidden
#nullable disable
         
#nullable restore
#line (11,39)-(11,50) "C:\Users\srrex\Desktop\Proyecto\HoteldiaServer\Hoteldia\Components\Account\Pages\ForgotPassword.razor"
EmailSender

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line (10,9)-(10,37) "C:\Users\srrex\Desktop\Proyecto\HoteldiaServer\Hoteldia\Components\Account\Pages\ForgotPassword.razor"
UserManager<ApplicationUser>

#line default
#line hidden
#nullable disable
         
#nullable restore
#line (10,38)-(10,49) "C:\Users\srrex\Desktop\Proyecto\HoteldiaServer\Hoteldia\Components\Account\Pages\ForgotPassword.razor"
UserManager

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
    }
}
namespace __Blazor.Hoteldia.Components.Account.Pages.ForgotPassword
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0, int __seq1, global::System.Object __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddComponentParameter(__seq0, "For", __arg0);
        __builder.AddComponentParameter(__seq1, "class", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
