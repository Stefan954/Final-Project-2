#pragma checksum "C:\Users\f5216125\OneDrive - FRG\Desktop\Varsity 2020\Semester 2\CMPG 323 - IT Development\Project_2\Stefan_Proj2\Stefan_Proj2\Views\Datasets\Index_User.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1fa8a92196072e0ee250b03b7464865e062bbb2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Datasets_Index_User), @"mvc.1.0.view", @"/Views/Datasets/Index_User.cshtml")]
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
#line 1 "C:\Users\f5216125\OneDrive - FRG\Desktop\Varsity 2020\Semester 2\CMPG 323 - IT Development\Project_2\Stefan_Proj2\Stefan_Proj2\Views\_ViewImports.cshtml"
using Stefan_Proj2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\f5216125\OneDrive - FRG\Desktop\Varsity 2020\Semester 2\CMPG 323 - IT Development\Project_2\Stefan_Proj2\Stefan_Proj2\Views\_ViewImports.cshtml"
using Stefan_Proj2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1fa8a92196072e0ee250b03b7464865e062bbb2", @"/Views/Datasets/Index_User.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a664838c924589e8cc59277167f3fcd3843834d2", @"/Views/_ViewImports.cshtml")]
    public class Views_Datasets_Index_User : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Stefan_Proj2.Models.Dataset>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\f5216125\OneDrive - FRG\Desktop\Varsity 2020\Semester 2\CMPG 323 - IT Development\Project_2\Stefan_Proj2\Stefan_Proj2\Views\Datasets\Index_User.cshtml"
   ViewData["Title"] = "Admin"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Dataset</h1>\n\n<h4>Test User</h4>\n\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
