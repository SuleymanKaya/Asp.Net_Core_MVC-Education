#pragma checksum "C:\Users\Suleyman\Desktop\Genel Çalışmalar\Aspnet_core_mvc\Ders1\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3bbd1e1548d5775c20f499975ac10a5cd4a2636c"
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
#line 1 "C:\Users\Suleyman\Desktop\Genel Çalışmalar\Aspnet_core_mvc\Ders1\Views\_ViewImports.cshtml"
using Ders1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Suleyman\Desktop\Genel Çalışmalar\Aspnet_core_mvc\Ders1\Views\_ViewImports.cshtml"
using Ders1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bbd1e1548d5775c20f499975ac10a5cd4a2636c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a239240390b41d6d9b43e9282416e91fbbd2f3f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Suleyman\Desktop\Genel Çalışmalar\Aspnet_core_mvc\Ders1\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Merhaba Dünya</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n    <p style=\"background-color:gold\"> ");
#nullable restore
#line 8 "C:\Users\Suleyman\Desktop\Genel Çalışmalar\Aspnet_core_mvc\Ders1\Views\Home\Index.cshtml"
                                 Write(DateTime.Now.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n    <br/>\r\n    <div style=\"background-color:#4800ff\">\r\n");
#nullable restore
#line 11 "C:\Users\Suleyman\Desktop\Genel Çalışmalar\Aspnet_core_mvc\Ders1\Views\Home\Index.cshtml"
         for(int i=1; i<=10; i++)
            {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Suleyman\Desktop\Genel Çalışmalar\Aspnet_core_mvc\Ders1\Views\Home\Index.cshtml"
       Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("            <br/>\r\n");
#nullable restore
#line 15 "C:\Users\Suleyman\Desktop\Genel Çalışmalar\Aspnet_core_mvc\Ders1\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n    <br/>\r\n    <br/>\r\n    <div style=\"background-color:#00ff21\">\r\n");
#nullable restore
#line 21 "C:\Users\Suleyman\Desktop\Genel Çalışmalar\Aspnet_core_mvc\Ders1\Views\Home\Index.cshtml"
           
            var liste = new List<string>() { "Ankara", "İzmir", "İstanbul", "Diyarbakır" };
        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 25 "C:\Users\Suleyman\Desktop\Genel Çalışmalar\Aspnet_core_mvc\Ders1\Views\Home\Index.cshtml"
         foreach(var li in liste){ 
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\Suleyman\Desktop\Genel Çalışmalar\Aspnet_core_mvc\Ders1\Views\Home\Index.cshtml"
       Write(li);

#line default
#line hidden
#nullable disable
            WriteLiteral("            <br/>\r\n");
#nullable restore
#line 28 "C:\Users\Suleyman\Desktop\Genel Çalışmalar\Aspnet_core_mvc\Ders1\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n</div>\r\n");
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
