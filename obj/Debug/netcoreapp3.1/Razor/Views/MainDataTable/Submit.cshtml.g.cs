#pragma checksum "/Users/macbook/Desktop/GozareshSaz/My_Application/My_Application/Views/MainDataTable/Submit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c679a865e8ffed9eafef40f6dcb8f57c8834063c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MainDataTable_Submit), @"mvc.1.0.view", @"/Views/MainDataTable/Submit.cshtml")]
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
#line 1 "/Users/macbook/Desktop/GozareshSaz/My_Application/My_Application/Views/_ViewImports.cshtml"
using My_Application;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/macbook/Desktop/GozareshSaz/My_Application/My_Application/Views/_ViewImports.cshtml"
using My_Application.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c679a865e8ffed9eafef40f6dcb8f57c8834063c", @"/Views/MainDataTable/Submit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d29f91ce78599e6eaa0e298d809c4747f98d5b5", @"/Views/_ViewImports.cshtml")]
    public class Views_MainDataTable_Submit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<My_Application.Models.DataGet>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/macbook/Desktop/GozareshSaz/My_Application/My_Application/Views/MainDataTable/Submit.cshtml"
  
    Layout = "/Views/Shared/_LayoutMainDataTable.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c679a865e8ffed9eafef40f6dcb8f57c8834063c3850", async() => {
                WriteLiteral(@"
            <div class=""input-container"">
                <div class=""input"">
                    <div>
                        <label for=""Code"" class=""label"">کد</label>
                        <input name=""Code"" type=""text"" />
                    </div>

                    <div>
                        <label for=""name"" class=""label"">نام</label>
                        <input name=""name"" type=""text""/>
                    </div>
                    
                    <div>
                        <label for=""name"" class=""label"">تاریخ</label>
                        <input name=""name"" type=""text"" />
                    </div>
                    
                    <div>
                        <label for=""YearSeason"" class=""label"">سال / فصل</label>
                        <input name=""YearSeason"" id=""SetDate"" type=""text"" onclick=""Click()"" />
                    </div>

                    <div>
                        <label for=""ContractNumber"" class=""label"">شماره قرار داد</label>
                     ");
                WriteLiteral(@"   <input name=""ContractNumber"" type=""text"" />
                    </div>

                    <div>
                        <label for=""ContractCount"" class=""label"">تعداد قرار داد</label>
                        <input name=""ContractCount"" type=""text"" />
                    </div>

                    <div>
                        <label for=""NoContractCount"" class=""label"">تعداد بدون قرار داد</label>
                        <input name=""NoContractCount"" type=""text"" />
                    </div>

                    <div>
                        <label for=""NoContractCount"" class=""label"">تعداد بدون قرار داد</label>
                        <input name=""NoContractCount"" type=""text"" />
                    </div>

                    <div>
                        <label for=""InvoiceNumber"" class=""label"">شماره فاکتور</label>
                        <input name=""InvoiceNumber"" type=""text"" />
                    </div>

                    <div>
                        <label for=""Count"" class=""label"">تعداد</label>
");
                WriteLiteral(@"                        <input name=""Count"" type=""text"" />
                    </div>

                    <div>
                        <label for=""PerSale"" class=""label"">فی فروش</label>
                        <input name=""PerSale"" type=""text"" onkeyup=""separateNum(this.value,this);"" />
                    </div>

                    <div>
                        <label for=""NetSales"" class=""label"">خالص فروش</label>
                        <input name=""NetSales"" type=""text"" onkeyup=""separateNum(this.value,this);"" />
                    </div>

                    <div>
                        <label for=""Discount"" class=""label"">تخفیف</label>
                        <input name=""Discount"" type=""text"" onkeyup=""separateNum(this.value,this);"" />
                    </div>

                    <div>
                        <label for=""SalesTax"" class=""label"">فروش با ارزش افزوده</label>
                        <input name=""SalesTax"" type=""text"" onkeyup=""separateNum(this.value,this);"" />
                    </div>
");
                WriteLiteral(@"
                    <div>
                        <label for=""ReturnedCount"" class=""label"">تعداد برگشت</label>
                        <input name=""ReturnedCount"" type=""text"" />
                    </div>

                    <div>
                        <label for=""RefundAmount"" class=""label"">مبلغ برگشت</label>
                        <input name=""RefundAmount"" type=""text"" onkeyup=""separateNum(this.value,this);"" />
                    </div>

                    <div>
                        <label for=""ReceivedMoney"" class=""label"">مبلغ دریافت</label>
                        <input name=""ReceivedMoney"" type=""text"" onkeyup=""separateNum(this.value,this);"" />
                    </div>

                    <div>
                        <label");
                BeginWriteAttribute("for", " for=\"", 3972, "\"", 3978, 0);
                EndWriteAttribute();
                WriteLiteral("></label>\n                        <input type=\"submit\" value=\"SUBMIT\" />\n                    </div>\n                    \n                </div>\n            </div>\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("       ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<My_Application.Models.DataGet>> Html { get; private set; }
    }
}
#pragma warning restore 1591
