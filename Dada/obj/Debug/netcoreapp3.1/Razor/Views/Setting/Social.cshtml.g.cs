#pragma checksum "C:\Users\DostTech\source\repos\Dada\Dada\Views\Setting\Social.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21ddd6248b85757bb352120d3a0c04018e392162"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Setting_Social), @"mvc.1.0.view", @"/Views/Setting/Social.cshtml")]
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
#nullable restore
#line 5 "C:\Users\DostTech\source\repos\Dada\Dada\Views\_ViewImports.cshtml"
using Dada.Models.Userdata;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21ddd6248b85757bb352120d3a0c04018e392162", @"/Views/Setting/Social.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5df8d91f3053575989349cd954876bfedd45bcfc", @"/Views/_ViewImports.cshtml")]
    public class Views_Setting_Social : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserSocialViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Nümunə:  https://fb.com/istifadəçiAdın"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\DostTech\source\repos\Dada\Dada\Views\Setting\Social.cshtml"
  
    Layout = "_SettingsLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<!-- WIDGET BOX -->
    <div class=""widget-box"">
        <!-- WIDGET BOX TITLE -->
        <p class=""widget-box-title"">Sosial media hesabların</p>
        <p class=""widget-box-text"" style=""font-size:12px;color:#8f91ac;"">Görünməyini istəmədiyin təqdirdə,silərək boş qoya bilərsən</p>
        <!-- /WIDGET BOX TITLE -->
        <!-- WIDGET BOX CONTENT -->
        <div class=""widget-box-content"">
            <!-- FORM -->
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21ddd6248b85757bb352120d3a0c04018e3921625803", async() => {
                WriteLiteral(@"
                <!-- FORM ROW -->
                <div class=""form-row split"">
                    <!-- FORM ITEM -->
                    <div class=""form-item"">
                        <!-- FORM INPUT -->
                        <div class=""form-input social-input small active"">
                            <!-- SOCIAL LINK -->
                            <div class=""social-link no-hover facebook"">
                                <!-- ICON FACEBOOK -->
                                <svg class=""icon-facebook"">
                                    <use xlink:href=""#svg-facebook""></use>
                                </svg>
                                <!-- /ICON FACEBOOK -->
                            </div>
                            <!-- /SOCIAL LINK -->

                            <label for=""social-account-facebook"">Facebook profil linki</label>
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "21ddd6248b85757bb352120d3a0c04018e3921626987", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 34 "C:\Users\DostTech\source\repos\Dada\Dada\Views\Setting\Social.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.FbLink);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        </div>
                        <!-- /FORM INPUT -->
                    </div>
                    <!-- /FORM ITEM -->
                    <!-- FORM ITEM -->
                    <div class=""form-item"">
                        <!-- FORM INPUT -->
                        <div class=""form-input social-input small active"">
                            <!-- SOCIAL LINK -->
                            <div class=""social-link no-hover twitter"">
                                <!-- ICON TWITTER -->
                                <svg class=""icon-twitter"">
                                    <use xlink:href=""#svg-twitter""></use>
                                </svg>
                                <!-- /ICON TWITTER -->
                            </div>
                            <!-- /SOCIAL LINK -->

                            <label for=""social-account-twitter"">Twitter profil linki</label>
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "21ddd6248b85757bb352120d3a0c04018e3921629748", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 54 "C:\Users\DostTech\source\repos\Dada\Dada\Views\Setting\Social.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.TwitLink);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        </div>
                        <!-- /FORM INPUT -->
                    </div>
                    <!-- /FORM ITEM -->
                </div>
                <!-- /FORM ROW -->
                <!-- FORM ROW -->
                <div class=""form-row split"">
                    <!-- FORM ITEM -->
                    <div class=""form-item"">
                        <!-- FORM INPUT -->
                        <div class=""form-input social-input small active"">
                            <!-- SOCIAL LINK -->
                            <div class=""social-link no-hover instagram"">
                                <!-- ICON INSTAGRAM -->
                                <svg class=""icon-instagram"">
                                    <use xlink:href=""#svg-instagram""></use>
                                </svg>
                                <!-- /ICON INSTAGRAM -->
                            </div>
                            <!-- /SOCIAL LINK -->

                     ");
                WriteLiteral("       <label for=\"social-account-instagram\">Instagram profil linki</label>\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "21ddd6248b85757bb352120d3a0c04018e39216212618", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 78 "C:\Users\DostTech\source\repos\Dada\Dada\Views\Setting\Social.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.InstaLink);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        </div>
                        <!-- /FORM INPUT -->
                    </div>
                    <!-- /FORM ITEM -->
                    <!-- FORM ITEM -->
                    <div class=""form-item"">
                        <!-- FORM INPUT -->
                        <div class=""form-input social-input small active"">
                            <!-- SOCIAL LINK -->
                            <div class=""social-link no-hover twitch"">
                                <!-- ICON TWITCH -->
                                <svg class=""icon-twitch"">
                                    <use xlink:href=""#svg-twitch""></use>
                                </svg>
                                <!-- /ICON TWITCH -->
                            </div>
                            <!-- /SOCIAL LINK -->

                            <label for=""social-account-twitch"">Twitch profil linki</label>
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "21ddd6248b85757bb352120d3a0c04018e39216215289", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 98 "C:\Users\DostTech\source\repos\Dada\Dada\Views\Setting\Social.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.TwitchLink);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        </div>
                        <!-- /FORM INPUT -->
                    </div>
                    <!-- /FORM ITEM -->
                </div>
                <!-- /FORM ROW -->
                <!-- FORM ROW -->
                <div class=""form-row split"">
                    <!-- FORM ITEM -->
                    <div class=""form-item"">
                        <!-- FORM INPUT -->
                        <div class=""form-input social-input small"">
                            <!-- SOCIAL LINK -->
                            <div class=""social-link no-hover google"">
                                <!-- ICON GOOGLE -->
                                <svg class=""icon-google"">
                                    <use xlink:href=""#svg-google""></use>
                                </svg>
                                <!-- /ICON GOOGLE -->
                            </div>
                            <!-- /SOCIAL LINK -->

                            <label for=""soc");
                WriteLiteral("ial-account-google\">Google + profil linki</label>\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "21ddd6248b85757bb352120d3a0c04018e39216218136", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 122 "C:\Users\DostTech\source\repos\Dada\Dada\Views\Setting\Social.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.GoogleLink);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        </div>
                        <!-- /FORM INPUT -->
                    </div>
                    <!-- /FORM ITEM -->
                    <!-- FORM ITEM -->
                    <div class=""form-item"">
                        <!-- FORM INPUT -->
                        <div class=""form-input social-input small active"">
                            <!-- SOCIAL LINK -->
                            <div class=""social-link no-hover youtube"">
                                <!-- ICON YOUTUBE -->
                                <svg class=""icon-youtube"">
                                    <use xlink:href=""#svg-youtube""></use>
                                </svg>
                                <!-- /ICON YOUTUBE -->
                            </div>
                            <!-- /SOCIAL LINK -->

                            <label for=""social-account-youtube"">Youtube kanal linki</label>
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "21ddd6248b85757bb352120d3a0c04018e39216220815", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 142 "C:\Users\DostTech\source\repos\Dada\Dada\Views\Setting\Social.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.YoutubeLink);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        </div>
                        <!-- /FORM INPUT -->
                    </div>
                    <!-- /FORM ITEM -->
                </div>
                <!-- /FORM ROW -->
                <!-- FORM ROW -->
                <div class=""form-row split"">
                    <!-- FORM ITEM -->
                    <div class=""form-item"">
                        <!-- FORM INPUT -->
                        <div class=""form-input social-input small active"">
                            <!-- SOCIAL LINK -->
                            <div class=""social-link no-hover patreon"">
                                <!-- ICON PATREON -->
                                <svg class=""icon-patreon"">
                                    <use xlink:href=""#svg-patreon""></use>
                                </svg>
                                <!-- /ICON PATREON -->
                            </div>
                            <!-- /SOCIAL LINK -->

                            <la");
                WriteLiteral("bel for=\"social-account-patreon\">Patreon profil linki</label>\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "21ddd6248b85757bb352120d3a0c04018e39216223676", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 166 "C:\Users\DostTech\source\repos\Dada\Dada\Views\Setting\Social.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.PatreonLink);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        </div>
                        <!-- /FORM INPUT -->
                    </div>
                    <!-- /FORM ITEM -->
                    <!-- FORM ITEM -->
                    <div class=""form-item"">
                        <!-- FORM INPUT -->
                        <div class=""form-input social-input small active"">
                            <!-- SOCIAL LINK -->
                            <div class=""social-link no-hover discord"">
                                <!-- ICON DISCORD -->
                                <svg class=""icon-discord"">
                                    <use xlink:href=""#svg-discord""></use>
                                </svg>
                                <!-- /ICON DISCORD -->
                            </div>
                            <!-- /SOCIAL LINK -->

                            <label for=""social-account-discord"">Discord kanal linki</label>
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "21ddd6248b85757bb352120d3a0c04018e39216226356", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 186 "C:\Users\DostTech\source\repos\Dada\Dada\Views\Setting\Social.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.DiscordLink);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        </div>
                        <!-- /FORM INPUT -->
                    </div>
                    <!-- /FORM ITEM -->
                </div>
                <!-- /FORM ROW -->
                <div style=""text-align:end"">
                    <button style=""width:86px; margin-top:25px;"" type=""submit"" class=""button small secondary"">Paylaş</button>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <!-- /FORM -->\r\n        </div>\r\n        <!-- WIDGET BOX CONTENT -->\r\n    </div>\r\n<!-- /WIDGET BOX -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserSocialViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
