#pragma checksum "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aad1d99db3e40f4dd0423633856dc1d87d60a5cd"
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
#line 1 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\_ViewImports.cshtml"
using NBILicenseProjectMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\_ViewImports.cshtml"
using NBILicenseProjectMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aad1d99db3e40f4dd0423633856dc1d87d60a5cd", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6168e502c3c315b4dad0d91f17e1a52abfd08457", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<NBILicenseProjectMVC.Models.Applicant>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Home Page</h1>\r\n\r\n");
            WriteLiteral("<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 15 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ApplicantPicture));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 18 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Lastname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 21 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Firstname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 24 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Middlename));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 27 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.BranchName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 30 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 33 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ValidId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <th>\r\n                ");
#nullable restore
#line 35 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 38 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CivilStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 43 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Home\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 1301, "\"", 1329, 1);
#nullable restore
#line 47 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 1307, item.ApplicantPicture, 1307, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"rounded mx-auto d-block\" style=\"overflow: hidden; position: relative; width:200px; height:200px;\" />\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 50 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Lastname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 53 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Firstname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 56 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Middlename));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 59 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.BranchName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 62 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 65 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ValidId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 68 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 71 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.CivilStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 74 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<NBILicenseProjectMVC.Models.Applicant>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
