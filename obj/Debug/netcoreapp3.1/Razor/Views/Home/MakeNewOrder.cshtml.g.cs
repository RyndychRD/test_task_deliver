#pragma checksum "D:\Users\Professional\source\repos\test_task_deliver_RyndychRD\test_task_deliver_RyndychRD\Views\Home\MakeNewOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28cbae4866b79c3773fb5b0b785151b8164cc3ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_MakeNewOrder), @"mvc.1.0.view", @"/Views/Home/MakeNewOrder.cshtml")]
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
#line 1 "D:\Users\Professional\source\repos\test_task_deliver_RyndychRD\test_task_deliver_RyndychRD\Views\_ViewImports.cshtml"
using test_task_deliver_RyndychRD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Users\Professional\source\repos\test_task_deliver_RyndychRD\test_task_deliver_RyndychRD\Views\_ViewImports.cshtml"
using test_task_deliver_RyndychRD.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28cbae4866b79c3773fb5b0b785151b8164cc3ac", @"/Views/Home/MakeNewOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c74b33837a6fff53263158a5bafce0e763f78f2b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_MakeNewOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form_order_save"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Users\Professional\source\repos\test_task_deliver_RyndychRD\test_task_deliver_RyndychRD\Views\Home\MakeNewOrder.cshtml"
  
	ViewData["Title"] = "???????????????? ???????????? ????????????";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n\t<h1 class=\"display-4\">");
#nullable restore
#line 6 "D:\Users\Professional\source\repos\test_task_deliver_RyndychRD\test_task_deliver_RyndychRD\Views\Home\MakeNewOrder.cshtml"
                     Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28cbae4866b79c3773fb5b0b785151b8164cc3ac4982", async() => {
                WriteLiteral("\r\n\t\t<div class=\"d-flex flex-wrap\">\r\n\t\t\t<div class=\"w-auto mr-3\">\r\n\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t<label for=\"inp_sender_city\">?????????? ??????????????????????</label>\r\n\t\t\t\t\t<input type=\"text\" name=\"inp_sender_city\" id=\"inp_sender_city\"");
                BeginWriteAttribute("value", " value=\"", 408, "\"", 416, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control \">\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t\t<div class=\"w-auto mr-3\">\r\n\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t<label for=\"inp_sender_addres\">?????????? ??????????????????????</label>\r\n\t\t\t\t\t<input type=\"text\" name=\"inp_sender_addres\" id=\"inp_sender_addres\"");
                BeginWriteAttribute("value", " value=\"", 659, "\"", 667, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control \">\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t\t<div class=\"w-auto mr-3\">\r\n\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t<label for=\"inp_receiver_city\">?????????? ????????????????????</label>\r\n\t\t\t\t\t<input type=\"text\" name=\"inp_receiver_city\" id=\"inp_receiver_city\"");
                BeginWriteAttribute("value", " value=\"", 909, "\"", 917, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control \">\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t\t<div class=\"w-auto mr-3\">\r\n\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t<label for=\"inp_receiver_addres\">?????????? ????????????????????</label>\r\n\t\t\t\t\t<input type=\"text\" name=\"inp_receiver_addres\" id=\"inp_receiver_addres\"");
                BeginWriteAttribute("value", " value=\"", 1165, "\"", 1173, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""form-control "">
				</div>
			</div>
			<div class=""w-auto mr-3"">
				<div class=""form-group"">
					<label for=""inp_package_weight"">?????? ??????????</label>
					<input type=""number"" name=""inp_package_weight"" id=""inp_package_weight"" min=""0"" value=""0"" class=""form-control "">
				</div>
			</div>
			<div class=""w-auto mr-3"">
				<div class=""form-group"">
					<label for=""inp_package_pickupDate"">???????? ???????????? ??????????</label>
					<input type=""date"" name=""inp_package_pickupDate"" id=""inp_package_pickupDate""");
                BeginWriteAttribute("value", " value=\"", 1688, "\"", 1696, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control \">\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
	<div class=""d-flex"">
		<button type=""button"" id=""btn_save"" class=""btn btn-success font-weight-normal m-1 justify-content-center "">
			??????????????????
		</button>
		<button type=""button"" id=""btn_clear"" class=""btn btn-secondary font-weight-normal m-1 justify-content-center"">
			???????????????? ????????
		</button>
	</div>
</div>
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
