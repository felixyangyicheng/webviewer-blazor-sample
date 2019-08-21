#pragma checksum "C:\Users\Yon\Documents\blazor-sample\blazor-webviewer-sample\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0852390ac7c8cd80f821b783b9118072f399b560"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorWebViewerServer.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\Yon\Documents\blazor-sample\blazor-webviewer-sample\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\Yon\Documents\blazor-sample\blazor-webviewer-sample\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 3 "C:\Users\Yon\Documents\blazor-sample\blazor-webviewer-sample\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 4 "C:\Users\Yon\Documents\blazor-sample\blazor-webviewer-sample\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 5 "C:\Users\Yon\Documents\blazor-sample\blazor-webviewer-sample\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\Users\Yon\Documents\blazor-sample\blazor-webviewer-sample\_Imports.razor"
using BlazorWebViewerServer;

#line default
#line hidden
#line 7 "C:\Users\Yon\Documents\blazor-sample\blazor-webviewer-sample\_Imports.razor"
using BlazorWebViewerServer.Shared;

#line default
#line hidden
#line 3 "C:\Users\Yon\Documents\blazor-sample\blazor-webviewer-sample\Pages\FetchData.razor"
using BlazorWebViewerServer.Data;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            builder.AddMarkupContent(0, "<h1>Weather forecast</h1>\r\n\r\n");
            builder.AddMarkupContent(1, "<p>This component demonstrates fetching data from a service.</p>\r\n\r\n");
#line 10 "C:\Users\Yon\Documents\blazor-sample\blazor-webviewer-sample\Pages\FetchData.razor"
 if (forecasts == null)
{

#line default
#line hidden
            builder.AddContent(2, "    ");
            builder.AddMarkupContent(3, "<p><em>Loading...</em></p>\r\n");
#line 13 "C:\Users\Yon\Documents\blazor-sample\blazor-webviewer-sample\Pages\FetchData.razor"
}
else
{

#line default
#line hidden
            builder.AddContent(4, "    ");
            builder.OpenElement(5, "table");
            builder.AddAttribute(6, "class", "table");
            builder.AddMarkupContent(7, "\r\n        ");
            builder.AddMarkupContent(8, "<thead>\r\n            <tr>\r\n                <th>Date</th>\r\n                <th>Temp. (C)</th>\r\n                <th>Temp. (F)</th>\r\n                <th>Summary</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            builder.OpenElement(9, "tbody");
            builder.AddMarkupContent(10, "\r\n");
#line 26 "C:\Users\Yon\Documents\blazor-sample\blazor-webviewer-sample\Pages\FetchData.razor"
             foreach (var forecast in forecasts)
            {

#line default
#line hidden
            builder.AddContent(11, "                ");
            builder.OpenElement(12, "tr");
            builder.AddMarkupContent(13, "\r\n                    ");
            builder.OpenElement(14, "td");
            builder.AddContent(15, 
#line 29 "C:\Users\Yon\Documents\blazor-sample\blazor-webviewer-sample\Pages\FetchData.razor"
                         forecast.Date.ToShortDateString()

#line default
#line hidden
            );
            builder.CloseElement();
            builder.AddMarkupContent(16, "\r\n                    ");
            builder.OpenElement(17, "td");
            builder.AddContent(18, 
#line 30 "C:\Users\Yon\Documents\blazor-sample\blazor-webviewer-sample\Pages\FetchData.razor"
                         forecast.TemperatureC

#line default
#line hidden
            );
            builder.CloseElement();
            builder.AddMarkupContent(19, "\r\n                    ");
            builder.OpenElement(20, "td");
            builder.AddContent(21, 
#line 31 "C:\Users\Yon\Documents\blazor-sample\blazor-webviewer-sample\Pages\FetchData.razor"
                         forecast.TemperatureF

#line default
#line hidden
            );
            builder.CloseElement();
            builder.AddMarkupContent(22, "\r\n                    ");
            builder.OpenElement(23, "td");
            builder.AddContent(24, 
#line 32 "C:\Users\Yon\Documents\blazor-sample\blazor-webviewer-sample\Pages\FetchData.razor"
                         forecast.Summary

#line default
#line hidden
            );
            builder.CloseElement();
            builder.AddMarkupContent(25, "\r\n                ");
            builder.CloseElement();
            builder.AddMarkupContent(26, "\r\n");
#line 34 "C:\Users\Yon\Documents\blazor-sample\blazor-webviewer-sample\Pages\FetchData.razor"
            }

#line default
#line hidden
            builder.AddContent(27, "        ");
            builder.CloseElement();
            builder.AddMarkupContent(28, "\r\n    ");
            builder.CloseElement();
            builder.AddMarkupContent(29, "\r\n");
#line 37 "C:\Users\Yon\Documents\blazor-sample\blazor-webviewer-sample\Pages\FetchData.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 39 "C:\Users\Yon\Documents\blazor-sample\blazor-webviewer-sample\Pages\FetchData.razor"
       
    WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherForecastService ForecastService { get; set; }
    }
}
#pragma warning restore 1591