#nullable restore
#line 13 "C:\Users\f5216125\OneDrive - FRG\Desktop\Varsity 2020\Semester 2\CMPG 323 - IT Development\Project_2\Stefan_Proj2\Stefan_Proj2\Views\Datasets\Index_User.cshtml"
           Write(Html.DisplayNameFor(model => model.EmployeeNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 16 "C:\Users\f5216125\OneDrive - FRG\Desktop\Varsity 2020\Semester 2\CMPG 323 - IT Development\Project_2\Stefan_Proj2\Stefan_Proj2\Views\Datasets\Index_User.cshtml"
           Write(Html.DisplayNameFor(model => model.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 19 "C:\Users\f5216125\OneDrive - FRG\Desktop\Varsity 2020\Semester 2\CMPG 323 - IT Development\Project_2\Stefan_Proj2\Stefan_Proj2\Views\Datasets\Index_User.cshtml"
           Write(Html.DisplayNameFor(model => model.Attrition));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 22 "C:\Users\f5216125\OneDrive - FRG\Desktop\Varsity 2020\Semester 2\CMPG 323 - IT Development\Project_2\Stefan_Proj2\Stefan_Proj2\Views\Datasets\Index_User.cshtml"
           Write(Html.DisplayNameFor(model => model.BusinessTravel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 25 "C:\Users\f5216125\OneDrive - FRG\Desktop\Varsity 2020\Semester 2\CMPG 323 - IT Development\Project_2\Stefan_Proj2\Stefan_Proj2\Views\Datasets\Index_User.cshtml"
           Write(Html.DisplayNameFor(model => model.DailyRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 28 "C:\Users\f5216125\OneDrive - FRG\Desktop\Varsity 2020\Semester 2\CMPG 323 - IT Development\Project_2\Stefan_Proj2\Stefan_Proj2\Views\Datasets\Index_User.cshtml"
           Write(Html.DisplayNameFor(model => model.Department));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 31 "C:\Users\f5216125\OneDrive - FRG\Desktop\Varsity 2020\Semester 2\CMPG 323 - IT Development\Project_2\Stefan_Proj2\Stefan_Proj2\Views\Datasets\Index_User.cshtml"
           Write(Html.DisplayNameFor(model => model.DistanceFromHome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 34 "C:\Users\f5216125\OneDrive - FRG\Desktop\Varsity 2020\Semester 2\CMPG 323 - IT Development\Project_2\Stefan_Proj2\Stefan_Proj2\Views\Datasets\Index_User.cshtml"
           Write(Html.DisplayNameFor(model => model.Education));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 37 "C:\Users\f5216125\OneDrive - FRG\Desktop\Varsity 2020\Semester 2\CMPG 323 - IT Development\Project_2\Stefan_Proj2\Stefan_Proj2\Views\Datasets\Index_User.cshtml"
           Write(Html.DisplayNameFor(model => model.EducationField));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 40 "C:\Users\f5216125\OneDrive - FRG\Desktop\Varsity 2020\Semester 2\CMPG 323 - IT Development\Project_2\Stefan_Proj2\Stefan_Proj2\Views\Datasets\Index_User.cshtml"
           Write(Html.DisplayNameFor(model => model.EmployeeCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 43 "C:\Users\f5216125\OneDrive - FRG\Desktop\Varsity 2020\Semester 2\CMPG 323 - IT Development\Project_2\Stefan_Proj2\Stefan_Proj2\Views\Datasets\Index_User.cshtml"
           Write(Html.DisplayNameFor(model => model.EnvironmentSatisfaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 46 "C:\Users\f5216125\OneDrive - FRG\Desktop\Varsity 2020\Semester 2\CMPG 323 - IT Development\Project_2\Stefan_Proj2\Stefan_Proj2\Views\Datasets\Index_User.cshtml"
           Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 49 "C:\Users\f5216125\OneDrive - FRG\Desktop\Varsity 2020\Semester 2\CMPG 323 - IT Development\Project_2\Stefan_Proj2\Stefan_Proj2\Views\Datasets\Index_User.cshtml"
           Write(Html.DisplayNameFor(model => model.HourlyRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 52 "C:\Users\f5216125\OneDrive - FRG\Desktop\Varsity 2020\Semester 2\CMPG 323 - IT Development\Project_2\Stefan_Proj2\Stefan_Proj2\Views\Datasets\Index_User.cshtml"
           Write(Html.DisplayNameFor(model => model.JobInvolvement));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 55 "C:\Users\f5216125\OneDrive - FRG\Desktop\Varsity 2020\Semester 2\CMPG 323 - IT Development\Project_2\Stefan_Proj2\Stefan_Proj2\Views\Datasets\Index_User.cshtml"
           Write(Html.DisplayNameFor(model => model.JobLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 58 "C:\Users\f5216125\OneDrive - FRG\Desktop\Varsity 2020\Semester 2\CMPG 323 - IT Development\Project_2\Stefan_Proj2\Stefan_Proj2\Views\Datasets\Index_User.cshtml"
           Write(Html.DisplayNameFor(model => model.JobRole));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 61 "C:\Users\f5216125\OneDrive - FRG\Desktop\Varsity 2020\Semester 2\CMPG 323 - IT Development\Project_2\Stefan_Proj2\Stefan_Proj2\Views\Datasets\Index_User.cshtml"
           Write(Html.DisplayNameFor(model => model.JobSatisfaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 64 "C:\Users\f5216125\OneDrive - FRG\Desktop\Varsity 2020\Semester 2\CMPG 323 - IT Development\Project_2\Stefan_Proj2\Stefan_Proj2\Views\Datasets\Index_User.cshtml"
           Write(Html.DisplayNameFor(model => model.MaritalStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 67 "C:\Users\f5216125\OneDrive - FRG\Desktop\Varsity 2020\Semester 2\CMPG 323 - IT Development\Project_2\Stefan_Proj2\Stefan_Proj2\Views\Datasets\Index_User.cshtml"
           Write(Html.DisplayNameFor(model => model.MonthlyIncome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 70 "C:\Users\f5216125\OneDrive - FRG\Desktop\Varsity 2020\Semester 2\CMPG 323 - IT Development\Project_2\Stefan_Proj2\Stefan_Proj2\Views\Datasets\Index_User.cshtml"
           Write(Html.DisplayNameFor(model => model.MonthlyRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 73 "C:\Users\f5216125\OneDrive - FRG\Desktop\Varsity 2020\Semester 2\CMPG 323 - IT Development\Project_2\Stefan_Proj2\Stefan_Proj2\Views\Datasets\Index_User.cshtml"
           Write(Html.DisplayNameFor(model => model.NumCompaniesWorked));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 76 "C:\Users\f5216125\OneDrive - FRG\Desktop\Varsity 2020\Semester 2\CMPG 323 - IT Development\Project_2\Stefan_Proj2\Stefan_Proj2\Views\Datasets\Index_User.cshtml"
           Write(Html.DisplayNameFor(model => model.Over18));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 79 "C:\Users\f5216125\OneDrive - FRG\Desktop\Varsity 2020\Semester 2\CMPG 323 - IT Development\Project_2\Stefan_Proj2\Stefan_Proj2\Views\Datasets\Index_User.cshtml"
           Write(Html.DisplayNameFor(model => model.OverTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 82 "C:\Users\f5216125\OneDrive - FRG\Desktop\Varsity 2020\Semester 2\CMPG 323 - IT Development\Project_2\Stefan_Proj2\Stefan_Proj2\Views\Datasets\Index_User.cshtml"
           Write(Html.DisplayNameFor(model => model.PercentSalaryHike));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 85 "C:\Users\f5216125\OneDrive - FRG\Desktop\Varsity 2020\Semester 2\CMPG 323 - IT Development\Project_2\Stefan_Proj2\Stefan_Proj2\Views\Datasets\Index_User.cshtml"
           Write(Html.DisplayNameFor(model => model.PerformanceRating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 88 "C:\Users\f5216125\OneDrive - FRG\Desktop\Varsity 2020\Semester 2\CMPG 323 - IT Development\Project_2\Stefan_Proj2\Stefan_Proj2\Views\Datasets\Index_User.cshtml"
           Write(Html.DisplayNameFor(model => model.RelationshipSatisfaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 91 "C:\Users\f5216125\OneDrive - FRG\Desktop\Varsity 2020\Semester 2\CMPG 323 - IT Development\Project_2\Stefan_Proj2\Stefan_Proj2\Views\Datasets\Index_User.cshtml"
           Write(Html.DisplayNameFor(model => model.StandardHours));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 94 "C:\Users\f5216125\OneDrive - FRG\Desktop\Varsity 2020\Semester 2\CMPG 323 - IT Development\Project_2\Stefan_Proj2\Stefan_Proj2\Views\Datasets\Index_User.cshtml"
           Write(Html.DisplayNameFor(model => model.StockOptionLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 97 "C:\Users\f5216125\OneDrive - FRG\Desktop\Varsity 2020\Semester 2\CMPG 323 - IT Development\Project_2\Stefan_Proj2\Stefan_Proj2\Views\Datasets\Index_User.cshtml"
           Write(Html.DisplayNameFor(model => model.TotalWorkingYears));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 100 "C:\Users\f5216125\OneDrive - FRG\Desktop\Varsity 2020\Semester 2\CMPG 323 - IT Development\Project_2\Stefan_Proj2\Stefan_Proj2\Views\Datasets\Index_User.cshtml"
           Write(Html.DisplayNameFor(model => model.TrainingTimesLastYear));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 103 "C:\Users\f5216125\OneDrive - FRG\Desktop\Varsity 2020\Semester 2\CMPG 323 - IT Development\Project_2\Stefan_Proj2\Stefan_Proj2\Views\Datasets\Index_User.cshtml"
           Write(Html.DisplayNameFor(model => model.WorkLifeBalance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 106 "C:\Users\f5216125\OneDrive - FRG\Desktop\Varsity 2020\Semester 2\CMPG 323 - IT Development\Project_2\Stefan_Proj2\Stefan_Proj2\Views\Datasets\Index_User.cshtml"
           Write(Html.DisplayNameFor(model => model.YearsAtCompany));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 109 "C:\Users\f5216125\OneDrive - FRG\Desktop\Varsity 2020\Semester 2\CMPG 323 - IT Development\Project_2\Stefan_Proj2\Stefan_Proj2\Views\Datasets\Index_User.cshtml"
           Write(Html.DisplayNameFor(model => model.YearsInCurrentRole));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 112 "C:\Users\f5216125\OneDrive - FRG\Desktop\Varsity 2020\Semester 2\CMPG 323 - IT Development\Project_2\Stefan_Proj2\Stefan_Proj2\Views\Datasets\Index_User.cshtml"
           Write(Html.DisplayNameFor(model => model.YearsSinceLastPromotion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 115 "C:\Users\f5216125\OneDrive - FRG\Desktop\Varsity 2020\Semester 2\CMPG 323 - IT Development\Project_2\Stefan_Proj2\Stefan_Proj2\Views\Datasets\Index_User.cshtml"
           Write(Html.DisplayNameFor(model => model.YearsWithCurrManager));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 121 "C:\Users\f5216125\OneDrive - FRG\Desktop\Varsity 2020\Semester 2\CMPG 323 - IT Development\Project_2\Stefan_Proj2\Stefan_Proj2\Views\Datasets\Index_User.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\n    <td>\n        ");
#nullable restore
#line 125 "C:\Users\f5216125\OneDrive - FRG\Desktop\Varsity 2020\Semester 2\CMPG 323 - IT Development\Project_2\Stefan_Proj2\Stefan_Proj2\Views\Datasets\Index_User.cshtml"
   Write(Html.DisplayFor(modelItem => item.EmployeeNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 128 "C:\Users\f5216125\OneDrive - FRG\Desktop\Varsity 2020\Semester 2\CMPG 323 - IT Development\Project_2\Stefan_Proj2\Stefan_Proj2\Views\Datasets\Index_User.cshtml"
   Write(Html.DisplayFor(modelItem => item.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 131 "C:\Users\f5216125\OneDrive - FRG\Desktop\Varsity 2020\Semester 2\CMPG 323 - IT Development\Project_2\Stefan_Proj2\Stefan_Proj2\Views\Datasets\Index_User.cshtml"
   Write(Html.DisplayFor(modelItem => item.Attrition));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 134 "C:\Users\f5216125\OneDrive - FRG\Desktop\Varsity 2020\Semester 2\CMPG 323 - IT Development\Project_2\Stefan_Proj2\Stefan_Proj2\Views\Datasets\Index_User.cshtml"
   Write(Html.DisplayFor(modelItem => item.BusinessTravel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 137 "C:\Users\f5216125\OneDrive - FRG\Desktop\Varsity 2020\Semester 2\CMPG 323 - IT Development\Project_2\Stefan_Proj2\Stefan_Proj2\Views\Datasets\Index_User.cshtml"
   Write(Html.DisplayFor(modelItem => item.DailyRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 140 "C:\Users\f5216125\OneDrive - FRG\Desktop\Varsity 2020\Semester 2\CMPG 323 - IT Development\Project_2\Stefan_Proj2\Stefan_Proj2\Views\Datasets\Index_User.cshtml"
   Write(Html.DisplayFor(modelItem => item.Department));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 143 "C:\Users\f5216125\OneDrive - FRG\Desktop\Varsity 2020\Semester 2\CMPG 323 - IT Development\Project_2\Stefan_Proj2\Stefan_Proj2\Views\Datasets\Index_User.cshtml"
   Write(Html.DisplayFor(modelItem => item.DistanceFromHome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 146 "C:\Users\f5216125\OneDrive - FRG\Desktop\Varsity 2020\Semester 2\CMPG 323 - IT Development\Project_2\Stefan_Proj2\Stefan_Proj2\Views\Datasets\Index_User.cshtml"
   Write(Html.DisplayFor(modelItem => item.Education));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 149 "C:\Users\f5216125\OneDrive - FRG\Desktop\Varsity 2020\Semester 2\CMPG 323 - IT Development\Project_2\Stefan_Proj2\Stefan_Proj2\Views\Datasets\Index_User.cshtml"
   Write(Html.DisplayFor(modelItem => item.EducationField));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 152 "C:\Users\f5216125\OneDrive - FRG\Desktop\Varsity 2020\Semester 2\CMPG 323 - IT Development\Project_2\Stefan_Proj2\Stefan_Proj2\Views\Datasets\Index_User.cshtml"
   Write(Html.DisplayFor(modelItem => item.EmployeeCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 155 "C:\Users\f5216125\OneDrive - FRG\Desktop\Varsity 2020\Semester 2\CMPG 323 - IT Development\Project_2\Stefan_Proj2\Stefan_Proj2\Views\Datasets\Index_User.cshtml"
   Write(Html.DisplayFor(modelItem => item.EnvironmentSatisfaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 158 "C:\Users\f5216125\OneDrive - FRG\Desktop\Varsity 2020\Semester 2\CMPG 323 - IT Development\Project_2\Stefan_Proj2\Stefan_Proj2\Views\Datasets\Index_User.cshtml"
   Write(Html.DisplayFor(modelItem => item.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 161 "C:\Users\f5216125\OneDrive - FRG\Desktop\Varsity 2020\Semester 2\CMPG 323 - IT Development\Project_2\Stefan_Proj2\Stefan_Proj2\Views\Datasets\Index_User.cshtml"
   Write(Html.DisplayFor(modelItem => item.HourlyRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 164 "C:\Users\f5216125\OneDrive - FRG\Desktop\Varsity 2020\Semester 2\CMPG 323 - IT Development\Project_2\Stefan_Proj2\Stefan_Proj2\Views\Datasets\Index_User.cshtml"
   Write(Html.DisplayFor(modelItem => item.JobInvolvement));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 167 "C:\Users\f5216125\OneDrive - FRG\Desktop\Varsity 2020\Semester 2\CMPG 323 - IT Development\Project_2\Stefan_Proj2\Stefan_Proj2\Views\Datasets\Index_User.cshtml"
   Write(Html.DisplayFor(modelItem => item.JobLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 170 "C:\Users\f5216125\OneDrive - FRG\Desktop\Varsity 2020\Semester 2\CMPG 323 - IT Development\Project_2\Stefan_Proj2\Stefan_Proj2\Views\Datasets\Index_User.cshtml"
   Write(Html.DisplayFor(modelItem => item.JobRole));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 173 "C:\Users\f5216125\OneDrive - FRG\Desktop\Varsity 2020\Semester 2\CMPG 323 - IT Development\Project_2\Stefan_Proj2\Stefan_Proj2\Views\Datasets\Index_User.cshtml"
   Write(Html.DisplayFor(modelItem => item.JobSatisfaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 176 "C:\Users\f5216125\OneDrive - FRG\Desktop\Varsity 2020\Semester 2\CMPG 323 - IT Development\Project_2\Stefan_Proj2\Stefan_Proj2\Views\Datasets\Index_User.cshtml"
   Write(Html.DisplayFor(modelItem => item.MaritalStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 179 "C:\Users\f5216125\OneDrive - FRG\Desktop\Varsity 2020\Semester 2\CMPG 323 - IT Development\Project_2\Stefan_Proj2\Stefan_Proj2\Views\Datasets\Index_User.cshtml"
   Write(Html.DisplayFor(modelItem => item.MonthlyIncome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 182 "C:\Users\f5216125\OneDrive - FRG\Desktop\Varsity 2020\Semester 2\CMPG 323 - IT Development\Project_2\Stefan_Proj2\Stefan_Proj2\Views\Datasets\Index_User.cshtml"
   Write(Html.DisplayFor(modelItem => item.MonthlyRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 185 "C:\Users\f5216125\OneDrive - FRG\Desktop\Varsity 2020\Semester 2\CMPG 323 - IT Development\Project_2\Stefan_Proj2\Stefan_Proj2\Views\Datasets\Index_User.cshtml"
   Write(Html.DisplayFor(modelItem => item.NumCompaniesWorked));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 188 "C:\Users\f5216125\OneDrive - FRG\Desktop\Varsity 2020\Semester 2\CMPG 323 - IT Development\Project_2\Stefan_Proj2\Stefan_Proj2\Views\Datasets\Index_User.cshtml"
   Write(Html.DisplayFor(modelItem => item.Over18));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 191 "C:\Users\f5216125\OneDrive - FRG\Desktop\Varsity 2020\Semester 2\CMPG 323 - IT Development\Project_2\Stefan_Proj2\Stefan_Proj2\Views\Datasets\Index_User.cshtml"
   Write(Html.DisplayFor(modelItem => item.OverTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 194 "C:\Users\f5216125\OneDrive - FRG\Desktop\Varsity 2020\Semester 2\CMPG 323 - IT Development\Project_2\Stefan_Proj2\Stefan_Proj2\Views\Datasets\Index_User.cshtml"
   Write(Html.DisplayFor(modelItem => item.PercentSalaryHike));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 197 "C:\Users\f5216125\OneDrive - FRG\Desktop\Varsity 2020\Semester 2\CMPG 323 - IT Development\Project_2\Stefan_Proj2\Stefan_Proj2\Views\Datasets\Index_User.cshtml"
   Write(Html.DisplayFor(modelItem => item.PerformanceRating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 200 "C:\Users\f5216125\OneDrive - FRG\Desktop\Varsity 2020\Semester 2\CMPG 323 - IT Development\Project_2\Stefan_Proj2\Stefan_Proj2\Views\Datasets\Index_User.cshtml"
   Write(Html.DisplayFor(modelItem => item.RelationshipSatisfaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 203 "C:\Users\f5216125\OneDrive - FRG\Desktop\Varsity 2020\Semester 2\CMPG 323 - IT Development\Project_2\Stefan_Proj2\Stefan_Proj2\Views\Datasets\Index_User.cshtml"
   Write(Html.DisplayFor(modelItem => item.StandardHours));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 206 "C:\Users\f5216125\OneDrive - FRG\Desktop\Varsity 2020\Semester 2\CMPG 323 - IT Development\Project_2\Stefan_Proj2\Stefan_Proj2\Views\Datasets\Index_User.cshtml"
   Write(Html.DisplayFor(modelItem => item.StockOptionLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 209 "C:\Users\f5216125\OneDrive - FRG\Desktop\Varsity 2020\Semester 2\CMPG 323 - IT Development\Project_2\Stefan_Proj2\Stefan_Proj2\Views\Datasets\Index_User.cshtml"
   Write(Html.DisplayFor(modelItem => item.TotalWorkingYears));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 212 "C:\Users\f5216125\OneDrive - FRG\Desktop\Varsity 2020\Semester 2\CMPG 323 - IT Development\Project_2\Stefan_Proj2\Stefan_Proj2\Views\Datasets\Index_User.cshtml"
   Write(Html.DisplayFor(modelItem => item.TrainingTimesLastYear));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 215 "C:\Users\f5216125\OneDrive - FRG\Desktop\Varsity 2020\Semester 2\CMPG 323 - IT Development\Project_2\Stefan_Proj2\Stefan_Proj2\Views\Datasets\Index_User.cshtml"
   Write(Html.DisplayFor(modelItem => item.WorkLifeBalance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 218 "C:\Users\f5216125\OneDrive - FRG\Desktop\Varsity 2020\Semester 2\CMPG 323 - IT Development\Project_2\Stefan_Proj2\Stefan_Proj2\Views\Datasets\Index_User.cshtml"
   Write(Html.DisplayFor(modelItem => item.YearsAtCompany));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 221 "C:\Users\f5216125\OneDrive - FRG\Desktop\Varsity 2020\Semester 2\CMPG 323 - IT Development\Project_2\Stefan_Proj2\Stefan_Proj2\Views\Datasets\Index_User.cshtml"
   Write(Html.DisplayFor(modelItem => item.YearsInCurrentRole));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 224 "C:\Users\f5216125\OneDrive - FRG\Desktop\Varsity 2020\Semester 2\CMPG 323 - IT Development\Project_2\Stefan_Proj2\Stefan_Proj2\Views\Datasets\Index_User.cshtml"
   Write(Html.DisplayFor(modelItem => item.YearsSinceLastPromotion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 227 "C:\Users\f5216125\OneDrive - FRG\Desktop\Varsity 2020\Semester 2\CMPG 323 - IT Development\Project_2\Stefan_Proj2\Stefan_Proj2\Views\Datasets\Index_User.cshtml"
   Write(Html.DisplayFor(modelItem => item.YearsWithCurrManager));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1fa8a92196072e0ee250b03b7464865e062bbb231194", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 230 "C:\Users\f5216125\OneDrive - FRG\Desktop\Varsity 2020\Semester 2\CMPG 323 - IT Development\Project_2\Stefan_Proj2\Stefan_Proj2\Views\Datasets\Index_User.cshtml"
                                  WriteLiteral(item.EmployeeNumber);

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
            WriteLiteral("\n    </td>\n</tr>\n");
#nullable restore
#line 233 "C:\Users\f5216125\OneDrive - FRG\Desktop\Varsity 2020\Semester 2\CMPG 323 - IT Development\Project_2\Stefan_Proj2\Stefan_Proj2\Views\Datasets\Index_User.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Stefan_Proj2.Models.Dataset>> Html { get; private set; }
    }
}
#pragma warning restore 1591
