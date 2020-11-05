#pragma checksum "D:\Projects\CompanyTests\Red River\HotdrinkMachine\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b12f5b8381d09b9ad6e2b0d4a7c786cf0214f1d2"
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
#line 1 "D:\Projects\CompanyTests\Red River\HotdrinkMachine\Views\_ViewImports.cshtml"
using HotdrinkMachine;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\CompanyTests\Red River\HotdrinkMachine\Views\_ViewImports.cshtml"
using HotdrinkMachine.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b12f5b8381d09b9ad6e2b0d4a7c786cf0214f1d2", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00a3487be0bc393329bd91ddbdae09116342580b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Projects\CompanyTests\Red River\HotdrinkMachine\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container row"">
    <div style=""margin: auto;
        width: 100%;
        text-align: center;
        border-bottom: 3px solid gray;
        margin-bottom: 30px;
        border-bottom: 16px solid #f9f5ea; "">
        <h1>Hot Drink Machine</h1>
    </div>
    <hr />
    <div class=""flex-container"">
        <input type=""button"" class=""flex-item css-drinkType"" onclick=""fn_clickDrink('coffee')"" value=""Coffee"" />
        <input type=""button"" class=""flex-item css-drinkType"" onclick=""fn_clickDrink('lemontea')"" value=""Lemon Tea"" />
        <input type=""button"" class=""flex-item css-drinkType"" onclick=""fn_clickDrink('chocolate')"" value=""Chocolate"" />
        <input type=""button"" class=""flex-item css-drinkType"" onclick=""fn_clickDrink('roohafza')"" value=""Rooh Afza"" />
    </div>

    <div id=""divPrepartionInProgress"" class=""flex-container""></div>

</div>



    <script>
        function fn_clickDrink(drinkType) {
            $.ajax(
                {
                    type: ""GET");
            WriteLiteral(@""",
                    url: ""/Home/GetDrink"",
                    data: { drinkType: drinkType },
                    success: function (result) {
                        $(""#divPrepartionInProgress"").html(result);
                        $('.css-drinkType').addClass(""disableMe"");
                        $('.css-drinkType').disabled = true;
                        $('.css-drinkType').addClass(""css-disableButton"");
                        fn_display(0);
                    }
                });
        }



        function fn_display(i) {
            var ln = $('#divPrepartionInProgress')[0].children.length;
            $('#' + ln).removeClass(""blink-me"");
            if (i < ln) {
                $('.css-drinkProgress').hide();
                $('#' + $('#divPrepartionInProgress').children(0)[i].id).show()
                i++;
            }
            else {
                $('#ready').show()
            }
            if (i < ln) {
                setTimeout(function () { fn_displ");
            WriteLiteral(@"ay(i) }, 2500)
            }
        }

        function fn_drinkReady() {
            $('.css-drinkType').disabled = false;
            $('.css-drinkType').removeClass(""css-disableButton"");
            $('.css-drinkProgress').css(""display"", ""none"");
            $('.css-drinkProgress-drinkready').css(""display"", ""none"");
        }


    </script>
");
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
