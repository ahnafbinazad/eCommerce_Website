#pragma checksum "C:\Users\ahnaf\Documents\Nottingham Trent University\Year 2\Internet Applications Programming\Assessment 2\Project\e-commerce website\e-commerce website\Pages\Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9be12c303be603143d297409f52f34faa8d38702"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(e_commerce_website.Pages.Pages_Cart), @"mvc.1.0.razor-page", @"/Pages/Cart.cshtml")]
namespace e_commerce_website.Pages
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
#line 1 "C:\Users\ahnaf\Documents\Nottingham Trent University\Year 2\Internet Applications Programming\Assessment 2\Project\e-commerce website\e-commerce website\Pages\_ViewImports.cshtml"
using e_commerce_website;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9be12c303be603143d297409f52f34faa8d38702", @"/Pages/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9950662e95f6f8c6c3813dec7fedf22362558665", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Cart : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "3", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "4", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<section class=""h-100 h-custom"" style=""background-color: #d2c9ff;"">
    <div class=""container py-5 h-100"">
        <div class=""row d-flex justify-content-center align-items-center h-100"">
            <div class=""col-12"">
                <div class=""card card-registration card-registration-2"" style=""border-radius: 15px;"">
                    <div class=""card-body p-0"">
                        <div class=""row g-0"">
                            <div class=""col-lg-8"">
                                <div class=""p-5"">
                                    <div class=""d-flex justify-content-between align-items-center mb-5"">
                                        <h1 class=""fw-bold mb-0 text-black"">Shopping Cart</h1>
                                        <h6 class=""mb-0 text-muted"">3 items</h6>
                                    </div>
                                    <hr class=""my-4"">

                                    <div class=""row mb-4 d-flex justify-content-between align-items-center"">
  ");
            WriteLiteral(@"                                      <div class=""col-md-2 col-lg-2 col-xl-2"">
                                            <img src=""https://mdbcdn.b-cdn.net/img/Photos/new-templates/bootstrap-shopping-carts/img5.webp""
                                                 class=""img-fluid rounded-3"" alt=""Cotton T-shirt"">
                                        </div>
                                        <div class=""col-md-3 col-lg-3 col-xl-3"">
                                            <h6 class=""text-muted"">Shirt</h6>
                                            <h6 class=""text-black mb-0"">Cotton T-shirt</h6>
                                        </div>
                                        <div class=""col-md-3 col-lg-3 col-xl-2 d-flex"">
                                            <button class=""btn btn-link px-2""
                                                    onclick=""this.parentNode.querySelector('input[type=number]').stepDown()"">
                                                <i class=""");
            WriteLiteral(@"fas fa-minus""></i>
                                            </button>

                                            <input id=""form1"" min=""0"" name=""quantity"" value=""1"" type=""number""
                                                   class=""form-control form-control-sm"" />

                                            <button class=""btn btn-link px-2""
                                                    onclick=""this.parentNode.querySelector('input[type=number]').stepUp()"">
                                                <i class=""fas fa-plus""></i>
                                            </button>
                                        </div>
                                        <div class=""col-md-3 col-lg-2 col-xl-2 offset-lg-1"">
                                            <h6 class=""mb-0"">??? 44.00</h6>
                                        </div>
                                        <div class=""col-md-1 col-lg-1 col-xl-1 text-end"">
                                            <a hre");
            WriteLiteral(@"f=""#!"" class=""text-muted""><i class=""fas fa-times""></i></a>
                                        </div>
                                    </div>

                                    <hr class=""my-4"">

                                    <div class=""row mb-4 d-flex justify-content-between align-items-center"">
                                        <div class=""col-md-2 col-lg-2 col-xl-2"">
                                            <img src=""https://mdbcdn.b-cdn.net/img/Photos/new-templates/bootstrap-shopping-carts/img6.webp""
                                                 class=""img-fluid rounded-3"" alt=""Cotton T-shirt"">
                                        </div>
                                        <div class=""col-md-3 col-lg-3 col-xl-3"">
                                            <h6 class=""text-muted"">Shirt</h6>
                                            <h6 class=""text-black mb-0"">Cotton T-shirt</h6>
                                        </div>
                              ");
            WriteLiteral(@"          <div class=""col-md-3 col-lg-3 col-xl-2 d-flex"">
                                            <button class=""btn btn-link px-2""
                                                    onclick=""this.parentNode.querySelector('input[type=number]').stepDown()"">
                                                <i class=""fas fa-minus""></i>
                                            </button>

                                            <input id=""form1"" min=""0"" name=""quantity"" value=""1"" type=""number""
                                                   class=""form-control form-control-sm"" />

                                            <button class=""btn btn-link px-2""
                                                    onclick=""this.parentNode.querySelector('input[type=number]').stepUp()"">
                                                <i class=""fas fa-plus""></i>
                                            </button>
                                        </div>
                                   ");
            WriteLiteral(@"     <div class=""col-md-3 col-lg-2 col-xl-2 offset-lg-1"">
                                            <h6 class=""mb-0"">??? 44.00</h6>
                                        </div>
                                        <div class=""col-md-1 col-lg-1 col-xl-1 text-end"">
                                            <a href=""#!"" class=""text-muted""><i class=""fas fa-times""></i></a>
                                        </div>
                                    </div>

                                    <hr class=""my-4"">

                                    <div class=""row mb-4 d-flex justify-content-between align-items-center"">
                                        <div class=""col-md-2 col-lg-2 col-xl-2"">
                                            <img src=""https://mdbcdn.b-cdn.net/img/Photos/new-templates/bootstrap-shopping-carts/img7.webp""
                                                 class=""img-fluid rounded-3"" alt=""Cotton T-shirt"">
                                        </div>
         ");
            WriteLiteral(@"                               <div class=""col-md-3 col-lg-3 col-xl-3"">
                                            <h6 class=""text-muted"">Shirt</h6>
                                            <h6 class=""text-black mb-0"">Cotton T-shirt</h6>
                                        </div>
                                        <div class=""col-md-3 col-lg-3 col-xl-2 d-flex"">
                                            <button class=""btn btn-link px-2""
                                                    onclick=""this.parentNode.querySelector('input[type=number]').stepDown()"">
                                                <i class=""fas fa-minus""></i>
                                            </button>

                                            <input id=""form1"" min=""0"" name=""quantity"" value=""1"" type=""number""
                                                   class=""form-control form-control-sm"" />

                                            <button class=""btn btn-link px-2""
                 ");
            WriteLiteral(@"                                   onclick=""this.parentNode.querySelector('input[type=number]').stepUp()"">
                                                <i class=""fas fa-plus""></i>
                                            </button>
                                        </div>
                                        <div class=""col-md-3 col-lg-2 col-xl-2 offset-lg-1"">
                                            <h6 class=""mb-0"">??? 44.00</h6>
                                        </div>
                                        <div class=""col-md-1 col-lg-1 col-xl-1 text-end"">
                                            <a href=""#!"" class=""text-muted""><i class=""fas fa-times""></i></a>
                                        </div>
                                    </div>

                                    <hr class=""my-4"">

                                    <div class=""pt-5"">
                                        <h6 class=""mb-0"">
                                            <a href=");
            WriteLiteral(@"""#!"" class=""text-body"">
                                                <i class=""fas fa-long-arrow-alt-left me-2""></i>Back to shop
                                            </a>
                                        </h6>
                                    </div>
                                </div>
                            </div>
                            <div class=""col-lg-4 bg-grey"">
                                <div class=""p-5"">
                                    <h3 class=""fw-bold mb-5 mt-2 pt-1"">Summary</h3>
                                    <hr class=""my-4"">

                                    <div class=""d-flex justify-content-between mb-4"">
                                        <h5 class=""text-uppercase"">items 3</h5>
                                        <h5>??? 132.00</h5>
                                    </div>

                                    <h5 class=""text-uppercase mb-3"">Shipping</h5>

                                    <div class=""mb-4 pb-2"">
 ");
            WriteLiteral("                                       <select class=\"select\">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9be12c303be603143d297409f52f34faa8d3870214122", async() => {
                WriteLiteral("Standard-Delivery- ???5.00");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9be12c303be603143d297409f52f34faa8d3870215344", async() => {
                WriteLiteral("Two");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9be12c303be603143d297409f52f34faa8d3870216545", async() => {
                WriteLiteral("Three");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9be12c303be603143d297409f52f34faa8d3870217748", async() => {
                WriteLiteral("Four");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                        </select>
                                    </div>

                                    <h5 class=""text-uppercase mb-3"">Give code</h5>

                                    <div class=""mb-5"">
                                        <div class=""form-outline"">
                                            <input type=""text"" id=""form3Examplea2"" class=""form-control form-control-lg"" />
                                            <label class=""form-label"" for=""form3Examplea2"">Enter your code</label>
                                        </div>
                                    </div>

                                    <hr class=""my-4"">

                                    <div class=""d-flex justify-content-between mb-5"">
                                        <h5 class=""text-uppercase"">Total price</h5>
                                        <h5>??? 137.00</h5>
                                    </div>

                                    <button typ");
            WriteLiteral(@"e=""button"" class=""btn btn-dark btn-block btn-lg""
                                            data-mdb-ripple-color=""dark"">
                                        Register
                                    </button>

                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<e_commerce_website.Pages.CartModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<e_commerce_website.Pages.CartModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<e_commerce_website.Pages.CartModel>)PageContext?.ViewData;
        public e_commerce_website.Pages.CartModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
