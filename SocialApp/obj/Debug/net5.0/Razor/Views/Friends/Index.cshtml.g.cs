#pragma checksum "C:\Users\Randy\Desktop\Chan\Programacion 3\SocialApp\SocialApp\Views\Friends\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e31e6578bfaa496f54d98dbdc473cb08d663821"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Friends_Index), @"mvc.1.0.view", @"/Views/Friends/Index.cshtml")]
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
#line 1 "C:\Users\Randy\Desktop\Chan\Programacion 3\SocialApp\SocialApp\Views\_ViewImports.cshtml"
using SocialApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Randy\Desktop\Chan\Programacion 3\SocialApp\SocialApp\Views\_ViewImports.cshtml"
using SocialApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Randy\Desktop\Chan\Programacion 3\SocialApp\SocialApp\Views\Friends\Index.cshtml"
using SocialApp.Core.Application.ViewModels.Friend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Randy\Desktop\Chan\Programacion 3\SocialApp\SocialApp\Views\Friends\Index.cshtml"
using SocialApp.Core.Application.ViewModels.Commentary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Randy\Desktop\Chan\Programacion 3\SocialApp\SocialApp\Views\Friends\Index.cshtml"
using SocialApp.Core.Application.ViewModels.Publication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Randy\Desktop\Chan\Programacion 3\SocialApp\SocialApp\Views\Friends\Index.cshtml"
using SocialApp.Core.Application.ViewModels.User;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Randy\Desktop\Chan\Programacion 3\SocialApp\SocialApp\Views\Friends\Index.cshtml"
using SocialApp.Core.Application.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Randy\Desktop\Chan\Programacion 3\SocialApp\SocialApp\Views\Friends\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e31e6578bfaa496f54d98dbdc473cb08d663821", @"/Views/Friends/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4505f08feed56818a0a4ce49ad6be511510b945b", @"/Views/_ViewImports.cshtml")]
    public class Views_Friends_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SaveFriendVm>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Comments", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-outline-primary float-start"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-label"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control w-75"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Nombre de usuario"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Friends", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddFriend", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-outline-danger float-end mx-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 11 "C:\Users\Randy\Desktop\Chan\Programacion 3\SocialApp\SocialApp\Views\Friends\Index.cshtml"
  

    UserVm user = httpContext.HttpContext.Session.Get<UserVm>("user");
    ViewData["Title"] = "Friends";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid mb-3"">

    <div class=""row"">

        <div class=""col-md-8"">

            <div class=""col-md-12 col-sm-6 mt-2"">

                <div class=""card bg-transparent text-white text-center"">
                    <div class=""card-title"">
                        <h3 class=""card-text fw-bold ""> PUBLICACIONES DE AMIGOS </h3>
                    </div>
                </div>

            </div>

            <div class=""col-md-10 offset-1"">

");
#nullable restore
#line 35 "C:\Users\Randy\Desktop\Chan\Programacion 3\SocialApp\SocialApp\Views\Friends\Index.cshtml"
                 if (ViewBag.PublicationList == null || ViewBag.PublicationList.Count == 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h2 class=\"text-white mx-5 my-5\"> No tienes amigos agregados. </h2>\r\n");
#nullable restore
#line 38 "C:\Users\Randy\Desktop\Chan\Programacion 3\SocialApp\SocialApp\Views\Friends\Index.cshtml"
                }
                else
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\Randy\Desktop\Chan\Programacion 3\SocialApp\SocialApp\Views\Friends\Index.cshtml"
                     foreach (PublicationVm item in ViewBag.PublicationList)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"card text-white mt-3 bg-dark bg-opacity-50 animate__animated animate__fadeIn\r\n                     rounded border border-warning\">\r\n\r\n                            <div>\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 1568, "\"", 1587, 1);
#nullable restore
#line 47 "C:\Users\Randy\Desktop\Chan\Programacion 3\SocialApp\SocialApp\Views\Friends\Index.cshtml"
WriteAttributeValue("", 1574, item.UserImg, 1574, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\" float-start rounded mx-auto d-block img-size-profileImg rounded-circle\"\r\n                                     alt=\"no hay imagen disponible\" />\r\n\r\n                                <h6 class=\"mt-3\"> ");
#nullable restore
#line 50 "C:\Users\Randy\Desktop\Chan\Programacion 3\SocialApp\SocialApp\Views\Friends\Index.cshtml"
                                             Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </h6>\r\n                            </div>\r\n\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 1887, "\"", 1906, 1);
