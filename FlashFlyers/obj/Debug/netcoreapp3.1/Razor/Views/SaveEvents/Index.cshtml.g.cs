#pragma checksum "C:\Users\mjdie\Desktop\School\SDP\capstone-project-master\capstone-project-master\FlashFlyers\Views\SaveEvents\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47792f99f5bcee69ecdeb3f0480e552b1daadcbc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SaveEvents_Index), @"mvc.1.0.view", @"/Views/SaveEvents/Index.cshtml")]
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
#line 1 "C:\Users\mjdie\Desktop\School\SDP\capstone-project-master\capstone-project-master\FlashFlyers\Views\_ViewImports.cshtml"
using FlashFlyers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mjdie\Desktop\School\SDP\capstone-project-master\capstone-project-master\FlashFlyers\Views\_ViewImports.cshtml"
using FlashFlyers.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47792f99f5bcee69ecdeb3f0480e552b1daadcbc", @"/Views/SaveEvents/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08e2705ecaae742090d7ef4e4058a0d70e7f7ed6", @"/Views/_ViewImports.cshtml")]
    public class Views_SaveEvents_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EventModel>>
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
#line 2 "C:\Users\mjdie\Desktop\School\SDP\capstone-project-master\capstone-project-master\FlashFlyers\Views\SaveEvents\Index.cshtml"
   
    ViewData["Title"] = "Saved Events";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47792f99f5bcee69ecdeb3f0480e552b1daadcbc3627", async() => {
                WriteLiteral(@"
    <link href=""https://fonts.googleapis.com/css2?family=Roboto+Slab&display=swap"" rel=""stylesheet"">
    <style>
        h1 {
            font-size: 35px;
            color: white;
        }

        .h1 {
            font-size: 35px;
            color: white;
            position: relative;
            right: 0;
        }

        h2 {
            font-size: 100px;
            color: rgb(238,174,36);
        }

        p {
            font-size: 20px;
            padding-top: 10px;
            padding-bottom: 10px;
            color: white;
        }

        body {
            font-family: 'Roboto Slab', serif;
            background: radial-gradient(#001f55, #013375);
        }

        .line {
            border-bottom: 4px solid rgb(238,174,36);
        }

        .button {
            font-size: 35px;
            color: white;
        }
    </style>
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47792f99f5bcee69ecdeb3f0480e552b1daadcbc5508", async() => {
                WriteLiteral("\r\n    <h2 style=\"position: relative; right:0;\">\r\n        Saved Events\r\n    </h2>\r\n\r\n\r\n");
#nullable restore
#line 55 "C:\Users\mjdie\Desktop\School\SDP\capstone-project-master\capstone-project-master\FlashFlyers\Views\SaveEvents\Index.cshtml"
       var Last = Model.Last();
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\Users\mjdie\Desktop\School\SDP\capstone-project-master\capstone-project-master\FlashFlyers\Views\SaveEvents\Index.cshtml"
         foreach (var evnt in Model)
        {
            DateTime eventDate = DateTime.Parse(@evnt.Date);
            DateTime currentDate = DateTime.Now;

            

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\mjdie\Desktop\School\SDP\capstone-project-master\capstone-project-master\FlashFlyers\Views\SaveEvents\Index.cshtml"
             if (@evnt.Saved == true) // no longer need this check just show everything in saved table for now (than when setting up for account filter by account id)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <!-- Display the event title, description, time, date, building, and room-->\r\n                <a");
                BeginWriteAttribute("href", " href=\"", 1593, "\"", 1632, 2);
                WriteAttributeValue("", 1600, "https://localhost:44395/", 1600, 24, true);
#nullable restore
#line 64 "C:\Users\mjdie\Desktop\School\SDP\capstone-project-master\capstone-project-master\FlashFlyers\Views\SaveEvents\Index.cshtml"
WriteAttributeValue("", 1624, evnt.Id, 1624, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"h1\"> ");
#nullable restore
#line 64 "C:\Users\mjdie\Desktop\School\SDP\capstone-project-master\capstone-project-master\FlashFlyers\Views\SaveEvents\Index.cshtml"
                                                                  Write(evnt.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n");
#nullable restore
#line 65 "C:\Users\mjdie\Desktop\School\SDP\capstone-project-master\capstone-project-master\FlashFlyers\Views\SaveEvents\Index.cshtml"
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <p class=\"line\" style=\"position: relative; right: 0;\">\r\n                        ");
#nullable restore
#line 67 "C:\Users\mjdie\Desktop\School\SDP\capstone-project-master\capstone-project-master\FlashFlyers\Views\SaveEvents\Index.cshtml"
                   Write(evnt.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        <br />\r\n                        ");
#nullable restore
#line 69 "C:\Users\mjdie\Desktop\School\SDP\capstone-project-master\capstone-project-master\FlashFlyers\Views\SaveEvents\Index.cshtml"
                   Write(evnt.Date);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 70 "C:\Users\mjdie\Desktop\School\SDP\capstone-project-master\capstone-project-master\FlashFlyers\Views\SaveEvents\Index.cshtml"
                   Write(evnt.Time);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        <br />\r\n                        ");
#nullable restore
#line 72 "C:\Users\mjdie\Desktop\School\SDP\capstone-project-master\capstone-project-master\FlashFlyers\Views\SaveEvents\Index.cshtml"
                   Write(evnt.Building);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 73 "C:\Users\mjdie\Desktop\School\SDP\capstone-project-master\capstone-project-master\FlashFlyers\Views\SaveEvents\Index.cshtml"
                   Write(evnt.Room);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 74 "C:\Users\mjdie\Desktop\School\SDP\capstone-project-master\capstone-project-master\FlashFlyers\Views\SaveEvents\Index.cshtml"
                   Write(evnt.Campus);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </p>\r\n");
#nullable restore
#line 76 "C:\Users\mjdie\Desktop\School\SDP\capstone-project-master\capstone-project-master\FlashFlyers\Views\SaveEvents\Index.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "C:\Users\mjdie\Desktop\School\SDP\capstone-project-master\capstone-project-master\FlashFlyers\Views\SaveEvents\Index.cshtml"
             
        }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EventModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
