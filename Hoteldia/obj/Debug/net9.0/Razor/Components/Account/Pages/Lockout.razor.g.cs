#pragma checksum "C:\Users\srrex\Desktop\Proyecto\HoteldiaServer\Hoteldia\Components\Account\Pages\Lockout.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "f2a83452a1da572ca282f20a0d20b5855b410cc2a4d0610c3a5c886a338c4f8a"
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
#line (1,7)-(1,25) "C:\Users\srrex\Desktop\Proyecto\HoteldiaServer\Hoteldia\Components\Account\Pages\Lockout.razor"
"/Account/Lockout"

#line default
#line hidden
#nullable disable
    )]
    #nullable restore
    public partial class Lockout : global::Microsoft.AspNetCore.Components.ComponentBase
    #nullable disable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Web.PageTitle>(0);
            __builder.AddAttribute(1, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(2, "Locked out");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.AddMarkupContent(4, "<header><h1 class=\"text-danger\">Locked out</h1>\r\n    <p class=\"text-danger\" role=\"alert\">This account has been locked out, please try again later.</p></header>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