#nullable restore
#line 53 "C:\Users\Randy\Desktop\Chan\Programacion 3\SocialApp\SocialApp\Views\Friends\Index.cshtml"
WriteAttributeValue("", 1893, item.PostImg, 1893, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"rounded mx-auto d-block img-size-post\" alt=\"...\">\r\n\r\n                            <div class=\"card-body\">\r\n\r\n                                <p class=\"card-text fw-bold\">\r\n                                    ");
#nullable restore
#line 58 "C:\Users\Randy\Desktop\Chan\Programacion 3\SocialApp\SocialApp\Views\Friends\Index.cshtml"
                               Write(item.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <span class=\"text-white fw-light float-end\">\r\n                                        Created at: ");
#nullable restore
#line 60 "C:\Users\Randy\Desktop\Chan\Programacion 3\SocialApp\SocialApp\Views\Friends\Index.cshtml"
                                               Write(item.Created.ToString("dd/MM/yyyy: h:mm tt"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </span>\r\n                                </p>\r\n\r\n");
#nullable restore
#line 64 "C:\Users\Randy\Desktop\Chan\Programacion 3\SocialApp\SocialApp\Views\Friends\Index.cshtml"
                                 if (ViewBag.CommentaryList == null || ViewBag.CommentaryList.Count == 0)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p class=\"card-text mt-3\"> No hay comentarios </p>\r\n");
#nullable restore
#line 67 "C:\Users\Randy\Desktop\Chan\Programacion 3\SocialApp\SocialApp\Views\Friends\Index.cshtml"
                                }
                                else
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "C:\Users\Randy\Desktop\Chan\Programacion 3\SocialApp\SocialApp\Views\Friends\Index.cshtml"
                                     foreach (CommentaryVm x in ViewBag.CommentaryList)
                                    {
                                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"row\">\r\n                                            <div class=\"col-md-1 me-4\">\r\n                                                <img");
            BeginWriteAttribute("src", " src=\"", 3227, "\"", 3243, 1);
#nullable restore
#line 77 "C:\Users\Randy\Desktop\Chan\Programacion 3\SocialApp\SocialApp\Views\Friends\Index.cshtml"
WriteAttributeValue("", 3233, x.UserImg, 3233, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""float-start mx-auto d-block img-size-profileImg rounded-circle""
                                                     alt=""....."" />
                                            </div>
                                            <div class=""col-md-10"">
                                                <p class=""card-text mt-3""> ");
#nullable restore
#line 81 "C:\Users\Randy\Desktop\Chan\Programacion 3\SocialApp\SocialApp\Views\Friends\Index.cshtml"
                                                                      Write(x.Comentario);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                                            </div>\r\n                                        </div>\r\n");
            WriteLiteral("                                        <hr />\r\n");
#nullable restore
#line 88 "C:\Users\Randy\Desktop\Chan\Programacion 3\SocialApp\SocialApp\Views\Friends\Index.cshtml"
                                                                                                 

                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 90 "C:\Users\Randy\Desktop\Chan\Programacion 3\SocialApp\SocialApp\Views\Friends\Index.cshtml"
                                     
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n\r\n                            <div class=\"card-footer border-top border-warning\">\r\n                                <div class=\"row\">\r\n\r\n                                    <div class=\"col-md-2 my-2\">\r\n\r\n");
            WriteLiteral("                                        <img");
            BeginWriteAttribute("src", " src=\"", 4295, "\"", 4314, 1);
