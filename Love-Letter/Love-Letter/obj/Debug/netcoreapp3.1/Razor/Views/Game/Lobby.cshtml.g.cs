#pragma checksum "C:\Users\Turqay\Desktop\LoveLetter\Love-Letter\Love-Letter\Views\Game\Lobby.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f600b779029ffb7ebfc98ee48b742fee130b350f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Game_Lobby), @"mvc.1.0.view", @"/Views/Game/Lobby.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Turqay\Desktop\LoveLetter\Love-Letter\Love-Letter\Views\_ViewImports.cshtml"
using Love_Letter;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Turqay\Desktop\LoveLetter\Love-Letter\Love-Letter\Views\_ViewImports.cshtml"
using Love_Letter.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Turqay\Desktop\LoveLetter\Love-Letter\Love-Letter\Views\_ViewImports.cshtml"
using Love_Letter.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f600b779029ffb7ebfc98ee48b742fee130b350f", @"/Views/Game/Lobby.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4224dab69271b8e65078cbf7aebf4557bb1fda71", @"/Views/_ViewImports.cshtml")]
    public class Views_Game_Lobby : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LobbiesViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/signalr/signalr.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/signalr/game.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Turqay\Desktop\LoveLetter\Love-Letter\Love-Letter\Views\Game\Lobby.cshtml"
  
    ViewData["Title"] = "Lobby";
    Layout = "~/Views/Shared/_CustomLayout.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f600b779029ffb7ebfc98ee48b742fee130b350f4788", async() => {
                WriteLiteral("\r\n\r\n\r\n    <h1>\r\n        Lobby#\r\n        <span id=\"lobbyID\">");
#nullable restore
#line 12 "C:\Users\Turqay\Desktop\LoveLetter\Love-Letter\Love-Letter\Views\Game\Lobby.cshtml"
                      Write(Model.Lobby.LobbyID);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n    </h1>\r\n    <div >\r\n        <div class=\"enemy-cards\">\r\n");
#nullable restore
#line 16 "C:\Users\Turqay\Desktop\LoveLetter\Love-Letter\Love-Letter\Views\Game\Lobby.cshtml"
             if (Model.Lobby.user1 != null && Model.Lobby.user1 != Model.username )
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"card-container c2\">\r\n                    <h4 class=\"username-h4\">");
#nullable restore
#line 19 "C:\Users\Turqay\Desktop\LoveLetter\Love-Letter\Love-Letter\Views\Game\Lobby.cshtml"
                                       Write(Model.Lobby.user1);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n                </div>\r\n");
#nullable restore
#line 21 "C:\Users\Turqay\Desktop\LoveLetter\Love-Letter\Love-Letter\Views\Game\Lobby.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 23 "C:\Users\Turqay\Desktop\LoveLetter\Love-Letter\Love-Letter\Views\Game\Lobby.cshtml"
             if (Model.Lobby.user2 != null && (Model.Lobby.user2 != Model.username || true))
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"card-container c2\">\r\n                    <h4 class=\"username-h4\">");
#nullable restore
#line 26 "C:\Users\Turqay\Desktop\LoveLetter\Love-Letter\Love-Letter\Views\Game\Lobby.cshtml"
                                       Write(Model.Lobby.user2);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n                </div>\r\n");
#nullable restore
#line 28 "C:\Users\Turqay\Desktop\LoveLetter\Love-Letter\Love-Letter\Views\Game\Lobby.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\Turqay\Desktop\LoveLetter\Love-Letter\Love-Letter\Views\Game\Lobby.cshtml"
             if (Model.Lobby.user3 != null && (Model.Lobby.user3 != Model.username || true))
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"card-container c2\">\r\n                    <h4 class=\"username-h4\">");
#nullable restore
#line 32 "C:\Users\Turqay\Desktop\LoveLetter\Love-Letter\Love-Letter\Views\Game\Lobby.cshtml"
                                       Write(Model.Lobby.user3);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n                </div>\r\n");
#nullable restore
#line 34 "C:\Users\Turqay\Desktop\LoveLetter\Love-Letter\Love-Letter\Views\Game\Lobby.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\Turqay\Desktop\LoveLetter\Love-Letter\Love-Letter\Views\Game\Lobby.cshtml"
             if (Model.Lobby.user4 != null && (Model.Lobby.user4 != Model.username || true))
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"card-container c2\">\r\n                    <h4 class=\"username-h4\">");
#nullable restore
#line 38 "C:\Users\Turqay\Desktop\LoveLetter\Love-Letter\Love-Letter\Views\Game\Lobby.cshtml"
                                       Write(Model.Lobby.user4);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n                </div>\r\n");
#nullable restore
#line 40 "C:\Users\Turqay\Desktop\LoveLetter\Love-Letter\Love-Letter\Views\Game\Lobby.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n\r\n        <div class=\"card-container c1 d-flex\">\r\n            <div class=\"deck\"></div>\r\n            \r\n            <h4");
                BeginWriteAttribute("class", " class=\"", 1463, "\"", 1471, 0);
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 46 "C:\Users\Turqay\Desktop\LoveLetter\Love-Letter\Love-Letter\Views\Game\Lobby.cshtml"
                    Write(Model.username);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n            <div class=\"my-cards d-flex\"></div>\r\n        </div>\r\n    </div>\r\n\r\n    \r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f600b779029ffb7ebfc98ee48b742fee130b350f10408", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f600b779029ffb7ebfc98ee48b742fee130b350f11448", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f600b779029ffb7ebfc98ee48b742fee130b350f12488", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LobbiesViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
