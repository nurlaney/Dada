#pragma checksum "C:\Users\DostTech\source\repos\Dada\Dada\Views\Setting\ChangePassword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9bde6904354eab9c5fc1d77faa3a5186667eddd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Setting_ChangePassword), @"mvc.1.0.view", @"/Views/Setting/ChangePassword.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9bde6904354eab9c5fc1d77faa3a5186667eddd", @"/Views/Setting/ChangePassword.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5df8d91f3053575989349cd954876bfedd45bcfc", @"/Views/_ViewImports.cshtml")]
    public class Views_Setting_ChangePassword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\DostTech\source\repos\Dada\Dada\Views\Setting\ChangePassword.cshtml"
  
    Layout = "_SettingsLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- GRID COLUMN -->
<div class=""account-hub-content"">
    <!-- SECTION HEADER -->
    <div class=""section-header"">
        <!-- SECTION HEADER INFO -->
        <div class=""section-header-info"">
            <!-- SECTION PRETITLE -->
            <p class=""section-pretitle"">Hesab</p>
            <!-- /SECTION PRETITLE -->
            <!-- SECTION TITLE -->
            <h2 class=""section-title"">Şifrəni dəyişdir</h2>
            <!-- /SECTION TITLE -->
        </div>
        <!-- /SECTION HEADER INFO -->
    </div>
    <!-- /SECTION HEADER -->
    <!-- GRID COLUMN -->
    <div class=""grid-column"">
        <!-- WIDGET BOX -->
        <div class=""widget-box"">
            <!-- WIDGET BOX CONTENT -->
            <div class=""widget-box-content"">
                <!-- FORM -->
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9bde6904354eab9c5fc1d77faa3a5186667eddd5150", async() => {
                WriteLiteral(@"
                    <!-- FORM ROW -->
                    <div class=""form-row"">
                        <!-- FORM ITEM -->
                        <div class=""form-item"">
                            <!-- FORM INPUT -->
                            <div class=""form-input small"">
                                <label for=""account-current-password"">Hal hazırki şifrəni təsdiqlə</label>
                                <input type=""password"" id=""account-current-password"" name=""account_current_password"">
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
                            <div class=""form-inp");
                WriteLiteral(@"ut small"">
                                <label for=""account-new-password"">Yeni şifrə gir</label>
                                <input type=""password"" id=""account-new-password"" name=""account_new_password"">
                            </div>
                            <!-- /FORM INPUT -->
                        </div>
                        <!-- /FORM ITEM -->
                        <!-- FORM ITEM -->
                        <div class=""form-item"">
                            <!-- FORM INPUT -->
                            <div class=""form-input small"">
                                <label for=""account-new-password-confirm"">Yeni şifrəni təsdiqlə</label>
                                <input type=""password"" id=""account-new-password-confirm"" name=""account_new_password_confirm"">
                            </div>
                            <!-- /FORM INPUT -->
                        </div>
                        <!-- /FORM ITEM -->
                    </div>
                    <!-");
                WriteLiteral(@"- /FORM ROW -->
                    <!-- FORM ROW -->
                    <div class=""form-row split"">
                        <!-- FORM ITEM -->
                        <div class=""form-item"">
                            <!-- BUTTON -->
                            <p class=""button full secondary"">Şifrəni unutmusan ?</p>
                            <!-- /BUTTON -->
                        </div>
                        <!-- /FORM ITEM -->
                        <!-- FORM ITEM -->
                        <div class=""form-item"">
                            <!-- BUTTON -->
                            <p class=""button full primary"">Şifrəmi yenilə :)</p>
                            <!-- /BUTTON -->
                        </div>
                        <!-- /FORM ITEM -->
                    </div>
                    <!-- /FORM ROW -->
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <!-- /FORM -->\r\n            </div>\r\n            <!-- WIDGET BOX CONTENT -->\r\n        </div>\r\n        <!-- /WIDGET BOX -->\r\n    </div>\r\n    <!-- /GRID COLUMN -->\r\n</div>\r\n<!-- /GRID COLUMN -->\r\n");
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
