#pragma checksum "C:\Users\ASUS\Desktop\Yummy-back\Areas\AdminPanel\Views\Food\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "398e434f121de69b6c2e49d2965f8aba40e36a23"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminPanel_Views_Food_Index), @"mvc.1.0.view", @"/Areas/AdminPanel/Views/Food/Index.cshtml")]
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
#line 1 "C:\Users\ASUS\Desktop\Yummy-back\Areas\AdminPanel\Views\_ViewImports.cshtml"
using Yummy.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\Yummy-back\Areas\AdminPanel\Views\_ViewImports.cshtml"
using Yummy.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"398e434f121de69b6c2e49d2965f8aba40e36a23", @"/Areas/AdminPanel/Views/Food/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d48ae033ec17d30fbab3b0044abe82a026dd082", @"/Areas/AdminPanel/Views/_ViewImports.cshtml")]
    public class Areas_AdminPanel_Views_Food_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Food>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\Yummy-back\Areas\AdminPanel\Views\Food\Index.cshtml"
  
    ViewData["Title"] = "Index";
    int count = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Index</h1>
<div class=""main-panel"">
    <div class=""content-wrapper"">
        <div class=""row"">
            <div class=""col-lg-6 grid-margin stretch-card"">
                <div class=""card"">
                    <div class=""card-body"">
                        <h4 class=""card-title"">Basic Table</h4>
                        <p class=""card-description"">
                            Add class <code>.table</code>
                        </p>
                        <div class=""table-responsive"">
                            <table class=""table"">
                                <thead>
                                    <tr>
                                        <th>№</th>
                                        <th>Image</th>
                                        <th>Name</th>
                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 28 "C:\Users\ASUS\Desktop\Yummy-back\Areas\AdminPanel\Views\Food\Index.cshtml"
                                     foreach (var food in Model)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <td>");
#nullable restore
#line 31 "C:\Users\ASUS\Desktop\Yummy-back\Areas\AdminPanel\Views\Food\Index.cshtml"
                                           Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "398e434f121de69b6c2e49d2965f8aba40e36a235023", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1292, "~/image/", 1292, 8, true);
#nullable restore
#line 32 "C:\Users\ASUS\Desktop\Yummy-back\Areas\AdminPanel\Views\Food\Index.cshtml"
AddHtmlAttributeValue("", 1300, food.Image, 1300, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 33 "C:\Users\ASUS\Desktop\Yummy-back\Areas\AdminPanel\Views\Food\Index.cshtml"
                                           Write(food.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td><button type=\"button\" class=\"btn btn-danger btn-sm\" asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1506, "\"", 1529, 1);
#nullable restore
#line 34 "C:\Users\ASUS\Desktop\Yummy-back\Areas\AdminPanel\Views\Food\Index.cshtml"
WriteAttributeValue("", 1521, food.Id, 1521, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></button></td>\r\n                                            <td><button type=\"button\" class=\"btn btn-warning btn-sm\" asp-action=\"Update\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1667, "\"", 1690, 1);
#nullable restore
#line 35 "C:\Users\ASUS\Desktop\Yummy-back\Areas\AdminPanel\Views\Food\Index.cshtml"
WriteAttributeValue("", 1682, food.Id, 1682, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></button></td>\r\n                                        </tr>\r\n");
#nullable restore
#line 37 "C:\Users\ASUS\Desktop\Yummy-back\Areas\AdminPanel\Views\Food\Index.cshtml"
                                        count++;
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </tbody>\r\n                            </table>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Food>> Html { get; private set; }
    }
}
#pragma warning restore 1591
