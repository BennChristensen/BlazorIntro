﻿using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorApp1.Pages
{
    public partial class FetchData
    {
        public FetchData()
        {

        }

        private WeatherForecast[] forecasts;
        [Inject]
        public HttpClient httpClient { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await Task.Delay(2000);
            forecasts = await httpClient.GetFromJsonAsync<WeatherForecast[]>("sample-data/weather.json");
        }

        public class WeatherForecast
        {
            public DateTime Date { get; set; }

            public int TemperatureC { get; set; }

            public string Summary { get; set; }

            public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
        }
    }
}
