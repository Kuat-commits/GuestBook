#pragma checksum "C:\Users\user\RiderProjects\Guestbook\Guestbook\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b1e3377cd67b6c938c699243089c91fdaeab5f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\user\RiderProjects\Guestbook\Guestbook\Views\_ViewImports.cshtml"
using Guestbook;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\RiderProjects\Guestbook\Guestbook\Views\_ViewImports.cshtml"
using Guestbook.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\user\RiderProjects\Guestbook\Guestbook\Views\Home\Index.cshtml"
using Microsoft.EntityFrameworkCore.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b1e3377cd67b6c938c699243089c91fdaeab5f4", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe50703c499f42c7088a01c50ebe005444171dd2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Guestbook.ViewModels.GusetBookViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Home/Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\user\RiderProjects\Guestbook\Guestbook\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Гостевая книга";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 10 "C:\Users\user\RiderProjects\Guestbook\Guestbook\Views\Home\Index.cshtml"
 using (Html.BeginForm("Create", "Home", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""container"">
        <div class=""row mb-2"">
            <div class=""card w-100 p-4"">
                <h2>Гостевая книга</h2>
                <h5 class=""card-title"">Добавить запись</h5>
                <div class=""form-group"">
                    <label for=""name"">Введите имя: </label>
                    <input type=""text"" class=""form-control"" name=""Name"" maxlength=""50"" required/>
                </div>
                <div class=""form-group"">
                    <label for=""email"">Введите email:</label>
                    <input type=""email"" class=""form-control"" name=""Mail"" maxlength=""50"" required/>
                </div>
                <div class=""form-group"">
                    <label for=""message"">Введите сообщение:</label>
                    <textarea name=""Message"" class=""form-control"" rows=""7"" cols=""40"" required></textarea>
                </div>
                <br/>
                <input type=""submit"" class=""btn btn-primary"" value=""Отправить""/>
            </div");
            WriteLiteral(">\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 34 "C:\Users\user\RiderProjects\Guestbook\Guestbook\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"row mb-2\">\r\n        <div class=\"card w-100 p-4\">\r\n            <h3 class=\"card-title\">Фильтр</h3>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b1e3377cd67b6c938c699243089c91fdaeab5f46074", async() => {
                WriteLiteral(@"
                <div class=""form-inline form-group"">
                    <label class=""control-label""> Имя: </label>
                    <input name=""Name"" class=""form-control ml-1 mr-1""/>
                    <label class=""control-label"">Email: </label>
                    <input name=""Mail"" class=""form-control ml-1 mr-1""/>
                    <input type=""submit"" value=""Фильтр"" class=""btn btn-primary ml-2""/>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
    </div>
</div>
<div class=""container"">
    <div class=""row"">
        <div class=""card w-100 p-4"">
            <h3 class=""card-title"">Отзывы</h3>
            <table class=""table"">
                <thead class=""thead-light"">
                <tr>
                    <th scope=""col"">Name</th>
                    <th scope=""col"">Email</th>
                    <th scope=""col"">Message</th>
                    <th scope=""col"">Action</th>
                </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 66 "C:\Users\user\RiderProjects\Guestbook\Guestbook\Views\Home\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 69 "C:\Users\user\RiderProjects\Guestbook\Guestbook\Views\Home\Index.cshtml"
                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 70 "C:\Users\user\RiderProjects\Guestbook\Guestbook\Views\Home\Index.cshtml"
                       Write(item.Mail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 71 "C:\Users\user\RiderProjects\Guestbook\Guestbook\Views\Home\Index.cshtml"
                       Write(item.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 2778, "\"", 2807, 2);
            WriteAttributeValue("", 2785, "/home/edit?id=", 2785, 14, true);
#nullable restore
#line 73 "C:\Users\user\RiderProjects\Guestbook\Guestbook\Views\Home\Index.cshtml"
WriteAttributeValue("", 2799, item.Id, 2799, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-id=\"");
#nullable restore
#line 73 "C:\Users\user\RiderProjects\Guestbook\Guestbook\Views\Home\Index.cshtml"
                                                                 Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-toggle=\"modal\" data-target=\"#editModal\" class=\"btn btn-success\">Edit</a>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 2937, "\"", 2968, 2);
            WriteAttributeValue("", 2944, "/home/delete?id=", 2944, 16, true);
#nullable restore
#line 74 "C:\Users\user\RiderProjects\Guestbook\Guestbook\Views\Home\Index.cshtml"
WriteAttributeValue("", 2960, item.Id, 2960, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</a>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 77 "C:\Users\user\RiderProjects\Guestbook\Guestbook\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </tbody>
            </table>
        </div>
    </div>
</div>

<!-- Modal -->
<div class=""modal fade"" id=""editModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Modal title</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
");
            WriteLiteral("            <div class=\"modal-footer\">\r\n                <button type=\"button\" class=\"btn btn-secondary\" data-dismiss=\"modal\">Close</button>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Guestbook.ViewModels.GusetBookViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
