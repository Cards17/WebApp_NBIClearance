#pragma checksum "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57544f8c9d5802280e3370251016c05f7175f4b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Applicant_Details), @"mvc.1.0.view", @"/Views/Applicant/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57544f8c9d5802280e3370251016c05f7175f4b6", @"/Views/Applicant/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6168e502c3c315b4dad0d91f17e1a52abfd08457", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Applicant_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NBILicenseProjectMVC.Models.Applicant>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Applicant", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n<h1 style=\"text-align:center\">Applicant Details</h1>\r\n<br /> <br />\r\n\r\n<div>\r\n\r\n    <div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57544f8c9d5802280e3370251016c05f7175f4b66230", async() => {
                WriteLiteral(" Back ");
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
            WriteLiteral(" &nbsp; &nbsp;\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57544f8c9d5802280e3370251016c05f7175f4b67696", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 14 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Details.cshtml"
                                                                                  WriteLiteral(Model.Id);

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
            WriteLiteral(" &nbsp; &nbsp;\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57544f8c9d5802280e3370251016c05f7175f4b610229", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 15 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Details.cshtml"
                                                                                   WriteLiteral(Model.Id);

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
            WriteLiteral(" &nbsp; &nbsp;\r\n    </div>\r\n    <hr />\r\n    <dl class=\"row\" style=\"font-size:20px; color:maroon\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ApplicantPicture));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 805, "\"", 834, 1);
#nullable restore
#line 23 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Details.cshtml"
WriteAttributeValue("", 811, Model.ApplicantPicture, 811, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"rounded mx-auto d-block\" style=\"overflow: hidden; position: relative; width:200px; height:200px;\" />\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Lastname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Details.cshtml"
       Write(Html.DisplayFor(model => model.Lastname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Firstname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Details.cshtml"
       Write(Html.DisplayFor(model => model.Firstname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Middlename));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Details.cshtml"
       Write(Html.DisplayFor(model => model.Middlename));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BranchName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Details.cshtml"
       Write(Html.DisplayFor(model => model.BranchName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Details.cshtml"
       Write(Html.DisplayFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ValidId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 59 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Details.cshtml"
       Write(Html.DisplayFor(model => model.ValidId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        \r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 63 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Birthdate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 66 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Details.cshtml"
       Write(Html.DisplayFor(model => model.Birthdate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 69 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 72 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Details.cshtml"
       Write(Html.DisplayFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 75 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CivilStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 78 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Details.cshtml"
       Write(Html.DisplayFor(model => model.CivilStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 81 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EducationalAttainment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 84 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Details.cshtml"
       Write(Html.DisplayFor(model => model.EducationalAttainment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 87 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LandlineNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 90 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Details.cshtml"
       Write(Html.DisplayFor(model => model.LandlineNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 93 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MobileNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 96 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Details.cshtml"
       Write(Html.DisplayFor(model => model.MobileNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 99 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EmailAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 102 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Details.cshtml"
       Write(Html.DisplayFor(model => model.EmailAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 105 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Complexion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 108 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Details.cshtml"
       Write(Html.DisplayFor(model => model.Complexion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 111 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Peculiarities));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 114 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Details.cshtml"
       Write(Html.DisplayFor(model => model.Peculiarities));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 117 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Religion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 120 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Details.cshtml"
       Write(Html.DisplayFor(model => model.Religion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 123 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Height));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 126 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Details.cshtml"
       Write(Html.DisplayFor(model => model.Height));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 129 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Weight));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 132 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Details.cshtml"
       Write(Html.DisplayFor(model => model.Weight));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 135 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.HusbandOrWifeName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 138 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Details.cshtml"
       Write(Html.DisplayFor(model => model.HusbandOrWifeName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 141 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FatherName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 144 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Details.cshtml"
       Write(Html.DisplayFor(model => model.FatherName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 147 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FatherBirthplace));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 150 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Details.cshtml"
       Write(Html.DisplayFor(model => model.FatherBirthplace));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 153 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MotherName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 156 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Details.cshtml"
       Write(Html.DisplayFor(model => model.MotherName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 159 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MotherBirthplace));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 162 "C:\Users\ricardo.piquero.jr\source\repos\NBILicenseProject\NBILicenseProjectMVC\Views\Applicant\Details.cshtml"
       Write(Html.DisplayFor(model => model.MotherBirthplace));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NBILicenseProjectMVC.Models.Applicant> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
