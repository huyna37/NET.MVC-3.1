#pragma checksum "D:\Food_Market\Food_Market\Views\Home\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "596e6d4e8a3725c15af98d0f4977fc0ad7c1b100"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Detail), @"mvc.1.0.view", @"/Views/Home/Detail.cshtml")]
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
#line 1 "D:\Food_Market\Food_Market\Views\_ViewImports.cshtml"
using Food_Market;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Food_Market\Food_Market\Views\_ViewImports.cshtml"
using Food_Market.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"596e6d4e8a3725c15af98d0f4977fc0ad7c1b100", @"/Views/Home/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25c1b07337f3e3c7426d97d19cc5bb15dd0377c0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-black py-3 px-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""hero-wrap hero-bread"" style=""background-image: url('/client/images/bg_1.jpg');"">
      <div class=""container"">
        <div class=""row no-gutters slider-text align-items-center justify-content-center"">
          <div class=""col-md-9 ftco-animate text-center"">
          	<p class=""breadcrumbs""><span class=""mr-2""><a href=""index.html"">Home</a></span> <span class=""mr-2""><a href=""index.html"">Product</a></span> <span>Product Single</span></p>
            <h1 class=""mb-0 bread"">Product Detail</h1>
          </div>
        </div>
      </div>
    </div>

    <section class=""ftco-section"">
    	<div class=""container"">
    		<div class=""row"">
    			<div class=""col-lg-6 mb-5 ftco-animate"">
    				<a");
            BeginWriteAttribute("href", " href=\"", 856, "\"", 888, 2);
            WriteAttributeValue("", 863, "/store-image/", 863, 13, true);
#nullable restore
#line 21 "D:\Food_Market\Food_Market\Views\Home\Detail.cshtml"
WriteAttributeValue("", 876, Model.Image, 876, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"image-popup\"><img style=\'height:500px\'");
            BeginWriteAttribute("src", " src=\"", 935, "\"", 966, 2);
            WriteAttributeValue("", 941, "/store-image/", 941, 13, true);
#nullable restore
#line 21 "D:\Food_Market\Food_Market\Views\Home\Detail.cshtml"
WriteAttributeValue("", 954, Model.Image, 954, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\" alt=\"Colorlib Template\"></a>\r\n    \t\t\t</div>\r\n    \t\t\t<div class=\"col-lg-6 product-details pl-md-5 ftco-animate\">\r\n    \t\t\t\t<h3>");
#nullable restore
#line 24 "D:\Food_Market\Food_Market\Views\Home\Detail.cshtml"
                   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
    				<div class=""rating d-flex"">
							<p class=""text-left mr-4"">
								<a href=""#"" class=""mr-2"">5.0</a>
								<a href=""#""><span class=""ion-ios-star-outline""></span></a>
								<a href=""#""><span class=""ion-ios-star-outline""></span></a>
								<a href=""#""><span class=""ion-ios-star-outline""></span></a>
								<a href=""#""><span class=""ion-ios-star-outline""></span></a>
								<a href=""#""><span class=""ion-ios-star-outline""></span></a>
							</p>
							<p class=""text-left mr-4"">
								<a href=""#"" class=""mr-2"" style=""color: #000;"">100 <span style=""color: #bbb;"">Rating</span></a>
							</p>
							<p class=""text-left"">
								<a href=""#"" class=""mr-2"" style=""color: #000;"">500 <span style=""color: #bbb;"">Sold</span></a>
							</p>
						</div>
    				<p class=""price""><span>$");
#nullable restore
#line 41 "D:\Food_Market\Food_Market\Views\Home\Detail.cshtml"
                                       Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n    \t\t\t\t<p>");
