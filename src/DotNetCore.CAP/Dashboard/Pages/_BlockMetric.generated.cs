﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DotNetCore.CAP.Dashboard.Pages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    #line 2 "..\..\Dashboard\Pages\_BlockMetric.cshtml"
    using DotNetCore.CAP.Dashboard;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Dashboard\Pages\_BlockMetric.cshtml"
    using DotNetCore.CAP.Dashboard.Resources;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    internal partial class BlockMetric : RazorPage
    {
#line hidden

        protected override void Execute()
        {


WriteLiteral("\r\n");





            
            #line 5 "..\..\Dashboard\Pages\_BlockMetric.cshtml"
  
    var metric = DashboardMetric.Func(this);
    var className = metric == null ? "metric-null" : metric.Style.ToClassName();
    var highlighted = metric != null && metric.Highlighted ? "highlighted" : null;


            
            #line default
            #line hidden
WriteLiteral("<div class=\"metric ");


            
            #line 10 "..\..\Dashboard\Pages\_BlockMetric.cshtml"
              Write(className);

            
            #line default
            #line hidden
WriteLiteral(" ");


            
            #line 10 "..\..\Dashboard\Pages\_BlockMetric.cshtml"
                         Write(highlighted);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n    <div class=\"metric-body\" data-metric=\"");


            
            #line 11 "..\..\Dashboard\Pages\_BlockMetric.cshtml"
                                     Write(DashboardMetric.Name);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n        ");


            
            #line 12 "..\..\Dashboard\Pages\_BlockMetric.cshtml"
    Write(metric?.Value);

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n    <div class=\"metric-description\">\r\n        ");


            
            #line 15 "..\..\Dashboard\Pages\_BlockMetric.cshtml"
    Write(Strings.ResourceManager.GetString(DashboardMetric.Title) ?? DashboardMetric.Title);

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n</div>");


        }
    }
}
#pragma warning restore 1591
