#pragma checksum "C:\Users\LENOVO\source\repos\ContactCenter\ContactCenter\Views\Orders\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8fba5fbeb483efbd2f99b6556145476051f4666b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Details), @"mvc.1.0.view", @"/Views/Orders/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Orders/Details.cshtml", typeof(AspNetCore.Views_Orders_Details))]
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
#line 1 "C:\Users\LENOVO\source\repos\ContactCenter\ContactCenter\Views\_ViewImports.cshtml"
using ContactCenter;

#line default
#line hidden
#line 2 "C:\Users\LENOVO\source\repos\ContactCenter\ContactCenter\Views\_ViewImports.cshtml"
using ContactCenter.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fba5fbeb483efbd2f99b6556145476051f4666b", @"/Views/Orders/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eddf4360dde8278ea559ad3171f66f8347ce36fe", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ContactCenter.Models.Orders>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(36, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\LENOVO\source\repos\ContactCenter\ContactCenter\Views\Orders\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(81, 129, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Orders</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(211, 45, false);
#line 14 "C:\Users\LENOVO\source\repos\ContactCenter\ContactCenter\Views\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OrderDate));

#line default
#line hidden
            EndContext();
            BeginContext(256, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(320, 41, false);
#line 17 "C:\Users\LENOVO\source\repos\ContactCenter\ContactCenter\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.OrderDate));

#line default
#line hidden
            EndContext();
            BeginContext(361, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(424, 48, false);
#line 20 "C:\Users\LENOVO\source\repos\ContactCenter\ContactCenter\Views\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RequiredDate));

#line default
#line hidden
            EndContext();
            BeginContext(472, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(536, 44, false);
#line 23 "C:\Users\LENOVO\source\repos\ContactCenter\ContactCenter\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.RequiredDate));

#line default
#line hidden
            EndContext();
            BeginContext(580, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(643, 47, false);
#line 26 "C:\Users\LENOVO\source\repos\ContactCenter\ContactCenter\Views\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ShippedDate));

#line default
#line hidden
            EndContext();
            BeginContext(690, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(754, 43, false);
#line 29 "C:\Users\LENOVO\source\repos\ContactCenter\ContactCenter\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.ShippedDate));

#line default
#line hidden
            EndContext();
            BeginContext(797, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(860, 43, false);
#line 32 "C:\Users\LENOVO\source\repos\ContactCenter\ContactCenter\Views\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Freight));

#line default
#line hidden
            EndContext();
            BeginContext(903, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(967, 39, false);
#line 35 "C:\Users\LENOVO\source\repos\ContactCenter\ContactCenter\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.Freight));

#line default
#line hidden
            EndContext();
            BeginContext(1006, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1069, 44, false);
#line 38 "C:\Users\LENOVO\source\repos\ContactCenter\ContactCenter\Views\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ShipName));

#line default
#line hidden
            EndContext();
            BeginContext(1113, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1177, 40, false);
#line 41 "C:\Users\LENOVO\source\repos\ContactCenter\ContactCenter\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.ShipName));

#line default
#line hidden
            EndContext();
            BeginContext(1217, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1280, 47, false);
#line 44 "C:\Users\LENOVO\source\repos\ContactCenter\ContactCenter\Views\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ShipAddress));

#line default
#line hidden
            EndContext();
            BeginContext(1327, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1391, 43, false);
#line 47 "C:\Users\LENOVO\source\repos\ContactCenter\ContactCenter\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.ShipAddress));

#line default
#line hidden
            EndContext();
            BeginContext(1434, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1497, 44, false);
#line 50 "C:\Users\LENOVO\source\repos\ContactCenter\ContactCenter\Views\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ShipCity));

#line default
#line hidden
            EndContext();
            BeginContext(1541, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1605, 40, false);
#line 53 "C:\Users\LENOVO\source\repos\ContactCenter\ContactCenter\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.ShipCity));

#line default
#line hidden
            EndContext();
            BeginContext(1645, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1708, 46, false);
#line 56 "C:\Users\LENOVO\source\repos\ContactCenter\ContactCenter\Views\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ShipRegion));

#line default
#line hidden
            EndContext();
            BeginContext(1754, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1818, 42, false);
#line 59 "C:\Users\LENOVO\source\repos\ContactCenter\ContactCenter\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.ShipRegion));

#line default
#line hidden
            EndContext();
            BeginContext(1860, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1923, 50, false);
#line 62 "C:\Users\LENOVO\source\repos\ContactCenter\ContactCenter\Views\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ShipPostalCode));

#line default
#line hidden
            EndContext();
            BeginContext(1973, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2037, 46, false);
#line 65 "C:\Users\LENOVO\source\repos\ContactCenter\ContactCenter\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.ShipPostalCode));

#line default
#line hidden
            EndContext();
            BeginContext(2083, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2146, 47, false);
#line 68 "C:\Users\LENOVO\source\repos\ContactCenter\ContactCenter\Views\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ShipCountry));

#line default
#line hidden
            EndContext();
            BeginContext(2193, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2257, 43, false);
#line 71 "C:\Users\LENOVO\source\repos\ContactCenter\ContactCenter\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.ShipCountry));

#line default
#line hidden
            EndContext();
            BeginContext(2300, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2363, 49, false);
#line 74 "C:\Users\LENOVO\source\repos\ContactCenter\ContactCenter\Views\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ConfirmStatus));

#line default
#line hidden
            EndContext();
            BeginContext(2412, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2476, 45, false);
#line 77 "C:\Users\LENOVO\source\repos\ContactCenter\ContactCenter\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.ConfirmStatus));

#line default
#line hidden
            EndContext();
            BeginContext(2521, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2584, 47, false);
#line 80 "C:\Users\LENOVO\source\repos\ContactCenter\ContactCenter\Views\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ConfirmDate));

#line default
#line hidden
            EndContext();
            BeginContext(2631, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2695, 43, false);
#line 83 "C:\Users\LENOVO\source\repos\ContactCenter\ContactCenter\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.ConfirmDate));

#line default
#line hidden
            EndContext();
            BeginContext(2738, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2801, 44, false);
#line 86 "C:\Users\LENOVO\source\repos\ContactCenter\ContactCenter\Views\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Comments));

#line default
#line hidden
            EndContext();
            BeginContext(2845, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2909, 40, false);
#line 89 "C:\Users\LENOVO\source\repos\ContactCenter\ContactCenter\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.Comments));

#line default
#line hidden
            EndContext();
            BeginContext(2949, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3012, 41, false);
#line 92 "C:\Users\LENOVO\source\repos\ContactCenter\ContactCenter\Views\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Total));

#line default
#line hidden
            EndContext();
            BeginContext(3053, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3117, 37, false);
#line 95 "C:\Users\LENOVO\source\repos\ContactCenter\ContactCenter\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.Total));

#line default
#line hidden
            EndContext();
            BeginContext(3154, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3217, 44, false);
#line 98 "C:\Users\LENOVO\source\repos\ContactCenter\ContactCenter\Views\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Customer));

#line default
#line hidden
            EndContext();
            BeginContext(3261, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3325, 51, false);
#line 101 "C:\Users\LENOVO\source\repos\ContactCenter\ContactCenter\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.Customer.CustomerId));

#line default
#line hidden
            EndContext();
            BeginContext(3376, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3439, 44, false);
#line 104 "C:\Users\LENOVO\source\repos\ContactCenter\ContactCenter\Views\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee));

#line default
#line hidden
            EndContext();
            BeginContext(3483, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3547, 50, false);
#line 107 "C:\Users\LENOVO\source\repos\ContactCenter\ContactCenter\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(3597, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3660, 53, false);
#line 110 "C:\Users\LENOVO\source\repos\ContactCenter\ContactCenter\Views\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ShipViaNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(3713, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3777, 61, false);
#line 113 "C:\Users\LENOVO\source\repos\ContactCenter\ContactCenter\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.ShipViaNavigation.CompanyName));

#line default
#line hidden
            EndContext();
            BeginContext(3838, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(3885, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8fba5fbeb483efbd2f99b6556145476051f4666b18929", async() => {
                BeginContext(3936, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 118 "C:\Users\LENOVO\source\repos\ContactCenter\ContactCenter\Views\Orders\Details.cshtml"
                           WriteLiteral(Model.OrderId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3944, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(3952, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8fba5fbeb483efbd2f99b6556145476051f4666b21262", async() => {
                BeginContext(3974, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3990, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContactCenter.Models.Orders> Html { get; private set; }
    }
}
#pragma warning restore 1591
