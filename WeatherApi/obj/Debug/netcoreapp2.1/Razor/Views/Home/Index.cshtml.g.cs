#pragma checksum "/Users/alexpaiu/projects/WeatherApi/WeatherApi/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "133f2398c82ba7ae5d29ae3def66e5be5c339d6c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "/Users/alexpaiu/projects/WeatherApi/WeatherApi/Views/_ViewImports.cshtml"
using WeatherApi;

#line default
#line hidden
#line 2 "/Users/alexpaiu/projects/WeatherApi/WeatherApi/Views/_ViewImports.cshtml"
using WeatherApi.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"133f2398c82ba7ae5d29ae3def66e5be5c339d6c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a26548a14ec9754f8f640881021cb5340933e4eb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/alexpaiu/projects/WeatherApi/WeatherApi/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Weather";

#line default
#line hidden
            BeginContext(40, 478, true);
            WriteLiteral(@"   <h2>Weather Updates</h2>
<p id=""reply""/>
<p id=""button1"" />
<button>Get Weather</button>
<script>
    $(document).ready(function() {
        $(""button"").click(function() {
             $.get(""http://api.openweathermap.org/data/2.5/weather?q=London,uk&APPID=da794fc3bcbfc36af0bc149b3fdff45b&units=metric"", function(response) {
                $(""reply"").text(response.name);
                $(""button1"").text(response.timezone);
             });
        });
    });
</script> ");
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
