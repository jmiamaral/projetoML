#pragma checksum "/home/jmiamaral/projeto/app/Views/FirstPage/InvocarWS.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc1e6a158ae0a346053b728d7d2d3f7110b6bf43"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FirstPage_InvocarWS), @"mvc.1.0.view", @"/Views/FirstPage/InvocarWS.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/FirstPage/InvocarWS.cshtml", typeof(AspNetCore.Views_FirstPage_InvocarWS))]
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
#line 1 "/home/jmiamaral/projeto/app/Views/_ViewImports.cshtml"
using app;

#line default
#line hidden
#line 2 "/home/jmiamaral/projeto/app/Views/_ViewImports.cshtml"
using app.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc1e6a158ae0a346053b728d7d2d3f7110b6bf43", @"/Views/FirstPage/InvocarWS.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35d7228549089a448a9c85c9fd74602bc83b83a3", @"/Views/_ViewImports.cshtml")]
    public class Views_FirstPage_InvocarWS : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<app.Models.Provider>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Web Service URL here"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "InvocarWS", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "FirstPage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/home/jmiamaral/projeto/app/Views/FirstPage/InvocarWS.cshtml"
  
    ViewBag.Title = "Evoke existing Web Service";

#line default
#line hidden
            BeginContext(82, 48, true);
            WriteLiteral("    <!-- var entidades = ViewBag.Entidades; -->\n");
            EndContext();
#line 6 "/home/jmiamaral/projeto/app/Views/FirstPage/InvocarWS.cshtml"
    //Layout = "~/Views/Shared/_Layout.cshtml";
    Layout = "";

