#pragma checksum "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fbca4aa25d8e9f3079e2429b8feaec5a4e828087"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Applicant_Index), @"mvc.1.0.view", @"/Views/Applicant/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbca4aa25d8e9f3079e2429b8feaec5a4e828087", @"/Views/Applicant/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6168e502c3c315b4dad0d91f17e1a52abfd08457", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Applicant_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<NBILicenseProjectMVC.Models.Applicant>>
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
#line 2 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<h1 style=\"text-align:center\">Home Page</h1>\r\n<br />\r\n<br />\r\n<hr />\r\n<br />\r\n<div style=\"text-align:left\">\r\n");
#nullable restore
#line 13 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Index.cshtml"
     using (Html.BeginForm("Index", "Applicant", FormMethod.Get))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <table>\r\n            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 18 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Index.cshtml"
               Write(Html.RadioButton("searchBy", "Firstname", true));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <text> First Name</text>\r\n                    ");
#nullable restore
#line 20 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Index.cshtml"
               Write(Html.RadioButton("searchBy", "Lastname"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <text> Last Name</text>\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 26 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Index.cshtml"
               Write(Html.TextBox("searchValue", null, new{Class="form-control",placeholder="Enter First/Last Name"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <input type=\"submit\" value=\"Search\" class=\"btn btn-success\" />\r\n                </td>\r\n                <td> &nbsp; </td>\r\n            </tr>\r\n\r\n        </table> <br />\r\n");
#nullable restore
#line 35 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n<br>\r\n<div class=\"d-flex justify-content-center table table-hover table-striped text\">\r\n    <table class=\"table\" id=\"my_table\">\r\n        <thead class=\"thead-dark\">\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 44 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.ApplicantPicture));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 47 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Lastname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 50 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Firstname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 53 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Middlename));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 56 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.BranchName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 59 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 62 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.ValidId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <th>\r\n                        ");
#nullable restore
#line 64 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                        ");
#nullable restore
#line 67 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.CivilStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                        ");
#nullable restore
#line 70 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.EducationalAttainment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                        ");
#nullable restore
#line 73 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.LandlineNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                        ");
#nullable restore
#line 76 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.MobileNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                        ");
#nullable restore
#line 79 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.EmailAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                        ");
#nullable restore
#line 82 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Complexion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                        ");
#nullable restore
#line 85 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Peculiarities));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                        ");
#nullable restore
#line 88 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Religion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                        ");
#nullable restore
#line 91 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Height));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                        ");
#nullable restore
#line 94 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Weight));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                        ");
#nullable restore
#line 97 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.HusbandOrWifeName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                        ");
#nullable restore
#line 100 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.FatherName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                        ");
#nullable restore
#line 103 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.FatherBirthplace));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                        ");
#nullable restore
#line 106 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.MotherName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                        ");
#nullable restore
#line 109 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.MotherBirthplace));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 115 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr style=\"font-family:\'Segoe UI\'; font-size: 16px; font-weight:300\">\r\n                    <td>\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 4172, "\"", 4200, 1);
#nullable restore
#line 119 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Index.cshtml"
WriteAttributeValue("", 4178, item.ApplicantPicture, 4178, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""rounded mx-auto d-block"" style=""overflow: hidden; position: relative; width:100px; height:100px;"" />
                    </td>
                    <td class=""text-justify"" id=""textbox"" style=""width:100px; height:60px; word-wrap: break-word"">
                        
                        ");
#nullable restore
#line 123 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Lastname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"text-justify\" id=\"textbox\" style=\"width:100px; height:60px; word-wrap: break-word\">\r\n                        ");
#nullable restore
#line 126 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Firstname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class =\"text-justify\" id=\"textbox\" style=\"width:100px; height:60px; word-wrap: break-word\">\r\n                        ");
#nullable restore
#line 129 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Middlename));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class =\"text-justify\" id=\"textbox\" style=\"width:100px; height:60px; word-wrap: break-word\">\r\n                        ");
#nullable restore
#line 132 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.BranchName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"text-justify\" id=\"textbox\" style=\"width:100px; height:60px; word-wrap: break-word\">\r\n                        ");
#nullable restore
#line 135 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"text-justify\" id=\"textbox\" style=\"width:100px; height:60px; word-wrap: break-word\">\r\n                        ");
#nullable restore
#line 138 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ValidId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class =\"text-justify\" id=\"textbox\" style=\"width:100px; height:60px; word-wrap: break-word\">\r\n                        ");
#nullable restore
#line 141 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class =\"text-justify\" id=\"textbox\" style=\"width:100px; height:60px; word-wrap: break-word\">\r\n                        ");
#nullable restore
#line 144 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.CivilStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class =\"text-justify\" id=\"textbox\" style=\"width:100px; height:60px; word-wrap: break-word\">\r\n                        ");
#nullable restore
#line 147 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.EducationalAttainment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"text-justify\" id=\"textbox\" style=\"width:100px; height:60px; word-wrap: break-word\">\r\n                        ");
#nullable restore
#line 150 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.LandlineNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"text-justify\" id=\"textbox\" style=\"width:100px; height:60px; word-wrap: break-word\">\r\n                        ");
#nullable restore
#line 153 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.MobileNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"text-justify\" id=\"textbox\" style=\"width:60px; height:60px; word-wrap: break-word\">\r\n                        ");
#nullable restore
#line 156 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.EmailAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"text-justify\" id=\"textbox\" style=\"width:100px; height:60px; word-wrap: break-word\">\r\n                        ");
#nullable restore
#line 159 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Complexion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"text-justify\" id=\"textbox\" style=\"width:100px; height:60px; word-wrap: break-word\">\r\n                        ");
#nullable restore
#line 162 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Peculiarities));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"text-justify\" id=\"textbox\" style=\"width:60px; height:60px; word-wrap: break-word\">\r\n                        ");
#nullable restore
#line 165 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Religion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"text-justify\" id=\"textbox\" style=\"width:100px; height:60px; word-wrap: break-word\">\r\n                        ");
#nullable restore
#line 168 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Height));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td >\r\n                    <td class=\"text-justify\" id=\"textbox\" style=\"width:100px; height:60px; word-wrap: break-word\">\r\n                        ");
#nullable restore
#line 171 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Weight));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"text-justify\" id=\"textbox\" style=\"width:100px; height:60px; word-wrap: break-word\">\r\n                        ");
#nullable restore
#line 174 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.HusbandOrWifeName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"text-justify\" id=\"textbox\" style=\"width:100px; height:60px; word-wrap: break-word\">\r\n                        ");
#nullable restore
#line 177 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.FatherName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"text-justify\" id=\"textbox\" style=\"width:100px; height:60px; word-wrap: break-word\">\r\n                        ");
#nullable restore
#line 180 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.FatherBirthplace));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"text-justify\" id=\"textbox\" style=\"width:100px; height:60px; word-wrap: break-word\">\r\n                        ");
#nullable restore
#line 183 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.MotherName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"text-justify\" id=\"textbox\" style=\"width:100px; height:60px; word-wrap: break-word\">\r\n                        ");
#nullable restore
#line 186 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.MotherBirthplace));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbca4aa25d8e9f3079e2429b8feaec5a4e82808727008", async() => {
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
#line 189 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Index.cshtml"
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
#line 193 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Index.cshtml"
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
