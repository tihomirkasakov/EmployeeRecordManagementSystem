#pragma checksum "C:\Users\Tihomir\source\repos\EmployeeRecordManagementSystem\EmployeeRecordManagementSystem.Web\Views\Shared\_EmployeeListPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb9a76d39059c6bc8da017b7a0f5e8459145234a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__EmployeeListPartial), @"mvc.1.0.view", @"/Views/Shared/_EmployeeListPartial.cshtml")]
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
#line 1 "C:\Users\Tihomir\source\repos\EmployeeRecordManagementSystem\EmployeeRecordManagementSystem.Web\Views\_ViewImports.cshtml"
using EmployeeRecordManagementSystem.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Tihomir\source\repos\EmployeeRecordManagementSystem\EmployeeRecordManagementSystem.Web\Views\_ViewImports.cshtml"
using EmployeeRecordManagementSystem.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb9a76d39059c6bc8da017b7a0f5e8459145234a", @"/Views/Shared/_EmployeeListPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"651c537ae8a4da7de5c5a7fee38e0d0d707e369c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__EmployeeListPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EmployeeRecordManagementSystem.Model.Dtos.EmployeeListDto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(" \r\n<ul id=\"employeeResult\">\r\n    <li class=\"employeeTitle\"><div>Name</div><div>Department</div><div>Job Title</div><div>Manager</div><div>Address</div></li>\r\n");
#nullable restore
#line 5 "C:\Users\Tihomir\source\repos\EmployeeRecordManagementSystem\EmployeeRecordManagementSystem.Web\Views\Shared\_EmployeeListPartial.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"employeeTitle\" data-id=\"");
#nullable restore
#line 7 "C:\Users\Tihomir\source\repos\EmployeeRecordManagementSystem\EmployeeRecordManagementSystem.Web\Views\Shared\_EmployeeListPartial.cshtml"
                                      Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("onclick", " onclick=\"", 323, "\"", 388, 3);
            WriteAttributeValue("", 333, "location.href=\'/Employee/Details?employeeId=\'+", 333, 46, true);
#nullable restore
#line 7 "C:\Users\Tihomir\source\repos\EmployeeRecordManagementSystem\EmployeeRecordManagementSystem.Web\Views\Shared\_EmployeeListPartial.cshtml"
WriteAttributeValue("", 379, item.Id, 379, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 387, ";", 387, 1, true);
            EndWriteAttribute();
            WriteLiteral("><div>");
#nullable restore
#line 7 "C:\Users\Tihomir\source\repos\EmployeeRecordManagementSystem\EmployeeRecordManagementSystem.Web\Views\Shared\_EmployeeListPartial.cshtml"
                                                                                                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div><div>");
#nullable restore
#line 7 "C:\Users\Tihomir\source\repos\EmployeeRecordManagementSystem\EmployeeRecordManagementSystem.Web\Views\Shared\_EmployeeListPartial.cshtml"
                                                                                                                                            Write(item.Department);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div><div>");
#nullable restore
#line 7 "C:\Users\Tihomir\source\repos\EmployeeRecordManagementSystem\EmployeeRecordManagementSystem.Web\Views\Shared\_EmployeeListPartial.cshtml"
                                                                                                                                                                       Write(item.JobTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div><div>");
#nullable restore
#line 7 "C:\Users\Tihomir\source\repos\EmployeeRecordManagementSystem\EmployeeRecordManagementSystem.Web\Views\Shared\_EmployeeListPartial.cshtml"
                                                                                                                                                                                                Write(item.Manager);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div><div>");
#nullable restore
#line 7 "C:\Users\Tihomir\source\repos\EmployeeRecordManagementSystem\EmployeeRecordManagementSystem.Web\Views\Shared\_EmployeeListPartial.cshtml"
                                                                                                                                                                                                                        Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div></li>\r\n");
#nullable restore
#line 8 "C:\Users\Tihomir\source\repos\EmployeeRecordManagementSystem\EmployeeRecordManagementSystem.Web\Views\Shared\_EmployeeListPartial.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EmployeeRecordManagementSystem.Model.Dtos.EmployeeListDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
