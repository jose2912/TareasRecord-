#pragma checksum "C:\Users\jl_gu\Downloads\aaaaa\StudentRecordManagementSystem\StudentRecordManagementSystem\Views\Usuario\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2d88e3de4967ffacf57176ae1bfc99e853bb090a754194e5b2445edd72977880"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Index), @"mvc.1.0.view", @"/Views/Usuario/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuario/Index.cshtml", typeof(AspNetCore.Views_Usuario_Index))]
namespace AspNetCore
{
    #line default
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\jl_gu\Downloads\aaaaa\StudentRecordManagementSystem\StudentRecordManagementSystem\Views\_ViewImports.cshtml"
using TareasRecordManagementSystem

    ;
#line 2 "C:\Users\jl_gu\Downloads\aaaaa\StudentRecordManagementSystem\StudentRecordManagementSystem\Views\_ViewImports.cshtml"
using TareasRecordManagementSystem.Models

#line default
#line hidden
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"2d88e3de4967ffacf57176ae1bfc99e853bb090a754194e5b2445edd72977880", @"/Views/Usuario/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"067c769114cdbecc8ba3d7861280688da0edc34c1ecb92c3109304d50b26f406", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TareasRecordManagementSystem.Models.Personal>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(66, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\jl_gu\Downloads\aaaaa\StudentRecordManagementSystem\StudentRecordManagementSystem\Views\Usuario\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden

