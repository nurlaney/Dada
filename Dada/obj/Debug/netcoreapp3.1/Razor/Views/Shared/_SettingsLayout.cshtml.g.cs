#pragma checksum "C:\Users\DostTech\source\repos\Dada\Dada\Views\Shared\_SettingsLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "674dede70b88d8c808dfa2386697690b3c4797f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__SettingsLayout), @"mvc.1.0.view", @"/Views/Shared/_SettingsLayout.cshtml")]
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
#line 1 "C:\Users\DostTech\source\repos\Dada\Dada\Views\_ViewImports.cshtml"
using Dada;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DostTech\source\repos\Dada\Dada\Views\_ViewImports.cshtml"
using Dada.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\DostTech\source\repos\Dada\Dada\Views\_ViewImports.cshtml"
using Dada.Models.Profile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\DostTech\source\repos\Dada\Dada\Views\_ViewImports.cshtml"
using Dada.Models.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"674dede70b88d8c808dfa2386697690b3c4797f8", @"/Views/Shared/_SettingsLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86ac85f7da9d649678e95c57b5bf9a186ed39845", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__SettingsLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("sidebar-menu-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "setting", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "social", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "changepassword", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\DostTech\source\repos\Dada\Dada\Views\Shared\_SettingsLayout.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "674dede70b88d8c808dfa2386697690b3c4797f85350", async() => {
                WriteLiteral(@"
    <!-- CONTENT GRID -->
    <div class=""content-grid"">
        <!-- SECTION BANNER -->
        <div class=""section-banner"">
            <!-- SECTION BANNER ICON -->
            <img class=""section-banner-icon"" src=""img/banner/accounthub-icon.png"" alt=""accounthub-icon"">
            <!-- /SECTION BANNER ICON -->
            <!-- SECTION BANNER TITLE -->
            <p class=""section-banner-title"">Account Hub</p>
            <!-- /SECTION BANNER TITLE -->
            <!-- SECTION BANNER TEXT -->
            <p class=""section-banner-text"">Profile info, messages, settings and much more!</p>
            <!-- /SECTION BANNER TEXT -->
        </div>
        <!-- /SECTION BANNER -->
        <!-- GRID -->
        <div class=""grid grid-3-9 medium-space"">
            <!-- GRID COLUMN -->
            <div class=""account-hub-sidebar"">
                <!-- SIDEBAR BOX -->
                <div class=""sidebar-box no-padding"">
                    <!-- SIDEBAR MENU -->
                    <div class=""s");
                WriteLiteral(@"idebar-menu"">
                        <!-- SIDEBAR MENU ITEM -->
                        <div class=""sidebar-menu-item"">
                            <!-- SIDEBAR MENU HEADER -->
                            <div class=""sidebar-menu-header accordion-trigger-linked"">
                                <!-- SIDEBAR MENU HEADER ICON -->
                                <svg class=""sidebar-menu-header-icon icon-profile"">
                                    <use xlink:href=""#svg-profile""></use>
                                </svg>
                                <!-- /SIDEBAR MENU HEADER ICON -->
                                <!-- SIDEBAR MENU HEADER CONTROL ICON -->
                                <div class=""sidebar-menu-header-control-icon"">
                                    <!-- SIDEBAR MENU HEADER CONTROL ICON OPEN -->
                                    <svg class=""sidebar-menu-header-control-icon-open icon-minus-small"">
                                        <use xlink:href=""#svg-minus-small""");
                WriteLiteral(@"></use>
                                    </svg>
                                    <!-- /SIDEBAR MENU HEADER CONTROL ICON OPEN -->
                                    <!-- SIDEBAR MENU HEADER CONTROL ICON CLOSED -->
                                    <svg class=""sidebar-menu-header-control-icon-closed icon-plus-small"">
                                        <use xlink:href=""#svg-plus-small""></use>
                                    </svg>
                                    <!-- /SIDEBAR MENU HEADER CONTROL ICON CLOSED -->
                                </div>
                                <!-- /SIDEBAR MENU HEADER CONTROL ICON -->
                                <!-- SIDEBAR MENU HEADER TITLE -->
                                <p class=""sidebar-menu-header-title"">Profilim</p>
                                <!-- /SIDEBAR MENU HEADER TITLE -->
                                <!-- SIDEBAR MENU HEADER TEXT -->
                                <p class=""sidebar-menu-header-text"">İstifadəç");
                WriteLiteral(@"i adınızı,adınızı,email ünvanınızı dəyişdirin.</p>
                                <!-- /SIDEBAR MENU HEADER TEXT -->
                            </div>
                            <!-- /SIDEBAR MENU HEADER -->
                            <!-- SIDEBAR MENU BODY -->
                            <div class=""sidebar-menu-body accordion-content-linked"">
                                <!-- SIDEBAR MENU LINK -->
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "674dede70b88d8c808dfa2386697690b3c4797f89280", async() => {
                    WriteLiteral("Profil məlumatları");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                <!-- /SIDEBAR MENU LINK -->\r\n                                <!-- SIDEBAR MENU LINK -->\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "674dede70b88d8c808dfa2386697690b3c4797f810969", async() => {
                    WriteLiteral("Sosial media");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                <!-- /SIDEBAR MENU LINK -->
                                <!-- /SIDEBAR MENU BODY -->
                            </div>
                            <!-- /SIDEBAR MENU ITEM -->

                        </div>
                        <!-- /SIDEBAR MENU -->
                        <!-- SIDEBAR MENU ITEM -->
                        <div class=""sidebar-menu-item"">
                            <!-- SIDEBAR MENU HEADER -->
                            <div class=""sidebar-menu-header accordion-trigger-linked"">
                                <!-- SIDEBAR MENU HEADER ICON -->
                                <svg class=""sidebar-menu-header-icon icon-settings"">
                                    <use xlink:href=""#svg-settings""></use>
                                </svg>
                                <!-- /SIDEBAR MENU HEADER ICON -->
                                <!-- SIDEBAR MENU HEADER CONTROL ICON -->
                                <div class=""sidebar-menu-h");
                WriteLiteral(@"eader-control-icon"">
                                    <!-- SIDEBAR MENU HEADER CONTROL ICON OPEN -->
                                    <svg class=""sidebar-menu-header-control-icon-open icon-minus-small"">
                                        <use xlink:href=""#svg-minus-small""></use>
                                    </svg>
                                    <!-- /SIDEBAR MENU HEADER CONTROL ICON OPEN -->
                                    <!-- SIDEBAR MENU HEADER CONTROL ICON CLOSED -->
                                    <svg class=""sidebar-menu-header-control-icon-closed icon-plus-small"">
                                        <use xlink:href=""#svg-plus-small""></use>
                                    </svg>
                                    <!-- /SIDEBAR MENU HEADER CONTROL ICON CLOSED -->
                                </div>
                                <!-- /SIDEBAR MENU HEADER CONTROL ICON -->
                                <!-- SIDEBAR MENU HEADER TITLE -->
          ");
                WriteLiteral(@"                      <p class=""sidebar-menu-header-title"">Hesab</p>
                                <!-- /SIDEBAR MENU HEADER TITLE -->
                                <!-- SIDEBAR MENU HEADER TEXT -->
                                <p class=""sidebar-menu-header-text"">Şifrənizi və gizlilik tənzimləmələrini dəyişin.</p>
                                <!-- /SIDEBAR MENU HEADER TEXT -->
                            </div>
                            <!-- /SIDEBAR MENU HEADER -->
                            <!-- SIDEBAR MENU BODY -->
                            <div class=""sidebar-menu-body accordion-content-linked"">
                                <!-- SIDEBAR MENU LINK -->
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "674dede70b88d8c808dfa2386697690b3c4797f815361", async() => {
                    WriteLiteral("Şifrə yeniləməsi");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                <!-- /SIDEBAR MENU LINK -->
                                <!-- SIDEBAR MENU LINK -->
                                <a class=""sidebar-menu-link"" href=""hub-account-settings.html"">Gizlilik</a>
                                <!-- /SIDEBAR MENU LINK -->
                            </div>
                            <!-- /SIDEBAR MENU BODY -->
                        </div>
                        <!-- /SIDEBAR MENU ITEM -->
                        <!-- SIDEBAR MENU ITEM -->
                        <div class=""sidebar-menu-item"">
                            <!-- SIDEBAR MENU HEADER -->
                            <div class=""sidebar-menu-header accordion-trigger-linked"">
                                <!-- SIDEBAR MENU HEADER ICON -->
                                <svg class=""sidebar-menu-header-icon icon-group"">
                                    <use xlink:href=""#svg-group""></use>
                                </svg>
                                <!--");
                WriteLiteral(@" /SIDEBAR MENU HEADER ICON -->
                                <!-- SIDEBAR MENU HEADER CONTROL ICON -->
                                <div class=""sidebar-menu-header-control-icon"">
                                    <!-- SIDEBAR MENU HEADER CONTROL ICON OPEN -->
                                    <svg class=""sidebar-menu-header-control-icon-open icon-minus-small"">
                                        <use xlink:href=""#svg-minus-small""></use>
                                    </svg>
                                    <!-- /SIDEBAR MENU HEADER CONTROL ICON OPEN -->
                                    <!-- SIDEBAR MENU HEADER CONTROL ICON CLOSED -->
                                    <svg class=""sidebar-menu-header-control-icon-closed icon-plus-small"">
                                        <use xlink:href=""#svg-plus-small""></use>
                                    </svg>
                                    <!-- /SIDEBAR MENU HEADER CONTROL ICON CLOSED -->
                             ");
                WriteLiteral(@"   </div>
                                <!-- /SIDEBAR MENU HEADER CONTROL ICON -->
                                <!-- SIDEBAR MENU HEADER TITLE -->
                                <p class=""sidebar-menu-header-title"">Klublar</p>
                                <!-- /SIDEBAR MENU HEADER TITLE -->
                                <!-- SIDEBAR MENU HEADER TEXT -->
                                <p class=""sidebar-menu-header-text"">Yeni klub yarat,mövcud klublarını idarə et.</p>
                                <!-- /SIDEBAR MENU HEADER TEXT -->
                            </div>
                            <!-- /SIDEBAR MENU HEADER -->
                            <!-- SIDEBAR MENU BODY -->
                            <div class=""sidebar-menu-body accordion-content-linked"">
                                <!-- SIDEBAR MENU LINK -->
                                <a class=""sidebar-menu-link"" href=""hub-group-management.html"">Klub tənzimləmələri</a>
                                <!-- /SIDEBAR MENU");
                WriteLiteral(@" LINK -->
                            </div>
                            <!-- /SIDEBAR MENU BODY -->
                        </div>
                        <!-- /SIDEBAR MENU ITEM -->
                    </div>
                    <!-- /SIDEBAR BOX -->
                </div>
                <!-- /GRID COLUMN -->
            </div>
            <!-- /GRID -->


            ");
#nullable restore
#line 167 "C:\Users\DostTech\source\repos\Dada\Dada\Views\Shared\_SettingsLayout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n        </div>\r\n    </div>\r\n\r\n\r\n");
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
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 175 "C:\Users\DostTech\source\repos\Dada\Dada\Views\Shared\_SettingsLayout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