#nullable restore
#line 101 "C:\Users\Randy\Desktop\Chan\Programacion 3\SocialApp\SocialApp\Views\Friends\Index.cshtml"
WriteAttributeValue("", 4301, user.UserImg, 4301, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""rounded mx-auto d-block img-size-profileImg rounded-circle""
                                             alt=""no hay imagen disponible"" />

                                    </div>

                                    <div class=""col-md-4 mt-3"">

                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e31e6578bfaa496f54d98dbdc473cb08d66382117449", async() => {
                WriteLiteral("Comentar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 108 "C:\Users\Randy\Desktop\Chan\Programacion 3\SocialApp\SocialApp\Views\Friends\Index.cshtml"
                                                                                          WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                                    </div>\r\n\r\n                                </div>\r\n\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 117 "C:\Users\Randy\Desktop\Chan\Programacion 3\SocialApp\SocialApp\Views\Friends\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 117 "C:\Users\Randy\Desktop\Chan\Programacion 3\SocialApp\SocialApp\Views\Friends\Index.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>



        </div>

        <div class=""col-md-4"">

            <div class=""col-md-4"">

                <div class=""card bg-transparent text-white text-center"">
                    <div class=""card-title"">
                        <h3 class=""card-text fw-bold ""> AMIGOS </h3>
                    </div>
                </div>

            </div>

");
#nullable restore
#line 138 "C:\Users\Randy\Desktop\Chan\Programacion 3\SocialApp\SocialApp\Views\Friends\Index.cshtml"
             if (user.IsInactive == "Inactivo")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h5 class=\"text-white\">\r\n                    Para Agregar amigos debe activar su usuario,\r\n                    Enlace en su correo electronico\r\n                </h5>\r\n");
#nullable restore
#line 144 "C:\Users\Randy\Desktop\Chan\Programacion 3\SocialApp\SocialApp\Views\Friends\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"my-4 fw-bold text-white \">\r\n\r\n                    ");
#nullable restore
#line 149 "C:\Users\Randy\Desktop\Chan\Programacion 3\SocialApp\SocialApp\Views\Friends\Index.cshtml"
               Write(Html.ValidationSummary(false, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e31e6578bfaa496f54d98dbdc473cb08d66382122071", async() => {
                WriteLiteral("\r\n\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e31e6578bfaa496f54d98dbdc473cb08d66382122358", async() => {
                    WriteLiteral(" User name: ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 152 "C:\Users\Randy\Desktop\Chan\Programacion 3\SocialApp\SocialApp\Views\Friends\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.FriendName);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2e31e6578bfaa496f54d98dbdc473cb08d66382124027", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 153 "C:\Users\Randy\Desktop\Chan\Programacion 3\SocialApp\SocialApp\Views\Friends\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.FriendName);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n                        <button type=\"submit\" class=\"btn btn-primary btn-sm float-md-start my-2\"> Buscar </button>\r\n\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                </div>\r\n");
#nullable restore
#line 160 "C:\Users\Randy\Desktop\Chan\Programacion 3\SocialApp\SocialApp\Views\Friends\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n            <div class=\"col-md-12 my-5\">\r\n\r\n");
#nullable restore
#line 166 "C:\Users\Randy\Desktop\Chan\Programacion 3\SocialApp\SocialApp\Views\Friends\Index.cshtml"
                 if (ViewBag.FriendsList == null || ViewBag.FriendsList.Count == 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h2 class=\"text-white mx-5 my-5\"> No hay amigos agregados </h2>\r\n");
#nullable restore
#line 169 "C:\Users\Randy\Desktop\Chan\Programacion 3\SocialApp\SocialApp\Views\Friends\Index.cshtml"
                }
                else
                {



                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 175 "C:\Users\Randy\Desktop\Chan\Programacion 3\SocialApp\SocialApp\Views\Friends\Index.cshtml"
                     foreach (FriendVm item in ViewBag.FriendsList)
                    {



#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"card text-white mt-3 bg-dark bg-opacity-50 animate__animated animate__fadeIn\r\n                                             rounded border border-warning w-50\">\r\n\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 6944, "\"", 6963, 1);
#nullable restore
#line 182 "C:\Users\Randy\Desktop\Chan\Programacion 3\SocialApp\SocialApp\Views\Friends\Index.cshtml"
WriteAttributeValue("", 6950, item.UserImg, 6950, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                                 class=\"rounded mx-auto d-block img-size-addFriend rounded-circle\" alt=\"...\">\r\n\r\n                            <div class=\"card-body\">\r\n                                <h5 class=\"card-title\">");
#nullable restore
#line 186 "C:\Users\Randy\Desktop\Chan\Programacion 3\SocialApp\SocialApp\Views\Friends\Index.cshtml"
                                                  Write(item.FriendName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n\r\n                                <p class=\"card-text\"> ");
#nullable restore
#line 188 "C:\Users\Randy\Desktop\Chan\Programacion 3\SocialApp\SocialApp\Views\Friends\Index.cshtml"
                                                 Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 188 "C:\Users\Randy\Desktop\Chan\Programacion 3\SocialApp\SocialApp\Views\Friends\Index.cshtml"
                                                             Write(item.Apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e31e6578bfaa496f54d98dbdc473cb08d66382130497", async() => {
                WriteLiteral("Borrar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 190 "C:\Users\Randy\Desktop\Chan\Programacion 3\SocialApp\SocialApp\Views\Friends\Index.cshtml"
                                                                                  WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                            </div>\r\n\r\n                        </div>\r\n");
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2e31e6578bfaa496f54d98dbdc473cb08d66382133126", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
#nullable restore
#line 197 "C:\Users\Randy\Desktop\Chan\Programacion 3\SocialApp\SocialApp\Views\Friends\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => item.Id);

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
            WriteLiteral("\r\n");
#nullable restore
#line 198 "C:\Users\Randy\Desktop\Chan\Programacion 3\SocialApp\SocialApp\Views\Friends\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 198 "C:\Users\Randy\Desktop\Chan\Programacion 3\SocialApp\SocialApp\Views\Friends\Index.cshtml"
                     


                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </div>\r\n\r\n        </div>\r\n\r\n    </div>\r\n\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor httpContext { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SaveFriendVm> Html { get; private set; }
    }
}
#pragma warning restore 1591