            BeginContext(109, 41, true);
            WriteLiteral("\r\n<h2>Lista de Clientes</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(150, 40, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d88e3de4967ffacf57176ae1bfc99e853bb090a754194e5b2445edd729778804171", async() => {
                BeginContext(173, 13, true);
                WriteLiteral("Crear Cliente");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(190, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(283, 38, false);
            Write(
#line 16 "C:\Users\jl_gu\Downloads\aaaaa\StudentRecordManagementSystem\StudentRecordManagementSystem\Views\Usuario\Index.cshtml"
                 Html.DisplayNameFor(model => model.Id)

#line default
#line hidden
            );
            EndContext();
            BeginContext(321, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(377, 43, false);
            Write(
#line 19 "C:\Users\jl_gu\Downloads\aaaaa\StudentRecordManagementSystem\StudentRecordManagementSystem\Views\Usuario\Index.cshtml"
                 Html.DisplayNameFor(model => model.TipoDoc)

#line default
#line hidden
            );
            EndContext();
            BeginContext(420, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(476, 45, false);
            Write(
#line 22 "C:\Users\jl_gu\Downloads\aaaaa\StudentRecordManagementSystem\StudentRecordManagementSystem\Views\Usuario\Index.cshtml"
                 Html.DisplayNameFor(model => model.NumeroDoc)

#line default
#line hidden
            );
            EndContext();
            BeginContext(521, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(577, 45, false);
            Write(
#line 25 "C:\Users\jl_gu\Downloads\aaaaa\StudentRecordManagementSystem\StudentRecordManagementSystem\Views\Usuario\Index.cshtml"
                 Html.DisplayNameFor(model => model.ApPaterno)

#line default
#line hidden
            );
            EndContext();
            BeginContext(622, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(678, 45, false);
            Write(
#line 28 "C:\Users\jl_gu\Downloads\aaaaa\StudentRecordManagementSystem\StudentRecordManagementSystem\Views\Usuario\Index.cshtml"
                 Html.DisplayNameFor(model => model.ApMaterno)

#line default
#line hidden
            );
            EndContext();
            BeginContext(723, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(779, 43, false);
            Write(
#line 31 "C:\Users\jl_gu\Downloads\aaaaa\StudentRecordManagementSystem\StudentRecordManagementSystem\Views\Usuario\Index.cshtml"
                 Html.DisplayNameFor(model => model.Nombre1)

#line default
#line hidden
            );
            EndContext();
            BeginContext(822, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(878, 43, false);
            Write(
#line 34 "C:\Users\jl_gu\Downloads\aaaaa\StudentRecordManagementSystem\StudentRecordManagementSystem\Views\Usuario\Index.cshtml"
                 Html.DisplayNameFor(model => model.Nombre2)

#line default
#line hidden
            );
            EndContext();
            BeginContext(921, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(977, 48, false);
            Write(
#line 37 "C:\Users\jl_gu\Downloads\aaaaa\StudentRecordManagementSystem\StudentRecordManagementSystem\Views\Usuario\Index.cshtml"
                 Html.DisplayNameFor(model => model.FechaIngreso)

#line default
#line hidden
            );
            EndContext();
            BeginContext(1025, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 43 "C:\Users\jl_gu\Downloads\aaaaa\StudentRecordManagementSystem\StudentRecordManagementSystem\Views\Usuario\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden

            BeginContext(1143, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1192, 37, false);
            Write(
#line 46 "C:\Users\jl_gu\Downloads\aaaaa\StudentRecordManagementSystem\StudentRecordManagementSystem\Views\Usuario\Index.cshtml"
                 Html.DisplayFor(modelItem => item.Id)

#line default
#line hidden
            );
            EndContext();
            BeginContext(1229, 59, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                    ");
            EndContext();
            BeginContext(1289, 42, false);
            Write(
#line 49 "C:\Users\jl_gu\Downloads\aaaaa\StudentRecordManagementSystem\StudentRecordManagementSystem\Views\Usuario\Index.cshtml"
                     Html.DisplayFor(modelItem => item.TipoDoc)

#line default
#line hidden
            );
            EndContext();
            BeginContext(1331, 59, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                    ");
            EndContext();
            BeginContext(1391, 44, false);
            Write(
#line 52 "C:\Users\jl_gu\Downloads\aaaaa\StudentRecordManagementSystem\StudentRecordManagementSystem\Views\Usuario\Index.cshtml"
                     Html.DisplayFor(modelItem => item.NumeroDoc)

#line default
#line hidden
            );
            EndContext();
            BeginContext(1435, 59, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                    ");
            EndContext();
            BeginContext(1495, 44, false);
            Write(
#line 55 "C:\Users\jl_gu\Downloads\aaaaa\StudentRecordManagementSystem\StudentRecordManagementSystem\Views\Usuario\Index.cshtml"
                     Html.DisplayFor(modelItem => item.ApPaterno)

#line default
#line hidden
            );
            EndContext();
            BeginContext(1539, 60, true);
            WriteLiteral("\r\n            </td>\r\n             <td>\r\n                    ");
            EndContext();
            BeginContext(1600, 44, false);
            Write(
#line 58 "C:\Users\jl_gu\Downloads\aaaaa\StudentRecordManagementSystem\StudentRecordManagementSystem\Views\Usuario\Index.cshtml"
                     Html.DisplayFor(modelItem => item.ApMaterno)

#line default
#line hidden
            );
            EndContext();
            BeginContext(1644, 59, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                    ");
            EndContext();
            BeginContext(1704, 42, false);
            Write(
#line 61 "C:\Users\jl_gu\Downloads\aaaaa\StudentRecordManagementSystem\StudentRecordManagementSystem\Views\Usuario\Index.cshtml"
                     Html.DisplayFor(modelItem => item.Nombre1)

#line default
#line hidden
            );
            EndContext();
            BeginContext(1746, 59, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                    ");
            EndContext();
            BeginContext(1806, 42, false);
            Write(
#line 64 "C:\Users\jl_gu\Downloads\aaaaa\StudentRecordManagementSystem\StudentRecordManagementSystem\Views\Usuario\Index.cshtml"
                     Html.DisplayFor(modelItem => item.Nombre2)

#line default
#line hidden
            );
            EndContext();
            BeginContext(1848, 59, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                    ");
            EndContext();
            BeginContext(1908, 47, false);
            Write(
#line 67 "C:\Users\jl_gu\Downloads\aaaaa\StudentRecordManagementSystem\StudentRecordManagementSystem\Views\Usuario\Index.cshtml"
                     Html.DisplayFor(modelItem => item.FechaIngreso)

#line default
#line hidden
            );
            EndContext();
            BeginContext(1955, 21, true);
            WriteLiteral("\r\n            </td>\r\n");
            EndContext();
            BeginContext(2594, 15, true);
            WriteLiteral("        </tr>\r\n");
            EndContext();
#line 81 "C:\Users\jl_gu\Downloads\aaaaa\StudentRecordManagementSystem\StudentRecordManagementSystem\Views\Usuario\Index.cshtml"
}

#line default
#line hidden

            BeginContext(2612, 32, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TareasRecordManagementSystem.Models.Personal>> Html { get; private set; }
    }
}
#pragma warning restore 1591
