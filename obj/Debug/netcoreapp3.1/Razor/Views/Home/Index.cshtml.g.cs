#pragma checksum "/Users/tjay/Documents/c_projects/DependencyInjection/DependencyInjection/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef4c9b2b8772ca4d690e378b42754ed7ce94b9d4"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef4c9b2b8772ca4d690e378b42754ed7ce94b9d4", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DependencyInjection.Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("m-1 p-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "/Users/tjay/Documents/c_projects/DependencyInjection/DependencyInjection/Views/Home/Index.cshtml"
   Layout = null; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\n<html>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef4c9b2b8772ca4d690e378b42754ed7ce94b9d43253", async() => {
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width""/>
    <title>Wstrzykiwanie zależności</title>
    
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css"" integrity=""sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh"" crossorigin=""anonymous"">
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"" integrity=""sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6"" crossorigin=""anonymous""></script>
");
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
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef4c9b2b8772ca4d690e378b42754ed7ce94b9d44750", async() => {
                WriteLiteral("\n");
#nullable restore
#line 13 "/Users/tjay/Documents/c_projects/DependencyInjection/DependencyInjection/Views/Home/Index.cshtml"
 if (ViewData.Count > 0){

#line default
#line hidden
#nullable disable
                WriteLiteral("    <table class=\"table table-bordered table-sm table-striped\">\n");
#nullable restore
#line 15 "/Users/tjay/Documents/c_projects/DependencyInjection/DependencyInjection/Views/Home/Index.cshtml"
         foreach (var kvp in ViewData){

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\n                <td>");
#nullable restore
#line 17 "/Users/tjay/Documents/c_projects/DependencyInjection/DependencyInjection/Views/Home/Index.cshtml"
               Write(kvp.Key);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td><td>");
#nullable restore
#line 17 "/Users/tjay/Documents/c_projects/DependencyInjection/DependencyInjection/Views/Home/Index.cshtml"
                                Write(kvp.Value);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n            </tr>\n");
#nullable restore
#line 19 "/Users/tjay/Documents/c_projects/DependencyInjection/DependencyInjection/Views/Home/Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </table>\n");
#nullable restore
#line 21 "/Users/tjay/Documents/c_projects/DependencyInjection/DependencyInjection/Views/Home/Index.cshtml"
}

#line default
#line hidden
#nullable disable
                WriteLiteral("<table class=\"table table-bordered table-sm table-striped\">\n    <thead>\n    <tr>\n        <th>Produkt</th><th>Cena</th>\n    </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 29 "/Users/tjay/Documents/c_projects/DependencyInjection/DependencyInjection/Views/Home/Index.cshtml"
     if (Model == null){

#line default
#line hidden
#nullable disable
                WriteLiteral("        <tr>\n            <td colspan=\"3\" class=\"text-center\">Brak danych modelu</td>\n        </tr>\n");
#nullable restore
#line 33 "/Users/tjay/Documents/c_projects/DependencyInjection/DependencyInjection/Views/Home/Index.cshtml"
    }
    else{
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "/Users/tjay/Documents/c_projects/DependencyInjection/DependencyInjection/Views/Home/Index.cshtml"
         foreach(var p in Model) {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\n                <td>");
#nullable restore
#line 37 "/Users/tjay/Documents/c_projects/DependencyInjection/DependencyInjection/Views/Home/Index.cshtml"
               Write(p.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                <td>");
#nullable restore
#line 38 "/Users/tjay/Documents/c_projects/DependencyInjection/DependencyInjection/Views/Home/Index.cshtml"
                Write($"{p.Price:C2}");

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n            </tr>\n");
#nullable restore
#line 40 "/Users/tjay/Documents/c_projects/DependencyInjection/DependencyInjection/Views/Home/Index.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "/Users/tjay/Documents/c_projects/DependencyInjection/DependencyInjection/Views/Home/Index.cshtml"
     
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </tbody>\n</table>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DependencyInjection.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591