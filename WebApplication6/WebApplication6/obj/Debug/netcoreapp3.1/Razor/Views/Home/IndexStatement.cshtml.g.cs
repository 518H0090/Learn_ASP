#pragma checksum "D:\ASPNET\WebApplication6\WebApplication6\Views\Home\IndexStatement.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6106b37575c0f4f3c4d9e7d6b107422c222cf2c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_IndexStatement), @"mvc.1.0.view", @"/Views/Home/IndexStatement.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6106b37575c0f4f3c4d9e7d6b107422c222cf2c0", @"/Views/Home/IndexStatement.cshtml")]
    #nullable restore
    public class Views_Home_IndexStatement : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\ASPNET\WebApplication6\WebApplication6\Views\Home\IndexStatement.cshtml"
  
	Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6106b37575c0f4f3c4d9e7d6b107422c222cf2c02968", async() => {
                WriteLiteral("\r\n\t<meta name=\"viewport\" content=\"width=device-width\" />\r\n\t<title>IndexStatement</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6106b37575c0f4f3c4d9e7d6b107422c222cf2c04032", async() => {
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 14 "D:\ASPNET\WebApplication6\WebApplication6\Views\Home\IndexStatement.cshtml"
      
		int a = 10;
		int b = 0;
	

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 19 "D:\ASPNET\WebApplication6\WebApplication6\Views\Home\IndexStatement.cshtml"
     if (a > 5)
	{
		a++;

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t<h1>Điều kiện đúng và giá trị = ");
#nullable restore
#line 22 "D:\ASPNET\WebApplication6\WebApplication6\Views\Home\IndexStatement.cshtml"
                                   Write(a);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n");
#nullable restore
#line 23 "D:\ASPNET\WebApplication6\WebApplication6\Views\Home\IndexStatement.cshtml"
	}
	else
	{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t<h2>Điều kiện sai</h2>\r\n");
#nullable restore
#line 27 "D:\ASPNET\WebApplication6\WebApplication6\Views\Home\IndexStatement.cshtml"
	}

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t<h1>Ternary - ");
#nullable restore
#line 29 "D:\ASPNET\WebApplication6\WebApplication6\Views\Home\IndexStatement.cshtml"
              Write(a > 10 ? b = 10 : b = 5);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n\r\n\t<h1>Value of B is ");
#nullable restore
#line 31 "D:\ASPNET\WebApplication6\WebApplication6\Views\Home\IndexStatement.cshtml"
                 Write(b);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n\r\n");
#nullable restore
#line 33 "D:\ASPNET\WebApplication6\WebApplication6\Views\Home\IndexStatement.cshtml"
      
		int valueSwitch = 3;
	

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 37 "D:\ASPNET\WebApplication6\WebApplication6\Views\Home\IndexStatement.cshtml"
     switch (valueSwitch)
	{
		case 1:

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t<h1>Case 1</h1>\r\n");
#nullable restore
#line 41 "D:\ASPNET\WebApplication6\WebApplication6\Views\Home\IndexStatement.cshtml"
			break;
		case 2:

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t<h1>Case 2</h1>\r\n");
#nullable restore
#line 44 "D:\ASPNET\WebApplication6\WebApplication6\Views\Home\IndexStatement.cshtml"
			break;
		case 3:

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t<h1>Case 3</h1>\r\n");
#nullable restore
#line 47 "D:\ASPNET\WebApplication6\WebApplication6\Views\Home\IndexStatement.cshtml"
			break;
		case 4:

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t<h1>Case 4</h1>\r\n");
#nullable restore
#line 50 "D:\ASPNET\WebApplication6\WebApplication6\Views\Home\IndexStatement.cshtml"
			break;
		default:

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t<h1>Default</h1>\r\n");
#nullable restore
#line 53 "D:\ASPNET\WebApplication6\WebApplication6\Views\Home\IndexStatement.cshtml"
			break;
	}

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
