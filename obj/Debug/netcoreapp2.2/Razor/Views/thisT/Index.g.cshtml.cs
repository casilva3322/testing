#pragma checksum "C:\Users\somet\Desktop\wellSomeTest\Views\thisT\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "adbd266228b7dd5d6bccf8de7c517ef4fcb13f20"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_thisT_Index), @"mvc.1.0.view", @"/Views/thisT/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/thisT/Index.cshtml", typeof(AspNetCore.Views_thisT_Index))]
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
#line 1 "C:\Users\somet\Desktop\wellSomeTest\Views\_ViewImports.cshtml"
using wellSomeTest;

#line default
#line hidden
#line 2 "C:\Users\somet\Desktop\wellSomeTest\Views\_ViewImports.cshtml"
using wellSomeTest.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"adbd266228b7dd5d6bccf8de7c517ef4fcb13f20", @"/Views/thisT/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8607746809cc3369bb534d75450e4cfeff8a5dfc", @"/Views/_ViewImports.cshtml")]
    public class Views_thisT_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 1 "C:\Users\somet\Desktop\wellSomeTest\Views\thisT\Index.cshtml"
      
        ViewBag.Title = "Index Page";
    

#line default
#line hidden
            BeginContext(54, 69, true);
            WriteLiteral("     \r\n    <h2>View Details</h2>\r\n     \r\n    <strong>Name</strong> : ");
            EndContext();
            BeginContext(124, 16, false);
#line 7 "C:\Users\somet\Desktop\wellSomeTest\Views\thisT\Index.cshtml"
                       Write(ViewData["Name"]);

#line default
#line hidden
            EndContext();
            BeginContext(140, 36, true);
            WriteLiteral("<br />\r\n    <strong>City</strong> : ");
            EndContext();
            BeginContext(177, 16, false);
#line 8 "C:\Users\somet\Desktop\wellSomeTest\Views\thisT\Index.cshtml"
                       Write(ViewData["City"]);

#line default
#line hidden
            EndContext();
            BeginContext(193, 39, true);
            WriteLiteral("<br />\r\n    <strong>Address</strong> : ");
            EndContext();
            BeginContext(233, 19, false);
#line 9 "C:\Users\somet\Desktop\wellSomeTest\Views\thisT\Index.cshtml"
                          Write(ViewData["Address"]);

#line default
#line hidden
            EndContext();
            BeginContext(252, 6, true);
            WriteLiteral("<br />");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591