#line default
#line hidden
            BeginContext(195, 57, true);
            WriteLiteral("    <!-- var valueEntidade = \" \";\n    var test = \"\"; -->\n");
            EndContext();
            BeginContext(254, 25, true);
            WriteLiteral("\n<!DOCTYPE html>\n\n<html>\n");
            EndContext();
            BeginContext(279, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc1e6a158ae0a346053b728d7d2d3f7110b6bf436215", async() => {
                BeginContext(285, 5, true);
                WriteLiteral("\n<h2>");
                EndContext();
                BeginContext(291, 13, false);
#line 16 "/home/jmiamaral/projeto/app/Views/FirstPage/InvocarWS.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
                EndContext();
                BeginContext(304, 6, true);
                WriteLiteral("</h2>\n");
                EndContext();
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
            EndContext();
            BeginContext(317, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(318, 1880, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc1e6a158ae0a346053b728d7d2d3f7110b6bf437690", async() => {
                BeginContext(324, 25, true);
                WriteLiteral("\n  <div class=\"row\">\n    ");
                EndContext();
                BeginContext(349, 1826, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc1e6a158ae0a346053b728d7d2d3f7110b6bf438094", async() => {
                    BeginContext(419, 96, true);
                    WriteLiteral("\n      <div class=\"form-group row\">\n\n        <label class=\"control-label\">URL: </label>\n        ");
                    EndContext();
                    BeginContext(515, 57, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "dc1e6a158ae0a346053b728d7d2d3f7110b6bf438591", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 24 "/home/jmiamaral/projeto/app/Views/FirstPage/InvocarWS.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.url);

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(572, 64, true);
                    WriteLiteral("\n\n        <label class=\"control-label\">Entity: </label>\n        ");
                    EndContext();
                    BeginContext(636, 161, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc1e6a158ae0a346053b728d7d2d3f7110b6bf4310376", async() => {
                        BeginContext(721, 11, true);
                        WriteLiteral("\n          ");
                        EndContext();
                        BeginContext(732, 47, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc1e6a158ae0a346053b728d7d2d3f7110b6bf4310804", async() => {
                            BeginContext(753, 17, true);
                            WriteLiteral("--Select Entity--");
                            EndContext();
                        }
                        );
                        __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                        __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                        __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                        BeginWriteTagHelperAttribute();
                        __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                        __tagHelperExecutionContext.AddHtmlAttribute("null", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(779, 9, true);
                        WriteLiteral("\n        ");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#line 27 "/home/jmiamaral/projeto/app/Views/FirstPage/InvocarWS.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.selected_table_name);

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 27 "/home/jmiamaral/projeto/app/Views/FirstPage/InvocarWS.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = new SelectList(Model.table_names);

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(797, 169, true);
                    WriteLiteral(" \n      </div>\n\n      <div class=\"form-group\">\n        <input type=\"submit\" value=\"Mapping\" name=\"map\" id=\"map\">\n      </div>\n      \n\n      <div class=\"form-group row\">\n");
                    EndContext();
#line 38 "/home/jmiamaral/projeto/app/Views/FirstPage/InvocarWS.cshtml"
       if ((@Model.selected_table_name != null) && (@Model.url != null) && (@Model.validResponse == true))
      {
        var idColumn = 0;

#line default
#line hidden
                    BeginContext(1107, 26, true);
                    WriteLiteral("        <!-- <h1>Resposta ");
                    EndContext();
                    BeginContext(1134, 22, false);
#line 41 "/home/jmiamaral/projeto/app/Views/FirstPage/InvocarWS.cshtml"
                     Write(Model.validateResponse);

#line default
#line hidden
                    EndContext();
                    BeginContext(1156, 10, true);
                    WriteLiteral("</h1> --> ");
                    EndContext();
#line 41 "/home/jmiamaral/projeto/app/Views/FirstPage/InvocarWS.cshtml"
                                                           //validacao json/xml

#line default
#line hidden
                    BeginContext(1187, 16, true);
                    WriteLiteral("        <!-- <p>");
                    EndContext();
                    BeginContext(1204, 12, false);
#line 42 "/home/jmiamaral/projeto/app/Views/FirstPage/InvocarWS.cshtml"
           Write(Model.dataWs);

#line default
#line hidden
                    EndContext();
                    BeginContext(1216, 20, true);
                    WriteLiteral("</p> -->\n        <p>");
                    EndContext();
                    BeginContext(1237, 13, false);
#line 43 "/home/jmiamaral/projeto/app/Views/FirstPage/InvocarWS.cshtml"
      Write(ViewBag.teste);

#line default
#line hidden
                    EndContext();
                    BeginContext(1250, 5, true);
                    WriteLiteral("</p>\n");
                    EndContext();
#line 44 "/home/jmiamaral/projeto/app/Views/FirstPage/InvocarWS.cshtml"
         if(@Model.isJson) //entra se a resposta for formato json
        {
          

#line default
#line hidden
#line 46 "/home/jmiamaral/projeto/app/Views/FirstPage/InvocarWS.cshtml"
           foreach (var item in @Model.fieldsJson)
          {

#line default
#line hidden
                    BeginContext(1394, 41, true);
                    WriteLiteral("            <label class=\"control-label\">");
                    EndContext();
                    BeginContext(1436, 4, false);
#line 48 "/home/jmiamaral/projeto/app/Views/FirstPage/InvocarWS.cshtml"
                                    Write(item);

#line default
#line hidden
                    EndContext();
                    BeginContext(1440, 36, true);
                    WriteLiteral(" ------------> </label>\n            ");
                    EndContext();
                    BeginContext(1476, 99, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc1e6a158ae0a346053b728d7d2d3f7110b6bf4317450", async() => {
                        BeginContext(1553, 13, true);
                        WriteLiteral("\n            ");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#line 49 "/home/jmiamaral/projeto/app/Views/FirstPage/InvocarWS.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.columnsSelected);

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 49 "/home/jmiamaral/projeto/app/Views/FirstPage/InvocarWS.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = new SelectList(Model.columns);

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1575, 19, true);
                    WriteLiteral("\n            <br/>\n");
                    EndContext();
#line 52 "/home/jmiamaral/projeto/app/Views/FirstPage/InvocarWS.cshtml"
          }

#line default
#line hidden
#line 52 "/home/jmiamaral/projeto/app/Views/FirstPage/InvocarWS.cshtml"
           
        }
        else if(@Model.isXml)
        {

#line default
#line hidden
                    BeginContext(1656, 25, true);
                    WriteLiteral("          <p>to aqui</p>\n");
                    EndContext();
#line 57 "/home/jmiamaral/projeto/app/Views/FirstPage/InvocarWS.cshtml"
        }

#line default
#line hidden
#line 57 "/home/jmiamaral/projeto/app/Views/FirstPage/InvocarWS.cshtml"
         
      }
      else
      {

#line default
#line hidden
                    BeginContext(1718, 12, true);
                    WriteLiteral("        <h2>");
                    EndContext();
                    BeginContext(1731, 22, false);
#line 61 "/home/jmiamaral/projeto/app/Views/FirstPage/InvocarWS.cshtml"
       Write(Model.validateResponse);

#line default
#line hidden
                    EndContext();
                    BeginContext(1753, 6, true);
                    WriteLiteral("</h2>\n");
                    EndContext();
#line 62 "/home/jmiamaral/projeto/app/Views/FirstPage/InvocarWS.cshtml"
      }

#line default
#line hidden
                    BeginContext(1767, 16, true);
                    WriteLiteral("    </div>\n    \n");
                    EndContext();
#line 65 "/home/jmiamaral/projeto/app/Views/FirstPage/InvocarWS.cshtml"
     if(@Model.mapButton)
    {

#line default
#line hidden
                    BeginContext(1815, 90, true);
                    WriteLiteral("    <div>\n      <input type=\"submit\" value=\"Result\" name=\"Submit\" id=\"result\">\n    </div>\n");
                    EndContext();
#line 70 "/home/jmiamaral/projeto/app/Views/FirstPage/InvocarWS.cshtml"
    }

#line default
#line hidden
                    BeginContext(1911, 4, true);
                    WriteLiteral("   \n");
                    EndContext();
#line 72 "/home/jmiamaral/projeto/app/Views/FirstPage/InvocarWS.cshtml"
     if(@Model.submitButton)
    {
      

#line default
#line hidden
#line 74 "/home/jmiamaral/projeto/app/Views/FirstPage/InvocarWS.cshtml"
       if(@Model.counterRow > 1){

#line default
#line hidden
                    BeginContext(1984, 11, true);
                    WriteLiteral("        <p>");
                    EndContext();
                    BeginContext(1996, 16, false);
#line 75 "/home/jmiamaral/projeto/app/Views/FirstPage/InvocarWS.cshtml"
      Write(Model.counterRow);

#line default
#line hidden
                    EndContext();
                    BeginContext(2012, 30, true);
                    WriteLiteral(" rows affected</p>\n        <p>");
                    EndContext();
                    BeginContext(2043, 13, false);
#line 76 "/home/jmiamaral/projeto/app/Views/FirstPage/InvocarWS.cshtml"
      Write(ViewBag.teste);

#line default
#line hidden
                    EndContext();
                    BeginContext(2056, 5, true);
                    WriteLiteral("</p>\n");
                    EndContext();
#line 77 "/home/jmiamaral/projeto/app/Views/FirstPage/InvocarWS.cshtml"
        
      }
      else
      {

#line default
#line hidden
                    BeginContext(2097, 11, true);
                    WriteLiteral("        <p>");
                    EndContext();
                    BeginContext(2109, 16, false);
#line 81 "/home/jmiamaral/projeto/app/Views/FirstPage/InvocarWS.cshtml"
      Write(Model.counterRow);

#line default
#line hidden
                    EndContext();
                    BeginContext(2125, 18, true);
                    WriteLiteral(" row affected</p>\n");
                    EndContext();
#line 82 "/home/jmiamaral/projeto/app/Views/FirstPage/InvocarWS.cshtml"
      }

#line default
#line hidden
#line 82 "/home/jmiamaral/projeto/app/Views/FirstPage/InvocarWS.cshtml"
       
     
    }

#line default
#line hidden
                    BeginContext(2163, 5, true);
                    WriteLiteral("\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2175, 16, true);
                WriteLiteral("\n    \n  </div>\n\n");
                EndContext();
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
            EndContext();
            BeginContext(2198, 46, true);
            WriteLiteral("\n\n<!-- <span id=\"msg\" style=\"color:red;\"/>   \n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2262, 313, true);
                WriteLiteral(@"
  <script type=""text/javascript"">  
    $('#mapa').click(function () {  
        var form = $(""#testForm"") 
        var url_ = form.attr(""action""); 
        var formData = form.serialize();  
        $.post(url, formData, function (data) {  
            $(""#msg"").html(data);  
        });  
    })  
</script> 
");
                EndContext();
            }
            );
            BeginContext(2576, 140, true);
            WriteLiteral(" -->\n \n  <!-- <script src=\"~wwwroot/lib/jquery/dist/jquery.min.js\"></script>\n  <script type=\"text/javascript\"> -->\n  \n\n  <!-- </script> -->\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<app.Models.Provider> Html { get; private set; }
    }
}
#pragma warning restore 1591