#nullable restore
#line 42 "D:\Food_Market\Food_Market\Views\Home\Detail.cshtml"
                  Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
						<div class=""row mt-4"">
							<div class=""col-md-6"">
								<div class=""form-group d-flex"">
		            </div>
							</div>
							<div class=""w-100""></div>
							<div class=""input-group col-md-6 d-flex mb-3"">
	             	<span class=""input-group-btn mr-2"">
	                	<button type=""button"" class=""quantity-left-minus btn""  data-type=""minus"" data-field="""">
	                   <i class=""ion-ios-remove""></i>
	                	</button>
	            		</span>
	             	<input type=""text"" id=""quantity"" name=""quantity"" class=""form-control input-number"" value=""1"" min=""1"" max=""100"">
	             	<span class=""input-group-btn ml-2"">
	                	<button type=""button"" class=""quantity-right-plus btn"" data-type=""plus"" data-field="""">
	                     <i class=""ion-ios-add""></i>
	                 </button>
	             	</span>
	          	</div>
	          	<div class=""w-100""></div>
	          	<div class=""col-md-12"">
	          		<p style=""color: #000;"">600 ");
            WriteLiteral("kg available</p>\r\n\t          \t</div>\r\n          \t</div>\r\n          \t<p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "596e6d4e8a3725c15af98d0f4977fc0ad7c1b1008158", async() => {
                WriteLiteral("Add to Cart");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 67 "D:\Food_Market\Food_Market\Views\Home\Detail.cshtml"
                                             WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</p>
    			</div>
    		</div>
    	</div>
    </section>

    <section class=""ftco-section"">
    	<div class=""container"">
				<div class=""row justify-content-center mb-3 pb-3"">
          <div class=""col-md-12 heading-section text-center ftco-animate"">
          	<span class=""subheading"">Products</span>
            <h2 class=""mb-4"">Related Products</h2>
            <p>Far far away, behind the word mountains, far from the countries Vokalia and Consonantia</p>
          </div>
        </div>   		
    	</div>
    	<div class=""container"">
    		<div class=""row"">
");
#nullable restore
#line 85 "D:\Food_Market\Food_Market\Views\Home\Detail.cshtml"
             foreach(var data in ViewBag.RelativeProduct)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                  <div class=\"col-md-6 col-lg-3 ftco-animate\">\r\n    \t\t\t\t<div class=\"product\">\r\n    \t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 3950, "\"", 3978, 2);
            WriteAttributeValue("", 3957, "/home/detail/", 3957, 13, true);
#nullable restore
#line 89 "D:\Food_Market\Food_Market\Views\Home\Detail.cshtml"
WriteAttributeValue("", 3970, data.Id, 3970, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-prod\"><img class=\"img-fluid w-100\" style=\'height:250px\'");
            BeginWriteAttribute("src", " src=\"", 4046, "\"", 4076, 2);
            WriteAttributeValue("", 4052, "/store-image/", 4052, 13, true);
#nullable restore
#line 89 "D:\Food_Market\Food_Market\Views\Home\Detail.cshtml"
WriteAttributeValue("", 4065, data.Image, 4065, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 4077, "\"", 4093, 1);
#nullable restore
#line 89 "D:\Food_Market\Food_Market\Views\Home\Detail.cshtml"
WriteAttributeValue("", 4083, data.Name, 4083, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 90 "D:\Food_Market\Food_Market\Views\Home\Detail.cshtml"
                              
                                var pricePer =(int.Parse(data.Price) == int.Parse(data.SalePrice))?0: ((int.Parse(data.Price) / int.Parse(data.SalePrice)) * 10);
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("    \t\t\t\t\t\t<span class=\"status\">");
#nullable restore
#line 93 "D:\Food_Market\Food_Market\Views\Home\Detail.cshtml"
                                            Write(pricePer);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</span>\r\n    \t\t\t\t\t\t<div class=\"overlay\"></div>\r\n    \t\t\t\t\t</a>\r\n    \t\t\t\t\t<div class=\"text py-3 pb-4 px-3 text-center\">\r\n    \t\t\t\t\t\t<h3><a href=\"#\">");
#nullable restore
#line 97 "D:\Food_Market\Food_Market\Views\Home\Detail.cshtml"
                                       Write(data.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n    \t\t\t\t\t\t<div class=\"d-flex\">\r\n    \t\t\t\t\t\t\t<div class=\"pricing\">\r\n\t\t    \t\t\t\t\t\t<p class=\"price\"><span class=\"mr-2 price-dc\">$");
#nullable restore
#line 100 "D:\Food_Market\Food_Market\Views\Home\Detail.cshtml"
                                                                             Write(data.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><span class=\"price-sale\">$");
#nullable restore
#line 100 "D:\Food_Market\Food_Market\Views\Home\Detail.cshtml"
                                                                                                                         Write(data.SalePrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></p>
		    					</div>
	    					</div>
	    					<div class=""bottom-area d-flex px-3"">
	    						<div class=""m-auto d-flex"">
	    							<a href=""#"" class=""add-to-cart d-flex justify-content-center align-items-center text-center"">
	    								<span><i class=""ion-ios-menu""></i></span>
	    							</a>
	    							<a href=""#"" class=""buy-now d-flex justify-content-center align-items-center mx-1"">
	    								<span><i class=""ion-ios-cart""></i></span>
	    							</a>
	    							<a href=""#"" class=""heart d-flex justify-content-center align-items-center "">
	    								<span><i class=""ion-ios-heart""></i></span>
	    							</a>
    							</div>
    						</div>
    					</div>
    				</div>
    			</div>  
");
#nullable restore
#line 119 "D:\Food_Market\Food_Market\Views\Home\Detail.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("    \t\t</div>\r\n    \t</div>\r\n    </section>");
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