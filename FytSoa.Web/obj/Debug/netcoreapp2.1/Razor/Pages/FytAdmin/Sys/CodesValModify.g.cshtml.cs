#pragma checksum "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sys\CodesValModify.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97370449a918e4bbed1783ca93f9ce510483b427"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FytSoa.Web.Pages.FytAdmin.Sys.Pages_FytAdmin_Sys_CodesValModify), @"mvc.1.0.razor-page", @"/Pages/FytAdmin/Sys/CodesValModify.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/FytAdmin/Sys/CodesValModify.cshtml", typeof(FytSoa.Web.Pages.FytAdmin.Sys.Pages_FytAdmin_Sys_CodesValModify), null)]
namespace FytSoa.Web.Pages.FytAdmin.Sys
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\_ViewImports.cshtml"
using FytSoa.Web;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97370449a918e4bbed1783ca93f9ce510483b427", @"/Pages/FytAdmin/Sys/CodesValModify.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21c44af9864cf57cf01e8fd1fe389a8e352e148c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_FytAdmin_Sys_CodesValModify : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("layui-form form-cus"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sys\CodesValModify.cshtml"
  
    ViewData["Title"] = "CodesValModify";
    Layout = "~/Pages/FytAdmin/_Layout.cshtml";

#line default
#line hidden
            BeginContext(147, 1859, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a4e68dbd8774d27a1bea63677ab96f2", async() => {
                BeginContext(191, 174, true);
                WriteLiteral("\r\n    <div class=\"layui-form-item\">\r\n        <label class=\"layui-form-label\">字典名称</label>\r\n        <div class=\"layui-input-block\">\r\n            <input type=\"text\" name=\"Name\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 365, "\"", 394, 1);
#line 11 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sys\CodesValModify.cshtml"
WriteAttributeValue("", 373, Model.CodeModel.Name, 373, 21, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(395, 307, true);
                WriteLiteral(@" lay-verify=""required"" lay-verType=""tips"" autocomplete=""off"" placeholder=""请输入字典名称"" class=""layui-input"">
        </div>
    </div>
    <div class=""layui-form-item"">
        <label class=""layui-form-label"">阈值</label>
        <div class=""layui-input-block"">
            <input type=""text"" name=""CodeType""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 702, "\"", 735, 1);
#line 17 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sys\CodesValModify.cshtml"
WriteAttributeValue("", 710, Model.CodeModel.CodeType, 710, 25, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(736, 374, true);
                WriteLiteral(@" lay-verify=""required"" lay-verType=""tips"" autocomplete=""off"" placeholder=""请输入阈值"" class=""layui-input"">
        </div>
    </div>
    <div class=""layui-form-item"">
        <label class=""layui-form-label"">备注</label>
        <div class=""layui-input-block"">
            <textarea name=""Summary"" class=""layui-textarea"" style=""min-height: 60px;"" placeholder=""（非必填）可以描述字典的说明"">");
                EndContext();
                BeginContext(1111, 23, false);
#line 23 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sys\CodesValModify.cshtml"
                                                                                                              Write(Model.CodeModel.Summary);

#line default
#line hidden
                EndContext();
                BeginContext(1134, 269, true);
                WriteLiteral(@"</textarea>
        </div>
    </div>
    <div class=""layui-form-item"">
        <label class=""layui-form-label"">是否有效</label>
        <div class=""layui-input-block"">
            <input type=""checkbox"" name=""status"" lay-skin=""switch"" lay-text=""ON|OFF"" value=""true"" ");
                EndContext();
                BeginContext(1405, 39, false);
#line 29 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sys\CodesValModify.cshtml"
                                                                                              Write(Model.CodeModel.Status ? "checked" : "");

#line default
#line hidden
                EndContext();
                BeginContext(1445, 365, true);
                WriteLiteral(@">
        </div>
    </div>
    <div class=""layui-form-item"">
        <div class=""layui-input-block"">
            <button class=""layui-btn"" lay-submit="""" lay-filter=""submit"">立即提交</button>
            <button type=""reset"" class=""layui-btn layui-btn-primary btn-open-close"">取消</button>
        </div>
    </div>
    <input type=""hidden"" name=""guid"" id=""guid""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1810, "\"", 1839, 1);
#line 38 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sys\CodesValModify.cshtml"
WriteAttributeValue("", 1818, Model.CodeModel.Guid, 1818, 21, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1840, 47, true);
                WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"parentguid\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1887, "\"", 1922, 1);
#line 39 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sys\CodesValModify.cshtml"
WriteAttributeValue("", 1895, Model.CodeModel.ParentGuid, 1895, 27, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1923, 41, true);
                WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"sort\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1964, "\"", 1993, 1);
#line 40 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sys\CodesValModify.cshtml"
WriteAttributeValue("", 1972, Model.CodeModel.Sort, 1972, 21, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1994, 5, true);
                WriteLiteral(" />\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2006, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2025, 996, true);
                WriteLiteral(@"
    <script>
        layui.config({
            base: '/themes/js/modules/'
        }).use(['layer', 'jquery', 'common', 'form'], function () {
            var form = layui.form, $ = layui.$, os = layui.common;
            var index = parent.layer.getFrameIndex(window.name);
            //监听提交
            form.on('submit(submit)', function (data) {
                var urls = ""api/code/add"";
                if ($(""#guid"").val()) {
                    urls = ""api/code/edit"";
                }
                os.ajax(urls, data.field, function(res) {
                    if (res.statusCode === 200) {
                        parent.layer.close(index);
                    } else {
                        os.error(res.message);
                    }   
                });
                return false;
            });
            $("".btn-open-close"").on('click', function () {
                parent.layer.close(index);
            });

        });
    </script>
");
                EndContext();
            }
            );
            BeginContext(3024, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FytAdmin.Sys.CodesValModifyModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytAdmin.Sys.CodesValModifyModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytAdmin.Sys.CodesValModifyModel>)PageContext?.ViewData;
        public FytAdmin.Sys.CodesValModifyModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
