#pragma checksum "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93503961a017cae617522116e562e5cecb0769fa"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93503961a017cae617522116e562e5cecb0769fa", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6168e502c3c315b4dad0d91f17e1a52abfd08457", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<NBILicenseProjectMVC.Models.Applicant>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Applicant", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<h1 style=\"text-align:center\">Home Page</h1>\r\n<br />\r\n<br />\r\n<hr />\r\n<div style=\"text-align:left\">\r\n");
#nullable restore
#line 12 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Home\Index.cshtml"
     using (Html.BeginForm("Index", "Applicant", FormMethod.Get))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <table>\r\n            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 17 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Home\Index.cshtml"
               Write(Html.RadioButton("searchBy", "Firstname", true));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <text> First Name</text>\r\n                    ");
#nullable restore
#line 19 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Home\Index.cshtml"
               Write(Html.RadioButton("searchBy", "Lastname"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <text> Last Name</text>\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 25 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Home\Index.cshtml"
               Write(Html.TextBox("searchValue", null, new{Class="form-control",placeholder="Enter First/Last Name"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <input type=\"submit\" value=\"Search\" class=\"btn btn-success\" />\r\n                </td>\r\n                <td> &nbsp; </td>\r\n            </tr>\r\n\r\n        </table> <br />\r\n");
#nullable restore
#line 34 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n<br>\r\n<div class=\"d-flex justify-content-center table table-hover table-striped\">\r\n    <table class=\"table\">\r\n        <thead class=\"thead-dark\">\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 43 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Home\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.ApplicantPicture));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 46 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Home\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Lastname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 49 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Home\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Firstname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 52 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Home\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Middlename));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 55 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Home\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.BranchName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 58 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Home\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 61 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Home\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.ValidId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <th>\r\n                        ");
#nullable restore
#line 63 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Home\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                        ");
#nullable restore
#line 66 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Home\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.CivilStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                        ");
#nullable restore
#line 69 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Home\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.EducationalAttainment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                        ");
#nullable restore
#line 72 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Home\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.LandlineNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                        ");
#nullable restore
#line 75 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Home\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.MobileNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                        ");
#nullable restore
#line 78 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Home\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.EmailAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                        ");
#nullable restore
#line 81 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Home\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Complexion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                        ");
#nullable restore
#line 84 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Home\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Peculiarities));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                        ");
#nullable restore
#line 87 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Home\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Religion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                        ");
#nullable restore
#line 90 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Home\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Height));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                        ");
#nullable restore
#line 93 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Home\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Weight));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                        ");
#nullable restore
#line 96 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Home\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.HusbandOrWifeName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                        ");
#nullable restore
#line 99 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Home\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.FatherName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                        ");
#nullable restore
#line 102 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Home\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.FatherBirthplace));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                        ");
#nullable restore
#line 105 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Home\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.MotherName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                        ");
#nullable restore
#line 108 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Home\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.MotherBirthplace));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 114 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Home\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr style=\"font-family:\'Segoe UI\'; font-size: 14px\">\r\n                    <td>\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 4128, "\"", 4156, 1);
#nullable restore
#line 118 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 4134, item.ApplicantPicture, 4134, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"rounded mx-auto d-block\" style=\"overflow: hidden; position: relative; width:100px; height:100px;\" />\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 121 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Home\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Lastname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 124 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Home\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Firstname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 127 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Home\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Middlename));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 130 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Home\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.BranchName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 133 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Home\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 136 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Home\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ValidId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 139 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Home\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 142 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Home\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.CivilStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 145 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Home\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.EducationalAttainment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 148 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Home\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.LandlineNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 151 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Home\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.MobileNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"text-justify\" id=\"textbox\" style=\"width:60px; height:60px; word-wrap: break-word\">\r\n                        ");
#nullable restore
#line 154 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Home\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.EmailAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 157 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Home\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Complexion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 160 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Home\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Peculiarities));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"text-justify\" id=\"textbox\" style=\"width:60px; height:60px; word-wrap: break-word\">\r\n                        ");
#nullable restore
#line 163 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Home\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Religion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 166 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Home\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Height));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 169 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Home\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Weight));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 172 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Home\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.HusbandOrWifeName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"text-justify\" id=\"textbox\" style=\"width:100px; height:60px; word-wrap: break-word\">\r\n                        ");
#nullable restore
#line 175 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Home\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.FatherName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"text-justify\" id=\"textbox\" style=\"width:100px; height:60px; word-wrap: break-word\">\r\n                        ");
#nullable restore
#line 178 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Home\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.FatherBirthplace));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"text-justify\" id=\"textbox\" style=\"width:100px; height:60px; word-wrap: break-word\">\r\n                        ");
#nullable restore
#line 181 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Home\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.MotherName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"text-justify\" id=\"textbox\" style=\"width:100px; height:60px; word-wrap: break-word\">\r\n                        ");
#nullable restore
#line 184 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Home\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.MotherBirthplace));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93503961a017cae617522116e562e5cecb0769fa25106", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 187 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Home\Index.cshtml"
                                                                                                     WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 191 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n</div>\r\n");
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
